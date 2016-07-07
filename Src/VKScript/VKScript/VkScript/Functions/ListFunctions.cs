using System;
using System.Collections.Generic;
using System.Linq;

namespace VKScript.VkScript.Functions
{
    internal static class ListFunctions
    {
        public static Value Exec(List<Value> obj, string func, List<Value> args)
        {
            var funcs = new Dictionary<string, Func<List<Value>, List<Value>, Value>>
            {
                {"first", First},
                {"last", Last},
                {"at", At},
                {"remove", Remove},
                {"take", Take},
                {"append", Append},
                {"byKey", ByKey}
            };
            if (funcs.ContainsKey(func)) return funcs[func](obj, args);
            return null;
        }

        private static Value First(List<Value> list, List<Value> args)
        {
            return new Value(list.First().Data);
        }

        private static Value Last(List<Value> list, List<Value> args)
        {
            return new Value(list.Last().Data);
        }

        private static Value At(List<Value> list, List<Value> args)
        {
            var argsCopy = args.ConvertAll(input => input.IsPair ? input.AsPair : null);
            return new Value(list[argsCopy.ByKey("pos").AsInt].Data);
        }

        private static Value Remove(List<Value> list, List<Value> args)
        {
            var argsCopy = args.ConvertAll(input => input.IsPair ? input.AsPair : null);
            var c = new List<Value>(list);
            c.RemoveAt(argsCopy.ByKey("pos").AsInt);
            return new Value(c);
        }

        private static Value Append(List<Value> list, List<Value> args)
        {
            var c = new List<Value>(list);
            c.AddRange(args);
            return new Value(c);
        }

        private static Value Take(List<Value> list, List<Value> args)
        {
            var argsCopy = args.ConvertAll(input => input.IsPair ? input.AsPair : null);
            var count = argsCopy.ByKey("count").AsInt;
            var from = 0;
            if (argsCopy.Has("from")) from = argsCopy.ByKey("from").AsInt;
            return new Value(list.Skip(from).Take(count).ToList());
        }

        private static Value ByKey(List<Value> list, List<Value> args)
        {
            var listCopy = list.ConvertAll(input => input.IsPair ? input.AsPair : null);
            return listCopy.ByKey(args[0].AsString);
        }
    }
}