namespace VKScript.VkScript
{
    public static class OperatorExtensions
    {
        public static Value Eval(this VKScriptParser.ExprOperatorAndContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsBool && b.IsBool)
                return new Value(a.AsBool && b.AsBool);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorOrContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsBool && b.IsBool)
                return new Value(a.AsBool || b.AsBool);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorEqContext op, Value aa, Value bb)
        {
            if (aa == null || bb == null) return new Value(false);
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsString && !b.IsString)
                b = new Value(b.AsString);
            if (b.IsString && !a.IsString)
                a = new Value(a.AsString);

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt == b.AsInt);

            if (a.IsString && b.IsString)
                return new Value(a.AsString == b.AsString);

            if (a.IsBool && b.IsBool)
                return new Value(a.AsBool == b.AsBool);
            return new Value(false);
        }

        public static Value Eval(this VKScriptParser.ExprOperatorNotEqContext op, Value aa, Value bb)
        {
            if (aa == null || bb == null) return new Value(true);
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsString && !b.IsString)
                b = new Value(b.AsString);
            if (b.IsString && !a.IsString)
                a = new Value(a.AsString);

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt != b.AsInt);

            if (a.IsString && b.IsString)
                return new Value(a.AsString != b.AsString);

            if (a.IsBool && b.IsBool)
                return new Value(a.AsBool != b.AsBool);
            return new Value(true);
        }

        public static Value Eval(this VKScriptParser.ExprOperatorLessThenContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt < b.AsInt);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorLessEqThenContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt <= b.AsInt);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorGreaterThenContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt > b.AsInt);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorGreaterEqThenContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt >= b.AsInt);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorModContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt%b.AsInt);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorMulContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt*b.AsInt);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorDivContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt/b.AsInt);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorPlusContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsString && !b.IsString)
                b = new Value(b.AsString);
            if (b.IsString && !a.IsString)
                a = new Value(a.AsString);

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt + b.AsInt);

            if (a.IsString && b.IsString)
                return new Value(a.AsString + b.AsString);
            return null;
        }

        public static Value Eval(this VKScriptParser.ExprOperatorMinusContext op, Value aa, Value bb)
        {
            var a = aa.Copy();
            var b = bb.Copy();

            if (a.IsInt && b.IsInt)
                return new Value(a.AsInt - b.AsInt);
            return null;
        }
    }
}