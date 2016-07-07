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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="VKScriptParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IVKScriptListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.vk_script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVk_script([NotNull] VKScriptParser.Vk_scriptContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.vk_script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVk_script([NotNull] VKScriptParser.Vk_scriptContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>oneFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOneFunc([NotNull] VKScriptParser.OneFuncContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>oneFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOneFunc([NotNull] VKScriptParser.OneFuncContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>chainedFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChainedFunc([NotNull] VKScriptParser.ChainedFuncContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>chainedFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChainedFunc([NotNull] VKScriptParser.ChainedFuncContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] VKScriptParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] VKScriptParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList([NotNull] VKScriptParser.ListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList([NotNull] VKScriptParser.ListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPair([NotNull] VKScriptParser.PairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPair([NotNull] VKScriptParser.PairContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorLargerThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorLargerThen([NotNull] VKScriptParser.ExprOperatorLargerThenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorLargerThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorLargerThen([NotNull] VKScriptParser.ExprOperatorLargerThenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprPair</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprPair([NotNull] VKScriptParser.ExprPairContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprPair</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprPair([NotNull] VKScriptParser.ExprPairContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprBrackets</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprBrackets([NotNull] VKScriptParser.ExprBracketsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprBrackets</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprBrackets([NotNull] VKScriptParser.ExprBracketsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorLargerEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorLargerEqThen([NotNull] VKScriptParser.ExprOperatorLargerEqThenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorLargerEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorLargerEqThen([NotNull] VKScriptParser.ExprOperatorLargerEqThenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorPlus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorPlus([NotNull] VKScriptParser.ExprOperatorPlusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorPlus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorPlus([NotNull] VKScriptParser.ExprOperatorPlusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorDiv</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorDiv([NotNull] VKScriptParser.ExprOperatorDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorDiv</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorDiv([NotNull] VKScriptParser.ExprOperatorDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorMinus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorMinus([NotNull] VKScriptParser.ExprOperatorMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorMinus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorMinus([NotNull] VKScriptParser.ExprOperatorMinusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorNotEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorNotEq([NotNull] VKScriptParser.ExprOperatorNotEqContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorNotEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorNotEq([NotNull] VKScriptParser.ExprOperatorNotEqContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprLiteral</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprLiteral([NotNull] VKScriptParser.ExprLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprLiteral</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprLiteral([NotNull] VKScriptParser.ExprLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorOr</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorOr([NotNull] VKScriptParser.ExprOperatorOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorOr</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorOr([NotNull] VKScriptParser.ExprOperatorOrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprFuncCall</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprFuncCall([NotNull] VKScriptParser.ExprFuncCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprFuncCall</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprFuncCall([NotNull] VKScriptParser.ExprFuncCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorAnd</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorAnd([NotNull] VKScriptParser.ExprOperatorAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorAnd</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorAnd([NotNull] VKScriptParser.ExprOperatorAndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorEq([NotNull] VKScriptParser.ExprOperatorEqContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorEq([NotNull] VKScriptParser.ExprOperatorEqContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprId([NotNull] VKScriptParser.ExprIdContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprId([NotNull] VKScriptParser.ExprIdContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorMod</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorMod([NotNull] VKScriptParser.ExprOperatorModContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorMod</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorMod([NotNull] VKScriptParser.ExprOperatorModContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorLessThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorLessThen([NotNull] VKScriptParser.ExprOperatorLessThenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorLessThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorLessThen([NotNull] VKScriptParser.ExprOperatorLessThenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorLessEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorLessEqThen([NotNull] VKScriptParser.ExprOperatorLessEqThenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorLessEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorLessEqThen([NotNull] VKScriptParser.ExprOperatorLessEqThenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorMul</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOperatorMul([NotNull] VKScriptParser.ExprOperatorMulContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorMul</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOperatorMul([NotNull] VKScriptParser.ExprOperatorMulContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.primitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitive([NotNull] VKScriptParser.PrimitiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.primitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitive([NotNull] VKScriptParser.PrimitiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.assign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign([NotNull] VKScriptParser.AssignContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.assign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign([NotNull] VKScriptParser.AssignContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.if_else_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_else_statement([NotNull] VKScriptParser.If_else_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.if_else_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_else_statement([NotNull] VKScriptParser.If_else_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile_statement([NotNull] VKScriptParser.While_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile_statement([NotNull] VKScriptParser.While_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] VKScriptParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] VKScriptParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutput([NotNull] VKScriptParser.OutputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutput([NotNull] VKScriptParser.OutputContext context);
}
