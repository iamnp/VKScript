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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IVKScriptListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class VKScriptBaseListener : IVKScriptListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.vk_script"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVk_script([NotNull] VKScriptParser.Vk_scriptContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.vk_script"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVk_script([NotNull] VKScriptParser.Vk_scriptContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>oneFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOneFunc([NotNull] VKScriptParser.OneFuncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>oneFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOneFunc([NotNull] VKScriptParser.OneFuncContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>chainedFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChainedFunc([NotNull] VKScriptParser.ChainedFuncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>chainedFunc</c>
	/// labeled alternative in <see cref="VKScriptParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChainedFunc([NotNull] VKScriptParser.ChainedFuncContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] VKScriptParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] VKScriptParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterList([NotNull] VKScriptParser.ListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitList([NotNull] VKScriptParser.ListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.pair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPair([NotNull] VKScriptParser.PairContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.pair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPair([NotNull] VKScriptParser.PairContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprPair</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprPair([NotNull] VKScriptParser.ExprPairContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprPair</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprPair([NotNull] VKScriptParser.ExprPairContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprBrackets</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprBrackets([NotNull] VKScriptParser.ExprBracketsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprBrackets</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprBrackets([NotNull] VKScriptParser.ExprBracketsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorGreaterThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorGreaterThen([NotNull] VKScriptParser.ExprOperatorGreaterThenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorGreaterThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorGreaterThen([NotNull] VKScriptParser.ExprOperatorGreaterThenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorPlus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorPlus([NotNull] VKScriptParser.ExprOperatorPlusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorPlus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorPlus([NotNull] VKScriptParser.ExprOperatorPlusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorDiv</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorDiv([NotNull] VKScriptParser.ExprOperatorDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorDiv</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorDiv([NotNull] VKScriptParser.ExprOperatorDivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorMinus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorMinus([NotNull] VKScriptParser.ExprOperatorMinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorMinus</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorMinus([NotNull] VKScriptParser.ExprOperatorMinusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorNotEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorNotEq([NotNull] VKScriptParser.ExprOperatorNotEqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorNotEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorNotEq([NotNull] VKScriptParser.ExprOperatorNotEqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprLiteral</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprLiteral([NotNull] VKScriptParser.ExprLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprLiteral</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprLiteral([NotNull] VKScriptParser.ExprLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorOr</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorOr([NotNull] VKScriptParser.ExprOperatorOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorOr</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorOr([NotNull] VKScriptParser.ExprOperatorOrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprFuncCall</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprFuncCall([NotNull] VKScriptParser.ExprFuncCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprFuncCall</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprFuncCall([NotNull] VKScriptParser.ExprFuncCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorAnd</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorAnd([NotNull] VKScriptParser.ExprOperatorAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorAnd</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorAnd([NotNull] VKScriptParser.ExprOperatorAndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorEq([NotNull] VKScriptParser.ExprOperatorEqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorEq</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorEq([NotNull] VKScriptParser.ExprOperatorEqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprId([NotNull] VKScriptParser.ExprIdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprId([NotNull] VKScriptParser.ExprIdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorMod</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorMod([NotNull] VKScriptParser.ExprOperatorModContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorMod</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorMod([NotNull] VKScriptParser.ExprOperatorModContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorLessThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorLessThen([NotNull] VKScriptParser.ExprOperatorLessThenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorLessThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorLessThen([NotNull] VKScriptParser.ExprOperatorLessThenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorLessEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorLessEqThen([NotNull] VKScriptParser.ExprOperatorLessEqThenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorLessEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorLessEqThen([NotNull] VKScriptParser.ExprOperatorLessEqThenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorMul</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorMul([NotNull] VKScriptParser.ExprOperatorMulContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorMul</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorMul([NotNull] VKScriptParser.ExprOperatorMulContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOperatorGreaterEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOperatorGreaterEqThen([NotNull] VKScriptParser.ExprOperatorGreaterEqThenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOperatorGreaterEqThen</c>
	/// labeled alternative in <see cref="VKScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOperatorGreaterEqThen([NotNull] VKScriptParser.ExprOperatorGreaterEqThenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.primitive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimitive([NotNull] VKScriptParser.PrimitiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.primitive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimitive([NotNull] VKScriptParser.PrimitiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.assign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssign([NotNull] VKScriptParser.AssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.assign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssign([NotNull] VKScriptParser.AssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.if_else_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_else_statement([NotNull] VKScriptParser.If_else_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.if_else_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_else_statement([NotNull] VKScriptParser.If_else_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile_statement([NotNull] VKScriptParser.While_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile_statement([NotNull] VKScriptParser.While_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] VKScriptParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] VKScriptParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VKScriptParser.output"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOutput([NotNull] VKScriptParser.OutputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VKScriptParser.output"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOutput([NotNull] VKScriptParser.OutputContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
