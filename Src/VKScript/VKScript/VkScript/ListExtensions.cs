using System;
using System.Collections.Generic;

namespace VKScript.VkScript
{
    public static class ListExtensions
    {
        public static Value ByKey(this List<Tuple<string, Value>> obj, string key)
        {
            for (var i = 0; i < obj.Count; ++i)
            {
                if (obj[i] != null && obj[i].Item1 == key) return obj[i].Item2;
            }
            return null;
        }

        public static bool Has(this List<Tuple<string, Value>> obj, string key)
        {
            for (var i = 0; i < obj.Count; ++i)
            {
                if (obj[i] != null && obj[i].Item1 == key) return true;
            }
            return false;
        }
    }
}