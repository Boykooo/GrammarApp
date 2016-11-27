// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-11-27 19:36:57

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
    public const int Add = 6;
    public const int MoreOp = 20;
    public const int PRINT = 30;
    public const int MoreEqOp = 21;
    public const int VAR = 51;
    public const int CallMethod = 13;
    public const int While_ = 28;
    public const int DECREMENT = 45;
    public const int LessOp = 22;
    public const int MINUS = 32;
    public const int MULT = 7;
    public const int ELSE = 36;
    public const int CALLMETHOD = 58;
    public const int ID = 72;
    public const int Plus = 9;
    public const int IF = 35;
    public const int TYPE = 56;
    public const int MINUSASSIGN = 41;
    public const int LogicOp = 25;
    public const int INTEGER = 70;
    public const int MOREEQ = 68;
    public const int LESSEQ = 69;
    public const int For = 24;
    public const int BLOCK = 37;
    public const int ONEARRAY = 52;
    public const int FOR = 59;
    public const int Method = 5;
    public const int EQ = 64;
    public const int Double = 12;
    public const int AND = 62;
    public const int PUBLIC = 55;
    public const int MULTIPLY = 33;
    public const int CONDITION = 38;
    public const int COUNT = 53;
    public const int LESS = 67;
    public const int Id = 14;
    public const int VOID = 50;
    public const int If = 26;
    public const int Minus = 10;
    public const int PROGRAM = 29;
    public const int AndOp = 15;
    public const int Inc = 27;
    public const int PLUS = 31;
    public const int DIVIDEASSIGN = 43;
    public const int FLOAT = 47;
    public const int NonEqOp = 18;
    public const int MULTASSIGN = 42;
    public const int CHAR = 49;
    public const int DefOp = 19;
    public const int ASSIGN = 39;
    public const int INT = 46;
    public const int DIVIDE = 34;
    public const int T__77 = 77;
    public const int T__78 = 78;
    public const int PLUSASSIGN = 40;
    public const int T__79 = 79;
    public const int DOUBLE = 48;
    public const int WS = 73;
    public const int EOF = -1;
    public const int T__74 = 74;
    public const int T__75 = 75;
    public const int T__76 = 76;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int OrOp = 16;
    public const int MOD = 57;
    public const int OR = 63;
    public const int INCREMENT_ = 61;
    public const int LessEqOp = 23;
    public const int NONEQ = 65;
    public const int EqOp = 17;
    public const int DOUBLE_ = 71;
    public const int PRIVATE = 54;
    public const int VarInit = 4;
    public const int Integer = 11;
    public const int INCREMENT = 44;
    public const int MORE = 66;
    public const int Assign = 8;
    public const int WHILE = 60;

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

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:10:6: ( '+' )
            // MyGrammar.g:10:8: '+'
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
            // MyGrammar.g:11:7: ( '-' )
            // MyGrammar.g:11:9: '-'
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
            // MyGrammar.g:12:10: ( '*' )
            // MyGrammar.g:12:12: '*'
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
            // MyGrammar.g:13:8: ( '/' )
            // MyGrammar.g:13:10: '/'
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
            // MyGrammar.g:14:4: ( 'if' )
            // MyGrammar.g:14:6: 'if'
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
            // MyGrammar.g:15:6: ( 'else' )
            // MyGrammar.g:15:8: 'else'
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
            // MyGrammar.g:16:7: ( 'BLOCK' )
            // MyGrammar.g:16:9: 'BLOCK'
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
            // MyGrammar.g:17:11: ( 'CONDITION' )
            // MyGrammar.g:17:13: 'CONDITION'
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

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:18:8: ( '=' )
            // MyGrammar.g:18:10: '='
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
            // MyGrammar.g:19:12: ( '+=' )
            // MyGrammar.g:19:14: '+='
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
            // MyGrammar.g:20:13: ( '-=' )
            // MyGrammar.g:20:15: '-='
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
            // MyGrammar.g:21:12: ( '*=' )
            // MyGrammar.g:21:14: '*='
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
            // MyGrammar.g:22:14: ( '/=' )
            // MyGrammar.g:22:16: '/='
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
            // MyGrammar.g:23:11: ( '++' )
            // MyGrammar.g:23:13: '++'
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
            // MyGrammar.g:24:11: ( '--' )
            // MyGrammar.g:24:13: '--'
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
            // MyGrammar.g:25:5: ( 'int' )
            // MyGrammar.g:25:7: 'int'
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
            // MyGrammar.g:26:7: ( 'float' )
            // MyGrammar.g:26:9: 'float'
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
            // MyGrammar.g:27:8: ( 'double' )
            // MyGrammar.g:27:10: 'double'
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
            // MyGrammar.g:28:6: ( 'char' )
            // MyGrammar.g:28:8: 'char'
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
            // MyGrammar.g:29:6: ( 'void' )
            // MyGrammar.g:29:8: 'void'
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

    // $ANTLR start "PRIVATE"
    public void mPRIVATE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PRIVATE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:30:9: ( 'private' )
            // MyGrammar.g:30:11: 'private'
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
            // MyGrammar.g:31:8: ( 'public' )
            // MyGrammar.g:31:10: 'public'
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
            // MyGrammar.g:32:12: ( 'CallMethod' )
            // MyGrammar.g:32:14: 'CallMethod'
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
            // MyGrammar.g:33:5: ( 'for' )
            // MyGrammar.g:33:7: 'for'
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
            // MyGrammar.g:34:7: ( 'while' )
            // MyGrammar.g:34:9: 'while'
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
            // MyGrammar.g:35:12: ( 'INCREMENT' )
            // MyGrammar.g:35:14: 'INCREMENT'
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
            // MyGrammar.g:36:5: ( '&&' )
            // MyGrammar.g:36:7: '&&'
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
            // MyGrammar.g:37:4: ( '||' )
            // MyGrammar.g:37:6: '||'
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
            // MyGrammar.g:38:4: ( '==' )
            // MyGrammar.g:38:6: '=='
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
            // MyGrammar.g:39:7: ( '!=' )
            // MyGrammar.g:39:9: '!='
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
            // MyGrammar.g:40:6: ( '>' )
            // MyGrammar.g:40:8: '>'
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
            // MyGrammar.g:41:6: ( '<' )
            // MyGrammar.g:41:8: '<'
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
            // MyGrammar.g:42:8: ( '>=' )
            // MyGrammar.g:42:10: '>='
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
            // MyGrammar.g:43:8: ( '<=' )
            // MyGrammar.g:43:10: '<='
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

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:44:7: ( '[' )
            // MyGrammar.g:44:9: '['
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
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:45:7: ( ']' )
            // MyGrammar.g:45:9: ']'
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
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:46:7: ( '(' )
            // MyGrammar.g:46:9: '('
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
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:47:7: ( ')' )
            // MyGrammar.g:47:9: ')'
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
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:48:7: ( '{' )
            // MyGrammar.g:48:9: '{'
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
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:49:7: ( '}' )
            // MyGrammar.g:49:9: '}'
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
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:50:7: ( ';' )
            // MyGrammar.g:50:9: ';'
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
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public void mT__81() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__81;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:51:7: ( '()' )
            // MyGrammar.g:51:9: '()'
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
    // $ANTLR end "T__81"

    // $ANTLR start "INTEGER"
    public void mINTEGER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INTEGER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MyGrammar.g:130:9: ( ( '0' .. '9' )+ )
            // MyGrammar.g:130:11: ( '0' .. '9' )+
            {
            	// MyGrammar.g:130:11: ( '0' .. '9' )+
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
            			    // MyGrammar.g:130:12: '0' .. '9'
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
            // MyGrammar.g:133:9: ( INTEGER '.' INTEGER )
            // MyGrammar.g:133:11: INTEGER '.' INTEGER
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
            // MyGrammar.g:141:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // MyGrammar.g:141:8: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
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

            	// MyGrammar.g:141:32: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
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
            // MyGrammar.g:309:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
            // MyGrammar.g:310:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            {
            	// MyGrammar.g:310:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
        // MyGrammar.g:1:8: ( PRINT | PLUS | MINUS | MULTIPLY | DIVIDE | IF | ELSE | BLOCK | CONDITION | ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN | INCREMENT | DECREMENT | INT | FLOAT | DOUBLE | CHAR | VOID | PRIVATE | PUBLIC | CALLMETHOD | FOR | WHILE | INCREMENT_ | AND | OR | EQ | NONEQ | MORE | LESS | MOREEQ | LESSEQ | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | INTEGER | DOUBLE_ | ID | WS )
        int alt4 = 47;
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
                // MyGrammar.g:1:16: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 3 :
                // MyGrammar.g:1:21: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 4 :
                // MyGrammar.g:1:27: MULTIPLY
                {
                	mMULTIPLY(); 

                }
                break;
            case 5 :
                // MyGrammar.g:1:36: DIVIDE
                {
                	mDIVIDE(); 

                }
                break;
            case 6 :
                // MyGrammar.g:1:43: IF
                {
                	mIF(); 

                }
                break;
            case 7 :
                // MyGrammar.g:1:46: ELSE
                {
                	mELSE(); 

                }
                break;
            case 8 :
                // MyGrammar.g:1:51: BLOCK
                {
                	mBLOCK(); 

                }
                break;
            case 9 :
                // MyGrammar.g:1:57: CONDITION
                {
                	mCONDITION(); 

                }
                break;
            case 10 :
                // MyGrammar.g:1:67: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 11 :
                // MyGrammar.g:1:74: PLUSASSIGN
                {
                	mPLUSASSIGN(); 

                }
                break;
            case 12 :
                // MyGrammar.g:1:85: MINUSASSIGN
                {
                	mMINUSASSIGN(); 

                }
                break;
            case 13 :
                // MyGrammar.g:1:97: MULTASSIGN
                {
                	mMULTASSIGN(); 

                }
                break;
            case 14 :
                // MyGrammar.g:1:108: DIVIDEASSIGN
                {
                	mDIVIDEASSIGN(); 

                }
                break;
            case 15 :
                // MyGrammar.g:1:121: INCREMENT
                {
                	mINCREMENT(); 

                }
                break;
            case 16 :
                // MyGrammar.g:1:131: DECREMENT
                {
                	mDECREMENT(); 

                }
                break;
            case 17 :
                // MyGrammar.g:1:141: INT
                {
                	mINT(); 

                }
                break;
            case 18 :
                // MyGrammar.g:1:145: FLOAT
                {
                	mFLOAT(); 

                }
                break;
            case 19 :
                // MyGrammar.g:1:151: DOUBLE
                {
                	mDOUBLE(); 

                }
                break;
            case 20 :
                // MyGrammar.g:1:158: CHAR
                {
                	mCHAR(); 

                }
                break;
            case 21 :
                // MyGrammar.g:1:163: VOID
                {
                	mVOID(); 

                }
                break;
            case 22 :
                // MyGrammar.g:1:168: PRIVATE
                {
                	mPRIVATE(); 

                }
                break;
            case 23 :
                // MyGrammar.g:1:176: PUBLIC
                {
                	mPUBLIC(); 

                }
                break;
            case 24 :
                // MyGrammar.g:1:183: CALLMETHOD
                {
                	mCALLMETHOD(); 

                }
                break;
            case 25 :
                // MyGrammar.g:1:194: FOR
                {
                	mFOR(); 

                }
                break;
            case 26 :
                // MyGrammar.g:1:198: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 27 :
                // MyGrammar.g:1:204: INCREMENT_
                {
                	mINCREMENT_(); 

                }
                break;
            case 28 :
                // MyGrammar.g:1:215: AND
                {
                	mAND(); 

                }
                break;
            case 29 :
                // MyGrammar.g:1:219: OR
                {
                	mOR(); 

                }
                break;
            case 30 :
                // MyGrammar.g:1:222: EQ
                {
                	mEQ(); 

                }
                break;
            case 31 :
                // MyGrammar.g:1:225: NONEQ
                {
                	mNONEQ(); 

                }
                break;
            case 32 :
                // MyGrammar.g:1:231: MORE
                {
                	mMORE(); 

                }
                break;
            case 33 :
                // MyGrammar.g:1:236: LESS
                {
                	mLESS(); 

                }
                break;
            case 34 :
                // MyGrammar.g:1:241: MOREEQ
                {
                	mMOREEQ(); 

                }
                break;
            case 35 :
                // MyGrammar.g:1:248: LESSEQ
                {
                	mLESSEQ(); 

                }
                break;
            case 36 :
                // MyGrammar.g:1:255: T__74
                {
                	mT__74(); 

                }
                break;
            case 37 :
                // MyGrammar.g:1:261: T__75
                {
                	mT__75(); 

                }
                break;
            case 38 :
                // MyGrammar.g:1:267: T__76
                {
                	mT__76(); 

                }
                break;
            case 39 :
                // MyGrammar.g:1:273: T__77
                {
                	mT__77(); 

                }
                break;
            case 40 :
                // MyGrammar.g:1:279: T__78
                {
                	mT__78(); 

                }
                break;
            case 41 :
                // MyGrammar.g:1:285: T__79
                {
                	mT__79(); 

                }
                break;
            case 42 :
                // MyGrammar.g:1:291: T__80
                {
                	mT__80(); 

                }
                break;
            case 43 :
                // MyGrammar.g:1:297: T__81
                {
                	mT__81(); 

                }
                break;
            case 44 :
                // MyGrammar.g:1:303: INTEGER
                {
                	mINTEGER(); 

                }
                break;
            case 45 :
                // MyGrammar.g:1:311: DOUBLE_
                {
                	mDOUBLE_(); 

                }
                break;
            case 46 :
                // MyGrammar.g:1:319: ID
                {
                	mID(); 

                }
                break;
            case 47 :
                // MyGrammar.g:1:322: WS
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
        "\x01\uffff\x01\x1e\x01\x24\x01\x27\x01\x29\x01\x2b\x04\x1e\x01"+
        "\x33\x06\x1e\x03\uffff\x01\x3c\x01\x3e\x02\uffff\x01\x40\x04\uffff"+
        "\x01\x41\x02\uffff\x02\x1e\x0a\uffff\x01\x45\x05\x1e\x02\uffff\x07"+
        "\x1e\x08\uffff\x02\x1e\x01\uffff\x01\x55\x05\x1e\x01\x5b\x08\x1e"+
        "\x01\uffff\x01\x64\x04\x1e\x01\uffff\x01\x1e\x01\x6a\x01\x6b\x02"+
        "\x1e\x01\x6e\x02\x1e\x01\uffff\x01\x71\x02\x1e\x01\x74\x01\x1e\x02"+
        "\uffff\x01\x76\x01\x1e\x01\uffff\x01\x1e\x01\x79\x01\uffff\x02\x1e"+
        "\x01\uffff\x01\x7c\x01\uffff\x01\x1e\x01\x7e\x01\uffff\x02\x1e\x01"+
        "\uffff\x01\x1e\x01\uffff\x03\x1e\x01\u0085\x01\x1e\x01\u0087\x01"+
        "\uffff\x01\u0088\x02\uffff";
    const string DFA4_eofS =
        "\u0089\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x72\x01\x2b\x01\x2d\x02\x3d\x01\x66\x01\x6c\x01\x4c"+
        "\x01\x4f\x01\x3d\x01\x6c\x01\x6f\x01\x68\x01\x6f\x01\x68\x01\x4e"+
        "\x03\uffff\x02\x3d\x02\uffff\x01\x29\x04\uffff\x01\x2e\x02\uffff"+
        "\x01\x69\x01\x62\x0a\uffff\x01\x30\x01\x74\x01\x73\x01\x4f\x01\x4e"+
        "\x01\x6c\x02\uffff\x01\x6f\x01\x72\x01\x75\x01\x61\x02\x69\x01\x43"+
        "\x08\uffff\x01\x6e\x01\x6c\x01\uffff\x01\x30\x01\x65\x01\x43\x01"+
        "\x44\x01\x6c\x01\x61\x01\x30\x01\x62\x01\x72\x01\x64\x01\x6c\x01"+
        "\x52\x01\x74\x01\x61\x01\x69\x01\uffff\x01\x30\x01\x4b\x01\x49\x01"+
        "\x4d\x01\x74\x01\uffff\x01\x6c\x02\x30\x01\x65\x01\x45\x01\x30\x01"+
        "\x74\x01\x63\x01\uffff\x01\x30\x01\x54\x01\x65\x01\x30\x01\x65\x02"+
        "\uffff\x01\x30\x01\x4d\x01\uffff\x01\x65\x01\x30\x01\uffff\x01\x49"+
        "\x01\x74\x01\uffff\x01\x30\x01\uffff\x01\x45\x01\x30\x01\uffff\x01"+
        "\x4f\x01\x68\x01\uffff\x01\x4e\x01\uffff\x01\x4e\x01\x6f\x01\x54"+
        "\x01\x30\x01\x64\x01\x30\x01\uffff\x01\x30\x02\uffff";
    const string DFA4_maxS =
        "\x01\x7d\x01\x75\x04\x3d\x01\x6e\x01\x6c\x01\x4c\x01\x61\x01\x3d"+
        "\x02\x6f\x01\x68\x01\x6f\x01\x68\x01\x4e\x03\uffff\x02\x3d\x02\uffff"+
        "\x01\x29\x04\uffff\x01\x39\x02\uffff\x01\x69\x01\x62\x0a\uffff\x01"+
        "\x7a\x01\x74\x01\x73\x01\x4f\x01\x4e\x01\x6c\x02\uffff\x01\x6f\x01"+
        "\x72\x01\x75\x01\x61\x02\x69\x01\x43\x08\uffff\x01\x76\x01\x6c\x01"+
        "\uffff\x01\x7a\x01\x65\x01\x43\x01\x44\x01\x6c\x01\x61\x01\x7a\x01"+
        "\x62\x01\x72\x01\x64\x01\x6c\x01\x52\x01\x74\x01\x61\x01\x69\x01"+
        "\uffff\x01\x7a\x01\x4b\x01\x49\x01\x4d\x01\x74\x01\uffff\x01\x6c"+
        "\x02\x7a\x01\x65\x01\x45\x01\x7a\x01\x74\x01\x63\x01\uffff\x01\x7a"+
        "\x01\x54\x01\x65\x01\x7a\x01\x65\x02\uffff\x01\x7a\x01\x4d\x01\uffff"+
        "\x01\x65\x01\x7a\x01\uffff\x01\x49\x01\x74\x01\uffff\x01\x7a\x01"+
        "\uffff\x01\x45\x01\x7a\x01\uffff\x01\x4f\x01\x68\x01\uffff\x01\x4e"+
        "\x01\uffff\x01\x4e\x01\x6f\x01\x54\x01\x7a\x01\x64\x01\x7a\x01\uffff"+
        "\x01\x7a\x02\uffff";
    const string DFA4_acceptS =
        "\x11\uffff\x01\x1c\x01\x1d\x01\x1f\x02\uffff\x01\x24\x01\x25\x01"+
        "\uffff\x01\x27\x01\x28\x01\x29\x01\x2a\x01\uffff\x01\x2e\x01\x2f"+
        "\x02\uffff\x01\x0b\x01\x0f\x01\x02\x01\x0c\x01\x10\x01\x03\x01\x0d"+
        "\x01\x04\x01\x0e\x01\x05\x06\uffff\x01\x1e\x01\x0a\x07\uffff\x01"+
        "\x22\x01\x20\x01\x23\x01\x21\x01\x2b\x01\x26\x01\x2c\x01\x2d\x02"+
        "\uffff\x01\x06\x0f\uffff\x01\x11\x05\uffff\x01\x19\x08\uffff\x01"+
        "\x07\x05\uffff\x01\x14\x01\x15\x02\uffff\x01\x01\x02\uffff\x01\x08"+
        "\x02\uffff\x01\x12\x01\uffff\x01\x1a\x02\uffff\x01\x17\x02\uffff"+
        "\x01\x13\x01\uffff\x01\x16\x06\uffff\x01\x09\x01\uffff\x01\x1b\x01"+
        "\x18";
    const string DFA4_specialS =
        "\u0089\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x02\x1f\x01\uffff\x02\x1f\x12\uffff\x01\x1f\x01\x13\x04\uffff"+
            "\x01\x11\x01\uffff\x01\x18\x01\x19\x01\x04\x01\x02\x01\uffff"+
            "\x01\x03\x01\uffff\x01\x05\x0a\x1d\x01\uffff\x01\x1c\x01\x15"+
            "\x01\x0a\x01\x14\x02\uffff\x01\x1e\x01\x08\x01\x09\x05\x1e\x01"+
            "\x10\x11\x1e\x01\x16\x01\uffff\x01\x17\x01\uffff\x01\x1e\x01"+
            "\uffff\x02\x1e\x01\x0d\x01\x0c\x01\x07\x01\x0b\x02\x1e\x01\x06"+
            "\x06\x1e\x01\x01\x05\x1e\x01\x0e\x01\x0f\x03\x1e\x01\x1a\x01"+
            "\x12\x01\x1b",
            "\x01\x20\x02\uffff\x01\x21",
            "\x01\x23\x11\uffff\x01\x22",
            "\x01\x26\x0f\uffff\x01\x25",
            "\x01\x28",
            "\x01\x2a",
            "\x01\x2c\x07\uffff\x01\x2d",
            "\x01\x2e",
            "\x01\x2f",
            "\x01\x30\x11\uffff\x01\x31",
            "\x01\x32",
            "\x01\x34\x02\uffff\x01\x35",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38",
            "\x01\x39",
            "\x01\x3a",
            "",
            "",
            "",
            "\x01\x3b",
            "\x01\x3d",
            "",
            "",
            "\x01\x3f",
            "",
            "",
            "",
            "",
            "\x01\x42\x01\uffff\x0a\x1d",
            "",
            "",
            "\x01\x43",
            "\x01\x44",
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
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x46",
            "\x01\x47",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4a",
            "",
            "",
            "\x01\x4b",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f",
            "\x01\x50",
            "\x01\x51",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x52\x07\uffff\x01\x53",
            "\x01\x54",
            "",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x5c",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "",
            "\x01\x69",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x6c",
            "\x01\x6d",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x6f",
            "\x01\x70",
            "",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x72",
            "\x01\x73",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x75",
            "",
            "",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\x77",
            "",
            "\x01\x78",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "",
            "\x01\x7a",
            "\x01\x7b",
            "",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "",
            "\x01\x7d",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "",
            "\x01\x7f",
            "\x01\u0080",
            "",
            "\x01\u0081",
            "",
            "\x01\u0082",
            "\x01\u0083",
            "\x01\u0084",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "\x01\u0086",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
            "",
            "\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e",
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
            get { return "1:1: Tokens : ( PRINT | PLUS | MINUS | MULTIPLY | DIVIDE | IF | ELSE | BLOCK | CONDITION | ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN | INCREMENT | DECREMENT | INT | FLOAT | DOUBLE | CHAR | VOID | PRIVATE | PUBLIC | CALLMETHOD | FOR | WHILE | INCREMENT_ | AND | OR | EQ | NONEQ | MORE | LESS | MOREEQ | LESSEQ | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | INTEGER | DOUBLE_ | ID | WS );"; }
        }

    }

 
    
}
}