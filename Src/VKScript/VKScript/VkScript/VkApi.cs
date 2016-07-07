using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json.Linq;

namespace VKScript.VkScript
{
    internal class VkApi
    {
        // vk api client_id and client_secret reverse engineered from VK for Windows metro app
        private const string ClientId = "3697615";
        private const string ClientSecret = "AlVXZFMUqyrnABp8ncuU";
        private string _accessToken;
        private bool _loggedIn;
        private string _secret;
        private string _userId;

        public bool Login(string username, string password)
        {
            var scope = "nohttps,offline,friends,messages";
            var text = SendGetRequest(
                "https://api.vk.com/oauth/token?grant_type=password&client_id=" + ClientId + "&client_secret=" +
                ClientSecret + "&scope=" + scope + "&username=" + username + "&password=" + password);
            try
            {
                var o = JObject.Parse(text);
                if (o["access_token"] != null)
                {
                    _accessToken = o["access_token"].ToString();
                    _userId = o["user_id"].ToString();
                    _secret = o["secret"].ToString();
                    _loggedIn = true;

                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        public JObject ExecuteMethodGET(string method, string args)
        {
            return JObject.Parse(SendGetRequest(Format(method, args)));
        }

        private string SendGetRequest(string url)
        {
            var text = "";
            try
            {
                var req = (HttpWebRequest) WebRequest.Create(url);
                var resp = req.GetResponse();

                var str = resp.GetResponseStream();
                if (str != null)
                {
                    using (var reader = new StreamReader(str, Encoding.UTF8))
                    {
                        text = reader.ReadToEnd();
                    }
                }

                return text;
            }
            catch
            {
                return "";
            }
        }

        private string Format(string method, string param)
        {
            if (string.IsNullOrEmpty(param))
            {
                return string.Format("http://api.vk.com/method/{0}?access_token={1}&sig={2}", method, _accessToken,
                    Md5(string.Format("/method/{0}?access_token={1}{2}", method, _accessToken, _secret)));
            }
            return string.Format("http://api.vk.com/method/{0}?{1}&access_token={2}&sig={3}", method, param,
                _accessToken,
                Md5(string.Format("/method/{0}?{1}&access_token={2}{3}", method, param, _accessToken, _secret)));
        }

        private static string Md5(string input)
        {
            MD5 md5Hasher = new MD5CryptoServiceProvider();
            var data = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (var i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}