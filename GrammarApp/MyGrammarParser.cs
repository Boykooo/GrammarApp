// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2017-01-11 23:00:59

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  GrammarApp 
{
public partial class MyGrammarParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"VarInit", 
		"Method", 
		"Add", 
		"MULT", 
		"Assign", 
		"Plus", 
		"Minus", 
		"Integer", 
		"Double", 
		"CallMethod", 
		"Id", 
		"AndOp", 
		"OrOp", 
		"EqOp", 
		"NonEqOp", 
		"DefOp", 
		"MoreOp", 
		"MoreEqOp", 
		"LessOp", 
		"LessEqOp", 
		"For", 
		"LogicOp", 
		"If", 
		"Inc", 
		"While_", 
		"ArrayDecl", 
		"ArrayInit", 
		"Print", 
		"Println", 
		"NextLine", 
		"String", 
		"PROGRAM", 
		"PRINT", 
		"PRINTLN", 
		"NEXTLINE", 
		"PLUS", 
		"MINUS", 
		"MULTIPLY", 
		"DIVIDE", 
		"IF", 
		"ELSE", 
		"BLOCK", 
		"CONDITION", 
		"NEW", 
		"ASSIGN", 
		"PLUSASSIGN", 
		"MINUSASSIGN", 
		"MULTASSIGN", 
		"DIVIDEASSIGN", 
		"INCREMENT", 
		"DECREMENT", 
		"INT", 
		"FLOAT", 
		"DOUBLE", 
		"CHAR", 
		"VOID", 
		"STRING", 
		"VAR", 
		"ONEARRAY", 
		"COUNT", 
		"PRIVATE", 
		"PUBLIC", 
		"TYPE", 
		"MOD", 
		"CALLMETHOD", 
		"FOR", 
		"WHILE", 
		"INCREMENT_", 
		"AND", 
		"OR", 
		"EQ", 
		"NONEQ", 
		"MORE", 
		"LESS", 
		"MOREEQ", 
		"LESSEQ", 
		"QUOTES", 
		"INTEGER", 
		"DOUBLE_", 
		"ID", 
		"WS", 
		"'[]'", 
		"'['", 
		"']'", 
		"'('", 
		"')'", 
		"'{'", 
		"'}'", 
		"';'", 
		"'()'"
    };

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



        public MyGrammarParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public MyGrammarParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return MyGrammarParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "MyGrammar.g"; }
    }


    public class type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type"
    // MyGrammar.g:104:1: type : ( INT | FLOAT | STRING | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:104:6: ( INT | FLOAT | STRING | DOUBLE | CHAR | VOID )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set1 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INT && input.LA(1) <= STRING) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set1));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type"

    public class typeAssign_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "typeAssign"
    // MyGrammar.g:113:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:113:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set2 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= ASSIGN && input.LA(1) <= DIVIDEASSIGN) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set2));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typeAssign"

    public class incDec_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "incDec"
    // MyGrammar.g:121:1: incDec : ( inc | dec );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.inc_return inc3 = default(MyGrammarParser.inc_return);

        MyGrammarParser.dec_return dec4 = default(MyGrammarParser.dec_return);



        try 
    	{
            // MyGrammar.g:121:8: ( inc | dec )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == INCREMENT) )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == DECREMENT) )
            {
                alt1 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // MyGrammar.g:121:10: inc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inc_in_incDec1054);
                    	inc3 = inc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inc3.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:122:5: dec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dec_in_incDec1060);
                    	dec4 = dec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dec4.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "incDec"

    public class inc_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "inc"
    // MyGrammar.g:126:1: inc : INCREMENT -> ^( Inc INCREMENT ) ;
    public MyGrammarParser.inc_return inc() // throws RecognitionException [1]
    {   
        MyGrammarParser.inc_return retval = new MyGrammarParser.inc_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INCREMENT5 = null;

        object INCREMENT5_tree=null;
        RewriteRuleTokenStream stream_INCREMENT = new RewriteRuleTokenStream(adaptor,"token INCREMENT");

        try 
    	{
            // MyGrammar.g:126:6: ( INCREMENT -> ^( Inc INCREMENT ) )
            // MyGrammar.g:126:8: INCREMENT
            {
            	INCREMENT5=(IToken)Match(input,INCREMENT,FOLLOW_INCREMENT_in_inc1073); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_INCREMENT.Add(INCREMENT5);



            	// AST REWRITE
            	// elements:          INCREMENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 126:18: -> ^( Inc INCREMENT )
            	{
            	    // MyGrammar.g:126:21: ^( Inc INCREMENT )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new IncNode(Inc), root_1);

            	    adaptor.AddChild(root_1, stream_INCREMENT.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "inc"

    public class dec_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dec"
    // MyGrammar.g:129:1: dec : DECREMENT -> DECREMENT ;
    public MyGrammarParser.dec_return dec() // throws RecognitionException [1]
    {   
        MyGrammarParser.dec_return retval = new MyGrammarParser.dec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DECREMENT6 = null;

        object DECREMENT6_tree=null;
        RewriteRuleTokenStream stream_DECREMENT = new RewriteRuleTokenStream(adaptor,"token DECREMENT");

        try 
    	{
            // MyGrammar.g:129:6: ( DECREMENT -> DECREMENT )
            // MyGrammar.g:129:8: DECREMENT
            {
            	DECREMENT6=(IToken)Match(input,DECREMENT,FOLLOW_DECREMENT_in_dec1096); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DECREMENT.Add(DECREMENT6);



            	// AST REWRITE
            	// elements:          DECREMENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 129:18: -> DECREMENT
            	{
            	    adaptor.AddChild(root_0, new DecNode(stream_DECREMENT.NextToken()));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "dec"

    public class elementarySign_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elementarySign"
    // MyGrammar.g:132:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set7 = null;

        object set7_tree=null;

        try 
    	{
            // MyGrammar.g:132:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set7 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PLUS && input.LA(1) <= DIVIDE) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set7));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elementarySign"

    public class number_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "number"
    // MyGrammar.g:150:1: number : ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) );
    public MyGrammarParser.number_return number() // throws RecognitionException [1]
    {   
        MyGrammarParser.number_return retval = new MyGrammarParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INTEGER8 = null;
        IToken DOUBLE_9 = null;

        object INTEGER8_tree=null;
        object DOUBLE_9_tree=null;
        RewriteRuleTokenStream stream_DOUBLE_ = new RewriteRuleTokenStream(adaptor,"token DOUBLE_");
        RewriteRuleTokenStream stream_INTEGER = new RewriteRuleTokenStream(adaptor,"token INTEGER");

        try 
    	{
            // MyGrammar.g:150:8: ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == INTEGER) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == DOUBLE_) )
            {
                alt2 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // MyGrammar.g:150:10: INTEGER
                    {
                    	INTEGER8=(IToken)Match(input,INTEGER,FOLLOW_INTEGER_in_number1189); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INTEGER.Add(INTEGER8);



                    	// AST REWRITE
                    	// elements:          INTEGER
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 150:18: -> ^( Integer INTEGER )
                    	{
                    	    // MyGrammar.g:150:21: ^( Integer INTEGER )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new IntegerNode(Integer), root_1);

                    	    adaptor.AddChild(root_1, stream_INTEGER.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:151:5: DOUBLE_
                    {
                    	DOUBLE_9=(IToken)Match(input,DOUBLE_,FOLLOW_DOUBLE__in_number1206); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DOUBLE_.Add(DOUBLE_9);



                    	// AST REWRITE
                    	// elements:          DOUBLE_
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 151:13: -> ^( Double DOUBLE_ )
                    	{
                    	    // MyGrammar.g:151:16: ^( Double DOUBLE_ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new DoubleNode(Double), root_1);

                    	    adaptor.AddChild(root_1, stream_DOUBLE_.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "number"

    public class string__return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "string_"
    // MyGrammar.g:156:1: string_ : '\"' ID '\"' -> ^( String ID ) ;
    public MyGrammarParser.string__return string_() // throws RecognitionException [1]
    {   
        MyGrammarParser.string__return retval = new MyGrammarParser.string__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal10 = null;
        IToken ID11 = null;
        IToken char_literal12 = null;

        object char_literal10_tree=null;
        object ID11_tree=null;
        object char_literal12_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_QUOTES = new RewriteRuleTokenStream(adaptor,"token QUOTES");

        try 
    	{
            // MyGrammar.g:156:10: ( '\"' ID '\"' -> ^( String ID ) )
            // MyGrammar.g:156:12: '\"' ID '\"'
            {
            	char_literal10=(IToken)Match(input,QUOTES,FOLLOW_QUOTES_in_string_1231); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_QUOTES.Add(char_literal10);

            	ID11=(IToken)Match(input,ID,FOLLOW_ID_in_string_1233); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID11);

            	char_literal12=(IToken)Match(input,QUOTES,FOLLOW_QUOTES_in_string_1235); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_QUOTES.Add(char_literal12);



            	// AST REWRITE
            	// elements:          ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 156:23: -> ^( String ID )
            	{
            	    // MyGrammar.g:156:26: ^( String ID )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new StringNode(String), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "string_"

    public class ident_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ident"
    // MyGrammar.g:162:1: ident : ID -> ^( Id ID ) ;
    public MyGrammarParser.ident_return ident() // throws RecognitionException [1]
    {   
        MyGrammarParser.ident_return retval = new MyGrammarParser.ident_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID13 = null;

        object ID13_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:162:8: ( ID -> ^( Id ID ) )
            // MyGrammar.g:162:10: ID
            {
            	ID13=(IToken)Match(input,ID,FOLLOW_ID_in_ident1301); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID13);



            	// AST REWRITE
            	// elements:          ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 162:13: -> ^( Id ID )
            	{
            	    // MyGrammar.g:162:16: ^( Id ID )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new IDNode(Id), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ident"

    public class init_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "init"
    // MyGrammar.g:167:1: init : ( arrayInit | varInit );
    public MyGrammarParser.init_return init() // throws RecognitionException [1]
    {   
        MyGrammarParser.init_return retval = new MyGrammarParser.init_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.arrayInit_return arrayInit14 = default(MyGrammarParser.arrayInit_return);

        MyGrammarParser.varInit_return varInit15 = default(MyGrammarParser.varInit_return);



        try 
    	{
            // MyGrammar.g:167:6: ( arrayInit | varInit )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= INT && LA3_0 <= STRING)) )
            {
                int LA3_1 = input.LA(2);

                if ( (LA3_1 == ID) )
                {
                    alt3 = 2;
                }
                else if ( (LA3_1 == 85) )
                {
                    alt3 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d3s1 =
                        new NoViableAltException("", 3, 1, input);

                    throw nvae_d3s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // MyGrammar.g:167:8: arrayInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_init1326);
                    	arrayInit14 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit14.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:168:5: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_init1333);
                    	varInit15 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit15.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "init"

    public class arrayInit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arrayInit"
    // MyGrammar.g:171:1: arrayInit : type '[]' ident ( '=' NEW type '[' add ']' )? -> ^( ArrayDecl type ident ( add )? ) ;
    public MyGrammarParser.arrayInit_return arrayInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.arrayInit_return retval = new MyGrammarParser.arrayInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal17 = null;
        IToken char_literal19 = null;
        IToken NEW20 = null;
        IToken char_literal22 = null;
        IToken char_literal24 = null;
        MyGrammarParser.type_return type16 = default(MyGrammarParser.type_return);

        MyGrammarParser.ident_return ident18 = default(MyGrammarParser.ident_return);

        MyGrammarParser.type_return type21 = default(MyGrammarParser.type_return);

        MyGrammarParser.add_return add23 = default(MyGrammarParser.add_return);


        object string_literal17_tree=null;
        object char_literal19_tree=null;
        object NEW20_tree=null;
        object char_literal22_tree=null;
        object char_literal24_tree=null;
        RewriteRuleTokenStream stream_NEW = new RewriteRuleTokenStream(adaptor,"token NEW");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:171:11: ( type '[]' ident ( '=' NEW type '[' add ']' )? -> ^( ArrayDecl type ident ( add )? ) )
            // MyGrammar.g:171:13: type '[]' ident ( '=' NEW type '[' add ']' )?
            {
            	PushFollow(FOLLOW_type_in_arrayInit1344);
            	type16 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type16.Tree);
            	string_literal17=(IToken)Match(input,85,FOLLOW_85_in_arrayInit1346); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal17);

            	PushFollow(FOLLOW_ident_in_arrayInit1348);
            	ident18 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident18.Tree);
            	// MyGrammar.g:171:29: ( '=' NEW type '[' add ']' )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == ASSIGN) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // MyGrammar.g:171:30: '=' NEW type '[' add ']'
            	        {
            	        	char_literal19=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_arrayInit1351); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(char_literal19);

            	        	NEW20=(IToken)Match(input,NEW,FOLLOW_NEW_in_arrayInit1353); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_NEW.Add(NEW20);

            	        	PushFollow(FOLLOW_type_in_arrayInit1355);
            	        	type21 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type21.Tree);
            	        	char_literal22=(IToken)Match(input,86,FOLLOW_86_in_arrayInit1357); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_86.Add(char_literal22);

            	        	PushFollow(FOLLOW_add_in_arrayInit1359);
            	        	add23 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_add.Add(add23.Tree);
            	        	char_literal24=(IToken)Match(input,87,FOLLOW_87_in_arrayInit1361); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_87.Add(char_literal24);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          type, add, ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 172:6: -> ^( ArrayDecl type ident ( add )? )
            	{
            	    // MyGrammar.g:172:8: ^( ArrayDecl type ident ( add )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ArrayDeclNode(ArrayDecl), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:172:46: ( add )?
            	    if ( stream_add.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_add.NextTree());

            	    }
            	    stream_add.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arrayInit"

    public class varInit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "varInit"
    // MyGrammar.g:175:1: varInit : type fieldInitValue -> ^( VarInit type fieldInitValue ) ;
    public MyGrammarParser.varInit_return varInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInit_return retval = new MyGrammarParser.varInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.type_return type25 = default(MyGrammarParser.type_return);

        MyGrammarParser.fieldInitValue_return fieldInitValue26 = default(MyGrammarParser.fieldInitValue_return);


        RewriteRuleSubtreeStream stream_fieldInitValue = new RewriteRuleSubtreeStream(adaptor,"rule fieldInitValue");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:175:9: ( type fieldInitValue -> ^( VarInit type fieldInitValue ) )
            // MyGrammar.g:175:11: type fieldInitValue
            {
            	PushFollow(FOLLOW_type_in_varInit1398);
            	type25 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type25.Tree);
            	PushFollow(FOLLOW_fieldInitValue_in_varInit1400);
            	fieldInitValue26 = fieldInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fieldInitValue.Add(fieldInitValue26.Tree);


            	// AST REWRITE
            	// elements:          type, fieldInitValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 176:5: -> ^( VarInit type fieldInitValue )
            	{
            	    // MyGrammar.g:176:8: ^( VarInit type fieldInitValue )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new VarInitNode(VarInit), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_fieldInitValue.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "varInit"

    public class fieldInitValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fieldInitValue"
    // MyGrammar.g:180:1: fieldInitValue : ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) ;
    public MyGrammarParser.fieldInitValue_return fieldInitValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.fieldInitValue_return retval = new MyGrammarParser.fieldInitValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN28 = null;
        MyGrammarParser.ident_return ident27 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue29 = default(MyGrammarParser.initValue_return);


        object ASSIGN28_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:180:16: ( ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) )
            // MyGrammar.g:180:19: ident ( ASSIGN initValue )?
            {
            	PushFollow(FOLLOW_ident_in_fieldInitValue1430);
            	ident27 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident27.Tree);
            	// MyGrammar.g:180:26: ( ASSIGN initValue )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == ASSIGN) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // MyGrammar.g:180:27: ASSIGN initValue
            	        {
            	        	ASSIGN28=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_fieldInitValue1434); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN28);

            	        	PushFollow(FOLLOW_initValue_in_fieldInitValue1436);
            	        	initValue29 = initValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initValue.Add(initValue29.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          initValue, ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 181:7: -> ^( Assign ident ( initValue )? )
            	{
            	    // MyGrammar.g:181:10: ^( Assign ident ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AssignNode(Assign), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:181:37: ( initValue )?
            	    if ( stream_initValue.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_initValue.NextTree());

            	    }
            	    stream_initValue.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fieldInitValue"

    public class stringInit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "stringInit"
    // MyGrammar.g:185:1: stringInit : ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) ;
    public MyGrammarParser.stringInit_return stringInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.stringInit_return retval = new MyGrammarParser.stringInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN31 = null;
        MyGrammarParser.ident_return ident30 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue32 = default(MyGrammarParser.initValue_return);


        object ASSIGN31_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:185:13: ( ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) )
            // MyGrammar.g:185:15: ident ( ASSIGN initValue )?
            {
            	PushFollow(FOLLOW_ident_in_stringInit1475);
            	ident30 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident30.Tree);
            	// MyGrammar.g:185:22: ( ASSIGN initValue )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == ASSIGN) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // MyGrammar.g:185:23: ASSIGN initValue
            	        {
            	        	ASSIGN31=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_stringInit1479); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN31);

            	        	PushFollow(FOLLOW_initValue_in_stringInit1481);
            	        	initValue32 = initValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initValue.Add(initValue32.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ident, initValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 186:7: -> ^( Assign ident ( initValue )? )
            	{
            	    // MyGrammar.g:186:10: ^( Assign ident ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AssignNode(Assign), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:186:37: ( initValue )?
            	    if ( stream_initValue.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_initValue.NextTree());

            	    }
            	    stream_initValue.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "stringInit"

    public class initValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "initValue"
    // MyGrammar.g:190:1: initValue : ( addOrArray | callMethod | ident | inc | dec | string_ );
    public MyGrammarParser.initValue_return initValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.initValue_return retval = new MyGrammarParser.initValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.addOrArray_return addOrArray33 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.callMethod_return callMethod34 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.ident_return ident35 = default(MyGrammarParser.ident_return);

        MyGrammarParser.inc_return inc36 = default(MyGrammarParser.inc_return);

        MyGrammarParser.dec_return dec37 = default(MyGrammarParser.dec_return);

        MyGrammarParser.string__return string_38 = default(MyGrammarParser.string__return);



        try 
    	{
            // MyGrammar.g:190:12: ( addOrArray | callMethod | ident | inc | dec | string_ )
            int alt7 = 6;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // MyGrammar.g:190:14: addOrArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_addOrArray_in_initValue1520);
                    	addOrArray33 = addOrArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, addOrArray33.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:191:7: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_initValue1528);
                    	callMethod34 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod34.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:192:7: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_initValue1536);
                    	ident35 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident35.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:193:7: inc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inc_in_initValue1544);
                    	inc36 = inc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inc36.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:194:7: dec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dec_in_initValue1552);
                    	dec37 = dec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dec37.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:195:7: string_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string__in_initValue1560);
                    	string_38 = string_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_38.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "initValue"

    public class addOperation_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "addOperation"
    // MyGrammar.g:199:1: addOperation : ( PLUS -> Plus | MINUS -> Minus );
    public MyGrammarParser.addOperation_return addOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.addOperation_return retval = new MyGrammarParser.addOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS39 = null;
        IToken MINUS40 = null;

        object PLUS39_tree=null;
        object MINUS40_tree=null;
        RewriteRuleTokenStream stream_PLUS = new RewriteRuleTokenStream(adaptor,"token PLUS");
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor,"token MINUS");

        try 
    	{
            // MyGrammar.g:199:14: ( PLUS -> Plus | MINUS -> Minus )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == PLUS) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == MINUS) )
            {
                alt8 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // MyGrammar.g:199:16: PLUS
                    {
                    	PLUS39=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addOperation1574); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_PLUS.Add(PLUS39);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 199:21: -> Plus
                    	{
                    	    adaptor.AddChild(root_0, new PlusNode(Plus));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:200:7: MINUS
                    {
                    	MINUS40=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_addOperation1589); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MINUS.Add(MINUS40);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 200:13: -> Minus
                    	{
                    	    adaptor.AddChild(root_0, new MinusNode(Minus));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "addOperation"

    public class multOperation_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multOperation"
    // MyGrammar.g:203:1: multOperation : ( MULTIPLY -> MULT | DIVIDE -> DIVIDE );
    public MyGrammarParser.multOperation_return multOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.multOperation_return retval = new MyGrammarParser.multOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULTIPLY41 = null;
        IToken DIVIDE42 = null;

        object MULTIPLY41_tree=null;
        object DIVIDE42_tree=null;
        RewriteRuleTokenStream stream_MULTIPLY = new RewriteRuleTokenStream(adaptor,"token MULTIPLY");
        RewriteRuleTokenStream stream_DIVIDE = new RewriteRuleTokenStream(adaptor,"token DIVIDE");

        try 
    	{
            // MyGrammar.g:203:15: ( MULTIPLY -> MULT | DIVIDE -> DIVIDE )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == MULTIPLY) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == DIVIDE) )
            {
                alt9 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // MyGrammar.g:203:17: MULTIPLY
                    {
                    	MULTIPLY41=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multOperation1609); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MULTIPLY.Add(MULTIPLY41);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 203:26: -> MULT
                    	{
                    	    adaptor.AddChild(root_0, new MultNode(MULT));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:204:7: DIVIDE
                    {
                    	DIVIDE42=(IToken)Match(input,DIVIDE,FOLLOW_DIVIDE_in_multOperation1624); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DIVIDE.Add(DIVIDE42);



                    	// AST REWRITE
                    	// elements:          DIVIDE
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 204:14: -> DIVIDE
                    	{
                    	    adaptor.AddChild(root_0, new DivideNode(stream_DIVIDE.NextToken()));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multOperation"

    public class group_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "group"
    // MyGrammar.g:207:1: group : ( '(' add ')' | number | ident );
    public MyGrammarParser.group_return group() // throws RecognitionException [1]
    {   
        MyGrammarParser.group_return retval = new MyGrammarParser.group_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal43 = null;
        IToken char_literal45 = null;
        MyGrammarParser.add_return add44 = default(MyGrammarParser.add_return);

        MyGrammarParser.number_return number46 = default(MyGrammarParser.number_return);

        MyGrammarParser.ident_return ident47 = default(MyGrammarParser.ident_return);


        object char_literal43_tree=null;
        object char_literal45_tree=null;

        try 
    	{
            // MyGrammar.g:207:7: ( '(' add ')' | number | ident )
            int alt10 = 3;
            switch ( input.LA(1) ) 
            {
            case 88:
            	{
                alt10 = 1;
                }
                break;
            case INTEGER:
            case DOUBLE_:
            	{
                alt10 = 2;
                }
                break;
            case ID:
            	{
                alt10 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("", 10, 0, input);

            	    throw nvae_d10s0;
            }

            switch (alt10) 
            {
                case 1 :
                    // MyGrammar.g:207:9: '(' add ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal43=(IToken)Match(input,88,FOLLOW_88_in_group1647); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group1650);
                    	add44 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add44.Tree);
                    	char_literal45=(IToken)Match(input,89,FOLLOW_89_in_group1652); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:208:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group1660);
                    	number46 = number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number46.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:209:5: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_group1666);
                    	ident47 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident47.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "group"

    public class mult_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mult"
    // MyGrammar.g:212:1: mult : group ( multOperation group )* ;
    public MyGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        MyGrammarParser.mult_return retval = new MyGrammarParser.mult_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.group_return group48 = default(MyGrammarParser.group_return);

        MyGrammarParser.multOperation_return multOperation49 = default(MyGrammarParser.multOperation_return);

        MyGrammarParser.group_return group50 = default(MyGrammarParser.group_return);



        try 
    	{
            // MyGrammar.g:212:6: ( group ( multOperation group )* )
            // MyGrammar.g:212:8: group ( multOperation group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult1681);
            	group48 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group48.Tree);
            	// MyGrammar.g:212:14: ( multOperation group )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= MULTIPLY && LA11_0 <= DIVIDE)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MyGrammar.g:212:16: multOperation group
            			    {
            			    	PushFollow(FOLLOW_multOperation_in_mult1685);
            			    	multOperation49 = multOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperation49.Tree, root_0);
            			    	PushFollow(FOLLOW_group_in_mult1688);
            			    	group50 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group50.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mult"

    public class add_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "add"
    // MyGrammar.g:214:1: add : mult ( addOperation mult )* ;
    public MyGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        MyGrammarParser.add_return retval = new MyGrammarParser.add_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.mult_return mult51 = default(MyGrammarParser.mult_return);

        MyGrammarParser.addOperation_return addOperation52 = default(MyGrammarParser.addOperation_return);

        MyGrammarParser.mult_return mult53 = default(MyGrammarParser.mult_return);



        try 
    	{
            // MyGrammar.g:214:6: ( mult ( addOperation mult )* )
            // MyGrammar.g:214:8: mult ( addOperation mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1700);
            	mult51 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult51.Tree);
            	// MyGrammar.g:214:13: ( addOperation mult )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= PLUS && LA12_0 <= MINUS)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // MyGrammar.g:214:15: addOperation mult
            			    {
            			    	PushFollow(FOLLOW_addOperation_in_add1704);
            			    	addOperation52 = addOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperation52.Tree, root_0);
            			    	PushFollow(FOLLOW_mult_in_add1707);
            			    	mult53 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult53.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "add"

    public class block_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block"
    // MyGrammar.g:217:1: block : '{' ( line )* '}' -> ^( BLOCK ( line )* ) ;
    public MyGrammarParser.block_return block() // throws RecognitionException [1]
    {   
        MyGrammarParser.block_return retval = new MyGrammarParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal54 = null;
        IToken char_literal56 = null;
        MyGrammarParser.line_return line55 = default(MyGrammarParser.line_return);


        object char_literal54_tree=null;
        object char_literal56_tree=null;
        RewriteRuleTokenStream stream_90 = new RewriteRuleTokenStream(adaptor,"token 90");
        RewriteRuleTokenStream stream_91 = new RewriteRuleTokenStream(adaptor,"token 91");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:217:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:217:9: '{' ( line )* '}'
            {
            	char_literal54=(IToken)Match(input,90,FOLLOW_90_in_block1719); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_90.Add(char_literal54);

            	// MyGrammar.g:217:13: ( line )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= PRINT && LA13_0 <= NEXTLINE) || LA13_0 == IF || (LA13_0 >= INT && LA13_0 <= STRING) || (LA13_0 >= FOR && LA13_0 <= WHILE) || (LA13_0 >= INTEGER && LA13_0 <= ID) || LA13_0 == 88) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block1721);
            			    	line55 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line55.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	char_literal56=(IToken)Match(input,91,FOLLOW_91_in_block1724); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_91.Add(char_literal56);



            	// AST REWRITE
            	// elements:          line
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 217:23: -> ^( BLOCK ( line )* )
            	{
            	    // MyGrammar.g:217:26: ^( BLOCK ( line )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(BLOCK), root_1);

            	    // MyGrammar.g:217:49: ( line )*
            	    while ( stream_line.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_line.NextTree());

            	    }
            	    stream_line.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block"

    public class if__return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "if_"
    // MyGrammar.g:221:1: if_ : IF '(' logicOperator ')' block ( ELSE block )? -> ^( If logicOperator block ( ^( ELSE block ) )? ) ;
    public MyGrammarParser.if__return if_() // throws RecognitionException [1]
    {   
        MyGrammarParser.if__return retval = new MyGrammarParser.if__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF57 = null;
        IToken char_literal58 = null;
        IToken char_literal60 = null;
        IToken ELSE62 = null;
        MyGrammarParser.logicOperator_return logicOperator59 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block61 = default(MyGrammarParser.block_return);

        MyGrammarParser.block_return block63 = default(MyGrammarParser.block_return);


        object IF57_tree=null;
        object char_literal58_tree=null;
        object char_literal60_tree=null;
        object ELSE62_tree=null;
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:221:6: ( IF '(' logicOperator ')' block ( ELSE block )? -> ^( If logicOperator block ( ^( ELSE block ) )? ) )
            // MyGrammar.g:221:8: IF '(' logicOperator ')' block ( ELSE block )?
            {
            	IF57=(IToken)Match(input,IF,FOLLOW_IF_in_if_1749); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF57);

            	char_literal58=(IToken)Match(input,88,FOLLOW_88_in_if_1751); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(char_literal58);

            	PushFollow(FOLLOW_logicOperator_in_if_1753);
            	logicOperator59 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator59.Tree);
            	char_literal60=(IToken)Match(input,89,FOLLOW_89_in_if_1755); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_89.Add(char_literal60);

            	PushFollow(FOLLOW_block_in_if_1757);
            	block61 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block61.Tree);
            	// MyGrammar.g:221:39: ( ELSE block )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == ELSE) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // MyGrammar.g:221:40: ELSE block
            	        {
            	        	ELSE62=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_if_1760); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE62);

            	        	PushFollow(FOLLOW_block_in_if_1762);
            	        	block63 = block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block.Add(block63.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          logicOperator, block, block, ELSE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 222:4: -> ^( If logicOperator block ( ^( ELSE block ) )? )
            	{
            	    // MyGrammar.g:222:7: ^( If logicOperator block ( ^( ELSE block ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new IfNode(If), root_1);

            	    adaptor.AddChild(root_1, stream_logicOperator.NextTree());
            	    adaptor.AddChild(root_1, stream_block.NextTree());
            	    // MyGrammar.g:222:40: ( ^( ELSE block ) )?
            	    if ( stream_block.HasNext() || stream_ELSE.HasNext() )
            	    {
            	        // MyGrammar.g:222:40: ^( ELSE block )
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_2);

            	        adaptor.AddChild(root_2, stream_block.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_block.Reset();
            	    stream_ELSE.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "if_"

    public class operations_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "operations"
    // MyGrammar.g:228:1: operations : ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) );
    public MyGrammarParser.operations_return operations() // throws RecognitionException [1]
    {   
        MyGrammarParser.operations_return retval = new MyGrammarParser.operations_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation64 = default(MyGrammarParser.orOperation_return);

        MyGrammarParser.andOperation_return andOperation65 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.eqOp_return eqOp66 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp67 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.moreOp_return moreOp68 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp69 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.lessOp_return lessOp70 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp71 = default(MyGrammarParser.lessEqOp_return);


        RewriteRuleSubtreeStream stream_andOperation = new RewriteRuleSubtreeStream(adaptor,"rule andOperation");
        RewriteRuleSubtreeStream stream_lessEqOp = new RewriteRuleSubtreeStream(adaptor,"rule lessEqOp");
        RewriteRuleSubtreeStream stream_eqOp = new RewriteRuleSubtreeStream(adaptor,"rule eqOp");
        RewriteRuleSubtreeStream stream_moreOp = new RewriteRuleSubtreeStream(adaptor,"rule moreOp");
        RewriteRuleSubtreeStream stream_lessOp = new RewriteRuleSubtreeStream(adaptor,"rule lessOp");
        RewriteRuleSubtreeStream stream_nonEqOp = new RewriteRuleSubtreeStream(adaptor,"rule nonEqOp");
        RewriteRuleSubtreeStream stream_orOperation = new RewriteRuleSubtreeStream(adaptor,"rule orOperation");
        RewriteRuleSubtreeStream stream_moreEqOp = new RewriteRuleSubtreeStream(adaptor,"rule moreEqOp");
        try 
    	{
            // MyGrammar.g:228:14: ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) )
            int alt15 = 8;
            alt15 = dfa15.Predict(input);
            switch (alt15) 
            {
                case 1 :
                    // MyGrammar.g:228:16: orOperation
                    {
                    	PushFollow(FOLLOW_orOperation_in_operations1804);
                    	orOperation64 = orOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_orOperation.Add(orOperation64.Tree);


                    	// AST REWRITE
                    	// elements:          orOperation
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 228:28: -> ^( OrOp orOperation )
                    	{
                    	    // MyGrammar.g:228:31: ^( OrOp orOperation )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new OrOperationNode(OrOp), root_1);

                    	    adaptor.AddChild(root_1, stream_orOperation.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:229:8: andOperation
                    {
                    	PushFollow(FOLLOW_andOperation_in_operations1824);
                    	andOperation65 = andOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_andOperation.Add(andOperation65.Tree);


                    	// AST REWRITE
                    	// elements:          andOperation
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 229:21: -> ^( AndOp andOperation )
                    	{
                    	    // MyGrammar.g:229:24: ^( AndOp andOperation )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new AndOperationNode(AndOp), root_1);

                    	    adaptor.AddChild(root_1, stream_andOperation.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // MyGrammar.g:230:8: eqOp
                    {
                    	PushFollow(FOLLOW_eqOp_in_operations1844);
                    	eqOp66 = eqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_eqOp.Add(eqOp66.Tree);


                    	// AST REWRITE
                    	// elements:          eqOp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 230:13: -> ^( EqOp eqOp )
                    	{
                    	    // MyGrammar.g:230:16: ^( EqOp eqOp )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new EqualityOperationNode(EqOp), root_1);

                    	    adaptor.AddChild(root_1, stream_eqOp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // MyGrammar.g:231:8: nonEqOp
                    {
                    	PushFollow(FOLLOW_nonEqOp_in_operations1864);
                    	nonEqOp67 = nonEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nonEqOp.Add(nonEqOp67.Tree);


                    	// AST REWRITE
                    	// elements:          nonEqOp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 231:16: -> ^( NonEqOp nonEqOp )
                    	{
                    	    // MyGrammar.g:231:19: ^( NonEqOp nonEqOp )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new NonEqualityOperationNode(NonEqOp), root_1);

                    	    adaptor.AddChild(root_1, stream_nonEqOp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // MyGrammar.g:232:8: moreOp
                    {
                    	PushFollow(FOLLOW_moreOp_in_operations1884);
                    	moreOp68 = moreOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_moreOp.Add(moreOp68.Tree);


                    	// AST REWRITE
                    	// elements:          moreOp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 232:15: -> ^( MoreOp moreOp )
                    	{
                    	    // MyGrammar.g:232:18: ^( MoreOp moreOp )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationMoreNode(MoreOp), root_1);

                    	    adaptor.AddChild(root_1, stream_moreOp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // MyGrammar.g:233:8: moreEqOp
                    {
                    	PushFollow(FOLLOW_moreEqOp_in_operations1904);
                    	moreEqOp69 = moreEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_moreEqOp.Add(moreEqOp69.Tree);


                    	// AST REWRITE
                    	// elements:          moreEqOp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 233:17: -> ^( MoreEqOp moreEqOp )
                    	{
                    	    // MyGrammar.g:233:20: ^( MoreEqOp moreEqOp )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationMoreEqNode(MoreEqOp), root_1);

                    	    adaptor.AddChild(root_1, stream_moreEqOp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 7 :
                    // MyGrammar.g:234:8: lessOp
                    {
                    	PushFollow(FOLLOW_lessOp_in_operations1924);
                    	lessOp70 = lessOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lessOp.Add(lessOp70.Tree);


                    	// AST REWRITE
                    	// elements:          lessOp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 234:15: -> ^( LessOp lessOp )
                    	{
                    	    // MyGrammar.g:234:18: ^( LessOp lessOp )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationLessNode(LessOp), root_1);

                    	    adaptor.AddChild(root_1, stream_lessOp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 8 :
                    // MyGrammar.g:235:8: lessEqOp
                    {
                    	PushFollow(FOLLOW_lessEqOp_in_operations1944);
                    	lessEqOp71 = lessEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lessEqOp.Add(lessEqOp71.Tree);


                    	// AST REWRITE
                    	// elements:          lessEqOp
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 235:17: -> ^( LessEqOp lessEqOp )
                    	{
                    	    // MyGrammar.g:235:20: ^( LessEqOp lessEqOp )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationLessEqNode(LessEqOp), root_1);

                    	    adaptor.AddChild(root_1, stream_lessEqOp.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operations"

    public class logicOperator_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logicOperator"
    // MyGrammar.g:238:1: logicOperator : ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp );
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation72 = default(MyGrammarParser.orOperation_return);

        MyGrammarParser.andOperation_return andOperation73 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.eqOp_return eqOp74 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp75 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.moreOp_return moreOp76 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp77 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.lessOp_return lessOp78 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp79 = default(MyGrammarParser.lessEqOp_return);



        try 
    	{
            // MyGrammar.g:238:16: ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp )
            int alt16 = 8;
            alt16 = dfa16.Predict(input);
            switch (alt16) 
            {
                case 1 :
                    // MyGrammar.g:238:18: orOperation
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_orOperation_in_logicOperator1972);
                    	orOperation72 = orOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation72.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:239:8: andOperation
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_andOperation_in_logicOperator1981);
                    	andOperation73 = andOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation73.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:240:8: eqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_eqOp_in_logicOperator1990);
                    	eqOp74 = eqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, eqOp74.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:241:8: nonEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nonEqOp_in_logicOperator1999);
                    	nonEqOp75 = nonEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEqOp75.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:242:8: moreOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moreOp_in_logicOperator2008);
                    	moreOp76 = moreOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreOp76.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:243:8: moreEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moreEqOp_in_logicOperator2017);
                    	moreEqOp77 = moreEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreEqOp77.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:244:8: lessOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lessOp_in_logicOperator2026);
                    	lessOp78 = lessOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessOp78.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:245:8: lessEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lessEqOp_in_logicOperator2035);
                    	lessEqOp79 = lessEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessEqOp79.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicOperator"

    public class orOperation_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "orOperation"
    // MyGrammar.g:249:1: orOperation : addOrArray OR addOrArray -> ^( OrOp addOrArray addOrArray ) ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OR81 = null;
        MyGrammarParser.addOrArray_return addOrArray80 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray82 = default(MyGrammarParser.addOrArray_return);


        object OR81_tree=null;
        RewriteRuleTokenStream stream_OR = new RewriteRuleTokenStream(adaptor,"token OR");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:249:15: ( addOrArray OR addOrArray -> ^( OrOp addOrArray addOrArray ) )
            // MyGrammar.g:249:17: addOrArray OR addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_orOperation2052);
            	addOrArray80 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray80.Tree);
            	OR81=(IToken)Match(input,OR,FOLLOW_OR_in_orOperation2054); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_OR.Add(OR81);

            	PushFollow(FOLLOW_addOrArray_in_orOperation2056);
            	addOrArray82 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray82.Tree);


            	// AST REWRITE
            	// elements:          addOrArray, addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 249:42: -> ^( OrOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:249:45: ^( OrOp addOrArray addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new OrOperationNode(OrOp), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());
            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "orOperation"

    public class andOperation_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "andOperation"
    // MyGrammar.g:252:1: andOperation : addOrArray AND addOrArray -> ^( AndOp addOrArray addOrArray ) ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AND84 = null;
        MyGrammarParser.addOrArray_return addOrArray83 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray85 = default(MyGrammarParser.addOrArray_return);


        object AND84_tree=null;
        RewriteRuleTokenStream stream_AND = new RewriteRuleTokenStream(adaptor,"token AND");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:252:15: ( addOrArray AND addOrArray -> ^( AndOp addOrArray addOrArray ) )
            // MyGrammar.g:252:17: addOrArray AND addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_andOperation2084);
            	addOrArray83 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray83.Tree);
            	AND84=(IToken)Match(input,AND,FOLLOW_AND_in_andOperation2086); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_AND.Add(AND84);

            	PushFollow(FOLLOW_addOrArray_in_andOperation2088);
            	addOrArray85 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray85.Tree);


            	// AST REWRITE
            	// elements:          addOrArray, addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 252:43: -> ^( AndOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:252:46: ^( AndOp addOrArray addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AndOperationNode(AndOp), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());
            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "andOperation"

    public class eqOp_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "eqOp"
    // MyGrammar.g:255:1: eqOp : addOrArray EQ addOrArray -> ^( EqOp addOrArray addOrArray ) ;
    public MyGrammarParser.eqOp_return eqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.eqOp_return retval = new MyGrammarParser.eqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQ87 = null;
        MyGrammarParser.addOrArray_return addOrArray86 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray88 = default(MyGrammarParser.addOrArray_return);


        object EQ87_tree=null;
        RewriteRuleTokenStream stream_EQ = new RewriteRuleTokenStream(adaptor,"token EQ");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:255:9: ( addOrArray EQ addOrArray -> ^( EqOp addOrArray addOrArray ) )
            // MyGrammar.g:255:11: addOrArray EQ addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_eqOp2118);
            	addOrArray86 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray86.Tree);
            	EQ87=(IToken)Match(input,EQ,FOLLOW_EQ_in_eqOp2120); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQ.Add(EQ87);

            	PushFollow(FOLLOW_addOrArray_in_eqOp2122);
            	addOrArray88 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray88.Tree);


            	// AST REWRITE
            	// elements:          addOrArray, addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 255:36: -> ^( EqOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:255:39: ^( EqOp addOrArray addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new EqualityOperationNode(EqOp), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());
            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "eqOp"

    public class nonEqOp_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "nonEqOp"
    // MyGrammar.g:258:1: nonEqOp : addOrArray NONEQ addOrArray -> ^( NonEqOp addOrArray addOrArray ) ;
    public MyGrammarParser.nonEqOp_return nonEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.nonEqOp_return retval = new MyGrammarParser.nonEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NONEQ90 = null;
        MyGrammarParser.addOrArray_return addOrArray89 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray91 = default(MyGrammarParser.addOrArray_return);


        object NONEQ90_tree=null;
        RewriteRuleTokenStream stream_NONEQ = new RewriteRuleTokenStream(adaptor,"token NONEQ");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:258:12: ( addOrArray NONEQ addOrArray -> ^( NonEqOp addOrArray addOrArray ) )
            // MyGrammar.g:258:14: addOrArray NONEQ addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_nonEqOp2152);
            	addOrArray89 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray89.Tree);
            	NONEQ90=(IToken)Match(input,NONEQ,FOLLOW_NONEQ_in_nonEqOp2154); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NONEQ.Add(NONEQ90);

            	PushFollow(FOLLOW_addOrArray_in_nonEqOp2156);
            	addOrArray91 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray91.Tree);


            	// AST REWRITE
            	// elements:          addOrArray, addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 258:42: -> ^( NonEqOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:258:45: ^( NonEqOp addOrArray addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new NonEqualityOperationNode(NonEqOp), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());
            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "nonEqOp"

    public class moreOp_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "moreOp"
    // MyGrammar.g:261:1: moreOp : addOrArray MORE addOrArray -> ^( MoreOp addOrArray addOrArray ) ;
    public MyGrammarParser.moreOp_return moreOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreOp_return retval = new MyGrammarParser.moreOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MORE93 = null;
        MyGrammarParser.addOrArray_return addOrArray92 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray94 = default(MyGrammarParser.addOrArray_return);


        object MORE93_tree=null;
        RewriteRuleTokenStream stream_MORE = new RewriteRuleTokenStream(adaptor,"token MORE");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:261:11: ( addOrArray MORE addOrArray -> ^( MoreOp addOrArray addOrArray ) )
            // MyGrammar.g:261:14: addOrArray MORE addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_moreOp2187);
            	addOrArray92 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray92.Tree);
            	MORE93=(IToken)Match(input,MORE,FOLLOW_MORE_in_moreOp2189); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MORE.Add(MORE93);

            	PushFollow(FOLLOW_addOrArray_in_moreOp2191);
            	addOrArray94 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray94.Tree);


            	// AST REWRITE
            	// elements:          addOrArray, addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 261:41: -> ^( MoreOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:261:44: ^( MoreOp addOrArray addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationMoreNode(MoreOp), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());
            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moreOp"

    public class moreEqOp_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "moreEqOp"
    // MyGrammar.g:264:1: moreEqOp : addOrArray MOREEQ addOrArray -> ^( MoreEqOp addOrArray addOrArray ) ;
    public MyGrammarParser.moreEqOp_return moreEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreEqOp_return retval = new MyGrammarParser.moreEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MOREEQ96 = null;
        MyGrammarParser.addOrArray_return addOrArray95 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray97 = default(MyGrammarParser.addOrArray_return);


        object MOREEQ96_tree=null;
        RewriteRuleTokenStream stream_MOREEQ = new RewriteRuleTokenStream(adaptor,"token MOREEQ");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:264:12: ( addOrArray MOREEQ addOrArray -> ^( MoreEqOp addOrArray addOrArray ) )
            // MyGrammar.g:264:14: addOrArray MOREEQ addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_moreEqOp2220);
            	addOrArray95 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray95.Tree);
            	MOREEQ96=(IToken)Match(input,MOREEQ,FOLLOW_MOREEQ_in_moreEqOp2222); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MOREEQ.Add(MOREEQ96);

            	PushFollow(FOLLOW_addOrArray_in_moreEqOp2224);
            	addOrArray97 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray97.Tree);


            	// AST REWRITE
            	// elements:          addOrArray, addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 264:43: -> ^( MoreEqOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:264:46: ^( MoreEqOp addOrArray addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationMoreEqNode(MoreEqOp), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());
            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moreEqOp"

    public class lessOp_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lessOp"
    // MyGrammar.g:267:1: lessOp : addOrArray LESS addOrArray -> ^( LessOp addOrArray addOrArray ) ;
    public MyGrammarParser.lessOp_return lessOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessOp_return retval = new MyGrammarParser.lessOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESS99 = null;
        MyGrammarParser.addOrArray_return addOrArray98 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray100 = default(MyGrammarParser.addOrArray_return);


        object LESS99_tree=null;
        RewriteRuleTokenStream stream_LESS = new RewriteRuleTokenStream(adaptor,"token LESS");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:267:11: ( addOrArray LESS addOrArray -> ^( LessOp addOrArray addOrArray ) )
            // MyGrammar.g:267:13: addOrArray LESS addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_lessOp2254);
            	addOrArray98 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray98.Tree);
            	LESS99=(IToken)Match(input,LESS,FOLLOW_LESS_in_lessOp2256); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LESS.Add(LESS99);

            	PushFollow(FOLLOW_addOrArray_in_lessOp2258);
            	addOrArray100 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray100.Tree);


            	// AST REWRITE
            	// elements:          addOrArray, addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 267:40: -> ^( LessOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:267:43: ^( LessOp addOrArray addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationLessNode(LessOp), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());
            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lessOp"

    public class lessEqOp_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lessEqOp"
    // MyGrammar.g:270:1: lessEqOp : addOrArray LESSEQ addOrArray -> ^( LessEqOp addOrArray addOrArray ) ;
    public MyGrammarParser.lessEqOp_return lessEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessEqOp_return retval = new MyGrammarParser.lessEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSEQ102 = null;
        MyGrammarParser.addOrArray_return addOrArray101 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray103 = default(MyGrammarParser.addOrArray_return);


        object LESSEQ102_tree=null;
        RewriteRuleTokenStream stream_LESSEQ = new RewriteRuleTokenStream(adaptor,"token LESSEQ");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:270:12: ( addOrArray LESSEQ addOrArray -> ^( LessEqOp addOrArray addOrArray ) )
            // MyGrammar.g:270:14: addOrArray LESSEQ addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_lessEqOp2287);
            	addOrArray101 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray101.Tree);
            	LESSEQ102=(IToken)Match(input,LESSEQ,FOLLOW_LESSEQ_in_lessEqOp2289); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LESSEQ.Add(LESSEQ102);

            	PushFollow(FOLLOW_addOrArray_in_lessEqOp2291);
            	addOrArray103 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray103.Tree);


            	// AST REWRITE
            	// elements:          addOrArray, addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 270:43: -> ^( LessEqOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:270:46: ^( LessEqOp addOrArray addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationLessEqNode(LessEqOp), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());
            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lessEqOp"

    public class cycle_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "cycle"
    // MyGrammar.g:275:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_104 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_105 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:275:7: ( for_ | while_ )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == FOR) )
            {
                alt17 = 1;
            }
            else if ( (LA17_0 == WHILE) )
            {
                alt17 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // MyGrammar.g:275:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle2320);
                    	for_104 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_104.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:276:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle2326);
                    	while_105 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_105.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cycle"

    public class for__return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "for_"
    // MyGrammar.g:280:1: for_ : FOR '(' varInitOrChangeValue ';' logicOperator ';' fieldInitValue ')' block -> ^( For varInitOrChangeValue logicOperator fieldInitValue block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR106 = null;
        IToken char_literal107 = null;
        IToken char_literal109 = null;
        IToken char_literal111 = null;
        IToken char_literal113 = null;
        MyGrammarParser.varInitOrChangeValue_return varInitOrChangeValue108 = default(MyGrammarParser.varInitOrChangeValue_return);

        MyGrammarParser.logicOperator_return logicOperator110 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.fieldInitValue_return fieldInitValue112 = default(MyGrammarParser.fieldInitValue_return);

        MyGrammarParser.block_return block114 = default(MyGrammarParser.block_return);


        object FOR106_tree=null;
        object char_literal107_tree=null;
        object char_literal109_tree=null;
        object char_literal111_tree=null;
        object char_literal113_tree=null;
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_92 = new RewriteRuleTokenStream(adaptor,"token 92");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_fieldInitValue = new RewriteRuleSubtreeStream(adaptor,"rule fieldInitValue");
        RewriteRuleSubtreeStream stream_varInitOrChangeValue = new RewriteRuleSubtreeStream(adaptor,"rule varInitOrChangeValue");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:280:6: ( FOR '(' varInitOrChangeValue ';' logicOperator ';' fieldInitValue ')' block -> ^( For varInitOrChangeValue logicOperator fieldInitValue block ) )
            // MyGrammar.g:280:8: FOR '(' varInitOrChangeValue ';' logicOperator ';' fieldInitValue ')' block
            {
            	FOR106=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_2338); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR106);

            	char_literal107=(IToken)Match(input,88,FOLLOW_88_in_for_2353); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(char_literal107);

            	PushFollow(FOLLOW_varInitOrChangeValue_in_for_2362);
            	varInitOrChangeValue108 = varInitOrChangeValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitOrChangeValue.Add(varInitOrChangeValue108.Tree);
            	char_literal109=(IToken)Match(input,92,FOLLOW_92_in_for_2364); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_92.Add(char_literal109);

            	PushFollow(FOLLOW_logicOperator_in_for_2369);
            	logicOperator110 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator110.Tree);
            	char_literal111=(IToken)Match(input,92,FOLLOW_92_in_for_2371); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_92.Add(char_literal111);

            	PushFollow(FOLLOW_fieldInitValue_in_for_2379);
            	fieldInitValue112 = fieldInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fieldInitValue.Add(fieldInitValue112.Tree);
            	char_literal113=(IToken)Match(input,89,FOLLOW_89_in_for_2384); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_89.Add(char_literal113);

            	PushFollow(FOLLOW_block_in_for_2389);
            	block114 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block114.Tree);


            	// AST REWRITE
            	// elements:          varInitOrChangeValue, fieldInitValue, block, logicOperator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 287:4: -> ^( For varInitOrChangeValue logicOperator fieldInitValue block )
            	{
            	    // MyGrammar.g:287:7: ^( For varInitOrChangeValue logicOperator fieldInitValue block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ForNode(For), root_1);

            	    adaptor.AddChild(root_1, stream_varInitOrChangeValue.NextTree());
            	    adaptor.AddChild(root_1, stream_logicOperator.NextTree());
            	    adaptor.AddChild(root_1, stream_fieldInitValue.NextTree());
            	    adaptor.AddChild(root_1, stream_block.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "for_"

    public class varInitOrChangeValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "varInitOrChangeValue"
    // MyGrammar.g:290:1: varInitOrChangeValue : ( varChangeValue | varInit );
    public MyGrammarParser.varInitOrChangeValue_return varInitOrChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInitOrChangeValue_return retval = new MyGrammarParser.varInitOrChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.varChangeValue_return varChangeValue115 = default(MyGrammarParser.varChangeValue_return);

        MyGrammarParser.varInit_return varInit116 = default(MyGrammarParser.varInit_return);



        try 
    	{
            // MyGrammar.g:290:22: ( varChangeValue | varInit )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == ID) )
            {
                alt18 = 1;
            }
            else if ( ((LA18_0 >= INT && LA18_0 <= STRING)) )
            {
                alt18 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // MyGrammar.g:290:24: varChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varChangeValue_in_varInitOrChangeValue2420);
                    	varChangeValue115 = varChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varChangeValue115.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:291:9: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_varInitOrChangeValue2430);
                    	varInit116 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit116.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "varInitOrChangeValue"

    public class while__return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "while_"
    // MyGrammar.g:294:1: while_ : WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE117 = null;
        IToken char_literal118 = null;
        IToken char_literal120 = null;
        MyGrammarParser.logicOperator_return logicOperator119 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block121 = default(MyGrammarParser.block_return);


        object WHILE117_tree=null;
        object char_literal118_tree=null;
        object char_literal120_tree=null;
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:294:8: ( WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) )
            // MyGrammar.g:294:10: WHILE '(' logicOperator ')' block
            {
            	WHILE117=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_2445); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE117);

            	char_literal118=(IToken)Match(input,88,FOLLOW_88_in_while_2450); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(char_literal118);

            	PushFollow(FOLLOW_logicOperator_in_while_2455);
            	logicOperator119 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator119.Tree);
            	char_literal120=(IToken)Match(input,89,FOLLOW_89_in_while_2460); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_89.Add(char_literal120);

            	PushFollow(FOLLOW_block_in_while_2465);
            	block121 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block121.Tree);


            	// AST REWRITE
            	// elements:          block, logicOperator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 299:4: -> ^( While_ logicOperator block )
            	{
            	    // MyGrammar.g:299:7: ^( While_ logicOperator block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new WhileNode(While_), root_1);

            	    adaptor.AddChild(root_1, stream_logicOperator.NextTree());
            	    adaptor.AddChild(root_1, stream_block.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "while_"

    public class methodDef_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "methodDef"
    // MyGrammar.g:305:1: methodDef : type ID '()' block -> ^( Method ^( ID ( type )? block ) ) ;
    public MyGrammarParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        MyGrammarParser.methodDef_return retval = new MyGrammarParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID123 = null;
        IToken string_literal124 = null;
        MyGrammarParser.type_return type122 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block125 = default(MyGrammarParser.block_return);


        object ID123_tree=null;
        object string_literal124_tree=null;
        RewriteRuleTokenStream stream_93 = new RewriteRuleTokenStream(adaptor,"token 93");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:305:11: ( type ID '()' block -> ^( Method ^( ID ( type )? block ) ) )
            // MyGrammar.g:305:13: type ID '()' block
            {
            	PushFollow(FOLLOW_type_in_methodDef2497);
            	type122 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type122.Tree);
            	ID123=(IToken)Match(input,ID,FOLLOW_ID_in_methodDef2499); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID123);

            	string_literal124=(IToken)Match(input,93,FOLLOW_93_in_methodDef2501); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_93.Add(string_literal124);

            	PushFollow(FOLLOW_block_in_methodDef2503);
            	block125 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block125.Tree);


            	// AST REWRITE
            	// elements:          type, ID, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 305:32: -> ^( Method ^( ID ( type )? block ) )
            	{
            	    // MyGrammar.g:305:35: ^( Method ^( ID ( type )? block ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(Method), root_1);

            	    // MyGrammar.g:305:59: ^( ID ( type )? block )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:305:64: ( type )?
            	    if ( stream_type.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_type.NextTree());

            	    }
            	    stream_type.Reset();
            	    adaptor.AddChild(root_2, stream_block.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "methodDef"

    public class callMethod_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "callMethod"
    // MyGrammar.g:309:1: callMethod : ID '()' -> ^( CallMethod ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID126 = null;
        IToken string_literal127 = null;

        object ID126_tree=null;
        object string_literal127_tree=null;
        RewriteRuleTokenStream stream_93 = new RewriteRuleTokenStream(adaptor,"token 93");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:309:12: ( ID '()' -> ^( CallMethod ID ) )
            // MyGrammar.g:309:14: ID '()'
            {
            	ID126=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod2533); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID126);

            	string_literal127=(IToken)Match(input,93,FOLLOW_93_in_callMethod2535); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_93.Add(string_literal127);



            	// AST REWRITE
            	// elements:          ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 310:5: -> ^( CallMethod ID )
            	{
            	    // MyGrammar.g:310:8: ^( CallMethod ID )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new CallMethodNode(CallMethod), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "callMethod"

    public class printExpr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "printExpr"
    // MyGrammar.g:315:1: printExpr : ( add | ident | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add128 = default(MyGrammarParser.add_return);

        MyGrammarParser.ident_return ident129 = default(MyGrammarParser.ident_return);

        MyGrammarParser.callMethod_return callMethod130 = default(MyGrammarParser.callMethod_return);



        try 
    	{
            // MyGrammar.g:315:11: ( add | ident | callMethod )
            int alt19 = 3;
            int LA19_0 = input.LA(1);

            if ( ((LA19_0 >= INTEGER && LA19_0 <= DOUBLE_) || LA19_0 == 88) )
            {
                alt19 = 1;
            }
            else if ( (LA19_0 == ID) )
            {
                int LA19_2 = input.LA(2);

                if ( (LA19_2 == 93) )
                {
                    alt19 = 3;
                }
                else if ( (synpred48_MyGrammar()) )
                {
                    alt19 = 1;
                }
                else if ( (synpred49_MyGrammar()) )
                {
                    alt19 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d19s2 =
                        new NoViableAltException("", 19, 2, input);

                    throw nvae_d19s2;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // MyGrammar.g:315:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr2565);
                    	add128 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add128.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:316:6: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_printExpr2572);
                    	ident129 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident129.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:317:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr2579);
                    	callMethod130 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod130.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "printExpr"

    public class changeValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "changeValue"
    // MyGrammar.g:320:1: changeValue : ( varChangeValue | arrayChangeValue );
    public MyGrammarParser.changeValue_return changeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.changeValue_return retval = new MyGrammarParser.changeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.varChangeValue_return varChangeValue131 = default(MyGrammarParser.varChangeValue_return);

        MyGrammarParser.arrayChangeValue_return arrayChangeValue132 = default(MyGrammarParser.arrayChangeValue_return);



        try 
    	{
            // MyGrammar.g:320:14: ( varChangeValue | arrayChangeValue )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == ID) )
            {
                int LA20_1 = input.LA(2);

                if ( (LA20_1 == 86) )
                {
                    alt20 = 2;
                }
                else if ( (LA20_1 == ASSIGN) )
                {
                    alt20 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d20s1 =
                        new NoViableAltException("", 20, 1, input);

                    throw nvae_d20s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // MyGrammar.g:320:16: varChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varChangeValue_in_changeValue2594);
                    	varChangeValue131 = varChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varChangeValue131.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:321:7: arrayChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayChangeValue_in_changeValue2602);
                    	arrayChangeValue132 = arrayChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayChangeValue132.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "changeValue"

    public class varChangeValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "varChangeValue"
    // MyGrammar.g:324:1: varChangeValue : ident ASSIGN initValue -> ^( Assign ident initValue ) ;
    public MyGrammarParser.varChangeValue_return varChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.varChangeValue_return retval = new MyGrammarParser.varChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN134 = null;
        MyGrammarParser.ident_return ident133 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue135 = default(MyGrammarParser.initValue_return);


        object ASSIGN134_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:324:16: ( ident ASSIGN initValue -> ^( Assign ident initValue ) )
            // MyGrammar.g:324:18: ident ASSIGN initValue
            {
            	PushFollow(FOLLOW_ident_in_varChangeValue2615);
            	ident133 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident133.Tree);
            	ASSIGN134=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_varChangeValue2617); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN134);

            	PushFollow(FOLLOW_initValue_in_varChangeValue2619);
            	initValue135 = initValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_initValue.Add(initValue135.Tree);


            	// AST REWRITE
            	// elements:          initValue, ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 325:7: -> ^( Assign ident initValue )
            	{
            	    // MyGrammar.g:325:10: ^( Assign ident initValue )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AssignNode(Assign), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    adaptor.AddChild(root_1, stream_initValue.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "varChangeValue"

    public class arrayChangeValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arrayChangeValue"
    // MyGrammar.g:328:1: arrayChangeValue : ident '[' add ']' ( ASSIGN initValue )? -> ^( ArrayInit ident add ( initValue )? ) ;
    public MyGrammarParser.arrayChangeValue_return arrayChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.arrayChangeValue_return retval = new MyGrammarParser.arrayChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal137 = null;
        IToken char_literal139 = null;
        IToken ASSIGN140 = null;
        MyGrammarParser.ident_return ident136 = default(MyGrammarParser.ident_return);

        MyGrammarParser.add_return add138 = default(MyGrammarParser.add_return);

        MyGrammarParser.initValue_return initValue141 = default(MyGrammarParser.initValue_return);


        object char_literal137_tree=null;
        object char_literal139_tree=null;
        object ASSIGN140_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:328:18: ( ident '[' add ']' ( ASSIGN initValue )? -> ^( ArrayInit ident add ( initValue )? ) )
            // MyGrammar.g:328:20: ident '[' add ']' ( ASSIGN initValue )?
            {
            	PushFollow(FOLLOW_ident_in_arrayChangeValue2651);
            	ident136 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident136.Tree);
            	char_literal137=(IToken)Match(input,86,FOLLOW_86_in_arrayChangeValue2653); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal137);

            	PushFollow(FOLLOW_add_in_arrayChangeValue2655);
            	add138 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add138.Tree);
            	char_literal139=(IToken)Match(input,87,FOLLOW_87_in_arrayChangeValue2657); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(char_literal139);

            	// MyGrammar.g:328:38: ( ASSIGN initValue )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == ASSIGN) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // MyGrammar.g:328:39: ASSIGN initValue
            	        {
            	        	ASSIGN140=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_arrayChangeValue2660); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN140);

            	        	PushFollow(FOLLOW_initValue_in_arrayChangeValue2663);
            	        	initValue141 = initValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initValue.Add(initValue141.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          initValue, add, ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 329:8: -> ^( ArrayInit ident add ( initValue )? )
            	{
            	    // MyGrammar.g:329:11: ^( ArrayInit ident add ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ArrayInitNode(ArrayInit), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    // MyGrammar.g:329:48: ( initValue )?
            	    if ( stream_initValue.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_initValue.NextTree());

            	    }
            	    stream_initValue.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arrayChangeValue"

    public class addOrArray_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "addOrArray"
    // MyGrammar.g:332:1: addOrArray : ( string_ | add | arrayChangeValue );
    public MyGrammarParser.addOrArray_return addOrArray() // throws RecognitionException [1]
    {   
        MyGrammarParser.addOrArray_return retval = new MyGrammarParser.addOrArray_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.string__return string_142 = default(MyGrammarParser.string__return);

        MyGrammarParser.add_return add143 = default(MyGrammarParser.add_return);

        MyGrammarParser.arrayChangeValue_return arrayChangeValue144 = default(MyGrammarParser.arrayChangeValue_return);



        try 
    	{
            // MyGrammar.g:332:13: ( string_ | add | arrayChangeValue )
            int alt22 = 3;
            switch ( input.LA(1) ) 
            {
            case QUOTES:
            	{
                alt22 = 1;
                }
                break;
            case INTEGER:
            case DOUBLE_:
            case 88:
            	{
                alt22 = 2;
                }
                break;
            case ID:
            	{
                int LA22_3 = input.LA(2);

                if ( (LA22_3 == EOF || (LA22_3 >= PRINT && LA22_3 <= IF) || (LA22_3 >= INT && LA22_3 <= STRING) || (LA22_3 >= FOR && LA22_3 <= WHILE) || (LA22_3 >= AND && LA22_3 <= LESSEQ) || (LA22_3 >= INTEGER && LA22_3 <= ID) || (LA22_3 >= 88 && LA22_3 <= 89) || (LA22_3 >= 91 && LA22_3 <= 92)) )
                {
                    alt22 = 2;
                }
                else if ( (LA22_3 == 86) )
                {
                    alt22 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d22s3 =
                        new NoViableAltException("", 22, 3, input);

                    throw nvae_d22s3;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("", 22, 0, input);

            	    throw nvae_d22s0;
            }

            switch (alt22) 
            {
                case 1 :
                    // MyGrammar.g:332:15: string_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string__in_addOrArray2705);
                    	string_142 = string_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_142.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:333:7: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_addOrArray2713);
                    	add143 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add143.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:334:7: arrayChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayChangeValue_in_addOrArray2721);
                    	arrayChangeValue144 = arrayChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayChangeValue144.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "addOrArray"

    public class print_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "print"
    // MyGrammar.g:337:1: print : PRINT addOrArray -> ^( Print addOrArray ) ;
    public MyGrammarParser.print_return print() // throws RecognitionException [1]
    {   
        MyGrammarParser.print_return retval = new MyGrammarParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINT145 = null;
        MyGrammarParser.addOrArray_return addOrArray146 = default(MyGrammarParser.addOrArray_return);


        object PRINT145_tree=null;
        RewriteRuleTokenStream stream_PRINT = new RewriteRuleTokenStream(adaptor,"token PRINT");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:337:8: ( PRINT addOrArray -> ^( Print addOrArray ) )
            // MyGrammar.g:337:10: PRINT addOrArray
            {
            	PRINT145=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print2735); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINT.Add(PRINT145);

            	PushFollow(FOLLOW_addOrArray_in_print2737);
            	addOrArray146 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray146.Tree);


            	// AST REWRITE
            	// elements:          addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 338:6: -> ^( Print addOrArray )
            	{
            	    // MyGrammar.g:338:9: ^( Print addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new PrintNode(Print), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "print"

    public class println_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "println"
    // MyGrammar.g:341:1: println : PRINTLN addOrArray -> ^( Println addOrArray ) ;
    public MyGrammarParser.println_return println() // throws RecognitionException [1]
    {   
        MyGrammarParser.println_return retval = new MyGrammarParser.println_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINTLN147 = null;
        MyGrammarParser.addOrArray_return addOrArray148 = default(MyGrammarParser.addOrArray_return);


        object PRINTLN147_tree=null;
        RewriteRuleTokenStream stream_PRINTLN = new RewriteRuleTokenStream(adaptor,"token PRINTLN");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:341:10: ( PRINTLN addOrArray -> ^( Println addOrArray ) )
            // MyGrammar.g:341:12: PRINTLN addOrArray
            {
            	PRINTLN147=(IToken)Match(input,PRINTLN,FOLLOW_PRINTLN_in_println2766); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINTLN.Add(PRINTLN147);

            	PushFollow(FOLLOW_addOrArray_in_println2768);
            	addOrArray148 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray148.Tree);


            	// AST REWRITE
            	// elements:          addOrArray
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 342:6: -> ^( Println addOrArray )
            	{
            	    // MyGrammar.g:342:9: ^( Println addOrArray )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new PrintlnNode(Println), root_1);

            	    adaptor.AddChild(root_1, stream_addOrArray.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "println"

    public class nextLine_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "nextLine"
    // MyGrammar.g:345:1: nextLine : NEXTLINE -> NextLine ;
    public MyGrammarParser.nextLine_return nextLine() // throws RecognitionException [1]
    {   
        MyGrammarParser.nextLine_return retval = new MyGrammarParser.nextLine_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEXTLINE149 = null;

        object NEXTLINE149_tree=null;
        RewriteRuleTokenStream stream_NEXTLINE = new RewriteRuleTokenStream(adaptor,"token NEXTLINE");

        try 
    	{
            // MyGrammar.g:345:10: ( NEXTLINE -> NextLine )
            // MyGrammar.g:345:12: NEXTLINE
            {
            	NEXTLINE149=(IToken)Match(input,NEXTLINE,FOLLOW_NEXTLINE_in_nextLine2796); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NEXTLINE.Add(NEXTLINE149);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 346:6: -> NextLine
            	{
            	    adaptor.AddChild(root_0, new NextLineNode(NextLine));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "nextLine"

    public class expr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // MyGrammar.g:349:1: expr : ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | println | nextLine | changeValue );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add150 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_151 = default(MyGrammarParser.if__return);

        MyGrammarParser.init_return init152 = default(MyGrammarParser.init_return);

        MyGrammarParser.arrayInit_return arrayInit153 = default(MyGrammarParser.arrayInit_return);

        MyGrammarParser.cycle_return cycle154 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.fieldInitValue_return fieldInitValue155 = default(MyGrammarParser.fieldInitValue_return);

        MyGrammarParser.callMethod_return callMethod156 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print157 = default(MyGrammarParser.print_return);

        MyGrammarParser.println_return println158 = default(MyGrammarParser.println_return);

        MyGrammarParser.nextLine_return nextLine159 = default(MyGrammarParser.nextLine_return);

        MyGrammarParser.changeValue_return changeValue160 = default(MyGrammarParser.changeValue_return);



        try 
    	{
            // MyGrammar.g:349:6: ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | println | nextLine | changeValue )
            int alt23 = 11;
            alt23 = dfa23.Predict(input);
            switch (alt23) 
            {
                case 1 :
                    // MyGrammar.g:349:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr2820);
                    	add150 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add150.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:350:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr2826);
                    	if_151 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_151.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:351:5: init
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_init_in_expr2832);
                    	init152 = init();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, init152.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:352:5: arrayInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_expr2838);
                    	arrayInit153 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit153.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:353:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr2844);
                    	cycle154 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle154.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:354:5: fieldInitValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fieldInitValue_in_expr2850);
                    	fieldInitValue155 = fieldInitValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fieldInitValue155.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:355:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr2856);
                    	callMethod156 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod156.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:356:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr2862);
                    	print157 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print157.Tree);

                    }
                    break;
                case 9 :
                    // MyGrammar.g:357:5: println
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_println_in_expr2868);
                    	println158 = println();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, println158.Tree);

                    }
                    break;
                case 10 :
                    // MyGrammar.g:358:5: nextLine
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nextLine_in_expr2874);
                    	nextLine159 = nextLine();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nextLine159.Tree);

                    }
                    break;
                case 11 :
                    // MyGrammar.g:359:5: changeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_changeValue_in_expr2880);
                    	changeValue160 = changeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, changeValue160.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class line_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "line"
    // MyGrammar.g:362:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal162 = null;
        MyGrammarParser.expr_return expr161 = default(MyGrammarParser.expr_return);


        object char_literal162_tree=null;

        try 
    	{
            // MyGrammar.g:362:6: ( expr ( ';' )* )
            // MyGrammar.g:362:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line2891);
            	expr161 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr161.Tree);
            	// MyGrammar.g:362:13: ( ';' )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == 92) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // MyGrammar.g:362:14: ';'
            			    {
            			    	char_literal162=(IToken)Match(input,92,FOLLOW_92_in_line2894); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "line"

    public class exprList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "exprList"
    // MyGrammar.g:365:1: exprList : ( methodDef ( ';' )* | varInit ( ';' )* | arrayInit ( ';' )* );
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal164 = null;
        IToken char_literal166 = null;
        IToken char_literal168 = null;
        MyGrammarParser.methodDef_return methodDef163 = default(MyGrammarParser.methodDef_return);

        MyGrammarParser.varInit_return varInit165 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.arrayInit_return arrayInit167 = default(MyGrammarParser.arrayInit_return);


        object char_literal164_tree=null;
        object char_literal166_tree=null;
        object char_literal168_tree=null;

        try 
    	{
            // MyGrammar.g:365:9: ( methodDef ( ';' )* | varInit ( ';' )* | arrayInit ( ';' )* )
            int alt28 = 3;
            int LA28_0 = input.LA(1);

            if ( ((LA28_0 >= INT && LA28_0 <= STRING)) )
            {
                int LA28_1 = input.LA(2);

                if ( (LA28_1 == 85) )
                {
                    alt28 = 3;
                }
                else if ( (LA28_1 == ID) )
                {
                    int LA28_3 = input.LA(3);

                    if ( (LA28_3 == 93) )
                    {
                        alt28 = 1;
                    }
                    else if ( (LA28_3 == EOF || LA28_3 == ASSIGN || (LA28_3 >= INT && LA28_3 <= STRING) || LA28_3 == 92) )
                    {
                        alt28 = 2;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d28s3 =
                            new NoViableAltException("", 28, 3, input);

                        throw nvae_d28s3;
                    }
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d28s1 =
                        new NoViableAltException("", 28, 1, input);

                    throw nvae_d28s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d28s0 =
                    new NoViableAltException("", 28, 0, input);

                throw nvae_d28s0;
            }
            switch (alt28) 
            {
                case 1 :
                    // MyGrammar.g:365:11: methodDef ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodDef_in_exprList2908);
                    	methodDef163 = methodDef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef163.Tree);
                    	// MyGrammar.g:365:22: ( ';' )*
                    	do 
                    	{
                    	    int alt25 = 2;
                    	    int LA25_0 = input.LA(1);

                    	    if ( (LA25_0 == 92) )
                    	    {
                    	        alt25 = 1;
                    	    }


                    	    switch (alt25) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:365:23: ';'
                    			    {
                    			    	char_literal164=(IToken)Match(input,92,FOLLOW_92_in_exprList2912); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop25;
                    	    }
                    	} while (true);

                    	loop25:
                    		;	// Stops C# compiler whining that label 'loop25' has no statements


                    }
                    break;
                case 2 :
                    // MyGrammar.g:366:5: varInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_exprList2922);
                    	varInit165 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit165.Tree);
                    	// MyGrammar.g:366:13: ( ';' )*
                    	do 
                    	{
                    	    int alt26 = 2;
                    	    int LA26_0 = input.LA(1);

                    	    if ( (LA26_0 == 92) )
                    	    {
                    	        alt26 = 1;
                    	    }


                    	    switch (alt26) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:366:14: ';'
                    			    {
                    			    	char_literal166=(IToken)Match(input,92,FOLLOW_92_in_exprList2925); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop26;
                    	    }
                    	} while (true);

                    	loop26:
                    		;	// Stops C# compiler whining that label 'loop26' has no statements


                    }
                    break;
                case 3 :
                    // MyGrammar.g:367:5: arrayInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_exprList2935);
                    	arrayInit167 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit167.Tree);
                    	// MyGrammar.g:367:15: ( ';' )*
                    	do 
                    	{
                    	    int alt27 = 2;
                    	    int LA27_0 = input.LA(1);

                    	    if ( (LA27_0 == 92) )
                    	    {
                    	        alt27 = 1;
                    	    }


                    	    switch (alt27) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:367:16: ';'
                    			    {
                    			    	char_literal168=(IToken)Match(input,92,FOLLOW_92_in_exprList2938); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop27;
                    	    }
                    	} while (true);

                    	loop27:
                    		;	// Stops C# compiler whining that label 'loop27' has no statements


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exprList"

    public class fullProgramm_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fullProgramm"
    // MyGrammar.g:373:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList169 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:373:13: ( ( exprList )* )
            // MyGrammar.g:374:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:374:4: ( exprList )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( ((LA29_0 >= INT && LA29_0 <= STRING)) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm2959);
            			    	exprList169 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList169.Tree);

            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fullProgramm"

    public class program_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // MyGrammar.g:377:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm170 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:377:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:378:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program2973);
            	fullProgramm170 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm170.Tree);


            	// AST REWRITE
            	// elements:          fullProgramm
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 378:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:378:19: ^( PROGRAM fullProgramm )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

            	    adaptor.AddChild(root_1, stream_fullProgramm.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class execute_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "execute"
    // MyGrammar.g:381:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program171 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:381:8: ( program )
            // MyGrammar.g:382:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute2991);
            	program171 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program171.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "execute"

    // $ANTLR start "synpred19_MyGrammar"
    public void synpred19_MyGrammar_fragment() {
        // MyGrammar.g:190:14: ( addOrArray )
        // MyGrammar.g:190:14: addOrArray
        {
        	PushFollow(FOLLOW_addOrArray_in_synpred19_MyGrammar1520);
        	addOrArray();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_MyGrammar"

    // $ANTLR start "synpred21_MyGrammar"
    public void synpred21_MyGrammar_fragment() {
        // MyGrammar.g:192:7: ( ident )
        // MyGrammar.g:192:7: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred21_MyGrammar1536);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred21_MyGrammar"

    // $ANTLR start "synpred32_MyGrammar"
    public void synpred32_MyGrammar_fragment() {
        // MyGrammar.g:228:16: ( orOperation )
        // MyGrammar.g:228:16: orOperation
        {
        	PushFollow(FOLLOW_orOperation_in_synpred32_MyGrammar1804);
        	orOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_MyGrammar"

    // $ANTLR start "synpred33_MyGrammar"
    public void synpred33_MyGrammar_fragment() {
        // MyGrammar.g:229:8: ( andOperation )
        // MyGrammar.g:229:8: andOperation
        {
        	PushFollow(FOLLOW_andOperation_in_synpred33_MyGrammar1824);
        	andOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_MyGrammar"

    // $ANTLR start "synpred34_MyGrammar"
    public void synpred34_MyGrammar_fragment() {
        // MyGrammar.g:230:8: ( eqOp )
        // MyGrammar.g:230:8: eqOp
        {
        	PushFollow(FOLLOW_eqOp_in_synpred34_MyGrammar1844);
        	eqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_MyGrammar"

    // $ANTLR start "synpred35_MyGrammar"
    public void synpred35_MyGrammar_fragment() {
        // MyGrammar.g:231:8: ( nonEqOp )
        // MyGrammar.g:231:8: nonEqOp
        {
        	PushFollow(FOLLOW_nonEqOp_in_synpred35_MyGrammar1864);
        	nonEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred35_MyGrammar"

    // $ANTLR start "synpred36_MyGrammar"
    public void synpred36_MyGrammar_fragment() {
        // MyGrammar.g:232:8: ( moreOp )
        // MyGrammar.g:232:8: moreOp
        {
        	PushFollow(FOLLOW_moreOp_in_synpred36_MyGrammar1884);
        	moreOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred36_MyGrammar"

    // $ANTLR start "synpred37_MyGrammar"
    public void synpred37_MyGrammar_fragment() {
        // MyGrammar.g:233:8: ( moreEqOp )
        // MyGrammar.g:233:8: moreEqOp
        {
        	PushFollow(FOLLOW_moreEqOp_in_synpred37_MyGrammar1904);
        	moreEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred37_MyGrammar"

    // $ANTLR start "synpred38_MyGrammar"
    public void synpred38_MyGrammar_fragment() {
        // MyGrammar.g:234:8: ( lessOp )
        // MyGrammar.g:234:8: lessOp
        {
        	PushFollow(FOLLOW_lessOp_in_synpred38_MyGrammar1924);
        	lessOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_MyGrammar"

    // $ANTLR start "synpred39_MyGrammar"
    public void synpred39_MyGrammar_fragment() {
        // MyGrammar.g:238:18: ( orOperation )
        // MyGrammar.g:238:18: orOperation
        {
        	PushFollow(FOLLOW_orOperation_in_synpred39_MyGrammar1972);
        	orOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_MyGrammar"

    // $ANTLR start "synpred40_MyGrammar"
    public void synpred40_MyGrammar_fragment() {
        // MyGrammar.g:239:8: ( andOperation )
        // MyGrammar.g:239:8: andOperation
        {
        	PushFollow(FOLLOW_andOperation_in_synpred40_MyGrammar1981);
        	andOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred40_MyGrammar"

    // $ANTLR start "synpred41_MyGrammar"
    public void synpred41_MyGrammar_fragment() {
        // MyGrammar.g:240:8: ( eqOp )
        // MyGrammar.g:240:8: eqOp
        {
        	PushFollow(FOLLOW_eqOp_in_synpred41_MyGrammar1990);
        	eqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred41_MyGrammar"

    // $ANTLR start "synpred42_MyGrammar"
    public void synpred42_MyGrammar_fragment() {
        // MyGrammar.g:241:8: ( nonEqOp )
        // MyGrammar.g:241:8: nonEqOp
        {
        	PushFollow(FOLLOW_nonEqOp_in_synpred42_MyGrammar1999);
        	nonEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred42_MyGrammar"

    // $ANTLR start "synpred43_MyGrammar"
    public void synpred43_MyGrammar_fragment() {
        // MyGrammar.g:242:8: ( moreOp )
        // MyGrammar.g:242:8: moreOp
        {
        	PushFollow(FOLLOW_moreOp_in_synpred43_MyGrammar2008);
        	moreOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred43_MyGrammar"

    // $ANTLR start "synpred44_MyGrammar"
    public void synpred44_MyGrammar_fragment() {
        // MyGrammar.g:243:8: ( moreEqOp )
        // MyGrammar.g:243:8: moreEqOp
        {
        	PushFollow(FOLLOW_moreEqOp_in_synpred44_MyGrammar2017);
        	moreEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred44_MyGrammar"

    // $ANTLR start "synpred45_MyGrammar"
    public void synpred45_MyGrammar_fragment() {
        // MyGrammar.g:244:8: ( lessOp )
        // MyGrammar.g:244:8: lessOp
        {
        	PushFollow(FOLLOW_lessOp_in_synpred45_MyGrammar2026);
        	lessOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred45_MyGrammar"

    // $ANTLR start "synpred48_MyGrammar"
    public void synpred48_MyGrammar_fragment() {
        // MyGrammar.g:315:13: ( add )
        // MyGrammar.g:315:13: add
        {
        	PushFollow(FOLLOW_add_in_synpred48_MyGrammar2565);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred48_MyGrammar"

    // $ANTLR start "synpred49_MyGrammar"
    public void synpred49_MyGrammar_fragment() {
        // MyGrammar.g:316:6: ( ident )
        // MyGrammar.g:316:6: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred49_MyGrammar2572);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_MyGrammar"

    // $ANTLR start "synpred54_MyGrammar"
    public void synpred54_MyGrammar_fragment() {
        // MyGrammar.g:349:8: ( add )
        // MyGrammar.g:349:8: add
        {
        	PushFollow(FOLLOW_add_in_synpred54_MyGrammar2820);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred54_MyGrammar"

    // $ANTLR start "synpred56_MyGrammar"
    public void synpred56_MyGrammar_fragment() {
        // MyGrammar.g:351:5: ( init )
        // MyGrammar.g:351:5: init
        {
        	PushFollow(FOLLOW_init_in_synpred56_MyGrammar2832);
        	init();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred56_MyGrammar"

    // $ANTLR start "synpred57_MyGrammar"
    public void synpred57_MyGrammar_fragment() {
        // MyGrammar.g:352:5: ( arrayInit )
        // MyGrammar.g:352:5: arrayInit
        {
        	PushFollow(FOLLOW_arrayInit_in_synpred57_MyGrammar2838);
        	arrayInit();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred57_MyGrammar"

    // $ANTLR start "synpred59_MyGrammar"
    public void synpred59_MyGrammar_fragment() {
        // MyGrammar.g:354:5: ( fieldInitValue )
        // MyGrammar.g:354:5: fieldInitValue
        {
        	PushFollow(FOLLOW_fieldInitValue_in_synpred59_MyGrammar2850);
        	fieldInitValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred59_MyGrammar"

    // Delegated rules

   	public bool synpred37_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred37_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred42_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred42_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred56_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred56_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred19_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred19_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred43_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred43_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred38_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred38_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred44_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred44_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred49_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred49_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred36_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred36_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred57_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred57_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred33_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred33_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred32_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred32_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred45_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred45_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred48_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred48_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred35_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred35_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred40_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred40_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred54_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred54_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred39_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred39_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred34_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred34_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred41_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred41_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred59_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred59_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred21_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred21_MyGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA7 dfa7;
   	protected DFA15 dfa15;
   	protected DFA16 dfa16;
   	protected DFA23 dfa23;
	private void InitializeCyclicDFAs()
	{
    	this.dfa7 = new DFA7(this);
    	this.dfa15 = new DFA15(this);
    	this.dfa16 = new DFA16(this);
    	this.dfa23 = new DFA23(this);
	    this.dfa7.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA7_SpecialStateTransition);
	    this.dfa15.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA15_SpecialStateTransition);
	    this.dfa16.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA16_SpecialStateTransition);
	    this.dfa23.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA23_SpecialStateTransition);
	}

    const string DFA7_eotS =
        "\x0b\uffff";
    const string DFA7_eofS =
        "\x0b\uffff";
    const string DFA7_minS =
        "\x01\x35\x01\x53\x01\uffff\x01\x5d\x02\uffff\x01\x50\x02\uffff"+
        "\x01\x00\x01\uffff";
    const string DFA7_maxS =
        "\x01\x58\x01\x53\x01\uffff\x01\x5d\x02\uffff\x01\x50\x02\uffff"+
        "\x01\x00\x01\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x01\x01\uffff\x01\x04\x01\x05\x01\uffff\x01\x02"+
        "\x01\x03\x01\uffff\x01\x06";
    const string DFA7_specialS =
        "\x03\uffff\x01\x00\x05\uffff\x01\x01\x01\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x04\x01\x05\x19\uffff\x01\x01\x02\x02\x01\x03\x04\uffff"+
            "\x01\x02",
            "\x01\x06",
            "",
            "\x01\x07",
            "",
            "",
            "\x01\x09",
            "",
            "",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "190:1: initValue : ( addOrArray | callMethod | ident | inc | dec | string_ );"; }
        }

    }


    protected internal int DFA7_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA7_3 = input.LA(1);

                   	 
                   	int index7_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA7_3 == 93) ) { s = 7; }

                   	else if ( (synpred19_MyGrammar()) ) { s = 2; }

                   	else if ( (synpred21_MyGrammar()) ) { s = 8; }

                   	 
                   	input.Seek(index7_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA7_9 = input.LA(1);

                   	 
                   	int index7_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred19_MyGrammar()) ) { s = 2; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index7_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae7 =
            new NoViableAltException(dfa.Description, 7, _s, input);
        dfa.Error(nvae7);
        throw nvae7;
    }
    const string DFA15_eotS =
        "\x0e\uffff";
    const string DFA15_eofS =
        "\x0e\uffff";
    const string DFA15_minS =
        "\x01\x50\x05\x00\x08\uffff";
    const string DFA15_maxS =
        "\x01\x58\x05\x00\x08\uffff";
    const string DFA15_acceptS =
        "\x06\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08";
    const string DFA15_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x08\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x01\x01\x01\x03\x01\x04\x01\x05\x04\uffff\x01\x02",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "228:1: operations : ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) );"; }
        }

    }


    protected internal int DFA15_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA15_1 = input.LA(1);

                   	 
                   	int index15_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index15_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA15_2 = input.LA(1);

                   	 
                   	int index15_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index15_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA15_3 = input.LA(1);

                   	 
                   	int index15_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index15_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA15_4 = input.LA(1);

                   	 
                   	int index15_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index15_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA15_5 = input.LA(1);

                   	 
                   	int index15_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index15_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae15 =
            new NoViableAltException(dfa.Description, 15, _s, input);
        dfa.Error(nvae15);
        throw nvae15;
    }
    const string DFA16_eotS =
        "\x0e\uffff";
    const string DFA16_eofS =
        "\x0e\uffff";
    const string DFA16_minS =
        "\x01\x50\x05\x00\x08\uffff";
    const string DFA16_maxS =
        "\x01\x58\x05\x00\x08\uffff";
    const string DFA16_acceptS =
        "\x06\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08";
    const string DFA16_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x08\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x01\x01\x01\x03\x01\x04\x01\x05\x04\uffff\x01\x02",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "238:1: logicOperator : ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp );"; }
        }

    }


    protected internal int DFA16_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA16_1 = input.LA(1);

                   	 
                   	int index16_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred39_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred43_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred44_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred45_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index16_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA16_2 = input.LA(1);

                   	 
                   	int index16_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred39_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred43_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred44_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred45_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index16_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA16_3 = input.LA(1);

                   	 
                   	int index16_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred39_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred43_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred44_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred45_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index16_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA16_4 = input.LA(1);

                   	 
                   	int index16_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred39_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred43_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred44_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred45_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index16_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA16_5 = input.LA(1);

                   	 
                   	int index16_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred39_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred43_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred44_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred45_MyGrammar()) ) { s = 12; }

                   	else if ( (true) ) { s = 13; }

                   	 
                   	input.Seek(index16_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae16 =
            new NoViableAltException(dfa.Description, 16, _s, input);
        dfa.Error(nvae16);
        throw nvae16;
    }
    const string DFA23_eotS =
        "\x10\uffff";
    const string DFA23_eofS =
        "\x10\uffff";
    const string DFA23_minS =
        "\x01\x24\x01\uffff\x01\x30\x01\uffff\x01\x53\x07\uffff\x01\x53"+
        "\x01\uffff\x01\x00\x01\uffff";
    const string DFA23_maxS =
        "\x01\x58\x01\uffff\x01\x5d\x01\uffff\x01\x55\x07\uffff\x01\x53"+
        "\x01\uffff\x01\x00\x01\uffff";
    const string DFA23_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\uffff\x01\x05\x01\x08"+
        "\x01\x09\x01\x0a\x01\x07\x01\x0b\x01\x06\x01\uffff\x01\x03\x01\uffff"+
        "\x01\x04";
    const string DFA23_specialS =
        "\x02\uffff\x01\x01\x0b\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA23_transitionS = {
            "\x01\x06\x01\x07\x01\x08\x04\uffff\x01\x03\x0b\uffff\x06\x04"+
            "\x08\uffff\x02\x05\x0a\uffff\x02\x01\x01\x02\x04\uffff\x01\x01",
            "",
            "\x01\x0a\x25\uffff\x01\x0a\x06\uffff\x01\x09",
            "",
            "\x01\x0d\x01\uffff\x01\x0c",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0e",
            "",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
    static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
    static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
    static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
    static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
    static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
    static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray(DFA23_transitionS);

    protected class DFA23 : DFA
    {
        public DFA23(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;

        }

        override public string Description
        {
            get { return "349:1: expr : ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | println | nextLine | changeValue );"; }
        }

    }


    protected internal int DFA23_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA23_14 = input.LA(1);

                   	 
                   	int index23_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred56_MyGrammar()) ) { s = 13; }

                   	else if ( (synpred57_MyGrammar()) ) { s = 15; }

                   	 
                   	input.Seek(index23_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA23_2 = input.LA(1);

                   	 
                   	int index23_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA23_2 == 93) ) { s = 9; }

                   	else if ( (LA23_2 == ASSIGN || LA23_2 == 86) ) { s = 10; }

                   	else if ( (synpred54_MyGrammar()) ) { s = 1; }

                   	else if ( (synpred59_MyGrammar()) ) { s = 11; }

                   	 
                   	input.Seek(index23_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae23 =
            new NoViableAltException(dfa.Description, 23, _s, input);
        dfa.Error(nvae23);
        throw nvae23;
    }
 

    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inc_in_incDec1054 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dec_in_incDec1060 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_inc1073 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECREMENT_in_dec1096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_in_number1189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE__in_number1206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOTES_in_string_1231 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_ID_in_string_1233 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_QUOTES_in_string_1235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_ident1301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_init1326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_init1333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_arrayInit1344 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_arrayInit1346 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_ident_in_arrayInit1348 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_arrayInit1351 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NEW_in_arrayInit1353 = new BitSet(new ulong[]{0x1F80000000000000UL});
    public static readonly BitSet FOLLOW_type_in_arrayInit1355 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_arrayInit1357 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010E0000UL});
    public static readonly BitSet FOLLOW_add_in_arrayInit1359 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_arrayInit1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_varInit1398 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_varInit1400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_fieldInitValue1430 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_fieldInitValue1434 = new BitSet(new ulong[]{0x0060000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_initValue_in_fieldInitValue1436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_stringInit1475 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_stringInit1479 = new BitSet(new ulong[]{0x0060000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_initValue_in_stringInit1481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_initValue1520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_initValue1528 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_initValue1536 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inc_in_initValue1544 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dec_in_initValue1552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string__in_initValue1560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_addOperation1574 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_addOperation1589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multOperation1609 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multOperation1624 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_88_in_group1647 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010E0000UL});
    public static readonly BitSet FOLLOW_add_in_group1650 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_group1652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group1660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_group1666 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult1681 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_multOperation_in_mult1685 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010E0000UL});
    public static readonly BitSet FOLLOW_group_in_mult1688 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_mult_in_add1700 = new BitSet(new ulong[]{0x0000018000000002UL});
    public static readonly BitSet FOLLOW_addOperation_in_add1704 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010E0000UL});
    public static readonly BitSet FOLLOW_mult_in_add1707 = new BitSet(new ulong[]{0x0000018000000002UL});
    public static readonly BitSet FOLLOW_90_in_block1719 = new BitSet(new ulong[]{0x1F80087000000000UL,0x00000000090F0060UL});
    public static readonly BitSet FOLLOW_line_in_block1721 = new BitSet(new ulong[]{0x1F80087000000000UL,0x00000000090F0060UL});
    public static readonly BitSet FOLLOW_91_in_block1724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_1749 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_88_in_if_1751 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_1753 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_if_1755 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_in_if_1757 = new BitSet(new ulong[]{0x0000100000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_if_1760 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_in_if_1762 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_operations1804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_operations1824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_operations1844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_operations1864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_operations1884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_operations1904 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_operations1924 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_operations1944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator1972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_logicOperator1981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_logicOperator1990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_logicOperator1999 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_logicOperator2008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_logicOperator2017 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_logicOperator2026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_logicOperator2035 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_orOperation2052 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_OR_in_orOperation2054 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_orOperation2056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_andOperation2084 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_AND_in_andOperation2086 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_andOperation2088 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_eqOp2118 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_EQ_in_eqOp2120 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_eqOp2122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_nonEqOp2152 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_NONEQ_in_nonEqOp2154 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_nonEqOp2156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_moreOp2187 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_MORE_in_moreOp2189 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_moreOp2191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_moreEqOp2220 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_MOREEQ_in_moreEqOp2222 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_moreEqOp2224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_lessOp2254 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LESS_in_lessOp2256 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_lessOp2258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_lessEqOp2287 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LESSEQ_in_lessEqOp2289 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_lessEqOp2291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle2320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle2326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_2338 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_88_in_for_2353 = new BitSet(new ulong[]{0x1F80000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_varInitOrChangeValue_in_for_2362 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_92_in_for_2364 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_2369 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_92_in_for_2371 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_for_2379 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_for_2384 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_in_for_2389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varChangeValue_in_varInitOrChangeValue2420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_varInitOrChangeValue2430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_2445 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_88_in_while_2450 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_2455 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_while_2460 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_in_while_2465 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_methodDef2497 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_ID_in_methodDef2499 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_93_in_methodDef2501 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_block_in_methodDef2503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod2533 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_93_in_callMethod2535 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr2565 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_printExpr2572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr2579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varChangeValue_in_changeValue2594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayChangeValue_in_changeValue2602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_varChangeValue2615 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_varChangeValue2617 = new BitSet(new ulong[]{0x0060000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_initValue_in_varChangeValue2619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_arrayChangeValue2651 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_arrayChangeValue2653 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010E0000UL});
    public static readonly BitSet FOLLOW_add_in_arrayChangeValue2655 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_arrayChangeValue2657 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_arrayChangeValue2660 = new BitSet(new ulong[]{0x0060000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_initValue_in_arrayChangeValue2663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string__in_addOrArray2705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_addOrArray2713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayChangeValue_in_addOrArray2721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINT_in_print2735 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_print2737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINTLN_in_println2766 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000010F0000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_println2768 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEXTLINE_in_nextLine2796 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr2820 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr2826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_init_in_expr2832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_expr2838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr2844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_expr2850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr2856 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr2862 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_println_in_expr2868 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nextLine_in_expr2874 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_changeValue_in_expr2880 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line2891 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_92_in_line2894 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_methodDef_in_exprList2908 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_92_in_exprList2912 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_varInit_in_exprList2922 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_92_in_exprList2925 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_arrayInit_in_exprList2935 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_92_in_exprList2938 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm2959 = new BitSet(new ulong[]{0x1F80000000000002UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program2973 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute2991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_synpred19_MyGrammar1520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred21_MyGrammar1536 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_synpred32_MyGrammar1804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_synpred33_MyGrammar1824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_synpred34_MyGrammar1844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_synpred35_MyGrammar1864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_synpred36_MyGrammar1884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_synpred37_MyGrammar1904 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_synpred38_MyGrammar1924 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_synpred39_MyGrammar1972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_synpred40_MyGrammar1981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_synpred41_MyGrammar1990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_synpred42_MyGrammar1999 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_synpred43_MyGrammar2008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_synpred44_MyGrammar2017 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_synpred45_MyGrammar2026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred48_MyGrammar2565 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred49_MyGrammar2572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred54_MyGrammar2820 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_init_in_synpred56_MyGrammar2832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_synpred57_MyGrammar2838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_synpred59_MyGrammar2850 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}