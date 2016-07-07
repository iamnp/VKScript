using System;
using System.IO;
using VKScript.VkScript;

namespace VKScript
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string script = null;
                try
                {
                    script = File.ReadAllText(args[0]);
                }
                catch
                {
                }
                if (script != null) VkScript.VkScript.RunVkScript(script);
            }
            else
            {
                var vkRunner = new VkScript.VkScript(new Visitor(true));
                while (true)
                {
                    Console.Write(">>> ");
                    vkRunner.Exec(Console.ReadLine());
                }
            }
        }
    }
}