// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2017-01-11 23:01:00

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  GrammarApp 
{
public partial class MyGrammarLexer : Lexer {
    public const int PRINT = 36;
    public const int MoreEqOp = 21;
    public const int VAR = 61;
    public const int String = 34;
    public const int While_ = 28;
    public const int LessOp = 22;
    public const int MINUS = 40;
    public const int Print = 31;
    public const int MULT = 7;
    public const int ELSE = 44;
    public const int NextLine = 33;
    public const int ID = 83;
    public const int IF = 43;
    public const int TYPE = 66;
    public const int LogicOp = 25;
    public const int MOREEQ = 78;
    public const int Method = 5;
    public const int PUBLIC = 65;
    public const int CONDITION = 46;
    public const int COUNT = 63;
    public const int Id = 14;
    public const int If = 26;
    public const int Minus = 10;
    public const int PROGRAM = 35;
    public const int AndOp = 15;
    public const int NonEqOp = 18;
    public const int CHAR = 58;
    public const int DefOp = 19;
    public const int ASSIGN = 48;
    public const int DIVIDE = 42;
    public const int PLUSASSIGN = 49;
    public const int DOUBLE = 57;
    public const int OrOp = 16;
    public const int INCREMENT_ = 71;
    public const int LessEqOp = 23;
    public const int NONEQ = 75;
    public const int DOUBLE_ = 82;
    public const int PRIVATE = 64;
    public const int INCREMENT = 53;
    public const int MORE = 76;
    public const int STRING = 60;
    public const int Assign = 8;
    public const int QUOTES = 80;
    public const int T__91 = 91;
    public const int Add = 6;
    public const int MoreOp = 20;
    public const int T__92 = 92;
    public const int NEW = 47;
    public const int T__93 = 93;
    public const int T__90 = 90;
    public const int CallMethod = 13;
    public const int DECREMENT = 54;
    public const int ArrayInit = 30;
    public const int CALLMETHOD = 68;
    public const int Plus = 9;
    public const int MINUSASSIGN = 50;
    public const int INTEGER = 81;
    public const int LESSEQ = 79;
    public const int For = 24;
    public const int BLOCK = 45;
    public const int ONEARRAY = 62;
    public const int FOR = 69;
    public const int EQ = 74;
    public const int Double = 12;
    public const int AND = 72;
    public const int Println = 32;
    public const int MULTIPLY = 41;
    public const int LESS = 77;
    public const int VOID = 59;
    public const int Inc = 27;
    public const int PLUS = 39;
    public const int DIVIDEASSIGN = 52;
    public const int FLOAT = 56;
    public const int PRINTLN = 37;
    public const int MULTASSIGN = 51;
    public const int INT = 55;
    public const int WS = 84;
    public const int EOF = -1;
    public const int MOD = 67;
    public const int OR = 73;
    public const int EqOp = 17;
    public const int VarInit = 4;
    public const int Integer = 11;
    public const int NEXTLINE = 38;
    public const int T__88 = 88;
    public const int T__89 = 89;
    public const int WHILE = 70;
    public const int T__85 = 85;
    public const int T__86 = 86;
    public const int T__87 = 87;
    public const int ArrayDecl = 29;

    // delegates
    // delegators

    public MyGrammarLexer() 
    {
		InitializeCyclicDFAs();
    }
    public MyGrammarLexer(ICharStream input)
		: this(input, null) {
    }
    public MyGrammarLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "MyGrammar.g";} 
    }

    // $ANTLR start "PRINT"
    public void mPRINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PRINT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:9:7: ( 'print' )
            // MyGrammar.g:9:9: 'print'
            {
            	Match("print"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PRINT"

    // $ANTLR start "PRINTLN"
    public void mPRINTLN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PRINTLN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:10:9: ( 'println' )
            // MyGrammar.g:10:11: 'println'
            {
            	Match("println"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PRINTLN"

    // $ANTLR start "NEXTLINE"
    public void mNEXTLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEXTLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:11:10: ( 'nextLine()' )
            // MyGrammar.g:11:12: 'nextLine()'
            {
            	Match("nextLine()"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEXTLINE"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:12:6: ( '+' )
            // MyGrammar.g:12:8: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:13:7: ( '-' )
            // MyGrammar.g:13:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "MULTIPLY"
    public void mMULTIPLY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTIPLY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:14:10: ( '*' )
            // MyGrammar.g:14:12: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULTIPLY"

    // $ANTLR start "DIVIDE"
    public void mDIVIDE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIVIDE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:15:8: ( '/' )
            // MyGrammar.g:15:10: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIVIDE"

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:16:4: ( 'if' )
            // MyGrammar.g:16:6: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:17:6: ( 'else' )
            // MyGrammar.g:17:8: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "BLOCK"
    public void mBLOCK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BLOCK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:18:7: ( 'BLOCK' )
            // MyGrammar.g:18:9: 'BLOCK'
            {
            	Match("BLOCK"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BLOCK"

    // $ANTLR start "CONDITION"
    public void mCONDITION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CONDITION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:19:11: ( 'CONDITION' )
            // MyGrammar.g:19:13: 'CONDITION'
            {
            	Match("CONDITION"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CONDITION"

    // $ANTLR start "NEW"
    public void mNEW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:20:5: ( 'new' )
            // MyGrammar.g:20:7: 'new'
            {
            	Match("new"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEW"

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:21:8: ( '=' )
            // MyGrammar.g:21:10: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    // $ANTLR start "PLUSASSIGN"
    public void mPLUSASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUSASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:22:12: ( '+=' )
            // MyGrammar.g:22:14: '+='
            {
            	Match("+="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUSASSIGN"

    // $ANTLR start "MINUSASSIGN"
    public void mMINUSASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUSASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:23:13: ( '-=' )
            // MyGrammar.g:23:15: '-='
            {
            	Match("-="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUSASSIGN"

    // $ANTLR start "MULTASSIGN"
    public void mMULTASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:24:12: ( '*=' )
            // MyGrammar.g:24:14: '*='
            {
            	Match("*="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULTASSIGN"

    // $ANTLR start "DIVIDEASSIGN"
    public void mDIVIDEASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIVIDEASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:25:14: ( '/=' )
            // MyGrammar.g:25:16: '/='
            {
            	Match("/="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIVIDEASSIGN"

    // $ANTLR start "INCREMENT"
    public void mINCREMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INCREMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:26:11: ( '++' )
            // MyGrammar.g:26:13: '++'
            {
            	Match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INCREMENT"

    // $ANTLR start "DECREMENT"
    public void mDECREMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DECREMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:27:11: ( '--' )
            // MyGrammar.g:27:13: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DECREMENT"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:28:5: ( 'int' )
            // MyGrammar.g:28:7: 'int'
            {
            	Match("int"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT"
    public void mFLOAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FLOAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:29:7: ( 'float' )
            // MyGrammar.g:29:9: 'float'
            {
            	Match("float"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FLOAT"

    // $ANTLR start "DOUBLE"
    public void mDOUBLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:30:8: ( 'double' )
            // MyGrammar.g:30:10: 'double'
            {
            	Match("double"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOUBLE"

    // $ANTLR start "CHAR"
    public void mCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:31:6: ( 'char' )
            // MyGrammar.g:31:8: 'char'
            {
            	Match("char"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR"

    // $ANTLR start "VOID"
    public void mVOID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VOID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:32:6: ( 'void' )
            // MyGrammar.g:32:8: 'void'
            {
            	Match("void"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VOID"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:33:8: ( 'string' )
            // MyGrammar.g:33:10: 'string'
            {
            	Match("string"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "PRIVATE"
    public void mPRIVATE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PRIVATE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:34:9: ( 'private' )
            // MyGrammar.g:34:11: 'private'
            {
            	Match("private"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PRIVATE"

    // $ANTLR start "PUBLIC"
    public void mPUBLIC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PUBLIC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:35:8: ( 'public' )
            // MyGrammar.g:35:10: 'public'
            {
            	Match("public"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PUBLIC"

    // $ANTLR start "CALLMETHOD"
    public void mCALLMETHOD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CALLMETHOD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:36:12: ( 'CallMethod' )
            // MyGrammar.g:36:14: 'CallMethod'
            {
            	Match("CallMethod"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CALLMETHOD"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:37:5: ( 'for' )
            // MyGrammar.g:37:7: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:38:7: ( 'while' )
            // MyGrammar.g:38:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "INCREMENT_"
    public void mINCREMENT_() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INCREMENT_;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:39:12: ( 'INCREMENT' )
            // MyGrammar.g:39:14: 'INCREMENT'
            {
            	Match("INCREMENT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INCREMENT_"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:40:5: ( '&&' )
            // MyGrammar.g:40:7: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:41:4: ( '||' )
            // MyGrammar.g:41:6: '||'
            {
            	Match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "EQ"
    public void mEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:42:4: ( '==' )
            // MyGrammar.g:42:6: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQ"

    // $ANTLR start "NONEQ"
    public void mNONEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NONEQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:43:7: ( '!=' )
            // MyGrammar.g:43:9: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NONEQ"

    // $ANTLR start "MORE"
    public void mMORE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MORE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:44:6: ( '>' )
            // MyGrammar.g:44:8: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MORE"

    // $ANTLR start "LESS"
    public void mLESS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:45:6: ( '<' )
            // MyGrammar.g:45:8: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LESS"

    // $ANTLR start "MOREEQ"
    public void mMOREEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MOREEQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:46:8: ( '>=' )
            // MyGrammar.g:46:10: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MOREEQ"

    // $ANTLR start "LESSEQ"
    public void mLESSEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESSEQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:47:8: ( '<=' )
            // MyGrammar.g:47:10: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LESSEQ"

    // $ANTLR start "QUOTES"
    public void mQUOTES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QUOTES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:48:8: ( '\"' )
            // MyGrammar.g:48:10: '\"'
            {
            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QUOTES"

    // $ANTLR start "T__85"
    public void mT__85() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__85;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:49:7: ( '[]' )
            // MyGrammar.g:49:9: '[]'
            {
            	Match("[]"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__85"

    // $ANTLR start "T__86"
    public void mT__86() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__86;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:50:7: ( '[' )
            // MyGrammar.g:50:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__86"

    // $ANTLR start "T__87"
    public void mT__87() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__87;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:51:7: ( ']' )
            // MyGrammar.g:51:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__87"

    // $ANTLR start "T__88"
    public void mT__88() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__88;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:52:7: ( '(' )
            // MyGrammar.g:52:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__88"

    // $ANTLR start "T__89"
    public void mT__89() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__89;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:53:7: ( ')' )
            // MyGrammar.g:53:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__89"

    // $ANTLR start "T__90"
    public void mT__90() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__90;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:54:7: ( '{' )
            // MyGrammar.g:54:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__90"

    // $ANTLR start "T__91"
    public void mT__91() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__91;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:55:7: ( '}' )
            // MyGrammar.g:55:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__91"

    // $ANTLR start "T__92"
    public void mT__92() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__92;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:56:7: ( ';' )
            // MyGrammar.g:56:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__92"

    // $ANTLR start "T__93"
    public void mT__93() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__93;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:57:7: ( '()' )
            // MyGrammar.g:57:9: '()'
            {
            	Match("()"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__93"

    // $ANTLR start "INTEGER"
    public void mINTEGER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INTEGER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:142:9: ( ( '0' .. '9' )+ )
            // MyGrammar.g:142:11: ( '0' .. '9' )+
            {
            	// MyGrammar.g:142:11: ( '0' .. '9' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // MyGrammar.g:142:12: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INTEGER"

    // $ANTLR start "DOUBLE_"
    public void mDOUBLE_() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLE_;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:145:9: ( INTEGER '.' INTEGER )
            // MyGrammar.g:145:11: INTEGER '.' INTEGER
            {
            	mINTEGER(); 
            	Match('.'); 
            	mINTEGER(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOUBLE_"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:159:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // MyGrammar.g:159:8: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// MyGrammar.g:159:33: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // MyGrammar.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:387:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
            // MyGrammar.g:388:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            {
            	// MyGrammar.g:388:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || (LA3_0 >= '\f' && LA3_0 <= '\r') || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // MyGrammar.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            	    _channel=HIDDEN;
            	  

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // MyGrammar.g:1:8: ( PRINT | PRINTLN | NEXTLINE | PLUS | MINUS | MULTIPLY | DIVIDE | IF | ELSE | BLOCK | CONDITION | NEW | ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN | INCREMENT | DECREMENT | INT | FLOAT | DOUBLE | CHAR | VOID | STRING | PRIVATE | PUBLIC | CALLMETHOD | FOR | WHILE | INCREMENT_ | AND | OR | EQ | NONEQ | MORE | LESS | MOREEQ | LESSEQ | QUOTES | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | INTEGER | DOUBLE_ | ID | WS )
        int alt4 = 53;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // MyGrammar.g:1:10: PRINT
                {
                	mPRINT(); 

                }
                break;
            case 2 :
                // MyGrammar.g:1:16: PRINTLN
                {
                	mPRINTLN(); 

                }
                break;
            case 3 :
                // MyGrammar.g:1:24: NEXTLINE
                {
                	mNEXTLINE(); 

                }
                break;
            case 4 :
                // MyGrammar.g:1:33: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 5 :
                // MyGrammar.g:1:38: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 6 :
                // MyGrammar.g:1:44: MULTIPLY
                {
                	mMULTIPLY(); 

                }
                break;
            case 7 :
                // MyGrammar.g:1:53: DIVIDE
                {
                	mDIVIDE(); 

                }
                break;
            case 8 :
                // MyGrammar.g:1:60: IF
                {
                	mIF(); 

                }
                break;
            case 9 :
                // MyGrammar.g:1:63: ELSE
                {
                	mELSE(); 

                }
                break;
            case 10 :
                // MyGrammar.g:1:68: BLOCK
                {
                	mBLOCK(); 

                }
                break;
            case 11 :
                // MyGrammar.g:1:74: CONDITION
                {
                	mCONDITION(); 

                }
                break;
            case 12 :
                // MyGrammar.g:1:84: NEW
                {
                	mNEW(); 

                }
                break;
            case 13 :
                // MyGrammar.g:1:88: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 14 :
                // MyGrammar.g:1:95: PLUSASSIGN
                {
                	mPLUSASSIGN(); 

                }
                break;
            case 15 :
                // MyGrammar.g:1:106: MINUSASSIGN
                {
                	mMINUSASSIGN(); 

                }
                break;
            case 16 :
                // MyGrammar.g:1:118: MULTASSIGN
                {
                	mMULTASSIGN(); 

                }
                break;
            case 17 :
                // MyGrammar.g:1:129: DIVIDEASSIGN
                {
                	mDIVIDEASSIGN(); 

                }
                break;
            case 18 :
                // MyGrammar.g:1:142: INCREMENT
                {
                	mINCREMENT(); 

                }
                break;
            case 19 :
                // MyGrammar.g:1:152: DECREMENT
                {
                	mDECREMENT(); 

                }
                break;
            case 20 :
                // MyGrammar.g:1:162: INT
                {
                	mINT(); 

                }
                break;
            case 21 :
                // MyGrammar.g:1:166: FLOAT
                {
                	mFLOAT(); 

                }
                break;
            case 22 :
                // MyGrammar.g:1:172: DOUBLE
                {
                	mDOUBLE(); 

                }
                break;
            case 23 :
                // MyGrammar.g:1:179: CHAR
                {
                	mCHAR(); 

                }
                break;
            case 24 :
                // MyGrammar.g:1:184: VOID
                {
                	mVOID(); 

                }
                break;
            case 25 :
                // MyGrammar.g:1:189: STRING
                {
                	mSTRING(); 

                }
                break;
            case 26 :
                // MyGrammar.g:1:196: PRIVATE
                {
                	mPRIVATE(); 

                }
                break;
            case 27 :
                // MyGrammar.g:1:204: PUBLIC
                {
                	mPUBLIC(); 

                }
                break;
            case 28 :
                // MyGrammar.g:1:211: CALLMETHOD
                {
                	mCALLMETHOD(); 

                }
                break;
            case 29 :
                // MyGrammar.g:1:222: FOR
                {
                	mFOR(); 

                }
                break;
            case 30 :
                // MyGrammar.g:1:226: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 31 :
                // MyGrammar.g:1:232: INCREMENT_
                {
                	mINCREMENT_(); 

                }
                break;
            case 32 :
                // MyGrammar.g:1:243: AND
                {
                	mAND(); 

                }
                break;
            case 33 :
                // MyGrammar.g:1:247: OR
                {
                	mOR(); 

                }
                break;
            case 34 :
                // MyGrammar.g:1:250: EQ
                {
                	mEQ(); 

                }
                break;
            case 35 :
                // MyGrammar.g:1:253: NONEQ
                {
                	mNONEQ(); 

                }
                break;
            case 36 :
                // MyGrammar.g:1:259: MORE
                {
                	mMORE(); 

                }
                break;
            case 37 :
                // MyGrammar.g:1:264: LESS
                {
                	mLESS(); 

                }
                break;
            case 38 :
                // MyGrammar.g:1:269: MOREEQ
                {
                	mMOREEQ(); 

                }
                break;
            case 39 :
                // MyGrammar.g:1:276: LESSEQ
                {
                	mLESSEQ(); 

                }
                break;
            case 40 :
                // MyGrammar.g:1:283: QUOTES
                {
                	mQUOTES(); 

                }
                break;
            case 41 :
                // MyGrammar.g:1:290: T__85
                {
                	mT__85(); 

                }
                break;
            case 42 :
                // MyGrammar.g:1:296: T__86
                {
                	mT__86(); 

                }
                break;
            case 43 :
                // MyGrammar.g:1:302: T__87
                {
                	mT__87(); 

                }
                break;
            case 44 :
                // MyGrammar.g:1:308: T__88
                {
                	mT__88(); 

                }
                break;
            case 45 :
                // MyGrammar.g:1:314: T__89
                {
                	mT__89(); 

                }
                break;
            case 46 :
                // MyGrammar.g:1:320: T__90
                {
                	mT__90(); 

                }
                break;
            case 47 :
                // MyGrammar.g:1:326: T__91
                {
                	mT__91(); 

                }
                break;
            case 48 :
                // MyGrammar.g:1:332: T__92
                {
                	mT__92(); 

                }
                break;
            case 49 :
                // MyGrammar.g:1:338: T__93
                {
                	mT__93(); 

                }
                break;
            case 50 :
                // MyGrammar.g:1:344: INTEGER
                {
                	mINTEGER(); 

                }
                break;
            case 51 :
                // MyGrammar.g:1:352: DOUBLE_
                {
                	mDOUBLE_(); 

                }
                break;
            case 52 :
                // MyGrammar.g:1:360: ID
                {
                	mID(); 

                }
                break;
            case 53 :
                // MyGrammar.g:1:363: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	}

    const string DFA4_eotS =
        "\x01\uffff\x02\x21\x01\x28\x01\x2b\x01\x2d\x01\x2f\x04\x21\x01"+
        "\x37\x07\x21\x03\uffff\x01\x41\x01\x43\x01\uffff\x01\x45\x01\uffff"+
        "\x01\x47\x04\uffff\x01\x48\x02\uffff\x03\x21\x0a\uffff\x01\x4e\x05"+
        "\x21\x02\uffff\x08\x21\x0a\uffff\x03\x21\x01\x60\x01\uffff\x01\x61"+
        "\x05\x21\x01\x67\x0a\x21\x02\uffff\x01\x72\x04\x21\x01\uffff\x01"+
        "\x21\x01\x78\x01\x79\x03\x21\x01\x7e\x03\x21\x01\uffff\x01\u0082"+
        "\x02\x21\x01\u0085\x01\x21\x02\uffff\x01\x21\x01\u0088\x02\x21\x01"+
        "\uffff\x01\x21\x01\u008c\x01\x21\x01\uffff\x02\x21\x01\uffff\x01"+
        "\u0090\x01\u0091\x01\uffff\x01\x21\x01\u0093\x01\u0094\x01\uffff"+
        "\x03\x21\x02\uffff\x01\x21\x02\uffff\x04\x21\x01\uffff\x01\u009d"+
        "\x01\x21\x01\u009f\x01\uffff\x01\u00a0\x02\uffff";
    const string DFA4_eofS =
        "\u00a1\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x72\x01\x65\x01\x2b\x01\x2d\x02\x3d\x01\x66\x01\x6c"+
        "\x01\x4c\x01\x4f\x01\x3d\x01\x6c\x01\x6f\x01\x68\x01\x6f\x01\x74"+
        "\x01\x68\x01\x4e\x03\uffff\x02\x3d\x01\uffff\x01\x5d\x01\uffff\x01"+
        "\x29\x04\uffff\x01\x2e\x02\uffff\x01\x69\x01\x62\x01\x77\x0a\uffff"+
        "\x01\x30\x01\x74\x01\x73\x01\x4f\x01\x4e\x01\x6c\x02\uffff\x01\x6f"+
        "\x01\x72\x01\x75\x01\x61\x01\x69\x01\x72\x01\x69\x01\x43\x0a\uffff"+
        "\x01\x6e\x01\x6c\x01\x74\x01\x30\x01\uffff\x01\x30\x01\x65\x01\x43"+
        "\x01\x44\x01\x6c\x01\x61\x01\x30\x01\x62\x01\x72\x01\x64\x01\x69"+
        "\x01\x6c\x01\x52\x01\x74\x01\x61\x01\x69\x01\x4c\x02\uffff\x01\x30"+
        "\x01\x4b\x01\x49\x01\x4d\x01\x74\x01\uffff\x01\x6c\x02\x30\x01\x6e"+
        "\x01\x65\x01\x45\x01\x30\x01\x74\x01\x63\x01\x69\x01\uffff\x01\x30"+
        "\x01\x54\x01\x65\x01\x30\x01\x65\x02\uffff\x01\x67\x01\x30\x01\x4d"+
        "\x01\x6e\x01\uffff\x01\x65\x01\x30\x01\x6e\x01\uffff\x01\x49\x01"+
        "\x74\x01\uffff\x02\x30\x01\uffff\x01\x45\x02\x30\x01\uffff\x01\x65"+
        "\x01\x4f\x01\x68\x02\uffff\x01\x4e\x02\uffff\x01\x28\x01\x4e\x01"+
        "\x6f\x01\x54\x01\uffff\x01\x30\x01\x64\x01\x30\x01\uffff\x01\x30"+
        "\x02\uffff";
    const string DFA4_maxS =
        "\x01\x7d\x01\x75\x01\x65\x04\x3d\x01\x6e\x01\x6c\x01\x4c\x01\x61"+
        "\x01\x3d\x02\x6f\x01\x68\x01\x6f\x01\x74\x01\x68\x01\x4e\x03\uffff"+
        "\x02\x3d\x01\uffff\x01\x5d\x01\uffff\x01\x29\x04\uffff\x01\x39\x02"+
        "\uffff\x01\x69\x01\x62\x01\x78\x0a\uffff\x01\x7a\x01\x74\x01\x73"+
        "\x01\x4f\x01\x4e\x01\x6c\x02\uffff\x01\x6f\x01\x72\x01\x75\x01\x61"+
        "\x01\x69\x01\x72\x01\x69\x01\x43\x0a\uffff\x01\x76\x01\x6c\x01\x74"+
        "\x01\x7a\x01\uffff\x01\x7a\x01\x65\x01\x43\x01\x44\x01\x6c\x01\x61"+
        "\x01\x7a\x01\x62\x01\x72\x01\x64\x01\x69\x01\x6c\x01\x52\x01\x74"+
        "\x01\x61\x01\x69\x01\x4c\x02\uffff\x01\x7a\x01\x4b\x01\x49\x01\x4d"+
        "\x01\x74\x01\uffff\x01\x6c\x02\x7a\x01\x6e\x01\x65\x01\x45\x01\x7a"+
        "\x01\x74\x01\x63\x01\x69\x01\uffff\x01\x7a\x01\x54\x01\x65\x01\x7a"+
        "\x01\x65\x02\uffff\x01\x67\x01\x7a\x01\x4d\x01\x6e\x01\uffff\x01"+
        "\x65\x01\x7a\x01\x6e\x01\uffff\x01\x49\x01\x74\x01\uffff\x02\x7a"+
        "\x01\uffff\x01\x45\x02\x7a\x01\uffff\x01\x65\x01\x4f\x01\x68\x02"+
        "\uffff\x01\x4e\x02\uffff\x01\x28\x01\x4e\x01\x6f\x01\x54\x01\uffff"+
        "\x01\x7a\x01\x64\x01\x7a\x01\uffff\x01\x7a\x02\uffff";
    const string DFA4_acceptS =
        "\x13\uffff\x01\x20\x01\x21\x01\x23\x02\uffff\x01\x28\x01\uffff"+
        "\x01\x2b\x01\uffff\x01\x2d\x01\x2e\x01\x2f\x01\x30\x01\uffff\x01"+
        "\x34\x01\x35\x03\uffff\x01\x0e\x01\x12\x01\x04\x01\x0f\x01\x13\x01"+
        "\x05\x01\x10\x01\x06\x01\x11\x01\x07\x06\uffff\x01\x22\x01\x0d\x08"+
        "\uffff\x01\x26\x01\x24\x01\x27\x01\x25\x01\x29\x01\x2a\x01\x31\x01"+
        "\x2c\x01\x32\x01\x33\x04\uffff\x01\x08\x11\uffff\x01\x0c\x01\x14"+
        "\x05\uffff\x01\x1d\x0a\uffff\x01\x09\x05\uffff\x01\x17\x01\x18\x04"+
        "\uffff\x01\x01\x03\uffff\x01\x0a\x02\uffff\x01\x15\x02\uffff\x01"+
        "\x1e\x03\uffff\x01\x1b\x03\uffff\x01\x16\x01\x19\x01\uffff\x01\x02"+
        "\x01\x1a\x04\uffff\x01\x03\x03\uffff\x01\x0b\x01\uffff\x01\x1f\x01"+
        "\x1c";
    const string DFA4_specialS =
        "\u00a1\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x02\x22\x01\uffff\x02\x22\x12\uffff\x01\x22\x01\x15\x01\x18"+
            "\x03\uffff\x01\x13\x01\uffff\x01\x1b\x01\x1c\x01\x05\x01\x03"+
            "\x01\uffff\x01\x04\x01\uffff\x01\x06\x0a\x20\x01\uffff\x01\x1f"+
            "\x01\x17\x01\x0b\x01\x16\x02\uffff\x01\x21\x01\x09\x01\x0a\x05"+
            "\x21\x01\x12\x11\x21\x01\x19\x01\uffff\x01\x1a\x01\uffff\x01"+
            "\x21\x01\uffff\x02\x21\x01\x0e\x01\x0d\x01\x08\x01\x0c\x02\x21"+
            "\x01\x07\x04\x21\x01\x02\x01\x21\x01\x01\x02\x21\x01\x10\x02"+
            "\x21\x01\x0f\x01\x11\x03\x21\x01\x1d\x01\x14\x01\x1e",
            "\x01\x23\x02\uffff\x01\x24",
            "\x01\x25",
            "\x01\x27\x11\uffff\x01\x26",
            "\x01\x2a\x0f\uffff\x01\x29",
            "\x01\x2c",
            "\x01\x2e",
            "\x01\x30\x07\uffff\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34\x11\uffff\x01\x35",
            "\x01\x36",
            "\x01\x38\x02\uffff\x01\x39",
            "\x01\x3a",
            "\x01\x3b",
            "\x01\x3c",
            "\x01\x3d",
            "\x01\x3e",
            "\x01\x3f",
            "",
            "",
            "",
            "\x01\x40",
            "\x01\x42",
            "",
            "\x01\x44",
            "",
            "\x01\x46",
            "",
            "",
            "",
            "",
            "\x01\x49\x01\uffff\x0a\x20",
            "",
            "",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x4d\x01\x4c",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x4f",
            "\x01\x50",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "",
            "",
            "\x01\x54",
            "\x01\x55",
            "\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x5c\x07\uffff\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x62",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b",
            "\x01\x6c",
            "\x01\x6d",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71",
            "",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "",
            "\x01\x77",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x0b"+
            "\x21\x01\x7d\x0e\x21",
            "\x01\x7f",
            "\x01\u0080",
            "\x01\u0081",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\u0083",
            "\x01\u0084",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\u0086",
            "",
            "",
            "\x01\u0087",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\u0089",
            "\x01\u008a",
            "",
            "\x01\u008b",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\u008d",
            "",
            "\x01\u008e",
            "\x01\u008f",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "",
            "\x01\u0092",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "",
            "\x01\u0095",
            "\x01\u0096",
            "\x01\u0097",
            "",
            "",
            "\x01\u0098",
            "",
            "",
            "\x01\u0099",
            "\x01\u009a",
            "\x01\u009b",
            "\x01\u009c",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "\x01\u009e",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "",
            "\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01\x21\x01\uffff\x1a"+
            "\x21",
            "",
            ""
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( PRINT | PRINTLN | NEXTLINE | PLUS | MINUS | MULTIPLY | DIVIDE | IF | ELSE | BLOCK | CONDITION | NEW | ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN | INCREMENT | DECREMENT | INT | FLOAT | DOUBLE | CHAR | VOID | STRING | PRIVATE | PUBLIC | CALLMETHOD | FOR | WHILE | INCREMENT_ | AND | OR | EQ | NONEQ | MORE | LESS | MOREEQ | LESSEQ | QUOTES | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | INTEGER | DOUBLE_ | ID | WS );"; }
        }

    }

 
    
}
}