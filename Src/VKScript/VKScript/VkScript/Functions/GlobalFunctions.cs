using System;
using System.Collections.Generic;
using System.Threading;

namespace VKScript.VkScript.Functions
{
    internal static class GlobalFunctions
    {
        public static Value Exec(string func, List<Value> args)
        {
            var funcs = new Dictionary<string, Func<List<Value>, Value>>
            {
                {"print", Print},
                {"int", Int},
                {"sleep", Sleep}
            };
            if (funcs.ContainsKey(func)) return funcs[func](args);
            return VkGlobalFunctions.Exec(func, args);
        }

        private static Value Print(List<Value> args)
        {
            if (args.Count > 0 && args[0] != null) Console.WriteLine(args[0].AsString);
            return null;
        }

        private static Value Int(List<Value> args)
        {
            return new Value(int.Parse(args[0].AsString));
        }

        //vk api limits number of requests per second
        private static Value Sleep(List<Value> args)
        {
            Thread.Sleep(args[0].AsInt);
            return null;
        }
    }
}