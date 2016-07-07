using System;
using System.Collections.Generic;

namespace VKScript.VkScript
{
    public class Value
    {
        public object Data;

        public Value(object data)
        {
            Data = data;
        }

        public bool IsInt
        {
            get { return Data is int; }
        }

        public bool IsString
        {
            get { return Data is string; }
        }

        public bool IsBool
        {
            get { return Data is bool; }
        }

        public bool IsPair
        {
            get { return Data is Tuple<string, Value>; }
        }

        public bool IsList
        {
            get { return Data is List<Value>; }
        }

        public bool IsNull
        {
            get { return Data == null; }
        }

        public int AsInt
        {
            get { return (int) Data; }
        }

        public string AsString
        {
            get { return CurrentValueToString(); }
        }

        public bool AsBool
        {
            get { return (bool) Data; }
        }

        public Tuple<string, Value> AsPair
        {
            get { return (Tuple<string, Value>) Data; }
        }

        public List<Value> AsList
        {
            get { return (List<Value>) Data; }
        }

        public Value Copy()
        {
            return new Value(Data);
        }

        private string CurrentValueToString()
        {
            if (Data == null) return "null";
            if (IsList) return ListToString(AsList);
            if (IsPair) return TupleToString(AsPair);
            return Data.ToString();
        }

        private string TupleToString(Tuple<string, Value> t)
        {
            return t.Item1 + " : " + t.Item2.AsString;
        }

        private string ListToString(List<Value> l)
        {
            var s = "{";
            for (var i = 0; i < l.Count; ++i)
            {
                if (l[i] == null) s += "null";
                else if (l[i].IsList) s += ListToString(l[i].AsList);
                else if (l[i].IsPair) s += TupleToString(l[i].AsPair);
                else s += l[i].Data.ToString();
                if (i != l.Count - 1) s += ", ";
            }
            return s + "}";
        }
    }
}