//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Skell.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Generated {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SkellParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
public interface ISkellVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] SkellParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] SkellParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatementBlock([NotNull] SkellParser.StatementBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] SkellParser.DeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDecl([NotNull] SkellParser.VarDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.control"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitControl([NotNull] SkellParser.ControlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.ifControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfControl([NotNull] SkellParser.IfControlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.ifThenControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfThenControl([NotNull] SkellParser.IfThenControlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.ifThenElseControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfThenElseControl([NotNull] SkellParser.IfThenElseControlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] SkellParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.eqExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqExpr([NotNull] SkellParser.EqExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.relExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelExpr([NotNull] SkellParser.RelExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.addExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddExpr([NotNull] SkellParser.AddExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.mulExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulExpr([NotNull] SkellParser.MulExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnary([NotNull] SkellParser.UnaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimary([NotNull] SkellParser.PrimaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] SkellParser.TermContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] SkellParser.ValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBool([NotNull] SkellParser.BoolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArray([NotNull] SkellParser.ArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPair([NotNull] SkellParser.PairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObject([NotNull] SkellParser.ObjectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SkellParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] SkellParser.TypeNameContext context);
}
} // namespace Generated
