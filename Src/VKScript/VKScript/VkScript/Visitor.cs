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

        public override Value VisitList(VKScriptParser.ListContext context)
        {
            var list = context.expr().Select(Visit).ToList();
            return new Value(list);
        }

        public override Value VisitOutput(VKScriptParser.OutputContext context)
        {
            var v = Visit(context.expr());
            if (_interactive && v != null) Console.WriteLine(v.AsString);
            return null;
        }

        #region FUNCTIONS

        public override Value VisitOneFunc(VKScriptParser.OneFuncContext context)
        {
            var l = context.list() == null ? new List<Value>() : Visit(context.list()).AsList;
            if (context.literal() != null)
            {
                return FunctionsExecutor.Exec(Visit(context.literal()), context.ID(0).GetText(), l);
            }
            if (context.ID().Length == 2)
            {
                return FunctionsExecutor.Exec(_memory[context.ID(0).GetText()], context.ID(1).GetText(), l);
            }
            if (context.ID().Length == 1)
            {
                return FunctionsExecutor.Exec(null, context.ID(0).GetText(), l);
            }
            return null;
        }

        public override Value VisitChainedFunc(VKScriptParser.ChainedFuncContext context)
        {
            var ctx = (VKScriptParser.OneFuncContext) context.function_call(1);
            var l = ctx.list() == null ? new List<Value>() : Visit(ctx.list()).AsList;
            return FunctionsExecutor.Exec(Visit(context.function_call(0)), ctx.ID(0).GetText(), l);
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

        public override Value VisitExprFuncCall(VKScriptParser.ExprFuncCallContext context)
        {
            return Visit(context.function_call());
        }

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

        public override Value VisitExprOperatorLargerThen(VKScriptParser.ExprOperatorLargerThenContext context)
        {
            return context.Eval(Visit(context.expr(0)), Visit(context.expr(1)));
        }

        public override Value VisitExprOperatorLargerEqThen(VKScriptParser.ExprOperatorLargerEqThenContext context)
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