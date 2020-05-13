//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Shell.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Shell.Generated {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
public partial class ShellLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		EOL=1, WS=2, KW_TRUE=3, KW_FALSE=4, KW_IF=5, KW_ELSE=6, KW_FOR=7, KW_IN=8, 
		KW_RETURN=9, KW_LET=10, KW_FUN=11, KW_IS=12, KW_NAMESPACE=13, KW_USING=14, 
		KW_AS=15, TYPE_OBJECT=16, TYPE_ARRAY=17, TYPE_NUMBER=18, TYPE_STRING=19, 
		TYPE_BOOL=20, TYPE_ANY=21, TYPE_NULL=22, LSQR=23, RSQR=24, LCURL=25, RCURL=26, 
		LPAREN=27, RPAREN=28, SYM_PERIOD=29, SYM_COMMA=30, SYM_QUOTE=31, SYM_COLON=32, 
		SYM_DOLLAR=33, OP_ASSGN=34, OP_EQ=35, OP_NE=36, OP_LT=37, OP_LE=38, OP_GT=39, 
		OP_GE=40, OP_NOT=41, OP_OR=42, OP_AND=43, OP_ADD=44, OP_SUB=45, OP_DIV=46, 
		OP_MUL=47, OP_MOD=48, IDENTIFIER=49, STRING=50, NUMBER=51, NONDIGIT=52, 
		DIGIT=53, NONZERO_DIGIT=54, ZERO=55, SIGN=56, INT=57, FRAC=58, EXP=59, 
		HEX=60, UNICODE=61, ESC=62, SAFECODEPOINT=63;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"EOL", "WS", "KW_TRUE", "KW_FALSE", "KW_IF", "KW_ELSE", "KW_FOR", "KW_IN", 
		"KW_RETURN", "KW_LET", "KW_FUN", "KW_IS", "KW_NAMESPACE", "KW_USING", 
		"KW_AS", "TYPE_OBJECT", "TYPE_ARRAY", "TYPE_NUMBER", "TYPE_STRING", "TYPE_BOOL", 
		"TYPE_ANY", "TYPE_NULL", "LSQR", "RSQR", "LCURL", "RCURL", "LPAREN", "RPAREN", 
		"SYM_PERIOD", "SYM_COMMA", "SYM_QUOTE", "SYM_COLON", "SYM_DOLLAR", "OP_ASSGN", 
		"OP_EQ", "OP_NE", "OP_LT", "OP_LE", "OP_GT", "OP_GE", "OP_NOT", "OP_OR", 
		"OP_AND", "OP_ADD", "OP_SUB", "OP_DIV", "OP_MUL", "OP_MOD", "IDENTIFIER", 
		"STRING", "NUMBER", "NONDIGIT", "DIGIT", "NONZERO_DIGIT", "ZERO", "SIGN", 
		"INT", "FRAC", "EXP", "HEX", "UNICODE", "ESC", "SAFECODEPOINT"
	};


	public ShellLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ShellLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'\n'", null, "'true'", "'false'", "'if'", "'else'", "'for'", "'in'", 
		"'return'", "'let'", "'fun'", "'is'", "'namespace'", "'using'", "'as'", 
		"'object'", "'array'", "'number'", "'string'", "'bool'", "'any'", "'null'", 
		"'['", "']'", "'{'", "'}'", "'('", "')'", "'.'", "','", "'\"'", "':'", 
		"'$'", "'='", "'=='", "'!='", "'<'", "'<='", "'>'", "'>='", "'!'", "'|'", 
		"'&'", "'+'", "'-'", "'/'", "'*'", "'%'", null, null, null, null, null, 
		null, "'0'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "EOL", "WS", "KW_TRUE", "KW_FALSE", "KW_IF", "KW_ELSE", "KW_FOR", 
		"KW_IN", "KW_RETURN", "KW_LET", "KW_FUN", "KW_IS", "KW_NAMESPACE", "KW_USING", 
		"KW_AS", "TYPE_OBJECT", "TYPE_ARRAY", "TYPE_NUMBER", "TYPE_STRING", "TYPE_BOOL", 
		"TYPE_ANY", "TYPE_NULL", "LSQR", "RSQR", "LCURL", "RCURL", "LPAREN", "RPAREN", 
		"SYM_PERIOD", "SYM_COMMA", "SYM_QUOTE", "SYM_COLON", "SYM_DOLLAR", "OP_ASSGN", 
		"OP_EQ", "OP_NE", "OP_LT", "OP_LE", "OP_GT", "OP_GE", "OP_NOT", "OP_OR", 
		"OP_AND", "OP_ADD", "OP_SUB", "OP_DIV", "OP_MUL", "OP_MOD", "IDENTIFIER", 
		"STRING", "NUMBER", "NONDIGIT", "DIGIT", "NONZERO_DIGIT", "ZERO", "SIGN", 
		"INT", "FRAC", "EXP", "HEX", "UNICODE", "ESC", "SAFECODEPOINT"
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

	public override string GrammarFileName { get { return "Shell.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ShellLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x41', '\x17D', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
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
		'=', '\t', '=', '\x4', '>', '\t', '>', '\x4', '?', '\t', '?', '\x4', '@', 
		'\t', '@', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x6', '\x3', '\x85', 
		'\n', '\x3', '\r', '\x3', '\xE', '\x3', '\x86', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', 
		'\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', 
		'\x3', '$', '\x3', '%', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', '&', 
		'\x3', '\'', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', '\x3', 
		')', '\x3', ')', '\x3', ')', '\x3', '*', '\x3', '*', '\x3', '+', '\x3', 
		'+', '\x3', ',', '\x3', ',', '\x3', '-', '\x3', '-', '\x3', '.', '\x3', 
		'.', '\x3', '/', '\x3', '/', '\x3', '\x30', '\x3', '\x30', '\x3', '\x31', 
		'\x3', '\x31', '\x3', '\x32', '\x3', '\x32', '\x3', '\x32', '\a', '\x32', 
		'\x12E', '\n', '\x32', '\f', '\x32', '\xE', '\x32', '\x131', '\v', '\x32', 
		'\x3', '\x33', '\x3', '\x33', '\x3', '\x33', '\x3', '\x33', '\x3', '\x33', 
		'\x3', '\x33', '\a', '\x33', '\x139', '\n', '\x33', '\f', '\x33', '\xE', 
		'\x33', '\x13C', '\v', '\x33', '\x3', '\x33', '\x3', '\x33', '\a', '\x33', 
		'\x140', '\n', '\x33', '\f', '\x33', '\xE', '\x33', '\x143', '\v', '\x33', 
		'\x3', '\x33', '\x3', '\x33', '\x3', '\x34', '\x5', '\x34', '\x148', '\n', 
		'\x34', '\x3', '\x34', '\x3', '\x34', '\x5', '\x34', '\x14C', '\n', '\x34', 
		'\x3', '\x34', '\x5', '\x34', '\x14F', '\n', '\x34', '\x3', '\x35', '\x3', 
		'\x35', '\x3', '\x36', '\x3', '\x36', '\x3', '\x37', '\x3', '\x37', '\x3', 
		'\x38', '\x3', '\x38', '\x3', '\x39', '\x3', '\x39', '\x5', '\x39', '\x15B', 
		'\n', '\x39', '\x3', ':', '\x6', ':', '\x15E', '\n', ':', '\r', ':', '\xE', 
		':', '\x15F', '\x3', ';', '\x3', ';', '\x6', ';', '\x164', '\n', ';', 
		'\r', ';', '\xE', ';', '\x165', '\x3', '<', '\x3', '<', '\x5', '<', '\x16A', 
		'\n', '<', '\x3', '<', '\x5', '<', '\x16D', '\n', '<', '\x3', '=', '\x3', 
		'=', '\x3', '>', '\x3', '>', '\x3', '>', '\x3', '>', '\x3', '>', '\x3', 
		'>', '\x3', '?', '\x3', '?', '\x3', '?', '\x5', '?', '\x17A', '\n', '?', 
		'\x3', '@', '\x3', '@', '\x2', '\x2', '\x41', '\x3', '\x3', '\x5', '\x4', 
		'\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', 
		'\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', 
		'\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', 
		'\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', '\x19', 
		'\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', '\x39', 
		'\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', '#', '\x45', 
		'$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', '*', 'S', 
		'+', 'U', ',', 'W', '-', 'Y', '.', '[', '/', ']', '\x30', '_', '\x31', 
		'\x61', '\x32', '\x63', '\x33', '\x65', '\x34', 'g', '\x35', 'i', '\x36', 
		'k', '\x37', 'm', '\x38', 'o', '\x39', 'q', ':', 's', ';', 'u', '<', 'w', 
		'=', 'y', '>', '{', '?', '}', '@', '\x7F', '\x41', '\x3', '\x2', '\v', 
		'\x5', '\x2', '\v', '\v', '\xF', '\xF', '\"', '\"', '\x3', '\x2', '\x7F', 
		'\x7F', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x3', 
		'\x2', '\x32', ';', '\x3', '\x2', '\x33', ';', '\x4', '\x2', 'G', 'G', 
		'g', 'g', '\x5', '\x2', '\x32', ';', '\x43', 'H', '\x63', 'h', '\n', '\x2', 
		'$', '$', '\x31', '\x31', '^', '^', '\x64', '\x64', 'h', 'h', 'p', 'p', 
		't', 't', 'v', 'v', '\x5', '\x2', '\x2', '!', '$', '$', '^', '^', '\x2', 
		'\x18C', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2', '\x2', 'S', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'U', '\x3', '\x2', '\x2', '\x2', '\x2', 'W', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'Y', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'[', '\x3', '\x2', '\x2', '\x2', '\x2', ']', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '_', '\x3', '\x2', '\x2', '\x2', '\x2', '\x61', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x63', '\x3', '\x2', '\x2', '\x2', '\x2', '\x65', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'g', '\x3', '\x2', '\x2', '\x2', '\x2', 'i', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'k', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'm', '\x3', '\x2', '\x2', '\x2', '\x2', 'o', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'q', '\x3', '\x2', '\x2', '\x2', '\x2', 's', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'u', '\x3', '\x2', '\x2', '\x2', '\x2', 'w', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'y', '\x3', '\x2', '\x2', '\x2', '\x2', '{', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '}', '\x3', '\x2', '\x2', '\x2', '\x2', '\x7F', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x81', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '\x84', '\x3', '\x2', '\x2', '\x2', '\a', '\x8A', '\x3', '\x2', 
		'\x2', '\x2', '\t', '\x8F', '\x3', '\x2', '\x2', '\x2', '\v', '\x95', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\x98', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x11', '\xA1', '\x3', '\x2', 
		'\x2', '\x2', '\x13', '\xA4', '\x3', '\x2', '\x2', '\x2', '\x15', '\xAB', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\xAF', '\x3', '\x2', '\x2', '\x2', 
		'\x19', '\xB3', '\x3', '\x2', '\x2', '\x2', '\x1B', '\xB6', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', '\xC0', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xC6', 
		'\x3', '\x2', '\x2', '\x2', '!', '\xC9', '\x3', '\x2', '\x2', '\x2', '#', 
		'\xD0', '\x3', '\x2', '\x2', '\x2', '%', '\xD6', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\xDD', '\x3', '\x2', '\x2', '\x2', ')', '\xE4', '\x3', '\x2', 
		'\x2', '\x2', '+', '\xE9', '\x3', '\x2', '\x2', '\x2', '-', '\xED', '\x3', 
		'\x2', '\x2', '\x2', '/', '\xF2', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\xF4', '\x3', '\x2', '\x2', '\x2', '\x33', '\xF6', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\xF8', '\x3', '\x2', '\x2', '\x2', '\x37', '\xFA', '\x3', 
		'\x2', '\x2', '\x2', '\x39', '\xFC', '\x3', '\x2', '\x2', '\x2', ';', 
		'\xFE', '\x3', '\x2', '\x2', '\x2', '=', '\x100', '\x3', '\x2', '\x2', 
		'\x2', '?', '\x102', '\x3', '\x2', '\x2', '\x2', '\x41', '\x104', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\x106', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\x108', '\x3', '\x2', '\x2', '\x2', 'G', '\x10A', '\x3', '\x2', '\x2', 
		'\x2', 'I', '\x10D', '\x3', '\x2', '\x2', '\x2', 'K', '\x110', '\x3', 
		'\x2', '\x2', '\x2', 'M', '\x112', '\x3', '\x2', '\x2', '\x2', 'O', '\x115', 
		'\x3', '\x2', '\x2', '\x2', 'Q', '\x117', '\x3', '\x2', '\x2', '\x2', 
		'S', '\x11A', '\x3', '\x2', '\x2', '\x2', 'U', '\x11C', '\x3', '\x2', 
		'\x2', '\x2', 'W', '\x11E', '\x3', '\x2', '\x2', '\x2', 'Y', '\x120', 
		'\x3', '\x2', '\x2', '\x2', '[', '\x122', '\x3', '\x2', '\x2', '\x2', 
		']', '\x124', '\x3', '\x2', '\x2', '\x2', '_', '\x126', '\x3', '\x2', 
		'\x2', '\x2', '\x61', '\x128', '\x3', '\x2', '\x2', '\x2', '\x63', '\x12A', 
		'\x3', '\x2', '\x2', '\x2', '\x65', '\x132', '\x3', '\x2', '\x2', '\x2', 
		'g', '\x147', '\x3', '\x2', '\x2', '\x2', 'i', '\x150', '\x3', '\x2', 
		'\x2', '\x2', 'k', '\x152', '\x3', '\x2', '\x2', '\x2', 'm', '\x154', 
		'\x3', '\x2', '\x2', '\x2', 'o', '\x156', '\x3', '\x2', '\x2', '\x2', 
		'q', '\x15A', '\x3', '\x2', '\x2', '\x2', 's', '\x15D', '\x3', '\x2', 
		'\x2', '\x2', 'u', '\x161', '\x3', '\x2', '\x2', '\x2', 'w', '\x167', 
		'\x3', '\x2', '\x2', '\x2', 'y', '\x16E', '\x3', '\x2', '\x2', '\x2', 
		'{', '\x170', '\x3', '\x2', '\x2', '\x2', '}', '\x176', '\x3', '\x2', 
		'\x2', '\x2', '\x7F', '\x17B', '\x3', '\x2', '\x2', '\x2', '\x81', '\x82', 
		'\a', '\f', '\x2', '\x2', '\x82', '\x4', '\x3', '\x2', '\x2', '\x2', '\x83', 
		'\x85', '\t', '\x2', '\x2', '\x2', '\x84', '\x83', '\x3', '\x2', '\x2', 
		'\x2', '\x85', '\x86', '\x3', '\x2', '\x2', '\x2', '\x86', '\x84', '\x3', 
		'\x2', '\x2', '\x2', '\x86', '\x87', '\x3', '\x2', '\x2', '\x2', '\x87', 
		'\x88', '\x3', '\x2', '\x2', '\x2', '\x88', '\x89', '\b', '\x3', '\x2', 
		'\x2', '\x89', '\x6', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x8B', '\a', 
		'v', '\x2', '\x2', '\x8B', '\x8C', '\a', 't', '\x2', '\x2', '\x8C', '\x8D', 
		'\a', 'w', '\x2', '\x2', '\x8D', '\x8E', '\a', 'g', '\x2', '\x2', '\x8E', 
		'\b', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\a', 'h', '\x2', '\x2', 
		'\x90', '\x91', '\a', '\x63', '\x2', '\x2', '\x91', '\x92', '\a', 'n', 
		'\x2', '\x2', '\x92', '\x93', '\a', 'u', '\x2', '\x2', '\x93', '\x94', 
		'\a', 'g', '\x2', '\x2', '\x94', '\n', '\x3', '\x2', '\x2', '\x2', '\x95', 
		'\x96', '\a', 'k', '\x2', '\x2', '\x96', '\x97', '\a', 'h', '\x2', '\x2', 
		'\x97', '\f', '\x3', '\x2', '\x2', '\x2', '\x98', '\x99', '\a', 'g', '\x2', 
		'\x2', '\x99', '\x9A', '\a', 'n', '\x2', '\x2', '\x9A', '\x9B', '\a', 
		'u', '\x2', '\x2', '\x9B', '\x9C', '\a', 'g', '\x2', '\x2', '\x9C', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\a', 'h', '\x2', '\x2', '\x9E', 
		'\x9F', '\a', 'q', '\x2', '\x2', '\x9F', '\xA0', '\a', 't', '\x2', '\x2', 
		'\xA0', '\x10', '\x3', '\x2', '\x2', '\x2', '\xA1', '\xA2', '\a', 'k', 
		'\x2', '\x2', '\xA2', '\xA3', '\a', 'p', '\x2', '\x2', '\xA3', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '\xA4', '\xA5', '\a', 't', '\x2', '\x2', '\xA5', 
		'\xA6', '\a', 'g', '\x2', '\x2', '\xA6', '\xA7', '\a', 'v', '\x2', '\x2', 
		'\xA7', '\xA8', '\a', 'w', '\x2', '\x2', '\xA8', '\xA9', '\a', 't', '\x2', 
		'\x2', '\xA9', '\xAA', '\a', 'p', '\x2', '\x2', '\xAA', '\x14', '\x3', 
		'\x2', '\x2', '\x2', '\xAB', '\xAC', '\a', 'n', '\x2', '\x2', '\xAC', 
		'\xAD', '\a', 'g', '\x2', '\x2', '\xAD', '\xAE', '\a', 'v', '\x2', '\x2', 
		'\xAE', '\x16', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xB0', '\a', 'h', 
		'\x2', '\x2', '\xB0', '\xB1', '\a', 'w', '\x2', '\x2', '\xB1', '\xB2', 
		'\a', 'p', '\x2', '\x2', '\xB2', '\x18', '\x3', '\x2', '\x2', '\x2', '\xB3', 
		'\xB4', '\a', 'k', '\x2', '\x2', '\xB4', '\xB5', '\a', 'u', '\x2', '\x2', 
		'\xB5', '\x1A', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xB7', '\a', 'p', 
		'\x2', '\x2', '\xB7', '\xB8', '\a', '\x63', '\x2', '\x2', '\xB8', '\xB9', 
		'\a', 'o', '\x2', '\x2', '\xB9', '\xBA', '\a', 'g', '\x2', '\x2', '\xBA', 
		'\xBB', '\a', 'u', '\x2', '\x2', '\xBB', '\xBC', '\a', 'r', '\x2', '\x2', 
		'\xBC', '\xBD', '\a', '\x63', '\x2', '\x2', '\xBD', '\xBE', '\a', '\x65', 
		'\x2', '\x2', '\xBE', '\xBF', '\a', 'g', '\x2', '\x2', '\xBF', '\x1C', 
		'\x3', '\x2', '\x2', '\x2', '\xC0', '\xC1', '\a', 'w', '\x2', '\x2', '\xC1', 
		'\xC2', '\a', 'u', '\x2', '\x2', '\xC2', '\xC3', '\a', 'k', '\x2', '\x2', 
		'\xC3', '\xC4', '\a', 'p', '\x2', '\x2', '\xC4', '\xC5', '\a', 'i', '\x2', 
		'\x2', '\xC5', '\x1E', '\x3', '\x2', '\x2', '\x2', '\xC6', '\xC7', '\a', 
		'\x63', '\x2', '\x2', '\xC7', '\xC8', '\a', 'u', '\x2', '\x2', '\xC8', 
		' ', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\a', 'q', '\x2', '\x2', 
		'\xCA', '\xCB', '\a', '\x64', '\x2', '\x2', '\xCB', '\xCC', '\a', 'l', 
		'\x2', '\x2', '\xCC', '\xCD', '\a', 'g', '\x2', '\x2', '\xCD', '\xCE', 
		'\a', '\x65', '\x2', '\x2', '\xCE', '\xCF', '\a', 'v', '\x2', '\x2', '\xCF', 
		'\"', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD1', '\a', '\x63', '\x2', 
		'\x2', '\xD1', '\xD2', '\a', 't', '\x2', '\x2', '\xD2', '\xD3', '\a', 
		't', '\x2', '\x2', '\xD3', '\xD4', '\a', '\x63', '\x2', '\x2', '\xD4', 
		'\xD5', '\a', '{', '\x2', '\x2', '\xD5', '$', '\x3', '\x2', '\x2', '\x2', 
		'\xD6', '\xD7', '\a', 'p', '\x2', '\x2', '\xD7', '\xD8', '\a', 'w', '\x2', 
		'\x2', '\xD8', '\xD9', '\a', 'o', '\x2', '\x2', '\xD9', '\xDA', '\a', 
		'\x64', '\x2', '\x2', '\xDA', '\xDB', '\a', 'g', '\x2', '\x2', '\xDB', 
		'\xDC', '\a', 't', '\x2', '\x2', '\xDC', '&', '\x3', '\x2', '\x2', '\x2', 
		'\xDD', '\xDE', '\a', 'u', '\x2', '\x2', '\xDE', '\xDF', '\a', 'v', '\x2', 
		'\x2', '\xDF', '\xE0', '\a', 't', '\x2', '\x2', '\xE0', '\xE1', '\a', 
		'k', '\x2', '\x2', '\xE1', '\xE2', '\a', 'p', '\x2', '\x2', '\xE2', '\xE3', 
		'\a', 'i', '\x2', '\x2', '\xE3', '(', '\x3', '\x2', '\x2', '\x2', '\xE4', 
		'\xE5', '\a', '\x64', '\x2', '\x2', '\xE5', '\xE6', '\a', 'q', '\x2', 
		'\x2', '\xE6', '\xE7', '\a', 'q', '\x2', '\x2', '\xE7', '\xE8', '\a', 
		'n', '\x2', '\x2', '\xE8', '*', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', 
		'\a', '\x63', '\x2', '\x2', '\xEA', '\xEB', '\a', 'p', '\x2', '\x2', '\xEB', 
		'\xEC', '\a', '{', '\x2', '\x2', '\xEC', ',', '\x3', '\x2', '\x2', '\x2', 
		'\xED', '\xEE', '\a', 'p', '\x2', '\x2', '\xEE', '\xEF', '\a', 'w', '\x2', 
		'\x2', '\xEF', '\xF0', '\a', 'n', '\x2', '\x2', '\xF0', '\xF1', '\a', 
		'n', '\x2', '\x2', '\xF1', '.', '\x3', '\x2', '\x2', '\x2', '\xF2', '\xF3', 
		'\a', ']', '\x2', '\x2', '\xF3', '\x30', '\x3', '\x2', '\x2', '\x2', '\xF4', 
		'\xF5', '\a', '_', '\x2', '\x2', '\xF5', '\x32', '\x3', '\x2', '\x2', 
		'\x2', '\xF6', '\xF7', '\a', '}', '\x2', '\x2', '\xF7', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\xF8', '\xF9', '\a', '\x7F', '\x2', '\x2', '\xF9', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\xFA', '\xFB', '\a', '*', '\x2', 
		'\x2', '\xFB', '\x38', '\x3', '\x2', '\x2', '\x2', '\xFC', '\xFD', '\a', 
		'+', '\x2', '\x2', '\xFD', ':', '\x3', '\x2', '\x2', '\x2', '\xFE', '\xFF', 
		'\a', '\x30', '\x2', '\x2', '\xFF', '<', '\x3', '\x2', '\x2', '\x2', '\x100', 
		'\x101', '\a', '.', '\x2', '\x2', '\x101', '>', '\x3', '\x2', '\x2', '\x2', 
		'\x102', '\x103', '\a', '$', '\x2', '\x2', '\x103', '@', '\x3', '\x2', 
		'\x2', '\x2', '\x104', '\x105', '\a', '<', '\x2', '\x2', '\x105', '\x42', 
		'\x3', '\x2', '\x2', '\x2', '\x106', '\x107', '\a', '&', '\x2', '\x2', 
		'\x107', '\x44', '\x3', '\x2', '\x2', '\x2', '\x108', '\x109', '\a', '?', 
		'\x2', '\x2', '\x109', '\x46', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x10B', 
		'\a', '?', '\x2', '\x2', '\x10B', '\x10C', '\a', '?', '\x2', '\x2', '\x10C', 
		'H', '\x3', '\x2', '\x2', '\x2', '\x10D', '\x10E', '\a', '#', '\x2', '\x2', 
		'\x10E', '\x10F', '\a', '?', '\x2', '\x2', '\x10F', 'J', '\x3', '\x2', 
		'\x2', '\x2', '\x110', '\x111', '\a', '>', '\x2', '\x2', '\x111', 'L', 
		'\x3', '\x2', '\x2', '\x2', '\x112', '\x113', '\a', '>', '\x2', '\x2', 
		'\x113', '\x114', '\a', '?', '\x2', '\x2', '\x114', 'N', '\x3', '\x2', 
		'\x2', '\x2', '\x115', '\x116', '\a', '@', '\x2', '\x2', '\x116', 'P', 
		'\x3', '\x2', '\x2', '\x2', '\x117', '\x118', '\a', '@', '\x2', '\x2', 
		'\x118', '\x119', '\a', '?', '\x2', '\x2', '\x119', 'R', '\x3', '\x2', 
		'\x2', '\x2', '\x11A', '\x11B', '\a', '#', '\x2', '\x2', '\x11B', 'T', 
		'\x3', '\x2', '\x2', '\x2', '\x11C', '\x11D', '\a', '~', '\x2', '\x2', 
		'\x11D', 'V', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x11F', '\a', '(', 
		'\x2', '\x2', '\x11F', 'X', '\x3', '\x2', '\x2', '\x2', '\x120', '\x121', 
		'\a', '-', '\x2', '\x2', '\x121', 'Z', '\x3', '\x2', '\x2', '\x2', '\x122', 
		'\x123', '\a', '/', '\x2', '\x2', '\x123', '\\', '\x3', '\x2', '\x2', 
		'\x2', '\x124', '\x125', '\a', '\x31', '\x2', '\x2', '\x125', '^', '\x3', 
		'\x2', '\x2', '\x2', '\x126', '\x127', '\a', ',', '\x2', '\x2', '\x127', 
		'`', '\x3', '\x2', '\x2', '\x2', '\x128', '\x129', '\a', '\'', '\x2', 
		'\x2', '\x129', '\x62', '\x3', '\x2', '\x2', '\x2', '\x12A', '\x12F', 
		'\x5', 'i', '\x35', '\x2', '\x12B', '\x12E', '\x5', 'i', '\x35', '\x2', 
		'\x12C', '\x12E', '\x5', 'k', '\x36', '\x2', '\x12D', '\x12B', '\x3', 
		'\x2', '\x2', '\x2', '\x12D', '\x12C', '\x3', '\x2', '\x2', '\x2', '\x12E', 
		'\x131', '\x3', '\x2', '\x2', '\x2', '\x12F', '\x12D', '\x3', '\x2', '\x2', 
		'\x2', '\x12F', '\x130', '\x3', '\x2', '\x2', '\x2', '\x130', '\x64', 
		'\x3', '\x2', '\x2', '\x2', '\x131', '\x12F', '\x3', '\x2', '\x2', '\x2', 
		'\x132', '\x141', '\x5', '?', ' ', '\x2', '\x133', '\x140', '\x5', '}', 
		'?', '\x2', '\x134', '\x140', '\x5', '\x7F', '@', '\x2', '\x135', '\x136', 
		'\x5', '\x43', '\"', '\x2', '\x136', '\x13A', '\x5', '\x33', '\x1A', '\x2', 
		'\x137', '\x139', '\n', '\x3', '\x2', '\x2', '\x138', '\x137', '\x3', 
		'\x2', '\x2', '\x2', '\x139', '\x13C', '\x3', '\x2', '\x2', '\x2', '\x13A', 
		'\x138', '\x3', '\x2', '\x2', '\x2', '\x13A', '\x13B', '\x3', '\x2', '\x2', 
		'\x2', '\x13B', '\x13D', '\x3', '\x2', '\x2', '\x2', '\x13C', '\x13A', 
		'\x3', '\x2', '\x2', '\x2', '\x13D', '\x13E', '\x5', '\x35', '\x1B', '\x2', 
		'\x13E', '\x140', '\x3', '\x2', '\x2', '\x2', '\x13F', '\x133', '\x3', 
		'\x2', '\x2', '\x2', '\x13F', '\x134', '\x3', '\x2', '\x2', '\x2', '\x13F', 
		'\x135', '\x3', '\x2', '\x2', '\x2', '\x140', '\x143', '\x3', '\x2', '\x2', 
		'\x2', '\x141', '\x13F', '\x3', '\x2', '\x2', '\x2', '\x141', '\x142', 
		'\x3', '\x2', '\x2', '\x2', '\x142', '\x144', '\x3', '\x2', '\x2', '\x2', 
		'\x143', '\x141', '\x3', '\x2', '\x2', '\x2', '\x144', '\x145', '\x5', 
		'?', ' ', '\x2', '\x145', '\x66', '\x3', '\x2', '\x2', '\x2', '\x146', 
		'\x148', '\x5', '[', '.', '\x2', '\x147', '\x146', '\x3', '\x2', '\x2', 
		'\x2', '\x147', '\x148', '\x3', '\x2', '\x2', '\x2', '\x148', '\x149', 
		'\x3', '\x2', '\x2', '\x2', '\x149', '\x14B', '\x5', 's', ':', '\x2', 
		'\x14A', '\x14C', '\x5', 'u', ';', '\x2', '\x14B', '\x14A', '\x3', '\x2', 
		'\x2', '\x2', '\x14B', '\x14C', '\x3', '\x2', '\x2', '\x2', '\x14C', '\x14E', 
		'\x3', '\x2', '\x2', '\x2', '\x14D', '\x14F', '\x5', 'w', '<', '\x2', 
		'\x14E', '\x14D', '\x3', '\x2', '\x2', '\x2', '\x14E', '\x14F', '\x3', 
		'\x2', '\x2', '\x2', '\x14F', 'h', '\x3', '\x2', '\x2', '\x2', '\x150', 
		'\x151', '\t', '\x4', '\x2', '\x2', '\x151', 'j', '\x3', '\x2', '\x2', 
		'\x2', '\x152', '\x153', '\t', '\x5', '\x2', '\x2', '\x153', 'l', '\x3', 
		'\x2', '\x2', '\x2', '\x154', '\x155', '\t', '\x6', '\x2', '\x2', '\x155', 
		'n', '\x3', '\x2', '\x2', '\x2', '\x156', '\x157', '\a', '\x32', '\x2', 
		'\x2', '\x157', 'p', '\x3', '\x2', '\x2', '\x2', '\x158', '\x15B', '\x5', 
		'Y', '-', '\x2', '\x159', '\x15B', '\x5', '[', '.', '\x2', '\x15A', '\x158', 
		'\x3', '\x2', '\x2', '\x2', '\x15A', '\x159', '\x3', '\x2', '\x2', '\x2', 
		'\x15B', 'r', '\x3', '\x2', '\x2', '\x2', '\x15C', '\x15E', '\x5', 'k', 
		'\x36', '\x2', '\x15D', '\x15C', '\x3', '\x2', '\x2', '\x2', '\x15E', 
		'\x15F', '\x3', '\x2', '\x2', '\x2', '\x15F', '\x15D', '\x3', '\x2', '\x2', 
		'\x2', '\x15F', '\x160', '\x3', '\x2', '\x2', '\x2', '\x160', 't', '\x3', 
		'\x2', '\x2', '\x2', '\x161', '\x163', '\x5', ';', '\x1E', '\x2', '\x162', 
		'\x164', '\x5', 'k', '\x36', '\x2', '\x163', '\x162', '\x3', '\x2', '\x2', 
		'\x2', '\x164', '\x165', '\x3', '\x2', '\x2', '\x2', '\x165', '\x163', 
		'\x3', '\x2', '\x2', '\x2', '\x165', '\x166', '\x3', '\x2', '\x2', '\x2', 
		'\x166', 'v', '\x3', '\x2', '\x2', '\x2', '\x167', '\x169', '\t', '\a', 
		'\x2', '\x2', '\x168', '\x16A', '\x5', 'q', '\x39', '\x2', '\x169', '\x168', 
		'\x3', '\x2', '\x2', '\x2', '\x169', '\x16A', '\x3', '\x2', '\x2', '\x2', 
		'\x16A', '\x16C', '\x3', '\x2', '\x2', '\x2', '\x16B', '\x16D', '\x5', 
		's', ':', '\x2', '\x16C', '\x16B', '\x3', '\x2', '\x2', '\x2', '\x16C', 
		'\x16D', '\x3', '\x2', '\x2', '\x2', '\x16D', 'x', '\x3', '\x2', '\x2', 
		'\x2', '\x16E', '\x16F', '\t', '\b', '\x2', '\x2', '\x16F', 'z', '\x3', 
		'\x2', '\x2', '\x2', '\x170', '\x171', '\a', 'w', '\x2', '\x2', '\x171', 
		'\x172', '\x5', 'y', '=', '\x2', '\x172', '\x173', '\x5', 'y', '=', '\x2', 
		'\x173', '\x174', '\x5', 'y', '=', '\x2', '\x174', '\x175', '\x5', 'y', 
		'=', '\x2', '\x175', '|', '\x3', '\x2', '\x2', '\x2', '\x176', '\x179', 
		'\a', '^', '\x2', '\x2', '\x177', '\x17A', '\t', '\t', '\x2', '\x2', '\x178', 
		'\x17A', '\x5', '{', '>', '\x2', '\x179', '\x177', '\x3', '\x2', '\x2', 
		'\x2', '\x179', '\x178', '\x3', '\x2', '\x2', '\x2', '\x17A', '~', '\x3', 
		'\x2', '\x2', '\x2', '\x17B', '\x17C', '\n', '\n', '\x2', '\x2', '\x17C', 
		'\x80', '\x3', '\x2', '\x2', '\x2', '\x12', '\x2', '\x86', '\x12D', '\x12F', 
		'\x13A', '\x13F', '\x141', '\x147', '\x14B', '\x14E', '\x15A', '\x15F', 
		'\x165', '\x169', '\x16C', '\x179', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Shell.Generated