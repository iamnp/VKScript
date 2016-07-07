//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from VKScript.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="VKScriptParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IVKScriptVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.vk_script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVk_script([NotNull] VKScriptParser.Vk_scriptContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>oneFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOneFunc([NotNull] VKScriptParser.OneFuncContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>chainedFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChainedFunc([NotNull] VKScriptParser.ChainedFuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] VKScriptParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList([NotNull] VKScriptParser.ListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPair([NotNull] VKScriptParser.PairContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorLargerThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorLargerThen([NotNull] VKScriptParser.ExprOperatorLargerThenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprPair</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprPair([NotNull] VKScriptParser.ExprPairContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprBrackets</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprBrackets([NotNull] VKScriptParser.ExprBracketsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorLargerEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorLargerEqThen([NotNull] VKScriptParser.ExprOperatorLargerEqThenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorPlus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorPlus([NotNull] VKScriptParser.ExprOperatorPlusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorDiv</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorDiv([NotNull] VKScriptParser.ExprOperatorDivContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorMinus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorMinus([NotNull] VKScriptParser.ExprOperatorMinusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorNotEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorNotEq([NotNull] VKScriptParser.ExprOperatorNotEqContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprLiteral</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprLiteral([NotNull] VKScriptParser.ExprLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorOr</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorOr([NotNull] VKScriptParser.ExprOperatorOrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprFuncCall</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprFuncCall([NotNull] VKScriptParser.ExprFuncCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorAnd</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorAnd([NotNull] VKScriptParser.ExprOperatorAndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorEq([NotNull] VKScriptParser.ExprOperatorEqContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprId([NotNull] VKScriptParser.ExprIdContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorMod</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorMod([NotNull] VKScriptParser.ExprOperatorModContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorLessThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorLessThen([NotNull] VKScriptParser.ExprOperatorLessThenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorLessEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorLessEqThen([NotNull] VKScriptParser.ExprOperatorLessEqThenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprOperatorMul</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprOperatorMul([NotNull] VKScriptParser.ExprOperatorMulContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.primitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimitive([NotNull] VKScriptParser.PrimitiveContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.assign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssign([NotNull] VKScriptParser.AssignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.if_else_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_else_statement([NotNull] VKScriptParser.If_else_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhile_statement([NotNull] VKScriptParser.While_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] VKScriptParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="VKScriptParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutput([NotNull] VKScriptParser.OutputContext context);
}