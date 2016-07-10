using System;
using System.Collections.Generic;
using System.Linq;
using VKScript.VkScript.Functions;

namespace VKScript.VkScript
{
    public class Visitor : VKScriptBaseVisitor<Value>
    {
        private readonly bool _interactive;
        private readonly Memory _memory = new Memory();

        public Visitor(bool interactive)
        {
            _interactive = interactive;
        }

        public override Value VisitAssign(VKScriptParser.AssignContext context)
        {
            var id = context.ID().GetText();
            var v = Visit(context.expr());
            _memory[id] = v;
            return null;
        }

        public override Value VisitPrimitive(VKScriptParser.PrimitiveContext context)
        {
            if (context.BOOL() != null)
            {
                var b = context.GetText() == "true";
                return new Value(b);
            }
            if (context.INT() != null)
            {
                var i = int.Parse(context.GetText());
                return new Value(i);
            }
            if (context.STRING() != null)
            {
                var s = context.GetText();
                s = s.Substring(1, s.Length - 2);
                return new Value(s);
            }
            return null;
        }

        public override Value VisitPair(VKScriptParser.PairContext context)
        {
            return new Value(new Tuple<string, Value>(context.ID().GetText(), Visit(context.expr())));
        }

        public override Value VisitList_content(VKScriptParser.List_contentContext context)
        {
            var list = context.expr().Select(Visit).ToList();
            return new Value(list);
        }

        public override Value VisitList(VKScriptParser.ListContext context)
        {
            if (context.list_content() == null) return new Value(new List<Value>());
            return Visit(context.list_content());
        }

        public override Value VisitOutput(VKScriptParser.OutputContext context)
        {
            var v = Visit(context.expr());
            if (_interactive && v != null) Console.WriteLine(v.AsString);
            return null;
        }

        #region FUNCTIONS

        public override Value VisitExprMethodCall(VKScriptParser.ExprMethodCallContext context)
        {
            var args = context.list_content() == null ? new List<Value>() : Visit(context.list_content()).AsList;
            var methodName = context.ID().GetText();
            var calledOn = Visit(context.expr());
            return FunctionsExecutor.Exec(calledOn, methodName, args);
        }

        public override Value VisitExprFuncCall(VKScriptParser.ExprFuncCallContext context)
        {
            var args = context.list_content() == null ? new List<Value>() : Visit(context.list_content()).AsList;
            var methodName = context.ID().GetText();
            return FunctionsExecutor.Exec(null, methodName, args);
        }

        #endregion

        #region IF, WHILE

        public override Value VisitIf_else_statement(VKScriptParser.If_else_statementContext context)
        {
            var v = Visit(context.expr());
            if (v.IsBool)
            {
                if (v.AsBool)
                {
                    return Visit(context.vk_script(0));
                }
                if (context.vk_script().Length == 2)
                {
                    return Visit(context.vk_script(1));
                }
            }
            return null;
        }

        public override Value VisitWhile_statement(VKScriptParser.While_statementContext context)
        {
            Value v = null;
            while ((v = Visit(context.expr())).IsBool && v.AsBool)
            {
                Visit(context.vk_script());
            }

            return null;
        }

        #endregion

        #region EXPR

        public override Value VisitExprId(VKScriptParser.ExprIdContext context)
        {
            return _memory[context.GetText()];
        }

        public override Value VisitExprOperatorAnd(VKScriptParser.ExprOperatorAndContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorOr(VKScriptParser.ExprOperatorOrContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorEq(VKScriptParser.ExprOperatorEqContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorNotEq(VKScriptParser.ExprOperatorNotEqContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorLessThen(VKScriptParser.ExprOperatorLessThenContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorLessEqThen(VKScriptParser.ExprOperatorLessEqThenContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorGreaterThen(VKScriptParser.ExprOperatorGreaterThenContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorGreaterEqThen(VKScriptParser.ExprOperatorGreaterEqThenContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorMod(VKScriptParser.ExprOperatorModContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorMul(VKScriptParser.ExprOperatorMulContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorDiv(VKScriptParser.ExprOperatorDivContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorPlus(VKScriptParser.ExprOperatorPlusContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorMinus(VKScriptParser.ExprOperatorMinusContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprBrackets(VKScriptParser.ExprBracketsContext context)
        {
            return Visit(context.expr());
        }

        #endregion
    }
}