using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace VKScript.VkScript.Functions
{
    internal static class VkGlobalFunctions
    {
        private static VkApi _vk = new VkApi();

        public static Value Exec(string func, List<Value> args)
        {
            var funcs = new Dictionary<string, Func<List<Value>, Value>>
            {
                {"login", Login},
                {"logout", Logout}
            };
            if (funcs.ContainsKey(func)) return funcs[func](args);
            return Send(func, args);
        }

        private static int FirstUpper(string s)
        {
            for (var i = 0; i < s.Length; ++i)
            {
                if (char.IsUpper(s[i])) return i;
            }
            return -1;
        }

        private static Value SendVkRequest(string method, List<Tuple<string, Value>> args)
        {
            var p = args.Aggregate("",
                (s, tuple) => s + (s.Length == 0 ? "" : "&") + tuple.Item1 + "=" + tuple.Item2.AsString);
            var res = _vk.ExecuteMethodGET(method, p);
            return JsonToValue(res);
        }

        private static Value JsonToValue(JToken o)
        {
            if (o == null) return null;
            if (o is JArray)
            {
                return new Value(((JArray) o).Select(JsonToValue).ToList());
            }
            if (o is JObject)
            {
                var oo = (JObject) o;
                var list = new List<Value>();
                foreach (var pair in oo)
                {
                    list.Add(new Value(new Tuple<string, Value>(pair.Key, JsonToValue(pair.Value))));
                }
                return new Value(list);
            }
            var s = o.ToString();
            int i;
            if (int.TryParse(s, out i))
            {
                return new Value(i);
            }
            return new Value(s);
        }

        private static Value Send(string m, List<Value> args)
        {
            var argsCopy = args.ConvertAll(input => input.IsPair ? input.AsPair : null);
            var pos = FirstUpper(m);
            var s = m;
            if (pos != -1) s = m.Insert(pos, ".").ToLower();
            return SendVkRequest(s, argsCopy);
        }

        private static Value Login(List<Value> args)
        {
            var argsCopy = args.ConvertAll(input => input.IsPair ? input.AsPair : null);
            var res = _vk.Login(argsCopy.ByKey("user").AsString, argsCopy.ByKey("pswd").AsString);
            return new Value(res ? "success" : "failed");
        }

        private static Value Logout(List<Value> args)
        {
            _vk = new VkApi();
            return null;
        }
    }
}