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
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
public partial class SkellLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WS=1, KW_OBJECT=2, KW_ARRAY=3, KW_NUMBER=4, KW_STRING=5, KW_BOOL=6, KW_NULL=7, 
		KW_TRUE=8, KW_FALSE=9, KW_IF=10, KW_THEN=11, KW_ELSE=12, KW_FOR=13, KW_IN=14, 
		KW_RETURN=15, LSQR=16, RSQR=17, LCURL=18, RCURL=19, LPAREN=20, RPAREN=21, 
		SYM_PERIOD=22, SYM_COMMA=23, SYM_QUOTE=24, SYM_COLON=25, OP_ASSGN=26, 
		OP_EQ=27, OP_NE=28, OP_LT=29, OP_LE=30, OP_GT=31, OP_GE=32, OP_NOT=33, 
		OP_OR=34, OP_AND=35, OP_ADD=36, OP_SUB=37, OP_DIV=38, OP_MUL=39, OP_MOD=40, 
		IDENTIFIER=41, STRING=42, NUMBER=43, NONDIGIT=44, DIGIT=45, NONZERO_DIGIT=46, 
		ZERO=47, SIGN=48, INT=49, FRAC=50, EXP=51, HEX=52, UNICODE=53, ESC=54, 
		SAFECODEPOINT=55;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"WS", "KW_OBJECT", "KW_ARRAY", "KW_NUMBER", "KW_STRING", "KW_BOOL", "KW_NULL", 
		"KW_TRUE", "KW_FALSE", "KW_IF", "KW_THEN", "KW_ELSE", "KW_FOR", "KW_IN", 
		"KW_RETURN", "LSQR", "RSQR", "LCURL", "RCURL", "LPAREN", "RPAREN", "SYM_PERIOD", 
		"SYM_COMMA", "SYM_QUOTE", "SYM_COLON", "OP_ASSGN", "OP_EQ", "OP_NE", "OP_LT", 
		"OP_LE", "OP_GT", "OP_GE", "OP_NOT", "OP_OR", "OP_AND", "OP_ADD", "OP_SUB", 
		"OP_DIV", "OP_MUL", "OP_MOD", "IDENTIFIER", "STRING", "NUMBER", "NONDIGIT", 
		"DIGIT", "NONZERO_DIGIT", "ZERO", "SIGN", "INT", "FRAC", "EXP", "HEX", 
		"UNICODE", "ESC", "SAFECODEPOINT"
	};


	public SkellLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SkellLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'object'", "'array'", "'number'", "'string'", "'bool'", "'null'", 
		"'true'", "'false'", "'if'", "'then'", "'else'", "'for'", "'in'", "'return'", 
		"'['", "']'", "'{'", "'}'", "'('", "')'", "'.'", "','", "'\"'", "':'", 
		"'='", "'=='", "'!='", "'<'", "'<='", "'>'", "'>='", "'!'", "'|'", "'&'", 
		"'+'", "'-'", "'/'", "'*'", "'%'", null, null, null, null, null, null, 
		"'0'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WS", "KW_OBJECT", "KW_ARRAY", "KW_NUMBER", "KW_STRING", "KW_BOOL", 
		"KW_NULL", "KW_TRUE", "KW_FALSE", "KW_IF", "KW_THEN", "KW_ELSE", "KW_FOR", 
		"KW_IN", "KW_RETURN", "LSQR", "RSQR", "LCURL", "RCURL", "LPAREN", "RPAREN", 
		"SYM_PERIOD", "SYM_COMMA", "SYM_QUOTE", "SYM_COLON", "OP_ASSGN", "OP_EQ", 
		"OP_NE", "OP_LT", "OP_LE", "OP_GT", "OP_GE", "OP_NOT", "OP_OR", "OP_AND", 
		"OP_ADD", "OP_SUB", "OP_DIV", "OP_MUL", "OP_MOD", "IDENTIFIER", "STRING", 
		"NUMBER", "NONDIGIT", "DIGIT", "NONZERO_DIGIT", "ZERO", "SIGN", "INT", 
		"FRAC", "EXP", "HEX", "UNICODE", "ESC", "SAFECODEPOINT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Skell.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SkellLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x39', '\x147', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x4', '\x32', 
		'\t', '\x32', '\x4', '\x33', '\t', '\x33', '\x4', '\x34', '\t', '\x34', 
		'\x4', '\x35', '\t', '\x35', '\x4', '\x36', '\t', '\x36', '\x4', '\x37', 
		'\t', '\x37', '\x4', '\x38', '\t', '\x38', '\x3', '\x2', '\x6', '\x2', 
		's', '\n', '\x2', '\r', '\x2', '\xE', '\x2', 't', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', 
		'\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '\"', 
		'\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', '%', 
		'\x3', '%', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '(', 
		'\x3', '(', '\x3', ')', '\x3', ')', '\x3', '*', '\x3', '*', '\x3', '*', 
		'\a', '*', '\xFD', '\n', '*', '\f', '*', '\xE', '*', '\x100', '\v', '*', 
		'\x3', '+', '\x3', '+', '\x3', '+', '\a', '+', '\x105', '\n', '+', '\f', 
		'+', '\xE', '+', '\x108', '\v', '+', '\x3', '+', '\x3', '+', '\x3', ',', 
		'\x5', ',', '\x10D', '\n', ',', '\x3', ',', '\x3', ',', '\x5', ',', '\x111', 
		'\n', ',', '\x3', ',', '\x5', ',', '\x114', '\n', ',', '\x3', '-', '\x3', 
		'-', '\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', '\x3', '\x30', '\x3', 
		'\x30', '\x3', '\x31', '\x3', '\x31', '\x5', '\x31', '\x120', '\n', '\x31', 
		'\x3', '\x32', '\x3', '\x32', '\x3', '\x32', '\a', '\x32', '\x125', '\n', 
		'\x32', '\f', '\x32', '\xE', '\x32', '\x128', '\v', '\x32', '\x5', '\x32', 
		'\x12A', '\n', '\x32', '\x3', '\x33', '\x3', '\x33', '\x6', '\x33', '\x12E', 
		'\n', '\x33', '\r', '\x33', '\xE', '\x33', '\x12F', '\x3', '\x34', '\x3', 
		'\x34', '\x5', '\x34', '\x134', '\n', '\x34', '\x3', '\x34', '\x5', '\x34', 
		'\x137', '\n', '\x34', '\x3', '\x35', '\x3', '\x35', '\x3', '\x36', '\x3', 
		'\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x36', '\x3', 
		'\x37', '\x3', '\x37', '\x3', '\x37', '\x5', '\x37', '\x144', '\n', '\x37', 
		'\x3', '\x38', '\x3', '\x38', '\x2', '\x2', '\x39', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', 
		'%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', 
		'\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', 
		'*', 'S', '+', 'U', ',', 'W', '-', 'Y', '.', '[', '/', ']', '\x30', '_', 
		'\x31', '\x61', '\x32', '\x63', '\x33', '\x65', '\x34', 'g', '\x35', 'i', 
		'\x36', 'k', '\x37', 'm', '\x38', 'o', '\x39', '\x3', '\x2', '\n', '\x5', 
		'\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x5', '\x2', '\x43', '\\', 
		'\x61', '\x61', '\x63', '|', '\x3', '\x2', '\x32', ';', '\x3', '\x2', 
		'\x33', ';', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x5', '\x2', '\x32', ';', 
		'\x43', 'H', '\x63', 'h', '\n', '\x2', '$', '$', '\x31', '\x31', '^', 
		'^', '\x64', '\x64', 'h', 'h', 'p', 'p', 't', 't', 'v', 'v', '\x5', '\x2', 
		'\x2', '!', '$', '$', '^', '^', '\x2', '\x155', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'S', '\x3', '\x2', '\x2', '\x2', '\x2', 'U', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'W', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'Y', '\x3', '\x2', '\x2', '\x2', '\x2', '[', '\x3', '\x2', '\x2', '\x2', 
		'\x2', ']', '\x3', '\x2', '\x2', '\x2', '\x2', '_', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x61', '\x3', '\x2', '\x2', '\x2', '\x2', '\x63', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x65', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'g', '\x3', '\x2', '\x2', '\x2', '\x2', 'i', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'k', '\x3', '\x2', '\x2', '\x2', '\x2', 'm', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'o', '\x3', '\x2', '\x2', '\x2', '\x3', 'r', '\x3', '\x2', 
		'\x2', '\x2', '\x5', 'x', '\x3', '\x2', '\x2', '\x2', '\a', '\x7F', '\x3', 
		'\x2', '\x2', '\x2', '\t', '\x85', '\x3', '\x2', '\x2', '\x2', '\v', '\x8C', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\x93', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '\x98', '\x3', '\x2', '\x2', '\x2', '\x11', '\x9D', '\x3', '\x2', 
		'\x2', '\x2', '\x13', '\xA2', '\x3', '\x2', '\x2', '\x2', '\x15', '\xA8', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\xAB', '\x3', '\x2', '\x2', '\x2', 
		'\x19', '\xB0', '\x3', '\x2', '\x2', '\x2', '\x1B', '\xB5', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', '\xB9', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xBC', 
		'\x3', '\x2', '\x2', '\x2', '!', '\xC3', '\x3', '\x2', '\x2', '\x2', '#', 
		'\xC5', '\x3', '\x2', '\x2', '\x2', '%', '\xC7', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\xC9', '\x3', '\x2', '\x2', '\x2', ')', '\xCB', '\x3', '\x2', 
		'\x2', '\x2', '+', '\xCD', '\x3', '\x2', '\x2', '\x2', '-', '\xCF', '\x3', 
		'\x2', '\x2', '\x2', '/', '\xD1', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\xD3', '\x3', '\x2', '\x2', '\x2', '\x33', '\xD5', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\xD7', '\x3', '\x2', '\x2', '\x2', '\x37', '\xD9', '\x3', 
		'\x2', '\x2', '\x2', '\x39', '\xDC', '\x3', '\x2', '\x2', '\x2', ';', 
		'\xDF', '\x3', '\x2', '\x2', '\x2', '=', '\xE1', '\x3', '\x2', '\x2', 
		'\x2', '?', '\xE4', '\x3', '\x2', '\x2', '\x2', '\x41', '\xE6', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\xE9', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\xEB', '\x3', '\x2', '\x2', '\x2', 'G', '\xED', '\x3', '\x2', '\x2', 
		'\x2', 'I', '\xEF', '\x3', '\x2', '\x2', '\x2', 'K', '\xF1', '\x3', '\x2', 
		'\x2', '\x2', 'M', '\xF3', '\x3', '\x2', '\x2', '\x2', 'O', '\xF5', '\x3', 
		'\x2', '\x2', '\x2', 'Q', '\xF7', '\x3', '\x2', '\x2', '\x2', 'S', '\xF9', 
		'\x3', '\x2', '\x2', '\x2', 'U', '\x101', '\x3', '\x2', '\x2', '\x2', 
		'W', '\x10C', '\x3', '\x2', '\x2', '\x2', 'Y', '\x115', '\x3', '\x2', 
		'\x2', '\x2', '[', '\x117', '\x3', '\x2', '\x2', '\x2', ']', '\x119', 
		'\x3', '\x2', '\x2', '\x2', '_', '\x11B', '\x3', '\x2', '\x2', '\x2', 
		'\x61', '\x11F', '\x3', '\x2', '\x2', '\x2', '\x63', '\x129', '\x3', '\x2', 
		'\x2', '\x2', '\x65', '\x12B', '\x3', '\x2', '\x2', '\x2', 'g', '\x131', 
		'\x3', '\x2', '\x2', '\x2', 'i', '\x138', '\x3', '\x2', '\x2', '\x2', 
		'k', '\x13A', '\x3', '\x2', '\x2', '\x2', 'm', '\x140', '\x3', '\x2', 
		'\x2', '\x2', 'o', '\x145', '\x3', '\x2', '\x2', '\x2', 'q', 's', '\t', 
		'\x2', '\x2', '\x2', 'r', 'q', '\x3', '\x2', '\x2', '\x2', 's', 't', '\x3', 
		'\x2', '\x2', '\x2', 't', 'r', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\x3', 
		'\x2', '\x2', '\x2', 'u', 'v', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\b', 
		'\x2', '\x2', '\x2', 'w', '\x4', '\x3', '\x2', '\x2', '\x2', 'x', 'y', 
		'\a', 'q', '\x2', '\x2', 'y', 'z', '\a', '\x64', '\x2', '\x2', 'z', '{', 
		'\a', 'l', '\x2', '\x2', '{', '|', '\a', 'g', '\x2', '\x2', '|', '}', 
		'\a', '\x65', '\x2', '\x2', '}', '~', '\a', 'v', '\x2', '\x2', '~', '\x6', 
		'\x3', '\x2', '\x2', '\x2', '\x7F', '\x80', '\a', '\x63', '\x2', '\x2', 
		'\x80', '\x81', '\a', 't', '\x2', '\x2', '\x81', '\x82', '\a', 't', '\x2', 
		'\x2', '\x82', '\x83', '\a', '\x63', '\x2', '\x2', '\x83', '\x84', '\a', 
		'{', '\x2', '\x2', '\x84', '\b', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', 
		'\a', 'p', '\x2', '\x2', '\x86', '\x87', '\a', 'w', '\x2', '\x2', '\x87', 
		'\x88', '\a', 'o', '\x2', '\x2', '\x88', '\x89', '\a', '\x64', '\x2', 
		'\x2', '\x89', '\x8A', '\a', 'g', '\x2', '\x2', '\x8A', '\x8B', '\a', 
		't', '\x2', '\x2', '\x8B', '\n', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8D', 
		'\a', 'u', '\x2', '\x2', '\x8D', '\x8E', '\a', 'v', '\x2', '\x2', '\x8E', 
		'\x8F', '\a', 't', '\x2', '\x2', '\x8F', '\x90', '\a', 'k', '\x2', '\x2', 
		'\x90', '\x91', '\a', 'p', '\x2', '\x2', '\x91', '\x92', '\a', 'i', '\x2', 
		'\x2', '\x92', '\f', '\x3', '\x2', '\x2', '\x2', '\x93', '\x94', '\a', 
		'\x64', '\x2', '\x2', '\x94', '\x95', '\a', 'q', '\x2', '\x2', '\x95', 
		'\x96', '\a', 'q', '\x2', '\x2', '\x96', '\x97', '\a', 'n', '\x2', '\x2', 
		'\x97', '\xE', '\x3', '\x2', '\x2', '\x2', '\x98', '\x99', '\a', 'p', 
		'\x2', '\x2', '\x99', '\x9A', '\a', 'w', '\x2', '\x2', '\x9A', '\x9B', 
		'\a', 'n', '\x2', '\x2', '\x9B', '\x9C', '\a', 'n', '\x2', '\x2', '\x9C', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\a', 'v', '\x2', 
		'\x2', '\x9E', '\x9F', '\a', 't', '\x2', '\x2', '\x9F', '\xA0', '\a', 
		'w', '\x2', '\x2', '\xA0', '\xA1', '\a', 'g', '\x2', '\x2', '\xA1', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\a', 'h', '\x2', '\x2', '\xA3', 
		'\xA4', '\a', '\x63', '\x2', '\x2', '\xA4', '\xA5', '\a', 'n', '\x2', 
		'\x2', '\xA5', '\xA6', '\a', 'u', '\x2', '\x2', '\xA6', '\xA7', '\a', 
		'g', '\x2', '\x2', '\xA7', '\x14', '\x3', '\x2', '\x2', '\x2', '\xA8', 
		'\xA9', '\a', 'k', '\x2', '\x2', '\xA9', '\xAA', '\a', 'h', '\x2', '\x2', 
		'\xAA', '\x16', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', '\a', 'v', 
		'\x2', '\x2', '\xAC', '\xAD', '\a', 'j', '\x2', '\x2', '\xAD', '\xAE', 
		'\a', 'g', '\x2', '\x2', '\xAE', '\xAF', '\a', 'p', '\x2', '\x2', '\xAF', 
		'\x18', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\a', 'g', '\x2', 
		'\x2', '\xB1', '\xB2', '\a', 'n', '\x2', '\x2', '\xB2', '\xB3', '\a', 
		'u', '\x2', '\x2', '\xB3', '\xB4', '\a', 'g', '\x2', '\x2', '\xB4', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\a', 'h', '\x2', '\x2', '\xB6', 
		'\xB7', '\a', 'q', '\x2', '\x2', '\xB7', '\xB8', '\a', 't', '\x2', '\x2', 
		'\xB8', '\x1C', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', '\a', 'k', 
		'\x2', '\x2', '\xBA', '\xBB', '\a', 'p', '\x2', '\x2', '\xBB', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\a', 't', '\x2', '\x2', '\xBD', 
		'\xBE', '\a', 'g', '\x2', '\x2', '\xBE', '\xBF', '\a', 'v', '\x2', '\x2', 
		'\xBF', '\xC0', '\a', 'w', '\x2', '\x2', '\xC0', '\xC1', '\a', 't', '\x2', 
		'\x2', '\xC1', '\xC2', '\a', 'p', '\x2', '\x2', '\xC2', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\xC3', '\xC4', '\a', ']', '\x2', '\x2', '\xC4', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\xC5', '\xC6', '\a', '_', '\x2', '\x2', '\xC6', 
		'$', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\a', '}', '\x2', '\x2', 
		'\xC8', '&', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\a', '\x7F', 
		'\x2', '\x2', '\xCA', '(', '\x3', '\x2', '\x2', '\x2', '\xCB', '\xCC', 
		'\a', '*', '\x2', '\x2', '\xCC', '*', '\x3', '\x2', '\x2', '\x2', '\xCD', 
		'\xCE', '\a', '+', '\x2', '\x2', '\xCE', ',', '\x3', '\x2', '\x2', '\x2', 
		'\xCF', '\xD0', '\a', '\x30', '\x2', '\x2', '\xD0', '.', '\x3', '\x2', 
		'\x2', '\x2', '\xD1', '\xD2', '\a', '.', '\x2', '\x2', '\xD2', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\xD3', '\xD4', '\a', '$', '\x2', '\x2', '\xD4', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\xD5', '\xD6', '\a', '<', '\x2', 
		'\x2', '\xD6', '\x34', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD8', '\a', 
		'?', '\x2', '\x2', '\xD8', '\x36', '\x3', '\x2', '\x2', '\x2', '\xD9', 
		'\xDA', '\a', '?', '\x2', '\x2', '\xDA', '\xDB', '\a', '?', '\x2', '\x2', 
		'\xDB', '\x38', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xDD', '\a', '#', 
		'\x2', '\x2', '\xDD', '\xDE', '\a', '?', '\x2', '\x2', '\xDE', ':', '\x3', 
		'\x2', '\x2', '\x2', '\xDF', '\xE0', '\a', '>', '\x2', '\x2', '\xE0', 
		'<', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', '\a', '>', '\x2', '\x2', 
		'\xE2', '\xE3', '\a', '?', '\x2', '\x2', '\xE3', '>', '\x3', '\x2', '\x2', 
		'\x2', '\xE4', '\xE5', '\a', '@', '\x2', '\x2', '\xE5', '@', '\x3', '\x2', 
		'\x2', '\x2', '\xE6', '\xE7', '\a', '@', '\x2', '\x2', '\xE7', '\xE8', 
		'\a', '?', '\x2', '\x2', '\xE8', '\x42', '\x3', '\x2', '\x2', '\x2', '\xE9', 
		'\xEA', '\a', '#', '\x2', '\x2', '\xEA', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\xEB', '\xEC', '\a', '~', '\x2', '\x2', '\xEC', '\x46', '\x3', 
		'\x2', '\x2', '\x2', '\xED', '\xEE', '\a', '(', '\x2', '\x2', '\xEE', 
		'H', '\x3', '\x2', '\x2', '\x2', '\xEF', '\xF0', '\a', '-', '\x2', '\x2', 
		'\xF0', 'J', '\x3', '\x2', '\x2', '\x2', '\xF1', '\xF2', '\a', '/', '\x2', 
		'\x2', '\xF2', 'L', '\x3', '\x2', '\x2', '\x2', '\xF3', '\xF4', '\a', 
		'\x31', '\x2', '\x2', '\xF4', 'N', '\x3', '\x2', '\x2', '\x2', '\xF5', 
		'\xF6', '\a', ',', '\x2', '\x2', '\xF6', 'P', '\x3', '\x2', '\x2', '\x2', 
		'\xF7', '\xF8', '\a', '\'', '\x2', '\x2', '\xF8', 'R', '\x3', '\x2', '\x2', 
		'\x2', '\xF9', '\xFE', '\x5', 'Y', '-', '\x2', '\xFA', '\xFD', '\x5', 
		'Y', '-', '\x2', '\xFB', '\xFD', '\x5', '[', '.', '\x2', '\xFC', '\xFA', 
		'\x3', '\x2', '\x2', '\x2', '\xFC', '\xFB', '\x3', '\x2', '\x2', '\x2', 
		'\xFD', '\x100', '\x3', '\x2', '\x2', '\x2', '\xFE', '\xFC', '\x3', '\x2', 
		'\x2', '\x2', '\xFE', '\xFF', '\x3', '\x2', '\x2', '\x2', '\xFF', 'T', 
		'\x3', '\x2', '\x2', '\x2', '\x100', '\xFE', '\x3', '\x2', '\x2', '\x2', 
		'\x101', '\x106', '\x5', '\x31', '\x19', '\x2', '\x102', '\x105', '\x5', 
		'm', '\x37', '\x2', '\x103', '\x105', '\x5', 'o', '\x38', '\x2', '\x104', 
		'\x102', '\x3', '\x2', '\x2', '\x2', '\x104', '\x103', '\x3', '\x2', '\x2', 
		'\x2', '\x105', '\x108', '\x3', '\x2', '\x2', '\x2', '\x106', '\x104', 
		'\x3', '\x2', '\x2', '\x2', '\x106', '\x107', '\x3', '\x2', '\x2', '\x2', 
		'\x107', '\x109', '\x3', '\x2', '\x2', '\x2', '\x108', '\x106', '\x3', 
		'\x2', '\x2', '\x2', '\x109', '\x10A', '\x5', '\x31', '\x19', '\x2', '\x10A', 
		'V', '\x3', '\x2', '\x2', '\x2', '\x10B', '\x10D', '\x5', 'K', '&', '\x2', 
		'\x10C', '\x10B', '\x3', '\x2', '\x2', '\x2', '\x10C', '\x10D', '\x3', 
		'\x2', '\x2', '\x2', '\x10D', '\x10E', '\x3', '\x2', '\x2', '\x2', '\x10E', 
		'\x110', '\x5', '\x63', '\x32', '\x2', '\x10F', '\x111', '\x5', '\x65', 
		'\x33', '\x2', '\x110', '\x10F', '\x3', '\x2', '\x2', '\x2', '\x110', 
		'\x111', '\x3', '\x2', '\x2', '\x2', '\x111', '\x113', '\x3', '\x2', '\x2', 
		'\x2', '\x112', '\x114', '\x5', 'g', '\x34', '\x2', '\x113', '\x112', 
		'\x3', '\x2', '\x2', '\x2', '\x113', '\x114', '\x3', '\x2', '\x2', '\x2', 
		'\x114', 'X', '\x3', '\x2', '\x2', '\x2', '\x115', '\x116', '\t', '\x3', 
		'\x2', '\x2', '\x116', 'Z', '\x3', '\x2', '\x2', '\x2', '\x117', '\x118', 
		'\t', '\x4', '\x2', '\x2', '\x118', '\\', '\x3', '\x2', '\x2', '\x2', 
		'\x119', '\x11A', '\t', '\x5', '\x2', '\x2', '\x11A', '^', '\x3', '\x2', 
		'\x2', '\x2', '\x11B', '\x11C', '\a', '\x32', '\x2', '\x2', '\x11C', '`', 
		'\x3', '\x2', '\x2', '\x2', '\x11D', '\x120', '\x5', 'I', '%', '\x2', 
		'\x11E', '\x120', '\x5', 'K', '&', '\x2', '\x11F', '\x11D', '\x3', '\x2', 
		'\x2', '\x2', '\x11F', '\x11E', '\x3', '\x2', '\x2', '\x2', '\x120', '\x62', 
		'\x3', '\x2', '\x2', '\x2', '\x121', '\x12A', '\x5', '_', '\x30', '\x2', 
		'\x122', '\x126', '\x5', ']', '/', '\x2', '\x123', '\x125', '\x5', '[', 
		'.', '\x2', '\x124', '\x123', '\x3', '\x2', '\x2', '\x2', '\x125', '\x128', 
		'\x3', '\x2', '\x2', '\x2', '\x126', '\x124', '\x3', '\x2', '\x2', '\x2', 
		'\x126', '\x127', '\x3', '\x2', '\x2', '\x2', '\x127', '\x12A', '\x3', 
		'\x2', '\x2', '\x2', '\x128', '\x126', '\x3', '\x2', '\x2', '\x2', '\x129', 
		'\x121', '\x3', '\x2', '\x2', '\x2', '\x129', '\x122', '\x3', '\x2', '\x2', 
		'\x2', '\x12A', '\x64', '\x3', '\x2', '\x2', '\x2', '\x12B', '\x12D', 
		'\x5', '-', '\x17', '\x2', '\x12C', '\x12E', '\x5', '[', '.', '\x2', '\x12D', 
		'\x12C', '\x3', '\x2', '\x2', '\x2', '\x12E', '\x12F', '\x3', '\x2', '\x2', 
		'\x2', '\x12F', '\x12D', '\x3', '\x2', '\x2', '\x2', '\x12F', '\x130', 
		'\x3', '\x2', '\x2', '\x2', '\x130', '\x66', '\x3', '\x2', '\x2', '\x2', 
		'\x131', '\x133', '\t', '\x6', '\x2', '\x2', '\x132', '\x134', '\x5', 
		'\x61', '\x31', '\x2', '\x133', '\x132', '\x3', '\x2', '\x2', '\x2', '\x133', 
		'\x134', '\x3', '\x2', '\x2', '\x2', '\x134', '\x136', '\x3', '\x2', '\x2', 
		'\x2', '\x135', '\x137', '\x5', '\x63', '\x32', '\x2', '\x136', '\x135', 
		'\x3', '\x2', '\x2', '\x2', '\x136', '\x137', '\x3', '\x2', '\x2', '\x2', 
		'\x137', 'h', '\x3', '\x2', '\x2', '\x2', '\x138', '\x139', '\t', '\a', 
		'\x2', '\x2', '\x139', 'j', '\x3', '\x2', '\x2', '\x2', '\x13A', '\x13B', 
		'\a', 'w', '\x2', '\x2', '\x13B', '\x13C', '\x5', 'i', '\x35', '\x2', 
		'\x13C', '\x13D', '\x5', 'i', '\x35', '\x2', '\x13D', '\x13E', '\x5', 
		'i', '\x35', '\x2', '\x13E', '\x13F', '\x5', 'i', '\x35', '\x2', '\x13F', 
		'l', '\x3', '\x2', '\x2', '\x2', '\x140', '\x143', '\a', '^', '\x2', '\x2', 
		'\x141', '\x144', '\t', '\b', '\x2', '\x2', '\x142', '\x144', '\x5', 'k', 
		'\x36', '\x2', '\x143', '\x141', '\x3', '\x2', '\x2', '\x2', '\x143', 
		'\x142', '\x3', '\x2', '\x2', '\x2', '\x144', 'n', '\x3', '\x2', '\x2', 
		'\x2', '\x145', '\x146', '\n', '\t', '\x2', '\x2', '\x146', 'p', '\x3', 
		'\x2', '\x2', '\x2', '\x12', '\x2', 't', '\xFC', '\xFE', '\x104', '\x106', 
		'\x10C', '\x110', '\x113', '\x11F', '\x126', '\x129', '\x12F', '\x133', 
		'\x136', '\x143', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Generated