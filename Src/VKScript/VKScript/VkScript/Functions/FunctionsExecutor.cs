using System.Collections.Generic;

namespace VKScript.VkScript.Functions
{
    public static class FunctionsExecutor
    {
        public static Value Exec(Value obj, string func, List<Value> args)
        {
            if (obj == null) return GlobalFunctions.Exec(func, args);
            if (obj.IsList) return ListFunctions.Exec(obj.AsList, func, args);
            if (obj.IsPair) return PairFunctions.Exec(obj.AsPair, func, args);
            return null;
        }
    }
}