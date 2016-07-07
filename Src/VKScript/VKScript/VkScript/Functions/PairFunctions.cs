using System;
using System.Collections.Generic;

namespace VKScript.VkScript.Functions
{
    internal static class PairFunctions
    {
        public static Value Exec(Tuple<string, Value> obj, string func, List<Value> args)
        {
            var funcs = new Dictionary<string, Func<Tuple<string, Value>, List<Value>, Value>>
            {
                {"key", Key},
                {"value", Value}
            };
            if (funcs.ContainsKey(func)) return funcs[func](obj, args);
            return null;
        }

        private static Value Key(Tuple<string, Value> pair, List<Value> args)
        {
            return new Value(pair.Item1);
        }

        private static Value Value(Tuple<string, Value> pair, List<Value> args)
        {
            return new Value(pair.Item2.Data);
        }
    }
}