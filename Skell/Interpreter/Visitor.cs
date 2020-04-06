using Generated;
using Serilog;

namespace Skell.Interpreter
{
    class SkellVisitor : SkellBaseVisitor<Skell.Data.SkellData>
    {
        Skell.Data.Boolean defaultReturnValue = new Skell.Data.Boolean(true);
        private static ILogger logger;

        public SkellVisitor()
        {
            logger = Log.ForContext<SkellVisitor>();
        }

        /// <summary>
        /// program : statement+ ;
        /// </summary>
        override public Skell.Data.SkellData VisitProgram(SkellParser.ProgramContext context)
        {
            Skell.Data.SkellData lastResult = defaultReturnValue;
            foreach (var statement in context.statement()) {
                logger.Verbose("Visiting:\n" + statement.ToStringTree());
                lastResult = Visit(statement);
                if (lastResult is Skell.Data.Array arr)
                {
                    logger.Debug($"Result: {lastResult} of type {lastResult.GetType()} and length {arr.Count()}");
                } 
                else if (lastResult is Skell.Data.Object obj)
                {
                    logger.Debug($"Result: \n{obj}\n of type {lastResult.GetType()}");
                }
                else
                {
                    logger.Debug($"Result: {lastResult} of type {lastResult.GetType()}");
                }
                System.Console.WriteLine(lastResult);
            }
            return lastResult;
        }

        /// <summary>
        /// statement : expression | control;
        /// </summary>
        override public Skell.Data.SkellData VisitStatement(SkellParser.StatementContext context)
        {
            if (context.expression() != null)
            {
                return VisitExpression(context.expression());
            }
            else
            {
                return VisitControl(context.control());
            }
        }

        /// <summary>
        /// statementBlock : LCURL statement* RCURL ;
        /// </summary>
        override public Skell.Data.SkellData VisitStatementBlock(SkellParser.StatementBlockContext context)
        {
            Skell.Data.SkellData lastResult = defaultReturnValue;
            for (int i = 0; i < context.statement().Length; i++)
            {
                lastResult = VisitStatement(context.statement(i));
            }
            return lastResult;
        }

        /// <summary>
        /// expression : eqExpr ;
        /// </summary>
        override public Skell.Data.SkellData VisitExpression(SkellParser.ExpressionContext context)
        {
            return Visit(context.eqExpr());
        }

        /// <summary>
        /// eqExpr : relExpr ((OP_NE | OP_EQ) relExpr)? ;
        /// </summary>
        override public Skell.Data.SkellData VisitEqExpr(SkellParser.EqExprContext context)
        {
            Skell.Data.SkellData result = VisitRelExpr(context.relExpr(0));

            if (context.relExpr(1) != null) {
                Skell.Data.SkellData next = VisitRelExpr(context.relExpr(1));
                var op = (Antlr4.Runtime.IToken) Utility.GetLeftSibling(context.relExpr(1)).Payload;
                bool ret = result.Equals(next);
                if (op.Type == SkellLexer.OP_NE) {
                    ret = !ret;
                }
                return new Skell.Data.Boolean(ret);
            }
            return result;
        }

        /// <summary>
        /// relExpr : addExpr ((OP_GT | OP_GE | OP_LT | OP_LE) addExpr)? ;
        /// </summary>
        override public Skell.Data.SkellData VisitRelExpr(SkellParser.RelExprContext context)
        {
            Skell.Data.SkellData result = VisitAddExpr(context.addExpr(0));

            if (context.addExpr(1) != null) {
                Skell.Data.SkellData next = VisitAddExpr(context.addExpr(1));
                var op = (Antlr4.Runtime.IToken) Utility.GetLeftSibling(context.addExpr(1)).Payload;
                if (result is Skell.Data.Number r && next is Skell.Data.Number n) {
                    bool ret = false;
                    switch (op.Type) {
                        case SkellLexer.OP_GE:
                            ret = r >= n;
                        break;
                        case SkellLexer.OP_GT:
                            ret = r > n;
                        break;
                        case SkellLexer.OP_LE:
                            ret = r < n;
                        break;
                        case SkellLexer.OP_LT:
                            ret = r <= n;
                        break;
                    }
                    return new Skell.Data.Boolean(ret);
                }
            }
            return result;
        }

        /// <summary>
        /// addExpr : mulExpr ((OP_SUB | OP_ADD) mulExpr)* ;
        /// </summary>
        override public Skell.Data.SkellData VisitAddExpr(SkellParser.AddExprContext context)
        {
            int i = 0;
            Skell.Data.SkellData result = VisitMulExpr(context.mulExpr(i));

            i++;
            while (context.mulExpr(i) != null) {
                if (!(result is Skell.Data.Number)) {
                    throw new System.NotImplementedException();
                }
                Skell.Data.SkellData next = VisitMulExpr(context.mulExpr(i));
                if (!(next is Skell.Data.Number)) {
                    throw new System.NotImplementedException();
                }
                var op = (Antlr4.Runtime.IToken) Utility.GetLeftSibling(context.mulExpr(i)).Payload;
                if (op.Type == SkellLexer.OP_SUB) {
                    result = (Skell.Data.Number) result - (Skell.Data.Number) next;
                } else {
                    result = (Skell.Data.Number) result + (Skell.Data.Number) next;
                }
                i++;
            }
            return result;
        }

        /// <summary>
        /// mulExpr : unary ((OP_DIV | OP_MUL) unary)* ;
        /// </summary>
        override public Skell.Data.SkellData VisitMulExpr(SkellParser.MulExprContext context)
        {
            int i = 0;
            Skell.Data.SkellData result = VisitUnary(context.unary(i));

            i++;
            while (context.unary(i) != null) {
                if (!(result is Skell.Data.Number)) {
                    throw new System.NotImplementedException();
                }
                Skell.Data.SkellData next = VisitUnary(context.unary(i));
                if (!(next is Skell.Data.Number)) {
                    throw new System.NotImplementedException();
                }
                var op = (Antlr4.Runtime.IToken) Utility.GetLeftSibling(context.unary(i)).Payload;                
                if (op.Type == SkellLexer.OP_DIV) {
                    result = (Skell.Data.Number) result / (Skell.Data.Number) next;
                } else {
                    result = (Skell.Data.Number) result * (Skell.Data.Number) next;
                }
                i++;
            }
            return result;
        }

        /// <summary>
        /// control : ifControl ;
        /// </summary>
        override public Skell.Data.SkellData VisitControl(SkellParser.ControlContext context)
        {
            return VisitIfControl(context.ifControl());
        }

        /// <summary>
        /// ifControl : ifThenControl | ifThenElseControl ;
        /// </summary>
        override public Skell.Data.SkellData VisitIfControl(SkellParser.IfControlContext context)
        {
            if (context.ifThenControl() != null)
            {
                return VisitIfThenControl(context.ifThenControl());
            }
            else
            {
                return VisitIfThenElseControl(context.ifThenElseControl());
            }
        }

        /// <summary>
        /// ifThenControl : KW_IF expression KW_THEN statementBlock ;
        /// </summary>
        override public Skell.Data.SkellData VisitIfThenControl(SkellParser.IfThenControlContext context)
        {
            Skell.Data.Boolean cont = Utility.EvaluateExpr(this, context.expression());
            if (!cont.value)
            {
                return new Skell.Data.Boolean(false);
            }
            return VisitStatementBlock(context.statementBlock());
        }

        /// <summary>
        /// ifThenElseControl : ifThenControl KW_ELSE (statementBlock | ifControl) ;
        /// </summary>
        override public Skell.Data.SkellData VisitIfThenElseControl(SkellParser.IfThenElseControlContext context)
        {
            // Evaluate the expression separately
            // Do not use VisitIfThenControl as the statementBlock in the
            // ifThenControl can return a false value
            Skell.Data.Boolean cont = Utility.EvaluateExpr(this, context.ifThenControl().expression());
            if (cont.value)
            {
                return VisitStatementBlock(context.ifThenControl().statementBlock());
            }
            else
            {
                if (context.statementBlock() != null)
                {
                    return VisitStatementBlock(context.statementBlock());
                }
                else
                {
                    return VisitIfControl(context.ifControl());
                }
            }
        }

        /// <summary>
        /// unary : (OP_NOT | OP_SUB) unary
        ///       | primary
        ///       ;
        /// </summary>
        override public Skell.Data.SkellData VisitUnary(SkellParser.UnaryContext context)
        {
            if (context.unary() != null) {
                var op = (Antlr4.Runtime.IToken) Utility.GetLeftSibling(context.unary()).Payload;
                if (op.Type == SkellLexer.OP_NOT) {
                    Skell.Data.Boolean boolUnary = new Skell.Data.Boolean(VisitUnary(context.unary()).ToString());
                    return !boolUnary;
                }
                Skell.Data.Number numUnary = new Skell.Data.Number(VisitUnary(context.unary()).ToString());
                return -numUnary;
            }
            return VisitPrimary(context.primary());
        }

        /// <summary>
        /// primary : term
        ///         | LPAREN expression RPAREN
        ///         ;
        /// </summary>
        override public Skell.Data.SkellData VisitPrimary(SkellParser.PrimaryContext context)
        {
            if (context.term() != null) {
                return VisitTerm(context.term());
            }
            return VisitExpression(context.expression());
        }

        /// <summary>
        /// term : value
        ///      | IDENTIFIER
        ///      | term LSQR (STRING | NUMBER | IDENTIFIER) RSQR
        ///      ;
        /// </summary>
        override public Skell.Data.SkellData VisitTerm(SkellParser.TermContext context)
        {
            if (context.term() != null) {
                Skell.Data.SkellData term = VisitTerm(context.term());
                Skell.Data.SkellData index;
                if (context.STRING() != null) {
                    index = Utility.GetString(context.STRING());
                } else if (context.NUMBER() != null) {
                    index = new Skell.Data.Number(context.NUMBER().GetText());
                } else {
                    throw new System.NotImplementedException();
                }
                if (term is Skell.Data.Object obj) {
                    return obj.GetMember(index);
                } else if (term is Skell.Data.Array arr) {
                    return arr.GetMember(index);
                } else {
                    throw new System.NotImplementedException();
                }
            } else if (context.IDENTIFIER() != null) {
                throw new System.NotImplementedException();
            } else {
                return VisitValue(context.value());
            }
        }
        
        /// <summary>
        /// value : object | array | STRING | NUMBER | bool ;
        /// </summary>
        override public Skell.Data.SkellData VisitValue(SkellParser.ValueContext context)
        {
            if (context.@object() != null) {
                return VisitObject(context.@object());
            }
            if (context.array() != null) {
                return VisitArray(context.array());
            }
            if (context.STRING() != null) {
                return Utility.GetString(context.STRING());
            }
            if (context.NUMBER() != null) {
                return new Skell.Data.Number(context.NUMBER().GetText());
            }
            return new Skell.Data.Boolean(context.@bool().GetText());
        }

        /// <summary>
        /// array : LSQR value (SYM_COMMA value)* RSQR
        ///       | LSQR RSQR
        ///       ;
        /// </summary>
        override public Skell.Data.SkellData VisitArray(SkellParser.ArrayContext context)
        {
            SkellParser.ValueContext[] values = context.value();
            Skell.Data.SkellData[] contents = new Skell.Data.SkellData[values.Length];
            for (int i = 0; i < values.Length; i++) {
                contents[i] = VisitValue(values[i]);
            }
            return new Skell.Data.Array(contents);
        }

        /// <summary>
        /// object : LCURL pair (SYM_COMMA pair)* RCURL
        ///        | LCURL RCURL
        ///        ;
        /// pair : STRING SYM_COLON value ;
        /// </summary>
        override public Skell.Data.SkellData VisitObject(SkellParser.ObjectContext context)
        {
            Skell.Data.String[] keys = new Skell.Data.String[context.pair().Length];
            Skell.Data.SkellData[] values = new Skell.Data.SkellData[context.pair().Length];

            for (int i = 0; i < context.pair().Length; i++) {
                var pair = context.pair(i);
                keys[i] = Utility.GetString(pair.STRING());
                values[i] = VisitValue(pair.value());
            }

            return new Skell.Data.Object(keys, values);
        }
    }

    static class Utility
    {
        /// <summary>
        /// Returns a Skell.Data.String for a STRING token
        /// </summary>
        /// <remark>
        /// STRING : SYM_QUOTE (ESC | SAFECODEPOINT)* SYM_QUOTE ;
        /// </remark>
        public static Skell.Data.String GetString(Antlr4.Runtime.Tree.ITerminalNode context)
        {
            string contents = context.GetText();
            contents = contents.Remove(0,1);
            contents = contents.Remove(contents.Length - 1,1);
            return new Skell.Data.String(contents);
        }

        /// <summary>
        /// Evaluates an expression and returns a Skell.Data.Boolean
        /// </summary>
        public static Skell.Data.Boolean EvaluateExpr(SkellVisitor parser, SkellParser.ExpressionContext context)
        {
            var expressionResult = parser.VisitExpression(context);
            if (!(expressionResult is Skell.Data.Boolean))
            {
                throw new System.NotImplementedException();
            }
            return (Skell.Data.Boolean) expressionResult;
        }

        /// <summary>
        /// Returns the left sibling of the parse tree node.
        /// </summary>
        /// <param name="context">A node.</param>
        /// <returns>Left sibling of a node, or null if no sibling is found.</returns>
        public static Antlr4.Runtime.Tree.IParseTree GetLeftSibling(this Antlr4.Runtime.ParserRuleContext context)
        {
            int index = GetNodeIndex(context);

            return index > 0 && index < context.Parent.ChildCount 
                ? context.Parent.GetChild(index - 1) 
                : null;
        }

        /// <summary>
        /// Returns the right sibling of the parse tree node.
        /// </summary>
        /// <param name="context">A node.</param>
        /// <returns>Right sibling of a node, or null if no sibling is found.</returns>
        public static Antlr4.Runtime.Tree.IParseTree GetRightSibling(this Antlr4.Runtime.ParserRuleContext context)
        {
            int index = GetNodeIndex(context);

            return index >= 0 && index < context.Parent.ChildCount - 1
                ? context.Parent.GetChild(index + 1) 
                : null;
        }

        /// <summary>
        /// Returns the node's index with in its parent's children array.
        /// </summary>
        /// <param name="context">A child node.</param>
        /// <returns>Node's index or -1 if node is null or doesn't have a parent.</returns>
        public static int GetNodeIndex(this Antlr4.Runtime.ParserRuleContext context)
        {
            Antlr4.Runtime.RuleContext parent = context?.Parent;

            if (parent == null)
                return -1;

            for (int i = 0; i < parent.ChildCount; i++) {
                if (parent.GetChild(i) == context) {
                    return i;
                }
            }

            return -1;
        }
    }
}