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

namespace Skell.Generated {
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
		EOL=1, WS=2, KW_TRUE=3, KW_FALSE=4, KW_IF=5, KW_THEN=6, KW_ELSE=7, KW_FOR=8, 
		KW_IN=9, KW_RETURN=10, KW_LET=11, KW_FUN=12, KW_IS=13, TYPE_OBJECT=14, 
		TYPE_ARRAY=15, TYPE_NUMBER=16, TYPE_STRING=17, TYPE_BOOL=18, TYPE_ANY=19, 
		LSQR=20, RSQR=21, LCURL=22, RCURL=23, LPAREN=24, RPAREN=25, SYM_PERIOD=26, 
		SYM_COMMA=27, SYM_QUOTE=28, SYM_COLON=29, SYM_DOLLAR=30, OP_ASSGN=31, 
		OP_EQ=32, OP_NE=33, OP_LT=34, OP_LE=35, OP_GT=36, OP_GE=37, OP_NOT=38, 
		OP_OR=39, OP_AND=40, OP_ADD=41, OP_SUB=42, OP_DIV=43, OP_MUL=44, OP_MOD=45, 
		IDENTIFIER=46, STRING=47, NUMBER=48, NONDIGIT=49, DIGIT=50, NONZERO_DIGIT=51, 
		ZERO=52, SIGN=53, INT=54, FRAC=55, EXP=56, HEX=57, UNICODE=58, ESC=59, 
		SAFECODEPOINT=60;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"EOL", "WS", "KW_TRUE", "KW_FALSE", "KW_IF", "KW_THEN", "KW_ELSE", "KW_FOR", 
		"KW_IN", "KW_RETURN", "KW_LET", "KW_FUN", "KW_IS", "TYPE_OBJECT", "TYPE_ARRAY", 
		"TYPE_NUMBER", "TYPE_STRING", "TYPE_BOOL", "TYPE_ANY", "LSQR", "RSQR", 
		"LCURL", "RCURL", "LPAREN", "RPAREN", "SYM_PERIOD", "SYM_COMMA", "SYM_QUOTE", 
		"SYM_COLON", "SYM_DOLLAR", "OP_ASSGN", "OP_EQ", "OP_NE", "OP_LT", "OP_LE", 
		"OP_GT", "OP_GE", "OP_NOT", "OP_OR", "OP_AND", "OP_ADD", "OP_SUB", "OP_DIV", 
		"OP_MUL", "OP_MOD", "IDENTIFIER", "STRING", "NUMBER", "NONDIGIT", "DIGIT", 
		"NONZERO_DIGIT", "ZERO", "SIGN", "INT", "FRAC", "EXP", "HEX", "UNICODE", 
		"ESC", "SAFECODEPOINT"
	};


	public SkellLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SkellLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'\n'", null, "'true'", "'false'", "'if'", "'then'", "'else'", "'for'", 
		"'in'", "'return'", "'let'", "'fun'", "'is'", "'object'", "'array'", "'number'", 
		"'string'", "'bool'", "'any'", "'['", "']'", "'{'", "'}'", "'('", "')'", 
		"'.'", "','", "'\"'", "':'", "'$'", "'='", "'=='", "'!='", "'<'", "'<='", 
		"'>'", "'>='", "'!'", "'|'", "'&'", "'+'", "'-'", "'/'", "'*'", "'%'", 
		null, null, null, null, null, null, "'0'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "EOL", "WS", "KW_TRUE", "KW_FALSE", "KW_IF", "KW_THEN", "KW_ELSE", 
		"KW_FOR", "KW_IN", "KW_RETURN", "KW_LET", "KW_FUN", "KW_IS", "TYPE_OBJECT", 
		"TYPE_ARRAY", "TYPE_NUMBER", "TYPE_STRING", "TYPE_BOOL", "TYPE_ANY", "LSQR", 
		"RSQR", "LCURL", "RCURL", "LPAREN", "RPAREN", "SYM_PERIOD", "SYM_COMMA", 
		"SYM_QUOTE", "SYM_COLON", "SYM_DOLLAR", "OP_ASSGN", "OP_EQ", "OP_NE", 
		"OP_LT", "OP_LE", "OP_GT", "OP_GE", "OP_NOT", "OP_OR", "OP_AND", "OP_ADD", 
		"OP_SUB", "OP_DIV", "OP_MUL", "OP_MOD", "IDENTIFIER", "STRING", "NUMBER", 
		"NONDIGIT", "DIGIT", "NONZERO_DIGIT", "ZERO", "SIGN", "INT", "FRAC", "EXP", 
		"HEX", "UNICODE", "ESC", "SAFECODEPOINT"
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
		'\x5964', '\x2', '>', '\x15A', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
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
		'\t', '\x37', '\x4', '\x38', '\t', '\x38', '\x4', '\x39', '\t', '\x39', 
		'\x4', ':', '\t', ':', '\x4', ';', '\t', ';', '\x4', '<', '\t', '<', '\x4', 
		'=', '\t', '=', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x6', '\x3', 
		'\x7F', '\n', '\x3', '\r', '\x3', '\xE', '\x3', '\x80', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', 
		'\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', 
		'\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '\"', 
		'\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', 
		'\x3', '$', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', '&', '\x3', '&', 
		'\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', '\x3', ')', '\x3', ')', 
		'\x3', '*', '\x3', '*', '\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', 
		'\x3', '-', '\x3', '-', '\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', 
		'\x3', '/', '\a', '/', '\x115', '\n', '/', '\f', '/', '\xE', '/', '\x118', 
		'\v', '/', '\x3', '\x30', '\x3', '\x30', '\x3', '\x30', '\a', '\x30', 
		'\x11D', '\n', '\x30', '\f', '\x30', '\xE', '\x30', '\x120', '\v', '\x30', 
		'\x3', '\x30', '\x3', '\x30', '\x3', '\x31', '\x5', '\x31', '\x125', '\n', 
		'\x31', '\x3', '\x31', '\x3', '\x31', '\x5', '\x31', '\x129', '\n', '\x31', 
		'\x3', '\x31', '\x5', '\x31', '\x12C', '\n', '\x31', '\x3', '\x32', '\x3', 
		'\x32', '\x3', '\x33', '\x3', '\x33', '\x3', '\x34', '\x3', '\x34', '\x3', 
		'\x35', '\x3', '\x35', '\x3', '\x36', '\x3', '\x36', '\x5', '\x36', '\x138', 
		'\n', '\x36', '\x3', '\x37', '\x6', '\x37', '\x13B', '\n', '\x37', '\r', 
		'\x37', '\xE', '\x37', '\x13C', '\x3', '\x38', '\x3', '\x38', '\x6', '\x38', 
		'\x141', '\n', '\x38', '\r', '\x38', '\xE', '\x38', '\x142', '\x3', '\x39', 
		'\x3', '\x39', '\x5', '\x39', '\x147', '\n', '\x39', '\x3', '\x39', '\x5', 
		'\x39', '\x14A', '\n', '\x39', '\x3', ':', '\x3', ':', '\x3', ';', '\x3', 
		';', '\x3', ';', '\x3', ';', '\x3', ';', '\x3', ';', '\x3', '<', '\x3', 
		'<', '\x3', '<', '\x5', '<', '\x157', '\n', '<', '\x3', '=', '\x3', '=', 
		'\x2', '\x2', '>', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', 
		'\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', 
		'\x11', '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', 
		'+', '\x17', '-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', 
		'\x35', '\x1C', '\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', ' ', 
		'?', '!', '\x41', '\"', '\x43', '#', '\x45', '$', 'G', '%', 'I', '&', 
		'K', '\'', 'M', '(', 'O', ')', 'Q', '*', 'S', '+', 'U', ',', 'W', '-', 
		'Y', '.', '[', '/', ']', '\x30', '_', '\x31', '\x61', '\x32', '\x63', 
		'\x33', '\x65', '\x34', 'g', '\x35', 'i', '\x36', 'k', '\x37', 'm', '\x38', 
		'o', '\x39', 'q', ':', 's', ';', 'u', '<', 'w', '=', 'y', '>', '\x3', 
		'\x2', '\n', '\x5', '\x2', '\v', '\v', '\xF', '\xF', '\"', '\"', '\x5', 
		'\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x3', '\x2', '\x32', 
		';', '\x3', '\x2', '\x33', ';', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x5', 
		'\x2', '\x32', ';', '\x43', 'H', '\x63', 'h', '\n', '\x2', '$', '$', '\x31', 
		'\x31', '^', '^', '\x64', '\x64', 'h', 'h', 'p', 'p', 't', 't', 'v', 'v', 
		'\x5', '\x2', '\x2', '!', '$', '$', '^', '^', '\x2', '\x167', '\x2', '\x3', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', 
		';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'M', '\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'Q', '\x3', '\x2', '\x2', '\x2', '\x2', 'S', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'U', '\x3', '\x2', '\x2', '\x2', '\x2', 'W', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'Y', '\x3', '\x2', '\x2', '\x2', '\x2', '[', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ']', '\x3', '\x2', '\x2', '\x2', '\x2', '_', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x61', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x63', '\x3', '\x2', '\x2', '\x2', '\x2', '\x65', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'g', '\x3', '\x2', '\x2', '\x2', '\x2', 'i', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'k', '\x3', '\x2', '\x2', '\x2', '\x2', 'm', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'o', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'q', '\x3', '\x2', '\x2', '\x2', '\x2', 's', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'u', '\x3', '\x2', '\x2', '\x2', '\x2', 'w', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'y', '\x3', '\x2', '\x2', '\x2', '\x3', '{', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '~', '\x3', '\x2', '\x2', '\x2', '\a', '\x84', '\x3', 
		'\x2', '\x2', '\x2', '\t', '\x89', '\x3', '\x2', '\x2', '\x2', '\v', '\x8F', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\x92', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '\x97', '\x3', '\x2', '\x2', '\x2', '\x11', '\x9C', '\x3', '\x2', 
		'\x2', '\x2', '\x13', '\xA0', '\x3', '\x2', '\x2', '\x2', '\x15', '\xA3', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\xAA', '\x3', '\x2', '\x2', '\x2', 
		'\x19', '\xAE', '\x3', '\x2', '\x2', '\x2', '\x1B', '\xB2', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', '\xB5', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xBC', 
		'\x3', '\x2', '\x2', '\x2', '!', '\xC2', '\x3', '\x2', '\x2', '\x2', '#', 
		'\xC9', '\x3', '\x2', '\x2', '\x2', '%', '\xD0', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\xD5', '\x3', '\x2', '\x2', '\x2', ')', '\xD9', '\x3', '\x2', 
		'\x2', '\x2', '+', '\xDB', '\x3', '\x2', '\x2', '\x2', '-', '\xDD', '\x3', 
		'\x2', '\x2', '\x2', '/', '\xDF', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\xE1', '\x3', '\x2', '\x2', '\x2', '\x33', '\xE3', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\xE5', '\x3', '\x2', '\x2', '\x2', '\x37', '\xE7', '\x3', 
		'\x2', '\x2', '\x2', '\x39', '\xE9', '\x3', '\x2', '\x2', '\x2', ';', 
		'\xEB', '\x3', '\x2', '\x2', '\x2', '=', '\xED', '\x3', '\x2', '\x2', 
		'\x2', '?', '\xEF', '\x3', '\x2', '\x2', '\x2', '\x41', '\xF1', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\xF4', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\xF7', '\x3', '\x2', '\x2', '\x2', 'G', '\xF9', '\x3', '\x2', '\x2', 
		'\x2', 'I', '\xFC', '\x3', '\x2', '\x2', '\x2', 'K', '\xFE', '\x3', '\x2', 
		'\x2', '\x2', 'M', '\x101', '\x3', '\x2', '\x2', '\x2', 'O', '\x103', 
		'\x3', '\x2', '\x2', '\x2', 'Q', '\x105', '\x3', '\x2', '\x2', '\x2', 
		'S', '\x107', '\x3', '\x2', '\x2', '\x2', 'U', '\x109', '\x3', '\x2', 
		'\x2', '\x2', 'W', '\x10B', '\x3', '\x2', '\x2', '\x2', 'Y', '\x10D', 
		'\x3', '\x2', '\x2', '\x2', '[', '\x10F', '\x3', '\x2', '\x2', '\x2', 
		']', '\x111', '\x3', '\x2', '\x2', '\x2', '_', '\x119', '\x3', '\x2', 
		'\x2', '\x2', '\x61', '\x124', '\x3', '\x2', '\x2', '\x2', '\x63', '\x12D', 
		'\x3', '\x2', '\x2', '\x2', '\x65', '\x12F', '\x3', '\x2', '\x2', '\x2', 
		'g', '\x131', '\x3', '\x2', '\x2', '\x2', 'i', '\x133', '\x3', '\x2', 
		'\x2', '\x2', 'k', '\x137', '\x3', '\x2', '\x2', '\x2', 'm', '\x13A', 
		'\x3', '\x2', '\x2', '\x2', 'o', '\x13E', '\x3', '\x2', '\x2', '\x2', 
		'q', '\x144', '\x3', '\x2', '\x2', '\x2', 's', '\x14B', '\x3', '\x2', 
		'\x2', '\x2', 'u', '\x14D', '\x3', '\x2', '\x2', '\x2', 'w', '\x153', 
		'\x3', '\x2', '\x2', '\x2', 'y', '\x158', '\x3', '\x2', '\x2', '\x2', 
		'{', '|', '\a', '\f', '\x2', '\x2', '|', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'}', '\x7F', '\t', '\x2', '\x2', '\x2', '~', '}', '\x3', '\x2', '\x2', 
		'\x2', '\x7F', '\x80', '\x3', '\x2', '\x2', '\x2', '\x80', '~', '\x3', 
		'\x2', '\x2', '\x2', '\x80', '\x81', '\x3', '\x2', '\x2', '\x2', '\x81', 
		'\x82', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\b', '\x3', '\x2', 
		'\x2', '\x83', '\x6', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', 
		'v', '\x2', '\x2', '\x85', '\x86', '\a', 't', '\x2', '\x2', '\x86', '\x87', 
		'\a', 'w', '\x2', '\x2', '\x87', '\x88', '\a', 'g', '\x2', '\x2', '\x88', 
		'\b', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', '\a', 'h', '\x2', '\x2', 
		'\x8A', '\x8B', '\a', '\x63', '\x2', '\x2', '\x8B', '\x8C', '\a', 'n', 
		'\x2', '\x2', '\x8C', '\x8D', '\a', 'u', '\x2', '\x2', '\x8D', '\x8E', 
		'\a', 'g', '\x2', '\x2', '\x8E', '\n', '\x3', '\x2', '\x2', '\x2', '\x8F', 
		'\x90', '\a', 'k', '\x2', '\x2', '\x90', '\x91', '\a', 'h', '\x2', '\x2', 
		'\x91', '\f', '\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\a', 'v', '\x2', 
		'\x2', '\x93', '\x94', '\a', 'j', '\x2', '\x2', '\x94', '\x95', '\a', 
		'g', '\x2', '\x2', '\x95', '\x96', '\a', 'p', '\x2', '\x2', '\x96', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x97', '\x98', '\a', 'g', '\x2', '\x2', '\x98', 
		'\x99', '\a', 'n', '\x2', '\x2', '\x99', '\x9A', '\a', 'u', '\x2', '\x2', 
		'\x9A', '\x9B', '\a', 'g', '\x2', '\x2', '\x9B', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\x9C', '\x9D', '\a', 'h', '\x2', '\x2', '\x9D', '\x9E', 
		'\a', 'q', '\x2', '\x2', '\x9E', '\x9F', '\a', 't', '\x2', '\x2', '\x9F', 
		'\x12', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\a', 'k', '\x2', 
		'\x2', '\xA1', '\xA2', '\a', 'p', '\x2', '\x2', '\xA2', '\x14', '\x3', 
		'\x2', '\x2', '\x2', '\xA3', '\xA4', '\a', 't', '\x2', '\x2', '\xA4', 
		'\xA5', '\a', 'g', '\x2', '\x2', '\xA5', '\xA6', '\a', 'v', '\x2', '\x2', 
		'\xA6', '\xA7', '\a', 'w', '\x2', '\x2', '\xA7', '\xA8', '\a', 't', '\x2', 
		'\x2', '\xA8', '\xA9', '\a', 'p', '\x2', '\x2', '\xA9', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '\xAA', '\xAB', '\a', 'n', '\x2', '\x2', '\xAB', 
		'\xAC', '\a', 'g', '\x2', '\x2', '\xAC', '\xAD', '\a', 'v', '\x2', '\x2', 
		'\xAD', '\x18', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', '\a', 'h', 
		'\x2', '\x2', '\xAF', '\xB0', '\a', 'w', '\x2', '\x2', '\xB0', '\xB1', 
		'\a', 'p', '\x2', '\x2', '\xB1', '\x1A', '\x3', '\x2', '\x2', '\x2', '\xB2', 
		'\xB3', '\a', 'k', '\x2', '\x2', '\xB3', '\xB4', '\a', 'u', '\x2', '\x2', 
		'\xB4', '\x1C', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\a', 'q', 
		'\x2', '\x2', '\xB6', '\xB7', '\a', '\x64', '\x2', '\x2', '\xB7', '\xB8', 
		'\a', 'l', '\x2', '\x2', '\xB8', '\xB9', '\a', 'g', '\x2', '\x2', '\xB9', 
		'\xBA', '\a', '\x65', '\x2', '\x2', '\xBA', '\xBB', '\a', 'v', '\x2', 
		'\x2', '\xBB', '\x1E', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\a', 
		'\x63', '\x2', '\x2', '\xBD', '\xBE', '\a', 't', '\x2', '\x2', '\xBE', 
		'\xBF', '\a', 't', '\x2', '\x2', '\xBF', '\xC0', '\a', '\x63', '\x2', 
		'\x2', '\xC0', '\xC1', '\a', '{', '\x2', '\x2', '\xC1', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\xC2', '\xC3', '\a', 'p', '\x2', '\x2', '\xC3', '\xC4', 
		'\a', 'w', '\x2', '\x2', '\xC4', '\xC5', '\a', 'o', '\x2', '\x2', '\xC5', 
		'\xC6', '\a', '\x64', '\x2', '\x2', '\xC6', '\xC7', '\a', 'g', '\x2', 
		'\x2', '\xC7', '\xC8', '\a', 't', '\x2', '\x2', '\xC8', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\xC9', '\xCA', '\a', 'u', '\x2', '\x2', '\xCA', '\xCB', 
		'\a', 'v', '\x2', '\x2', '\xCB', '\xCC', '\a', 't', '\x2', '\x2', '\xCC', 
		'\xCD', '\a', 'k', '\x2', '\x2', '\xCD', '\xCE', '\a', 'p', '\x2', '\x2', 
		'\xCE', '\xCF', '\a', 'i', '\x2', '\x2', '\xCF', '$', '\x3', '\x2', '\x2', 
		'\x2', '\xD0', '\xD1', '\a', '\x64', '\x2', '\x2', '\xD1', '\xD2', '\a', 
		'q', '\x2', '\x2', '\xD2', '\xD3', '\a', 'q', '\x2', '\x2', '\xD3', '\xD4', 
		'\a', 'n', '\x2', '\x2', '\xD4', '&', '\x3', '\x2', '\x2', '\x2', '\xD5', 
		'\xD6', '\a', '\x63', '\x2', '\x2', '\xD6', '\xD7', '\a', 'p', '\x2', 
		'\x2', '\xD7', '\xD8', '\a', '{', '\x2', '\x2', '\xD8', '(', '\x3', '\x2', 
		'\x2', '\x2', '\xD9', '\xDA', '\a', ']', '\x2', '\x2', '\xDA', '*', '\x3', 
		'\x2', '\x2', '\x2', '\xDB', '\xDC', '\a', '_', '\x2', '\x2', '\xDC', 
		',', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', '\a', '}', '\x2', '\x2', 
		'\xDE', '.', '\x3', '\x2', '\x2', '\x2', '\xDF', '\xE0', '\a', '\x7F', 
		'\x2', '\x2', '\xE0', '\x30', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', 
		'\a', '*', '\x2', '\x2', '\xE2', '\x32', '\x3', '\x2', '\x2', '\x2', '\xE3', 
		'\xE4', '\a', '+', '\x2', '\x2', '\xE4', '\x34', '\x3', '\x2', '\x2', 
		'\x2', '\xE5', '\xE6', '\a', '\x30', '\x2', '\x2', '\xE6', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\xE7', '\xE8', '\a', '.', '\x2', '\x2', '\xE8', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\a', '$', '\x2', 
		'\x2', '\xEA', ':', '\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\a', 
		'<', '\x2', '\x2', '\xEC', '<', '\x3', '\x2', '\x2', '\x2', '\xED', '\xEE', 
		'\a', '&', '\x2', '\x2', '\xEE', '>', '\x3', '\x2', '\x2', '\x2', '\xEF', 
		'\xF0', '\a', '?', '\x2', '\x2', '\xF0', '@', '\x3', '\x2', '\x2', '\x2', 
		'\xF1', '\xF2', '\a', '?', '\x2', '\x2', '\xF2', '\xF3', '\a', '?', '\x2', 
		'\x2', '\xF3', '\x42', '\x3', '\x2', '\x2', '\x2', '\xF4', '\xF5', '\a', 
		'#', '\x2', '\x2', '\xF5', '\xF6', '\a', '?', '\x2', '\x2', '\xF6', '\x44', 
		'\x3', '\x2', '\x2', '\x2', '\xF7', '\xF8', '\a', '>', '\x2', '\x2', '\xF8', 
		'\x46', '\x3', '\x2', '\x2', '\x2', '\xF9', '\xFA', '\a', '>', '\x2', 
		'\x2', '\xFA', '\xFB', '\a', '?', '\x2', '\x2', '\xFB', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\xFC', '\xFD', '\a', '@', '\x2', '\x2', '\xFD', 'J', '\x3', 
		'\x2', '\x2', '\x2', '\xFE', '\xFF', '\a', '@', '\x2', '\x2', '\xFF', 
		'\x100', '\a', '?', '\x2', '\x2', '\x100', 'L', '\x3', '\x2', '\x2', '\x2', 
		'\x101', '\x102', '\a', '#', '\x2', '\x2', '\x102', 'N', '\x3', '\x2', 
		'\x2', '\x2', '\x103', '\x104', '\a', '~', '\x2', '\x2', '\x104', 'P', 
		'\x3', '\x2', '\x2', '\x2', '\x105', '\x106', '\a', '(', '\x2', '\x2', 
		'\x106', 'R', '\x3', '\x2', '\x2', '\x2', '\x107', '\x108', '\a', '-', 
		'\x2', '\x2', '\x108', 'T', '\x3', '\x2', '\x2', '\x2', '\x109', '\x10A', 
		'\a', '/', '\x2', '\x2', '\x10A', 'V', '\x3', '\x2', '\x2', '\x2', '\x10B', 
		'\x10C', '\a', '\x31', '\x2', '\x2', '\x10C', 'X', '\x3', '\x2', '\x2', 
		'\x2', '\x10D', '\x10E', '\a', ',', '\x2', '\x2', '\x10E', 'Z', '\x3', 
		'\x2', '\x2', '\x2', '\x10F', '\x110', '\a', '\'', '\x2', '\x2', '\x110', 
		'\\', '\x3', '\x2', '\x2', '\x2', '\x111', '\x116', '\x5', '\x63', '\x32', 
		'\x2', '\x112', '\x115', '\x5', '\x63', '\x32', '\x2', '\x113', '\x115', 
		'\x5', '\x65', '\x33', '\x2', '\x114', '\x112', '\x3', '\x2', '\x2', '\x2', 
		'\x114', '\x113', '\x3', '\x2', '\x2', '\x2', '\x115', '\x118', '\x3', 
		'\x2', '\x2', '\x2', '\x116', '\x114', '\x3', '\x2', '\x2', '\x2', '\x116', 
		'\x117', '\x3', '\x2', '\x2', '\x2', '\x117', '^', '\x3', '\x2', '\x2', 
		'\x2', '\x118', '\x116', '\x3', '\x2', '\x2', '\x2', '\x119', '\x11E', 
		'\x5', '\x39', '\x1D', '\x2', '\x11A', '\x11D', '\x5', 'w', '<', '\x2', 
		'\x11B', '\x11D', '\x5', 'y', '=', '\x2', '\x11C', '\x11A', '\x3', '\x2', 
		'\x2', '\x2', '\x11C', '\x11B', '\x3', '\x2', '\x2', '\x2', '\x11D', '\x120', 
		'\x3', '\x2', '\x2', '\x2', '\x11E', '\x11C', '\x3', '\x2', '\x2', '\x2', 
		'\x11E', '\x11F', '\x3', '\x2', '\x2', '\x2', '\x11F', '\x121', '\x3', 
		'\x2', '\x2', '\x2', '\x120', '\x11E', '\x3', '\x2', '\x2', '\x2', '\x121', 
		'\x122', '\x5', '\x39', '\x1D', '\x2', '\x122', '`', '\x3', '\x2', '\x2', 
		'\x2', '\x123', '\x125', '\x5', 'U', '+', '\x2', '\x124', '\x123', '\x3', 
		'\x2', '\x2', '\x2', '\x124', '\x125', '\x3', '\x2', '\x2', '\x2', '\x125', 
		'\x126', '\x3', '\x2', '\x2', '\x2', '\x126', '\x128', '\x5', 'm', '\x37', 
		'\x2', '\x127', '\x129', '\x5', 'o', '\x38', '\x2', '\x128', '\x127', 
		'\x3', '\x2', '\x2', '\x2', '\x128', '\x129', '\x3', '\x2', '\x2', '\x2', 
		'\x129', '\x12B', '\x3', '\x2', '\x2', '\x2', '\x12A', '\x12C', '\x5', 
		'q', '\x39', '\x2', '\x12B', '\x12A', '\x3', '\x2', '\x2', '\x2', '\x12B', 
		'\x12C', '\x3', '\x2', '\x2', '\x2', '\x12C', '\x62', '\x3', '\x2', '\x2', 
		'\x2', '\x12D', '\x12E', '\t', '\x3', '\x2', '\x2', '\x12E', '\x64', '\x3', 
		'\x2', '\x2', '\x2', '\x12F', '\x130', '\t', '\x4', '\x2', '\x2', '\x130', 
		'\x66', '\x3', '\x2', '\x2', '\x2', '\x131', '\x132', '\t', '\x5', '\x2', 
		'\x2', '\x132', 'h', '\x3', '\x2', '\x2', '\x2', '\x133', '\x134', '\a', 
		'\x32', '\x2', '\x2', '\x134', 'j', '\x3', '\x2', '\x2', '\x2', '\x135', 
		'\x138', '\x5', 'S', '*', '\x2', '\x136', '\x138', '\x5', 'U', '+', '\x2', 
		'\x137', '\x135', '\x3', '\x2', '\x2', '\x2', '\x137', '\x136', '\x3', 
		'\x2', '\x2', '\x2', '\x138', 'l', '\x3', '\x2', '\x2', '\x2', '\x139', 
		'\x13B', '\x5', '\x65', '\x33', '\x2', '\x13A', '\x139', '\x3', '\x2', 
		'\x2', '\x2', '\x13B', '\x13C', '\x3', '\x2', '\x2', '\x2', '\x13C', '\x13A', 
		'\x3', '\x2', '\x2', '\x2', '\x13C', '\x13D', '\x3', '\x2', '\x2', '\x2', 
		'\x13D', 'n', '\x3', '\x2', '\x2', '\x2', '\x13E', '\x140', '\x5', '\x35', 
		'\x1B', '\x2', '\x13F', '\x141', '\x5', '\x65', '\x33', '\x2', '\x140', 
		'\x13F', '\x3', '\x2', '\x2', '\x2', '\x141', '\x142', '\x3', '\x2', '\x2', 
		'\x2', '\x142', '\x140', '\x3', '\x2', '\x2', '\x2', '\x142', '\x143', 
		'\x3', '\x2', '\x2', '\x2', '\x143', 'p', '\x3', '\x2', '\x2', '\x2', 
		'\x144', '\x146', '\t', '\x6', '\x2', '\x2', '\x145', '\x147', '\x5', 
		'k', '\x36', '\x2', '\x146', '\x145', '\x3', '\x2', '\x2', '\x2', '\x146', 
		'\x147', '\x3', '\x2', '\x2', '\x2', '\x147', '\x149', '\x3', '\x2', '\x2', 
		'\x2', '\x148', '\x14A', '\x5', 'm', '\x37', '\x2', '\x149', '\x148', 
		'\x3', '\x2', '\x2', '\x2', '\x149', '\x14A', '\x3', '\x2', '\x2', '\x2', 
		'\x14A', 'r', '\x3', '\x2', '\x2', '\x2', '\x14B', '\x14C', '\t', '\a', 
		'\x2', '\x2', '\x14C', 't', '\x3', '\x2', '\x2', '\x2', '\x14D', '\x14E', 
		'\a', 'w', '\x2', '\x2', '\x14E', '\x14F', '\x5', 's', ':', '\x2', '\x14F', 
		'\x150', '\x5', 's', ':', '\x2', '\x150', '\x151', '\x5', 's', ':', '\x2', 
		'\x151', '\x152', '\x5', 's', ':', '\x2', '\x152', 'v', '\x3', '\x2', 
		'\x2', '\x2', '\x153', '\x156', '\a', '^', '\x2', '\x2', '\x154', '\x157', 
		'\t', '\b', '\x2', '\x2', '\x155', '\x157', '\x5', 'u', ';', '\x2', '\x156', 
		'\x154', '\x3', '\x2', '\x2', '\x2', '\x156', '\x155', '\x3', '\x2', '\x2', 
		'\x2', '\x157', 'x', '\x3', '\x2', '\x2', '\x2', '\x158', '\x159', '\n', 
		'\t', '\x2', '\x2', '\x159', 'z', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x2', '\x80', '\x114', '\x116', '\x11C', '\x11E', '\x124', '\x128', '\x12B', 
		'\x137', '\x13C', '\x142', '\x146', '\x149', '\x156', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Skell.Generated
