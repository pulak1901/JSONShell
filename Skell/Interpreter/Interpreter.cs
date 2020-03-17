using Generated;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Serilog;

namespace Interpreter
{
    class SkellInterpreter
    {
        private static ILogger logger;
        ITokenSource lexer;
        SkellParser parser;

        public SkellInterpreter()
        {
            logger = Log.ForContext<SkellInterpreter>();
        }

        public void interprete(string src)
        {
            logger.Verbose($":\n{src}");
            ICharStream charStream = CharStreams.fromstring(src);
            lexer = new SkellLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(lexer);
            parser = new SkellParser(tokenStream);
            parser.BuildParseTree = true;
            IParseTree tree = parser.program(); // Since program is our start rule
            logger.Debug($"Parse tree:\n{tree.ToStringTree(parser)}");
        }
    }
}