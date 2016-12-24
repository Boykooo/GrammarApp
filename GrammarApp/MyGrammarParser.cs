// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-12-24 17:58:37

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
		"PROGRAM", 
		"PRINT", 
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

    public const int Add = 6;
    public const int MoreOp = 20;
    public const int PRINT = 32;
    public const int NEW = 41;
    public const int MoreEqOp = 21;
    public const int VAR = 54;
    public const int CallMethod = 13;
    public const int While_ = 28;
    public const int DECREMENT = 48;
    public const int LessOp = 22;
    public const int MINUS = 34;
    public const int MULT = 7;
    public const int ArrayInit = 30;
    public const int ELSE = 38;
    public const int CALLMETHOD = 61;
    public const int ID = 75;
    public const int Plus = 9;
    public const int IF = 37;
    public const int TYPE = 59;
    public const int MINUSASSIGN = 44;
    public const int LogicOp = 25;
    public const int INTEGER = 73;
    public const int MOREEQ = 71;
    public const int LESSEQ = 72;
    public const int For = 24;
    public const int BLOCK = 39;
    public const int ONEARRAY = 55;
    public const int FOR = 62;
    public const int Method = 5;
    public const int EQ = 67;
    public const int Double = 12;
    public const int AND = 65;
    public const int PUBLIC = 58;
    public const int MULTIPLY = 35;
    public const int CONDITION = 40;
    public const int COUNT = 56;
    public const int LESS = 70;
    public const int Id = 14;
    public const int VOID = 53;
    public const int If = 26;
    public const int Minus = 10;
    public const int PROGRAM = 31;
    public const int AndOp = 15;
    public const int Inc = 27;
    public const int PLUS = 33;
    public const int DIVIDEASSIGN = 46;
    public const int FLOAT = 50;
    public const int NonEqOp = 18;
    public const int MULTASSIGN = 45;
    public const int CHAR = 52;
    public const int DefOp = 19;
    public const int ASSIGN = 42;
    public const int INT = 49;
    public const int DIVIDE = 36;
    public const int T__77 = 77;
    public const int T__78 = 78;
    public const int PLUSASSIGN = 43;
    public const int T__79 = 79;
    public const int DOUBLE = 51;
    public const int WS = 76;
    public const int EOF = -1;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int OrOp = 16;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int MOD = 60;
    public const int OR = 66;
    public const int INCREMENT_ = 64;
    public const int LessEqOp = 23;
    public const int NONEQ = 68;
    public const int EqOp = 17;
    public const int DOUBLE_ = 74;
    public const int PRIVATE = 57;
    public const int VarInit = 4;
    public const int Integer = 11;
    public const int INCREMENT = 47;
    public const int MORE = 69;
    public const int Assign = 8;
    public const int WHILE = 63;
    public const int T__84 = 84;
    public const int T__85 = 85;
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
    // MyGrammar.g:96:1: type : ( INT | FLOAT | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:96:6: ( INT | FLOAT | DOUBLE | CHAR | VOID )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set1 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INT && input.LA(1) <= VOID) ) 
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
    // MyGrammar.g:104:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:104:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
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
    // MyGrammar.g:112:1: incDec : ( inc | dec );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.inc_return inc3 = default(MyGrammarParser.inc_return);

        MyGrammarParser.dec_return dec4 = default(MyGrammarParser.dec_return);



        try 
    	{
            // MyGrammar.g:112:8: ( inc | dec )
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
                    // MyGrammar.g:112:10: inc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inc_in_incDec960);
                    	inc3 = inc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inc3.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:113:5: dec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dec_in_incDec966);
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
    // MyGrammar.g:117:1: inc : INCREMENT -> ^( Inc INCREMENT ) ;
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
            // MyGrammar.g:117:6: ( INCREMENT -> ^( Inc INCREMENT ) )
            // MyGrammar.g:117:8: INCREMENT
            {
            	INCREMENT5=(IToken)Match(input,INCREMENT,FOLLOW_INCREMENT_in_inc979); if (state.failed) return retval; 
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
            	// 117:18: -> ^( Inc INCREMENT )
            	{
            	    // MyGrammar.g:117:21: ^( Inc INCREMENT )
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
    // MyGrammar.g:120:1: dec : DECREMENT -> DECREMENT ;
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
            // MyGrammar.g:120:6: ( DECREMENT -> DECREMENT )
            // MyGrammar.g:120:8: DECREMENT
            {
            	DECREMENT6=(IToken)Match(input,DECREMENT,FOLLOW_DECREMENT_in_dec1002); if (state.failed) return retval; 
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
            	// 120:18: -> DECREMENT
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
    // MyGrammar.g:123:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set7 = null;

        object set7_tree=null;

        try 
    	{
            // MyGrammar.g:123:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
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
    // MyGrammar.g:139:1: number : ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) );
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
            // MyGrammar.g:139:8: ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) )
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
                    // MyGrammar.g:139:10: INTEGER
                    {
                    	INTEGER8=(IToken)Match(input,INTEGER,FOLLOW_INTEGER_in_number1093); if (state.failed) return retval; 
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
                    	// 139:18: -> ^( Integer INTEGER )
                    	{
                    	    // MyGrammar.g:139:21: ^( Integer INTEGER )
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
                    // MyGrammar.g:140:5: DOUBLE_
                    {
                    	DOUBLE_9=(IToken)Match(input,DOUBLE_,FOLLOW_DOUBLE__in_number1110); if (state.failed) return retval; 
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
                    	// 140:13: -> ^( Double DOUBLE_ )
                    	{
                    	    // MyGrammar.g:140:16: ^( Double DOUBLE_ )
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
    // MyGrammar.g:147:1: ident : ID -> ^( Id ID ) ;
    public MyGrammarParser.ident_return ident() // throws RecognitionException [1]
    {   
        MyGrammarParser.ident_return retval = new MyGrammarParser.ident_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID10 = null;

        object ID10_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:147:8: ( ID -> ^( Id ID ) )
            // MyGrammar.g:147:10: ID
            {
            	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_ident1175); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID10);



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
            	// 147:13: -> ^( Id ID )
            	{
            	    // MyGrammar.g:147:16: ^( Id ID )
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
    // MyGrammar.g:155:1: init : ( arrayInit | varInit );
    public MyGrammarParser.init_return init() // throws RecognitionException [1]
    {   
        MyGrammarParser.init_return retval = new MyGrammarParser.init_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.arrayInit_return arrayInit11 = default(MyGrammarParser.arrayInit_return);

        MyGrammarParser.varInit_return varInit12 = default(MyGrammarParser.varInit_return);



        try 
    	{
            // MyGrammar.g:155:6: ( arrayInit | varInit )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= INT && LA3_0 <= VOID)) )
            {
                int LA3_1 = input.LA(2);

                if ( (LA3_1 == ID) )
                {
                    alt3 = 2;
                }
                else if ( (LA3_1 == 77) )
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
                    // MyGrammar.g:155:8: arrayInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_init1203);
                    	arrayInit11 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit11.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:156:5: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_init1210);
                    	varInit12 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit12.Tree);

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
    // MyGrammar.g:159:1: arrayInit : type '[]' ident ( '=' NEW type '[' add ']' )? -> ^( ArrayDecl type ident ( add )? ) ;
    public MyGrammarParser.arrayInit_return arrayInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.arrayInit_return retval = new MyGrammarParser.arrayInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal14 = null;
        IToken char_literal16 = null;
        IToken NEW17 = null;
        IToken char_literal19 = null;
        IToken char_literal21 = null;
        MyGrammarParser.type_return type13 = default(MyGrammarParser.type_return);

        MyGrammarParser.ident_return ident15 = default(MyGrammarParser.ident_return);

        MyGrammarParser.type_return type18 = default(MyGrammarParser.type_return);

        MyGrammarParser.add_return add20 = default(MyGrammarParser.add_return);


        object string_literal14_tree=null;
        object char_literal16_tree=null;
        object NEW17_tree=null;
        object char_literal19_tree=null;
        object char_literal21_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_NEW = new RewriteRuleTokenStream(adaptor,"token NEW");
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:159:11: ( type '[]' ident ( '=' NEW type '[' add ']' )? -> ^( ArrayDecl type ident ( add )? ) )
            // MyGrammar.g:159:13: type '[]' ident ( '=' NEW type '[' add ']' )?
            {
            	PushFollow(FOLLOW_type_in_arrayInit1221);
            	type13 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type13.Tree);
            	string_literal14=(IToken)Match(input,77,FOLLOW_77_in_arrayInit1223); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(string_literal14);

            	PushFollow(FOLLOW_ident_in_arrayInit1225);
            	ident15 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident15.Tree);
            	// MyGrammar.g:159:29: ( '=' NEW type '[' add ']' )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == ASSIGN) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // MyGrammar.g:159:30: '=' NEW type '[' add ']'
            	        {
            	        	char_literal16=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_arrayInit1228); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(char_literal16);

            	        	NEW17=(IToken)Match(input,NEW,FOLLOW_NEW_in_arrayInit1230); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_NEW.Add(NEW17);

            	        	PushFollow(FOLLOW_type_in_arrayInit1232);
            	        	type18 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type18.Tree);
            	        	char_literal19=(IToken)Match(input,78,FOLLOW_78_in_arrayInit1234); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_78.Add(char_literal19);

            	        	PushFollow(FOLLOW_add_in_arrayInit1236);
            	        	add20 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_add.Add(add20.Tree);
            	        	char_literal21=(IToken)Match(input,79,FOLLOW_79_in_arrayInit1238); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_79.Add(char_literal21);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ident, add, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 160:6: -> ^( ArrayDecl type ident ( add )? )
            	{
            	    // MyGrammar.g:160:8: ^( ArrayDecl type ident ( add )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ArrayDecl(ArrayDecl), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:160:42: ( add )?
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
    // MyGrammar.g:163:1: varInit : type fieldInitValue -> ^( VarInit type fieldInitValue ) ;
    public MyGrammarParser.varInit_return varInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInit_return retval = new MyGrammarParser.varInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.type_return type22 = default(MyGrammarParser.type_return);

        MyGrammarParser.fieldInitValue_return fieldInitValue23 = default(MyGrammarParser.fieldInitValue_return);


        RewriteRuleSubtreeStream stream_fieldInitValue = new RewriteRuleSubtreeStream(adaptor,"rule fieldInitValue");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:163:9: ( type fieldInitValue -> ^( VarInit type fieldInitValue ) )
            // MyGrammar.g:163:11: type fieldInitValue
            {
            	PushFollow(FOLLOW_type_in_varInit1275);
            	type22 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type22.Tree);
            	PushFollow(FOLLOW_fieldInitValue_in_varInit1277);
            	fieldInitValue23 = fieldInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fieldInitValue.Add(fieldInitValue23.Tree);


            	// AST REWRITE
            	// elements:          fieldInitValue, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 164:5: -> ^( VarInit type fieldInitValue )
            	{
            	    // MyGrammar.g:164:8: ^( VarInit type fieldInitValue )
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
    // MyGrammar.g:168:1: fieldInitValue : ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) ;
    public MyGrammarParser.fieldInitValue_return fieldInitValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.fieldInitValue_return retval = new MyGrammarParser.fieldInitValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN25 = null;
        MyGrammarParser.ident_return ident24 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue26 = default(MyGrammarParser.initValue_return);


        object ASSIGN25_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:168:16: ( ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) )
            // MyGrammar.g:168:19: ident ( ASSIGN initValue )?
            {
            	PushFollow(FOLLOW_ident_in_fieldInitValue1307);
            	ident24 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident24.Tree);
            	// MyGrammar.g:168:26: ( ASSIGN initValue )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == ASSIGN) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // MyGrammar.g:168:27: ASSIGN initValue
            	        {
            	        	ASSIGN25=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_fieldInitValue1311); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN25);

            	        	PushFollow(FOLLOW_initValue_in_fieldInitValue1313);
            	        	initValue26 = initValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initValue.Add(initValue26.Tree);

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
            	// 169:7: -> ^( Assign ident ( initValue )? )
            	{
            	    // MyGrammar.g:169:10: ^( Assign ident ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AssignNode(Assign), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:169:37: ( initValue )?
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
    // MyGrammar.g:174:1: initValue : ( add | callMethod | ident | inc | dec );
    public MyGrammarParser.initValue_return initValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.initValue_return retval = new MyGrammarParser.initValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add27 = default(MyGrammarParser.add_return);

        MyGrammarParser.callMethod_return callMethod28 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.ident_return ident29 = default(MyGrammarParser.ident_return);

        MyGrammarParser.inc_return inc30 = default(MyGrammarParser.inc_return);

        MyGrammarParser.dec_return dec31 = default(MyGrammarParser.dec_return);



        try 
    	{
            // MyGrammar.g:174:12: ( add | callMethod | ident | inc | dec )
            int alt6 = 5;
            switch ( input.LA(1) ) 
            {
            case INTEGER:
            case DOUBLE_:
            case 80:
            	{
                alt6 = 1;
                }
                break;
            case ID:
            	{
                int LA6_2 = input.LA(2);

                if ( (LA6_2 == 85) )
                {
                    alt6 = 2;
                }
                else if ( (synpred17_MyGrammar()) )
                {
                    alt6 = 1;
                }
                else if ( (synpred19_MyGrammar()) )
                {
                    alt6 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d6s2 =
                        new NoViableAltException("", 6, 2, input);

                    throw nvae_d6s2;
                }
                }
                break;
            case INCREMENT:
            	{
                alt6 = 4;
                }
                break;
            case DECREMENT:
            	{
                alt6 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // MyGrammar.g:174:14: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_initValue1353);
                    	add27 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add27.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:175:7: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_initValue1361);
                    	callMethod28 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod28.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:176:7: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_initValue1369);
                    	ident29 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident29.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:177:7: inc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inc_in_initValue1377);
                    	inc30 = inc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inc30.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:178:7: dec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dec_in_initValue1385);
                    	dec31 = dec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dec31.Tree);

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
    // MyGrammar.g:182:1: addOperation : ( PLUS -> Plus | MINUS -> Minus );
    public MyGrammarParser.addOperation_return addOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.addOperation_return retval = new MyGrammarParser.addOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS32 = null;
        IToken MINUS33 = null;

        object PLUS32_tree=null;
        object MINUS33_tree=null;
        RewriteRuleTokenStream stream_PLUS = new RewriteRuleTokenStream(adaptor,"token PLUS");
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor,"token MINUS");

        try 
    	{
            // MyGrammar.g:182:14: ( PLUS -> Plus | MINUS -> Minus )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == PLUS) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == MINUS) )
            {
                alt7 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // MyGrammar.g:182:16: PLUS
                    {
                    	PLUS32=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addOperation1399); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_PLUS.Add(PLUS32);



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
                    	// 182:21: -> Plus
                    	{
                    	    adaptor.AddChild(root_0, new PlusNode(Plus));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:183:7: MINUS
                    {
                    	MINUS33=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_addOperation1414); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MINUS.Add(MINUS33);



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
                    	// 183:13: -> Minus
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
    // MyGrammar.g:186:1: multOperation : ( MULTIPLY -> MULT | DIVIDE -> DIVIDE );
    public MyGrammarParser.multOperation_return multOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.multOperation_return retval = new MyGrammarParser.multOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULTIPLY34 = null;
        IToken DIVIDE35 = null;

        object MULTIPLY34_tree=null;
        object DIVIDE35_tree=null;
        RewriteRuleTokenStream stream_MULTIPLY = new RewriteRuleTokenStream(adaptor,"token MULTIPLY");
        RewriteRuleTokenStream stream_DIVIDE = new RewriteRuleTokenStream(adaptor,"token DIVIDE");

        try 
    	{
            // MyGrammar.g:186:15: ( MULTIPLY -> MULT | DIVIDE -> DIVIDE )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == MULTIPLY) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == DIVIDE) )
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
                    // MyGrammar.g:186:17: MULTIPLY
                    {
                    	MULTIPLY34=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multOperation1434); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MULTIPLY.Add(MULTIPLY34);



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
                    	// 186:26: -> MULT
                    	{
                    	    adaptor.AddChild(root_0, new MultNode(MULT));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:187:7: DIVIDE
                    {
                    	DIVIDE35=(IToken)Match(input,DIVIDE,FOLLOW_DIVIDE_in_multOperation1449); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DIVIDE.Add(DIVIDE35);



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
                    	// 187:14: -> DIVIDE
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
    // MyGrammar.g:190:1: group : ( '(' add ')' | number | ident );
    public MyGrammarParser.group_return group() // throws RecognitionException [1]
    {   
        MyGrammarParser.group_return retval = new MyGrammarParser.group_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal36 = null;
        IToken char_literal38 = null;
        MyGrammarParser.add_return add37 = default(MyGrammarParser.add_return);

        MyGrammarParser.number_return number39 = default(MyGrammarParser.number_return);

        MyGrammarParser.ident_return ident40 = default(MyGrammarParser.ident_return);


        object char_literal36_tree=null;
        object char_literal38_tree=null;

        try 
    	{
            // MyGrammar.g:190:7: ( '(' add ')' | number | ident )
            int alt9 = 3;
            switch ( input.LA(1) ) 
            {
            case 80:
            	{
                alt9 = 1;
                }
                break;
            case INTEGER:
            case DOUBLE_:
            	{
                alt9 = 2;
                }
                break;
            case ID:
            	{
                alt9 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            }

            switch (alt9) 
            {
                case 1 :
                    // MyGrammar.g:190:9: '(' add ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal36=(IToken)Match(input,80,FOLLOW_80_in_group1472); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group1475);
                    	add37 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add37.Tree);
                    	char_literal38=(IToken)Match(input,81,FOLLOW_81_in_group1477); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:191:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group1485);
                    	number39 = number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number39.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:192:5: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_group1491);
                    	ident40 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident40.Tree);

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
    // MyGrammar.g:195:1: mult : group ( multOperation group )* ;
    public MyGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        MyGrammarParser.mult_return retval = new MyGrammarParser.mult_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.group_return group41 = default(MyGrammarParser.group_return);

        MyGrammarParser.multOperation_return multOperation42 = default(MyGrammarParser.multOperation_return);

        MyGrammarParser.group_return group43 = default(MyGrammarParser.group_return);



        try 
    	{
            // MyGrammar.g:195:6: ( group ( multOperation group )* )
            // MyGrammar.g:195:8: group ( multOperation group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult1506);
            	group41 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group41.Tree);
            	// MyGrammar.g:195:14: ( multOperation group )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= MULTIPLY && LA10_0 <= DIVIDE)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MyGrammar.g:195:16: multOperation group
            			    {
            			    	PushFollow(FOLLOW_multOperation_in_mult1510);
            			    	multOperation42 = multOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperation42.Tree, root_0);
            			    	PushFollow(FOLLOW_group_in_mult1513);
            			    	group43 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


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
    // MyGrammar.g:197:1: add : mult ( addOperation mult )* ;
    public MyGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        MyGrammarParser.add_return retval = new MyGrammarParser.add_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.mult_return mult44 = default(MyGrammarParser.mult_return);

        MyGrammarParser.addOperation_return addOperation45 = default(MyGrammarParser.addOperation_return);

        MyGrammarParser.mult_return mult46 = default(MyGrammarParser.mult_return);



        try 
    	{
            // MyGrammar.g:197:6: ( mult ( addOperation mult )* )
            // MyGrammar.g:197:8: mult ( addOperation mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1525);
            	mult44 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult44.Tree);
            	// MyGrammar.g:197:13: ( addOperation mult )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= PLUS && LA11_0 <= MINUS)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MyGrammar.g:197:15: addOperation mult
            			    {
            			    	PushFollow(FOLLOW_addOperation_in_add1529);
            			    	addOperation45 = addOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperation45.Tree, root_0);
            			    	PushFollow(FOLLOW_mult_in_add1532);
            			    	mult46 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult46.Tree);

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
    // $ANTLR end "add"

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
    // MyGrammar.g:199:1: print : PRINT '(' printExpr ')' -> ^( PRINT printExpr ) ;
    public MyGrammarParser.print_return print() // throws RecognitionException [1]
    {   
        MyGrammarParser.print_return retval = new MyGrammarParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINT47 = null;
        IToken char_literal48 = null;
        IToken char_literal50 = null;
        MyGrammarParser.printExpr_return printExpr49 = default(MyGrammarParser.printExpr_return);


        object PRINT47_tree=null;
        object char_literal48_tree=null;
        object char_literal50_tree=null;
        RewriteRuleTokenStream stream_PRINT = new RewriteRuleTokenStream(adaptor,"token PRINT");
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleSubtreeStream stream_printExpr = new RewriteRuleSubtreeStream(adaptor,"rule printExpr");
        try 
    	{
            // MyGrammar.g:199:7: ( PRINT '(' printExpr ')' -> ^( PRINT printExpr ) )
            // MyGrammar.g:199:9: PRINT '(' printExpr ')'
            {
            	PRINT47=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print1543); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINT.Add(PRINT47);

            	char_literal48=(IToken)Match(input,80,FOLLOW_80_in_print1545); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(char_literal48);

            	PushFollow(FOLLOW_printExpr_in_print1547);
            	printExpr49 = printExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_printExpr.Add(printExpr49.Tree);
            	char_literal50=(IToken)Match(input,81,FOLLOW_81_in_print1549); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(char_literal50);



            	// AST REWRITE
            	// elements:          PRINT, printExpr
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 200:4: -> ^( PRINT printExpr )
            	{
            	    // MyGrammar.g:200:7: ^( PRINT printExpr )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_PRINT.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_printExpr.NextTree());

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
    // MyGrammar.g:203:1: block : '{' ( line )* '}' -> ^( BLOCK ( line )* ) ;
    public MyGrammarParser.block_return block() // throws RecognitionException [1]
    {   
        MyGrammarParser.block_return retval = new MyGrammarParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal51 = null;
        IToken char_literal53 = null;
        MyGrammarParser.line_return line52 = default(MyGrammarParser.line_return);


        object char_literal51_tree=null;
        object char_literal53_tree=null;
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:203:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:203:9: '{' ( line )* '}'
            {
            	char_literal51=(IToken)Match(input,82,FOLLOW_82_in_block1571); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(char_literal51);

            	// MyGrammar.g:203:13: ( line )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == PRINT || LA12_0 == IF || (LA12_0 >= INT && LA12_0 <= VOID) || (LA12_0 >= FOR && LA12_0 <= WHILE) || (LA12_0 >= INTEGER && LA12_0 <= ID) || LA12_0 == 80) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block1573);
            			    	line52 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line52.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal53=(IToken)Match(input,83,FOLLOW_83_in_block1576); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(char_literal53);



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
            	// 203:23: -> ^( BLOCK ( line )* )
            	{
            	    // MyGrammar.g:203:26: ^( BLOCK ( line )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(BLOCK), root_1);

            	    // MyGrammar.g:203:49: ( line )*
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
    // MyGrammar.g:207:1: if_ : IF '(' logicOperator ')' block ( ELSE block )? -> ^( If logicOperator block ( ^( ELSE block ) )? ) ;
    public MyGrammarParser.if__return if_() // throws RecognitionException [1]
    {   
        MyGrammarParser.if__return retval = new MyGrammarParser.if__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF54 = null;
        IToken char_literal55 = null;
        IToken char_literal57 = null;
        IToken ELSE59 = null;
        MyGrammarParser.logicOperator_return logicOperator56 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block58 = default(MyGrammarParser.block_return);

        MyGrammarParser.block_return block60 = default(MyGrammarParser.block_return);


        object IF54_tree=null;
        object char_literal55_tree=null;
        object char_literal57_tree=null;
        object ELSE59_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:207:6: ( IF '(' logicOperator ')' block ( ELSE block )? -> ^( If logicOperator block ( ^( ELSE block ) )? ) )
            // MyGrammar.g:207:8: IF '(' logicOperator ')' block ( ELSE block )?
            {
            	IF54=(IToken)Match(input,IF,FOLLOW_IF_in_if_1601); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF54);

            	char_literal55=(IToken)Match(input,80,FOLLOW_80_in_if_1603); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(char_literal55);

            	PushFollow(FOLLOW_logicOperator_in_if_1605);
            	logicOperator56 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator56.Tree);
            	char_literal57=(IToken)Match(input,81,FOLLOW_81_in_if_1607); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(char_literal57);

            	PushFollow(FOLLOW_block_in_if_1609);
            	block58 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block58.Tree);
            	// MyGrammar.g:207:39: ( ELSE block )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == ELSE) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // MyGrammar.g:207:40: ELSE block
            	        {
            	        	ELSE59=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_if_1612); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE59);

            	        	PushFollow(FOLLOW_block_in_if_1614);
            	        	block60 = block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block.Add(block60.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          logicOperator, block, ELSE, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 208:4: -> ^( If logicOperator block ( ^( ELSE block ) )? )
            	{
            	    // MyGrammar.g:208:7: ^( If logicOperator block ( ^( ELSE block ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new IfNode(If), root_1);

            	    adaptor.AddChild(root_1, stream_logicOperator.NextTree());
            	    adaptor.AddChild(root_1, stream_block.NextTree());
            	    // MyGrammar.g:208:40: ( ^( ELSE block ) )?
            	    if ( stream_ELSE.HasNext() || stream_block.HasNext() )
            	    {
            	        // MyGrammar.g:208:40: ^( ELSE block )
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_2);

            	        adaptor.AddChild(root_2, stream_block.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_ELSE.Reset();
            	    stream_block.Reset();

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
    // MyGrammar.g:214:1: operations : ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) );
    public MyGrammarParser.operations_return operations() // throws RecognitionException [1]
    {   
        MyGrammarParser.operations_return retval = new MyGrammarParser.operations_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation61 = default(MyGrammarParser.orOperation_return);

        MyGrammarParser.andOperation_return andOperation62 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.eqOp_return eqOp63 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp64 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.moreOp_return moreOp65 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp66 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.lessOp_return lessOp67 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp68 = default(MyGrammarParser.lessEqOp_return);


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
            // MyGrammar.g:214:14: ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) )
            int alt14 = 8;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // MyGrammar.g:214:16: orOperation
                    {
                    	PushFollow(FOLLOW_orOperation_in_operations1656);
                    	orOperation61 = orOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_orOperation.Add(orOperation61.Tree);


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
                    	// 214:28: -> ^( OrOp orOperation )
                    	{
                    	    // MyGrammar.g:214:31: ^( OrOp orOperation )
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
                    // MyGrammar.g:215:8: andOperation
                    {
                    	PushFollow(FOLLOW_andOperation_in_operations1676);
                    	andOperation62 = andOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_andOperation.Add(andOperation62.Tree);


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
                    	// 215:21: -> ^( AndOp andOperation )
                    	{
                    	    // MyGrammar.g:215:24: ^( AndOp andOperation )
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
                    // MyGrammar.g:216:8: eqOp
                    {
                    	PushFollow(FOLLOW_eqOp_in_operations1696);
                    	eqOp63 = eqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_eqOp.Add(eqOp63.Tree);


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
                    	// 216:13: -> ^( EqOp eqOp )
                    	{
                    	    // MyGrammar.g:216:16: ^( EqOp eqOp )
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
                    // MyGrammar.g:217:8: nonEqOp
                    {
                    	PushFollow(FOLLOW_nonEqOp_in_operations1716);
                    	nonEqOp64 = nonEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nonEqOp.Add(nonEqOp64.Tree);


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
                    	// 217:16: -> ^( NonEqOp nonEqOp )
                    	{
                    	    // MyGrammar.g:217:19: ^( NonEqOp nonEqOp )
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
                    // MyGrammar.g:218:8: moreOp
                    {
                    	PushFollow(FOLLOW_moreOp_in_operations1736);
                    	moreOp65 = moreOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_moreOp.Add(moreOp65.Tree);


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
                    	// 218:15: -> ^( MoreOp moreOp )
                    	{
                    	    // MyGrammar.g:218:18: ^( MoreOp moreOp )
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
                    // MyGrammar.g:219:8: moreEqOp
                    {
                    	PushFollow(FOLLOW_moreEqOp_in_operations1756);
                    	moreEqOp66 = moreEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_moreEqOp.Add(moreEqOp66.Tree);


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
                    	// 219:17: -> ^( MoreEqOp moreEqOp )
                    	{
                    	    // MyGrammar.g:219:20: ^( MoreEqOp moreEqOp )
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
                    // MyGrammar.g:220:8: lessOp
                    {
                    	PushFollow(FOLLOW_lessOp_in_operations1776);
                    	lessOp67 = lessOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lessOp.Add(lessOp67.Tree);


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
                    	// 220:15: -> ^( LessOp lessOp )
                    	{
                    	    // MyGrammar.g:220:18: ^( LessOp lessOp )
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
                    // MyGrammar.g:221:8: lessEqOp
                    {
                    	PushFollow(FOLLOW_lessEqOp_in_operations1796);
                    	lessEqOp68 = lessEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lessEqOp.Add(lessEqOp68.Tree);


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
                    	// 221:17: -> ^( LessEqOp lessEqOp )
                    	{
                    	    // MyGrammar.g:221:20: ^( LessEqOp lessEqOp )
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
    // MyGrammar.g:224:1: logicOperator : ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp );
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation69 = default(MyGrammarParser.orOperation_return);

        MyGrammarParser.andOperation_return andOperation70 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.eqOp_return eqOp71 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp72 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.moreOp_return moreOp73 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp74 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.lessOp_return lessOp75 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp76 = default(MyGrammarParser.lessEqOp_return);



        try 
    	{
            // MyGrammar.g:224:16: ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp )
            int alt15 = 8;
            alt15 = dfa15.Predict(input);
            switch (alt15) 
            {
                case 1 :
                    // MyGrammar.g:224:18: orOperation
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_orOperation_in_logicOperator1824);
                    	orOperation69 = orOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation69.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:225:8: andOperation
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_andOperation_in_logicOperator1833);
                    	andOperation70 = andOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation70.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:226:8: eqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_eqOp_in_logicOperator1842);
                    	eqOp71 = eqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, eqOp71.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:227:8: nonEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nonEqOp_in_logicOperator1851);
                    	nonEqOp72 = nonEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEqOp72.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:228:8: moreOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moreOp_in_logicOperator1860);
                    	moreOp73 = moreOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreOp73.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:229:8: moreEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moreEqOp_in_logicOperator1869);
                    	moreEqOp74 = moreEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreEqOp74.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:230:8: lessOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lessOp_in_logicOperator1878);
                    	lessOp75 = lessOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessOp75.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:231:8: lessEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lessEqOp_in_logicOperator1887);
                    	lessEqOp76 = lessEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessEqOp76.Tree);

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
    // MyGrammar.g:235:1: orOperation : add OR add -> ^( OrOp add add ) ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OR78 = null;
        MyGrammarParser.add_return add77 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add79 = default(MyGrammarParser.add_return);


        object OR78_tree=null;
        RewriteRuleTokenStream stream_OR = new RewriteRuleTokenStream(adaptor,"token OR");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:235:15: ( add OR add -> ^( OrOp add add ) )
            // MyGrammar.g:235:17: add OR add
            {
            	PushFollow(FOLLOW_add_in_orOperation1904);
            	add77 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add77.Tree);
            	OR78=(IToken)Match(input,OR,FOLLOW_OR_in_orOperation1906); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_OR.Add(OR78);

            	PushFollow(FOLLOW_add_in_orOperation1908);
            	add79 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add79.Tree);


            	// AST REWRITE
            	// elements:          add, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 235:28: -> ^( OrOp add add )
            	{
            	    // MyGrammar.g:235:31: ^( OrOp add add )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new OrOperationNode(OrOp), root_1);

            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());

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
    // MyGrammar.g:238:1: andOperation : add AND add -> ^( AndOp add add ) ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AND81 = null;
        MyGrammarParser.add_return add80 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add82 = default(MyGrammarParser.add_return);


        object AND81_tree=null;
        RewriteRuleTokenStream stream_AND = new RewriteRuleTokenStream(adaptor,"token AND");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:238:15: ( add AND add -> ^( AndOp add add ) )
            // MyGrammar.g:238:17: add AND add
            {
            	PushFollow(FOLLOW_add_in_andOperation1936);
            	add80 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add80.Tree);
            	AND81=(IToken)Match(input,AND,FOLLOW_AND_in_andOperation1938); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_AND.Add(AND81);

            	PushFollow(FOLLOW_add_in_andOperation1940);
            	add82 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add82.Tree);


            	// AST REWRITE
            	// elements:          add, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 238:29: -> ^( AndOp add add )
            	{
            	    // MyGrammar.g:238:32: ^( AndOp add add )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AndOperationNode(AndOp), root_1);

            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());

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
    // MyGrammar.g:241:1: eqOp : add EQ add -> ^( EqOp add add ) ;
    public MyGrammarParser.eqOp_return eqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.eqOp_return retval = new MyGrammarParser.eqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQ84 = null;
        MyGrammarParser.add_return add83 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add85 = default(MyGrammarParser.add_return);


        object EQ84_tree=null;
        RewriteRuleTokenStream stream_EQ = new RewriteRuleTokenStream(adaptor,"token EQ");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:241:9: ( add EQ add -> ^( EqOp add add ) )
            // MyGrammar.g:241:11: add EQ add
            {
            	PushFollow(FOLLOW_add_in_eqOp1970);
            	add83 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add83.Tree);
            	EQ84=(IToken)Match(input,EQ,FOLLOW_EQ_in_eqOp1972); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQ.Add(EQ84);

            	PushFollow(FOLLOW_add_in_eqOp1974);
            	add85 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add85.Tree);


            	// AST REWRITE
            	// elements:          add, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 241:22: -> ^( EqOp add add )
            	{
            	    // MyGrammar.g:241:25: ^( EqOp add add )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new EqualityOperationNode(EqOp), root_1);

            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());

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
    // MyGrammar.g:244:1: nonEqOp : add NONEQ add -> ^( NonEqOp add add ) ;
    public MyGrammarParser.nonEqOp_return nonEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.nonEqOp_return retval = new MyGrammarParser.nonEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NONEQ87 = null;
        MyGrammarParser.add_return add86 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add88 = default(MyGrammarParser.add_return);


        object NONEQ87_tree=null;
        RewriteRuleTokenStream stream_NONEQ = new RewriteRuleTokenStream(adaptor,"token NONEQ");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:244:12: ( add NONEQ add -> ^( NonEqOp add add ) )
            // MyGrammar.g:244:14: add NONEQ add
            {
            	PushFollow(FOLLOW_add_in_nonEqOp2004);
            	add86 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add86.Tree);
            	NONEQ87=(IToken)Match(input,NONEQ,FOLLOW_NONEQ_in_nonEqOp2006); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NONEQ.Add(NONEQ87);

            	PushFollow(FOLLOW_add_in_nonEqOp2008);
            	add88 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add88.Tree);


            	// AST REWRITE
            	// elements:          add, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 244:28: -> ^( NonEqOp add add )
            	{
            	    // MyGrammar.g:244:31: ^( NonEqOp add add )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new NonEqualityOperationNode(NonEqOp), root_1);

            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());

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
    // MyGrammar.g:247:1: moreOp : add MORE add -> ^( MoreOp add add ) ;
    public MyGrammarParser.moreOp_return moreOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreOp_return retval = new MyGrammarParser.moreOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MORE90 = null;
        MyGrammarParser.add_return add89 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add91 = default(MyGrammarParser.add_return);


        object MORE90_tree=null;
        RewriteRuleTokenStream stream_MORE = new RewriteRuleTokenStream(adaptor,"token MORE");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:247:11: ( add MORE add -> ^( MoreOp add add ) )
            // MyGrammar.g:247:14: add MORE add
            {
            	PushFollow(FOLLOW_add_in_moreOp2039);
            	add89 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add89.Tree);
            	MORE90=(IToken)Match(input,MORE,FOLLOW_MORE_in_moreOp2041); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MORE.Add(MORE90);

            	PushFollow(FOLLOW_add_in_moreOp2043);
            	add91 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add91.Tree);


            	// AST REWRITE
            	// elements:          add, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 247:27: -> ^( MoreOp add add )
            	{
            	    // MyGrammar.g:247:30: ^( MoreOp add add )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationMoreNode(MoreOp), root_1);

            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());

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
    // MyGrammar.g:250:1: moreEqOp : add MOREEQ add -> ^( MoreEqOp add add ) ;
    public MyGrammarParser.moreEqOp_return moreEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreEqOp_return retval = new MyGrammarParser.moreEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MOREEQ93 = null;
        MyGrammarParser.add_return add92 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add94 = default(MyGrammarParser.add_return);


        object MOREEQ93_tree=null;
        RewriteRuleTokenStream stream_MOREEQ = new RewriteRuleTokenStream(adaptor,"token MOREEQ");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:250:12: ( add MOREEQ add -> ^( MoreEqOp add add ) )
            // MyGrammar.g:250:14: add MOREEQ add
            {
            	PushFollow(FOLLOW_add_in_moreEqOp2072);
            	add92 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add92.Tree);
            	MOREEQ93=(IToken)Match(input,MOREEQ,FOLLOW_MOREEQ_in_moreEqOp2074); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MOREEQ.Add(MOREEQ93);

            	PushFollow(FOLLOW_add_in_moreEqOp2076);
            	add94 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add94.Tree);


            	// AST REWRITE
            	// elements:          add, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 250:29: -> ^( MoreEqOp add add )
            	{
            	    // MyGrammar.g:250:32: ^( MoreEqOp add add )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationMoreEqNode(MoreEqOp), root_1);

            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());

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
    // MyGrammar.g:253:1: lessOp : add LESS add -> ^( LessOp add add ) ;
    public MyGrammarParser.lessOp_return lessOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessOp_return retval = new MyGrammarParser.lessOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESS96 = null;
        MyGrammarParser.add_return add95 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add97 = default(MyGrammarParser.add_return);


        object LESS96_tree=null;
        RewriteRuleTokenStream stream_LESS = new RewriteRuleTokenStream(adaptor,"token LESS");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:253:11: ( add LESS add -> ^( LessOp add add ) )
            // MyGrammar.g:253:13: add LESS add
            {
            	PushFollow(FOLLOW_add_in_lessOp2106);
            	add95 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add95.Tree);
            	LESS96=(IToken)Match(input,LESS,FOLLOW_LESS_in_lessOp2108); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LESS.Add(LESS96);

            	PushFollow(FOLLOW_add_in_lessOp2110);
            	add97 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add97.Tree);


            	// AST REWRITE
            	// elements:          add, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 253:26: -> ^( LessOp add add )
            	{
            	    // MyGrammar.g:253:29: ^( LessOp add add )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationLessNode(LessOp), root_1);

            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());

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
    // MyGrammar.g:256:1: lessEqOp : add LESSEQ add -> ^( LessEqOp add add ) ;
    public MyGrammarParser.lessEqOp_return lessEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessEqOp_return retval = new MyGrammarParser.lessEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSEQ99 = null;
        MyGrammarParser.add_return add98 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add100 = default(MyGrammarParser.add_return);


        object LESSEQ99_tree=null;
        RewriteRuleTokenStream stream_LESSEQ = new RewriteRuleTokenStream(adaptor,"token LESSEQ");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:256:12: ( add LESSEQ add -> ^( LessEqOp add add ) )
            // MyGrammar.g:256:14: add LESSEQ add
            {
            	PushFollow(FOLLOW_add_in_lessEqOp2139);
            	add98 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add98.Tree);
            	LESSEQ99=(IToken)Match(input,LESSEQ,FOLLOW_LESSEQ_in_lessEqOp2141); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LESSEQ.Add(LESSEQ99);

            	PushFollow(FOLLOW_add_in_lessEqOp2143);
            	add100 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add100.Tree);


            	// AST REWRITE
            	// elements:          add, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 256:29: -> ^( LessEqOp add add )
            	{
            	    // MyGrammar.g:256:32: ^( LessEqOp add add )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperationLessEqNode(LessEqOp), root_1);

            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());

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
    // MyGrammar.g:261:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_101 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_102 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:261:7: ( for_ | while_ )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == FOR) )
            {
                alt16 = 1;
            }
            else if ( (LA16_0 == WHILE) )
            {
                alt16 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // MyGrammar.g:261:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle2172);
                    	for_101 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_101.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:262:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle2178);
                    	while_102 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_102.Tree);

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
    // MyGrammar.g:266:1: for_ : FOR '(' varInit ';' logicOperator ';' fieldInitValue ')' block -> ^( For varInit logicOperator fieldInitValue block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR103 = null;
        IToken char_literal104 = null;
        IToken char_literal106 = null;
        IToken char_literal108 = null;
        IToken char_literal110 = null;
        MyGrammarParser.varInit_return varInit105 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.logicOperator_return logicOperator107 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.fieldInitValue_return fieldInitValue109 = default(MyGrammarParser.fieldInitValue_return);

        MyGrammarParser.block_return block111 = default(MyGrammarParser.block_return);


        object FOR103_tree=null;
        object char_literal104_tree=null;
        object char_literal106_tree=null;
        object char_literal108_tree=null;
        object char_literal110_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_varInit = new RewriteRuleSubtreeStream(adaptor,"rule varInit");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_fieldInitValue = new RewriteRuleSubtreeStream(adaptor,"rule fieldInitValue");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:266:6: ( FOR '(' varInit ';' logicOperator ';' fieldInitValue ')' block -> ^( For varInit logicOperator fieldInitValue block ) )
            // MyGrammar.g:266:8: FOR '(' varInit ';' logicOperator ';' fieldInitValue ')' block
            {
            	FOR103=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_2190); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR103);

            	char_literal104=(IToken)Match(input,80,FOLLOW_80_in_for_2205); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(char_literal104);

            	PushFollow(FOLLOW_varInit_in_for_2214);
            	varInit105 = varInit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInit.Add(varInit105.Tree);
            	char_literal106=(IToken)Match(input,84,FOLLOW_84_in_for_2216); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(char_literal106);

            	PushFollow(FOLLOW_logicOperator_in_for_2221);
            	logicOperator107 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator107.Tree);
            	char_literal108=(IToken)Match(input,84,FOLLOW_84_in_for_2223); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(char_literal108);

            	PushFollow(FOLLOW_fieldInitValue_in_for_2231);
            	fieldInitValue109 = fieldInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fieldInitValue.Add(fieldInitValue109.Tree);
            	char_literal110=(IToken)Match(input,81,FOLLOW_81_in_for_2236); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(char_literal110);

            	PushFollow(FOLLOW_block_in_for_2241);
            	block111 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block111.Tree);


            	// AST REWRITE
            	// elements:          fieldInitValue, varInit, block, logicOperator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 273:4: -> ^( For varInit logicOperator fieldInitValue block )
            	{
            	    // MyGrammar.g:273:7: ^( For varInit logicOperator fieldInitValue block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ForNode(For), root_1);

            	    adaptor.AddChild(root_1, stream_varInit.NextTree());
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
    // MyGrammar.g:277:1: while_ : WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE112 = null;
        IToken char_literal113 = null;
        IToken char_literal115 = null;
        MyGrammarParser.logicOperator_return logicOperator114 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block116 = default(MyGrammarParser.block_return);


        object WHILE112_tree=null;
        object char_literal113_tree=null;
        object char_literal115_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:277:8: ( WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) )
            // MyGrammar.g:277:10: WHILE '(' logicOperator ')' block
            {
            	WHILE112=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_2273); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE112);

            	char_literal113=(IToken)Match(input,80,FOLLOW_80_in_while_2278); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(char_literal113);

            	PushFollow(FOLLOW_logicOperator_in_while_2283);
            	logicOperator114 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator114.Tree);
            	char_literal115=(IToken)Match(input,81,FOLLOW_81_in_while_2288); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(char_literal115);

            	PushFollow(FOLLOW_block_in_while_2293);
            	block116 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block116.Tree);


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
            	// 282:4: -> ^( While_ logicOperator block )
            	{
            	    // MyGrammar.g:282:7: ^( While_ logicOperator block )
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
    // MyGrammar.g:288:1: methodDef : type ID '()' block -> ^( Method ^( ID ( type )? block ) ) ;
    public MyGrammarParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        MyGrammarParser.methodDef_return retval = new MyGrammarParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID118 = null;
        IToken string_literal119 = null;
        MyGrammarParser.type_return type117 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block120 = default(MyGrammarParser.block_return);


        object ID118_tree=null;
        object string_literal119_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:288:11: ( type ID '()' block -> ^( Method ^( ID ( type )? block ) ) )
            // MyGrammar.g:288:13: type ID '()' block
            {
            	PushFollow(FOLLOW_type_in_methodDef2325);
            	type117 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type117.Tree);
            	ID118=(IToken)Match(input,ID,FOLLOW_ID_in_methodDef2327); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID118);

            	string_literal119=(IToken)Match(input,85,FOLLOW_85_in_methodDef2329); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal119);

            	PushFollow(FOLLOW_block_in_methodDef2331);
            	block120 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block120.Tree);


            	// AST REWRITE
            	// elements:          block, ID, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 288:32: -> ^( Method ^( ID ( type )? block ) )
            	{
            	    // MyGrammar.g:288:35: ^( Method ^( ID ( type )? block ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(Method), root_1);

            	    // MyGrammar.g:288:59: ^( ID ( type )? block )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:288:64: ( type )?
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
    // MyGrammar.g:292:1: callMethod : ID '()' -> ^( CallMethod ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID121 = null;
        IToken string_literal122 = null;

        object ID121_tree=null;
        object string_literal122_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");

        try 
    	{
            // MyGrammar.g:292:12: ( ID '()' -> ^( CallMethod ID ) )
            // MyGrammar.g:292:14: ID '()'
            {
            	ID121=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod2361); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID121);

            	string_literal122=(IToken)Match(input,85,FOLLOW_85_in_callMethod2363); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal122);



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
            	// 293:5: -> ^( CallMethod ID )
            	{
            	    // MyGrammar.g:293:8: ^( CallMethod ID )
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
    // MyGrammar.g:298:1: printExpr : ( add | ident | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add123 = default(MyGrammarParser.add_return);

        MyGrammarParser.ident_return ident124 = default(MyGrammarParser.ident_return);

        MyGrammarParser.callMethod_return callMethod125 = default(MyGrammarParser.callMethod_return);



        try 
    	{
            // MyGrammar.g:298:11: ( add | ident | callMethod )
            int alt17 = 3;
            int LA17_0 = input.LA(1);

            if ( ((LA17_0 >= INTEGER && LA17_0 <= DOUBLE_) || LA17_0 == 80) )
            {
                alt17 = 1;
            }
            else if ( (LA17_0 == ID) )
            {
                int LA17_2 = input.LA(2);

                if ( (LA17_2 == 85) )
                {
                    alt17 = 3;
                }
                else if ( (synpred44_MyGrammar()) )
                {
                    alt17 = 1;
                }
                else if ( (synpred45_MyGrammar()) )
                {
                    alt17 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d17s2 =
                        new NoViableAltException("", 17, 2, input);

                    throw nvae_d17s2;
                }
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
                    // MyGrammar.g:298:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr2393);
                    	add123 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add123.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:299:6: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_printExpr2400);
                    	ident124 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident124.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:300:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr2407);
                    	callMethod125 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod125.Tree);

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
    // MyGrammar.g:303:1: changeValue : ( varChangeValue | arrayChangeValue );
    public MyGrammarParser.changeValue_return changeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.changeValue_return retval = new MyGrammarParser.changeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.varChangeValue_return varChangeValue126 = default(MyGrammarParser.varChangeValue_return);

        MyGrammarParser.arrayChangeValue_return arrayChangeValue127 = default(MyGrammarParser.arrayChangeValue_return);



        try 
    	{
            // MyGrammar.g:303:14: ( varChangeValue | arrayChangeValue )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == ID) )
            {
                int LA18_1 = input.LA(2);

                if ( (LA18_1 == 78) )
                {
                    alt18 = 2;
                }
                else if ( (LA18_1 == ASSIGN) )
                {
                    alt18 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d18s1 =
                        new NoViableAltException("", 18, 1, input);

                    throw nvae_d18s1;
                }
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
                    // MyGrammar.g:303:16: varChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varChangeValue_in_changeValue2422);
                    	varChangeValue126 = varChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varChangeValue126.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:304:7: arrayChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayChangeValue_in_changeValue2430);
                    	arrayChangeValue127 = arrayChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayChangeValue127.Tree);

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
    // MyGrammar.g:307:1: varChangeValue : ident ASSIGN initValue -> ^( Assign ident initValue ) ;
    public MyGrammarParser.varChangeValue_return varChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.varChangeValue_return retval = new MyGrammarParser.varChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN129 = null;
        MyGrammarParser.ident_return ident128 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue130 = default(MyGrammarParser.initValue_return);


        object ASSIGN129_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:307:16: ( ident ASSIGN initValue -> ^( Assign ident initValue ) )
            // MyGrammar.g:307:18: ident ASSIGN initValue
            {
            	PushFollow(FOLLOW_ident_in_varChangeValue2443);
            	ident128 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident128.Tree);
            	ASSIGN129=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_varChangeValue2445); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN129);

            	PushFollow(FOLLOW_initValue_in_varChangeValue2447);
            	initValue130 = initValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_initValue.Add(initValue130.Tree);


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
            	// 308:7: -> ^( Assign ident initValue )
            	{
            	    // MyGrammar.g:308:10: ^( Assign ident initValue )
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
    // MyGrammar.g:311:1: arrayChangeValue : ident '[' add ']' ASSIGN initValue -> ^( ArrayInit ident add initValue ) ;
    public MyGrammarParser.arrayChangeValue_return arrayChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.arrayChangeValue_return retval = new MyGrammarParser.arrayChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal132 = null;
        IToken char_literal134 = null;
        IToken ASSIGN135 = null;
        MyGrammarParser.ident_return ident131 = default(MyGrammarParser.ident_return);

        MyGrammarParser.add_return add133 = default(MyGrammarParser.add_return);

        MyGrammarParser.initValue_return initValue136 = default(MyGrammarParser.initValue_return);


        object char_literal132_tree=null;
        object char_literal134_tree=null;
        object ASSIGN135_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:311:18: ( ident '[' add ']' ASSIGN initValue -> ^( ArrayInit ident add initValue ) )
            // MyGrammar.g:311:20: ident '[' add ']' ASSIGN initValue
            {
            	PushFollow(FOLLOW_ident_in_arrayChangeValue2479);
            	ident131 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident131.Tree);
            	char_literal132=(IToken)Match(input,78,FOLLOW_78_in_arrayChangeValue2481); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_78.Add(char_literal132);

            	PushFollow(FOLLOW_add_in_arrayChangeValue2483);
            	add133 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add133.Tree);
            	char_literal134=(IToken)Match(input,79,FOLLOW_79_in_arrayChangeValue2485); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_79.Add(char_literal134);

            	ASSIGN135=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_arrayChangeValue2487); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN135);

            	PushFollow(FOLLOW_initValue_in_arrayChangeValue2490);
            	initValue136 = initValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_initValue.Add(initValue136.Tree);


            	// AST REWRITE
            	// elements:          add, ident, initValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 312:8: -> ^( ArrayInit ident add initValue )
            	{
            	    // MyGrammar.g:312:11: ^( ArrayInit ident add initValue )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ArrayInit(ArrayInit), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());
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
    // $ANTLR end "arrayChangeValue"

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
    // MyGrammar.g:316:1: expr : ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | changeValue );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add137 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_138 = default(MyGrammarParser.if__return);

        MyGrammarParser.init_return init139 = default(MyGrammarParser.init_return);

        MyGrammarParser.arrayInit_return arrayInit140 = default(MyGrammarParser.arrayInit_return);

        MyGrammarParser.cycle_return cycle141 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.fieldInitValue_return fieldInitValue142 = default(MyGrammarParser.fieldInitValue_return);

        MyGrammarParser.callMethod_return callMethod143 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print144 = default(MyGrammarParser.print_return);

        MyGrammarParser.changeValue_return changeValue145 = default(MyGrammarParser.changeValue_return);



        try 
    	{
            // MyGrammar.g:316:6: ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | changeValue )
            int alt19 = 9;
            alt19 = dfa19.Predict(input);
            switch (alt19) 
            {
                case 1 :
                    // MyGrammar.g:316:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr2527);
                    	add137 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add137.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:317:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr2533);
                    	if_138 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_138.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:318:5: init
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_init_in_expr2539);
                    	init139 = init();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, init139.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:319:5: arrayInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_expr2545);
                    	arrayInit140 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit140.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:320:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr2551);
                    	cycle141 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle141.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:321:5: fieldInitValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fieldInitValue_in_expr2557);
                    	fieldInitValue142 = fieldInitValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fieldInitValue142.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:322:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr2563);
                    	callMethod143 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod143.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:323:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr2569);
                    	print144 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print144.Tree);

                    }
                    break;
                case 9 :
                    // MyGrammar.g:324:5: changeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_changeValue_in_expr2575);
                    	changeValue145 = changeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, changeValue145.Tree);

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
    // MyGrammar.g:327:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal147 = null;
        MyGrammarParser.expr_return expr146 = default(MyGrammarParser.expr_return);


        object char_literal147_tree=null;

        try 
    	{
            // MyGrammar.g:327:6: ( expr ( ';' )* )
            // MyGrammar.g:327:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line2586);
            	expr146 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr146.Tree);
            	// MyGrammar.g:327:13: ( ';' )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == 84) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // MyGrammar.g:327:14: ';'
            			    {
            			    	char_literal147=(IToken)Match(input,84,FOLLOW_84_in_line2589); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements


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
    // MyGrammar.g:330:1: exprList : ( methodDef ( ';' )* | varInit ( ';' )* | arrayInit ( ';' )* );
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal149 = null;
        IToken char_literal151 = null;
        IToken char_literal153 = null;
        MyGrammarParser.methodDef_return methodDef148 = default(MyGrammarParser.methodDef_return);

        MyGrammarParser.varInit_return varInit150 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.arrayInit_return arrayInit152 = default(MyGrammarParser.arrayInit_return);


        object char_literal149_tree=null;
        object char_literal151_tree=null;
        object char_literal153_tree=null;

        try 
    	{
            // MyGrammar.g:330:9: ( methodDef ( ';' )* | varInit ( ';' )* | arrayInit ( ';' )* )
            int alt24 = 3;
            int LA24_0 = input.LA(1);

            if ( ((LA24_0 >= INT && LA24_0 <= VOID)) )
            {
                int LA24_1 = input.LA(2);

                if ( (LA24_1 == ID) )
                {
                    int LA24_2 = input.LA(3);

                    if ( (LA24_2 == 85) )
                    {
                        alt24 = 1;
                    }
                    else if ( (LA24_2 == EOF || LA24_2 == ASSIGN || (LA24_2 >= INT && LA24_2 <= VOID) || LA24_2 == 84) )
                    {
                        alt24 = 2;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d24s2 =
                            new NoViableAltException("", 24, 2, input);

                        throw nvae_d24s2;
                    }
                }
                else if ( (LA24_1 == 77) )
                {
                    alt24 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d24s1 =
                        new NoViableAltException("", 24, 1, input);

                    throw nvae_d24s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // MyGrammar.g:330:11: methodDef ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodDef_in_exprList2603);
                    	methodDef148 = methodDef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef148.Tree);
                    	// MyGrammar.g:330:22: ( ';' )*
                    	do 
                    	{
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);

                    	    if ( (LA21_0 == 84) )
                    	    {
                    	        alt21 = 1;
                    	    }


                    	    switch (alt21) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:330:23: ';'
                    			    {
                    			    	char_literal149=(IToken)Match(input,84,FOLLOW_84_in_exprList2607); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop21;
                    	    }
                    	} while (true);

                    	loop21:
                    		;	// Stops C# compiler whining that label 'loop21' has no statements


                    }
                    break;
                case 2 :
                    // MyGrammar.g:331:5: varInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_exprList2617);
                    	varInit150 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit150.Tree);
                    	// MyGrammar.g:331:13: ( ';' )*
                    	do 
                    	{
                    	    int alt22 = 2;
                    	    int LA22_0 = input.LA(1);

                    	    if ( (LA22_0 == 84) )
                    	    {
                    	        alt22 = 1;
                    	    }


                    	    switch (alt22) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:331:14: ';'
                    			    {
                    			    	char_literal151=(IToken)Match(input,84,FOLLOW_84_in_exprList2620); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop22;
                    	    }
                    	} while (true);

                    	loop22:
                    		;	// Stops C# compiler whining that label 'loop22' has no statements


                    }
                    break;
                case 3 :
                    // MyGrammar.g:332:5: arrayInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_exprList2630);
                    	arrayInit152 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit152.Tree);
                    	// MyGrammar.g:332:15: ( ';' )*
                    	do 
                    	{
                    	    int alt23 = 2;
                    	    int LA23_0 = input.LA(1);

                    	    if ( (LA23_0 == 84) )
                    	    {
                    	        alt23 = 1;
                    	    }


                    	    switch (alt23) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:332:16: ';'
                    			    {
                    			    	char_literal153=(IToken)Match(input,84,FOLLOW_84_in_exprList2633); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop23;
                    	    }
                    	} while (true);

                    	loop23:
                    		;	// Stops C# compiler whining that label 'loop23' has no statements


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
    // MyGrammar.g:338:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList154 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:338:13: ( ( exprList )* )
            // MyGrammar.g:339:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:339:4: ( exprList )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( ((LA25_0 >= INT && LA25_0 <= VOID)) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm2654);
            			    	exprList154 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList154.Tree);

            			    }
            			    break;

            			default:
            			    goto loop25;
            	    }
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements


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
    // MyGrammar.g:342:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm155 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:342:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:343:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program2668);
            	fullProgramm155 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm155.Tree);


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
            	// 343:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:343:19: ^( PROGRAM fullProgramm )
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
    // MyGrammar.g:346:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program156 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:346:8: ( program )
            // MyGrammar.g:347:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute2686);
            	program156 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program156.Tree);

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

    // $ANTLR start "synpred17_MyGrammar"
    public void synpred17_MyGrammar_fragment() {
        // MyGrammar.g:174:14: ( add )
        // MyGrammar.g:174:14: add
        {
        	PushFollow(FOLLOW_add_in_synpred17_MyGrammar1353);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_MyGrammar"

    // $ANTLR start "synpred19_MyGrammar"
    public void synpred19_MyGrammar_fragment() {
        // MyGrammar.g:176:7: ( ident )
        // MyGrammar.g:176:7: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred19_MyGrammar1369);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_MyGrammar"

    // $ANTLR start "synpred29_MyGrammar"
    public void synpred29_MyGrammar_fragment() {
        // MyGrammar.g:214:16: ( orOperation )
        // MyGrammar.g:214:16: orOperation
        {
        	PushFollow(FOLLOW_orOperation_in_synpred29_MyGrammar1656);
        	orOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred29_MyGrammar"

    // $ANTLR start "synpred30_MyGrammar"
    public void synpred30_MyGrammar_fragment() {
        // MyGrammar.g:215:8: ( andOperation )
        // MyGrammar.g:215:8: andOperation
        {
        	PushFollow(FOLLOW_andOperation_in_synpred30_MyGrammar1676);
        	andOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_MyGrammar"

    // $ANTLR start "synpred31_MyGrammar"
    public void synpred31_MyGrammar_fragment() {
        // MyGrammar.g:216:8: ( eqOp )
        // MyGrammar.g:216:8: eqOp
        {
        	PushFollow(FOLLOW_eqOp_in_synpred31_MyGrammar1696);
        	eqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_MyGrammar"

    // $ANTLR start "synpred32_MyGrammar"
    public void synpred32_MyGrammar_fragment() {
        // MyGrammar.g:217:8: ( nonEqOp )
        // MyGrammar.g:217:8: nonEqOp
        {
        	PushFollow(FOLLOW_nonEqOp_in_synpred32_MyGrammar1716);
        	nonEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_MyGrammar"

    // $ANTLR start "synpred33_MyGrammar"
    public void synpred33_MyGrammar_fragment() {
        // MyGrammar.g:218:8: ( moreOp )
        // MyGrammar.g:218:8: moreOp
        {
        	PushFollow(FOLLOW_moreOp_in_synpred33_MyGrammar1736);
        	moreOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_MyGrammar"

    // $ANTLR start "synpred34_MyGrammar"
    public void synpred34_MyGrammar_fragment() {
        // MyGrammar.g:219:8: ( moreEqOp )
        // MyGrammar.g:219:8: moreEqOp
        {
        	PushFollow(FOLLOW_moreEqOp_in_synpred34_MyGrammar1756);
        	moreEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_MyGrammar"

    // $ANTLR start "synpred35_MyGrammar"
    public void synpred35_MyGrammar_fragment() {
        // MyGrammar.g:220:8: ( lessOp )
        // MyGrammar.g:220:8: lessOp
        {
        	PushFollow(FOLLOW_lessOp_in_synpred35_MyGrammar1776);
        	lessOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred35_MyGrammar"

    // $ANTLR start "synpred36_MyGrammar"
    public void synpred36_MyGrammar_fragment() {
        // MyGrammar.g:224:18: ( orOperation )
        // MyGrammar.g:224:18: orOperation
        {
        	PushFollow(FOLLOW_orOperation_in_synpred36_MyGrammar1824);
        	orOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred36_MyGrammar"

    // $ANTLR start "synpred37_MyGrammar"
    public void synpred37_MyGrammar_fragment() {
        // MyGrammar.g:225:8: ( andOperation )
        // MyGrammar.g:225:8: andOperation
        {
        	PushFollow(FOLLOW_andOperation_in_synpred37_MyGrammar1833);
        	andOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred37_MyGrammar"

    // $ANTLR start "synpred38_MyGrammar"
    public void synpred38_MyGrammar_fragment() {
        // MyGrammar.g:226:8: ( eqOp )
        // MyGrammar.g:226:8: eqOp
        {
        	PushFollow(FOLLOW_eqOp_in_synpred38_MyGrammar1842);
        	eqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_MyGrammar"

    // $ANTLR start "synpred39_MyGrammar"
    public void synpred39_MyGrammar_fragment() {
        // MyGrammar.g:227:8: ( nonEqOp )
        // MyGrammar.g:227:8: nonEqOp
        {
        	PushFollow(FOLLOW_nonEqOp_in_synpred39_MyGrammar1851);
        	nonEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_MyGrammar"

    // $ANTLR start "synpred40_MyGrammar"
    public void synpred40_MyGrammar_fragment() {
        // MyGrammar.g:228:8: ( moreOp )
        // MyGrammar.g:228:8: moreOp
        {
        	PushFollow(FOLLOW_moreOp_in_synpred40_MyGrammar1860);
        	moreOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred40_MyGrammar"

    // $ANTLR start "synpred41_MyGrammar"
    public void synpred41_MyGrammar_fragment() {
        // MyGrammar.g:229:8: ( moreEqOp )
        // MyGrammar.g:229:8: moreEqOp
        {
        	PushFollow(FOLLOW_moreEqOp_in_synpred41_MyGrammar1869);
        	moreEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred41_MyGrammar"

    // $ANTLR start "synpred42_MyGrammar"
    public void synpred42_MyGrammar_fragment() {
        // MyGrammar.g:230:8: ( lessOp )
        // MyGrammar.g:230:8: lessOp
        {
        	PushFollow(FOLLOW_lessOp_in_synpred42_MyGrammar1878);
        	lessOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred42_MyGrammar"

    // $ANTLR start "synpred44_MyGrammar"
    public void synpred44_MyGrammar_fragment() {
        // MyGrammar.g:298:13: ( add )
        // MyGrammar.g:298:13: add
        {
        	PushFollow(FOLLOW_add_in_synpred44_MyGrammar2393);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred44_MyGrammar"

    // $ANTLR start "synpred45_MyGrammar"
    public void synpred45_MyGrammar_fragment() {
        // MyGrammar.g:299:6: ( ident )
        // MyGrammar.g:299:6: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred45_MyGrammar2400);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred45_MyGrammar"

    // $ANTLR start "synpred47_MyGrammar"
    public void synpred47_MyGrammar_fragment() {
        // MyGrammar.g:316:8: ( add )
        // MyGrammar.g:316:8: add
        {
        	PushFollow(FOLLOW_add_in_synpred47_MyGrammar2527);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred47_MyGrammar"

    // $ANTLR start "synpred49_MyGrammar"
    public void synpred49_MyGrammar_fragment() {
        // MyGrammar.g:318:5: ( init )
        // MyGrammar.g:318:5: init
        {
        	PushFollow(FOLLOW_init_in_synpred49_MyGrammar2539);
        	init();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_MyGrammar"

    // $ANTLR start "synpred50_MyGrammar"
    public void synpred50_MyGrammar_fragment() {
        // MyGrammar.g:319:5: ( arrayInit )
        // MyGrammar.g:319:5: arrayInit
        {
        	PushFollow(FOLLOW_arrayInit_in_synpred50_MyGrammar2545);
        	arrayInit();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred50_MyGrammar"

    // $ANTLR start "synpred52_MyGrammar"
    public void synpred52_MyGrammar_fragment() {
        // MyGrammar.g:321:5: ( fieldInitValue )
        // MyGrammar.g:321:5: fieldInitValue
        {
        	PushFollow(FOLLOW_fieldInitValue_in_synpred52_MyGrammar2557);
        	fieldInitValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred52_MyGrammar"

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
   	public bool synpred30_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred30_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred50_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred50_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred29_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred29_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred17_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred31_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred47_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred47_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred52_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred52_MyGrammar_fragment(); // can never throw exception
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


   	protected DFA14 dfa14;
   	protected DFA15 dfa15;
   	protected DFA19 dfa19;
	private void InitializeCyclicDFAs()
	{
    	this.dfa14 = new DFA14(this);
    	this.dfa15 = new DFA15(this);
    	this.dfa19 = new DFA19(this);
	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);
	    this.dfa15.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA15_SpecialStateTransition);
	    this.dfa19.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA19_SpecialStateTransition);
	}

    const string DFA14_eotS =
        "\x0d\uffff";
    const string DFA14_eofS =
        "\x0d\uffff";
    const string DFA14_minS =
        "\x01\x49\x04\x00\x08\uffff";
    const string DFA14_maxS =
        "\x01\x50\x04\x00\x08\uffff";
    const string DFA14_acceptS =
        "\x05\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08";
    const string DFA14_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x08\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x02\x01\x03\x01\x04\x04\uffff\x01\x01",
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

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "214:1: operations : ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) );"; }
        }

    }


    protected internal int DFA14_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA14_1 = input.LA(1);

                   	 
                   	int index14_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred29_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred30_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred31_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred32_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index14_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA14_2 = input.LA(1);

                   	 
                   	int index14_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred29_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred30_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred31_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred32_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index14_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA14_3 = input.LA(1);

                   	 
                   	int index14_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred29_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred30_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred31_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred32_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index14_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA14_4 = input.LA(1);

                   	 
                   	int index14_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred29_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred30_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred31_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred32_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred34_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index14_4);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae14 =
            new NoViableAltException(dfa.Description, 14, _s, input);
        dfa.Error(nvae14);
        throw nvae14;
    }
    const string DFA15_eotS =
        "\x0d\uffff";
    const string DFA15_eofS =
        "\x0d\uffff";
    const string DFA15_minS =
        "\x01\x49\x04\x00\x08\uffff";
    const string DFA15_maxS =
        "\x01\x50\x04\x00\x08\uffff";
    const string DFA15_acceptS =
        "\x05\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08";
    const string DFA15_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x08\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x01\x02\x01\x03\x01\x04\x04\uffff\x01\x01",
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
            get { return "224:1: logicOperator : ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp );"; }
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
                   	if ( (synpred36_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index15_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA15_2 = input.LA(1);

                   	 
                   	int index15_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index15_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA15_3 = input.LA(1);

                   	 
                   	int index15_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index15_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA15_4 = input.LA(1);

                   	 
                   	int index15_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred41_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred42_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index15_4);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae15 =
            new NoViableAltException(dfa.Description, 15, _s, input);
        dfa.Error(nvae15);
        throw nvae15;
    }
    const string DFA19_eotS =
        "\x0e\uffff";
    const string DFA19_eofS =
        "\x0e\uffff";
    const string DFA19_minS =
        "\x01\x20\x01\uffff\x01\x2a\x01\uffff\x01\x4b\x05\uffff\x01\x4b"+
        "\x01\uffff\x01\x00\x01\uffff";
    const string DFA19_maxS =
        "\x01\x50\x01\uffff\x01\x55\x01\uffff\x01\x4d\x05\uffff\x01\x4b"+
        "\x01\uffff\x01\x00\x01\uffff";
    const string DFA19_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\uffff\x01\x05\x01\x08"+
        "\x01\x07\x01\x09\x01\x06\x01\uffff\x01\x03\x01\uffff\x01\x04";
    const string DFA19_specialS =
        "\x02\uffff\x01\x00\x09\uffff\x01\x01\x01\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x06\x04\uffff\x01\x03\x0b\uffff\x05\x04\x08\uffff\x02"+
            "\x05\x09\uffff\x02\x01\x01\x02\x04\uffff\x01\x01",
            "",
            "\x01\x08\x23\uffff\x01\x08\x06\uffff\x01\x07",
            "",
            "\x01\x0b\x01\uffff\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c",
            "",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "316:1: expr : ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | changeValue );"; }
        }

    }


    protected internal int DFA19_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA19_2 = input.LA(1);

                   	 
                   	int index19_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA19_2 == 85) ) { s = 7; }

                   	else if ( (LA19_2 == ASSIGN || LA19_2 == 78) ) { s = 8; }

                   	else if ( (synpred47_MyGrammar()) ) { s = 1; }

                   	else if ( (synpred52_MyGrammar()) ) { s = 9; }

                   	 
                   	input.Seek(index19_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA19_12 = input.LA(1);

                   	 
                   	int index19_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred49_MyGrammar()) ) { s = 11; }

                   	else if ( (synpred50_MyGrammar()) ) { s = 13; }

                   	 
                   	input.Seek(index19_12);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae19 =
            new NoViableAltException(dfa.Description, 19, _s, input);
        dfa.Error(nvae19);
        throw nvae19;
    }
 

    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inc_in_incDec960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dec_in_incDec966 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_inc979 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECREMENT_in_dec1002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_in_number1093 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE__in_number1110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_ident1175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_init1203 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_init1210 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_arrayInit1221 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_arrayInit1223 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_ident_in_arrayInit1225 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_arrayInit1228 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_NEW_in_arrayInit1230 = new BitSet(new ulong[]{0x003E000000000000UL});
    public static readonly BitSet FOLLOW_type_in_arrayInit1232 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_arrayInit1234 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_arrayInit1236 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_arrayInit1238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_varInit1275 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_varInit1277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_fieldInitValue1307 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_fieldInitValue1311 = new BitSet(new ulong[]{0x0001800000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_initValue_in_fieldInitValue1313 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_initValue1353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_initValue1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_initValue1369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inc_in_initValue1377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dec_in_initValue1385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_addOperation1399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_addOperation1414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multOperation1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multOperation1449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_group1472 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_group1475 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_group1477 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group1485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_group1491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult1506 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_multOperation_in_mult1510 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_group_in_mult1513 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_mult_in_add1525 = new BitSet(new ulong[]{0x0000000600000002UL});
    public static readonly BitSet FOLLOW_addOperation_in_add1529 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_mult_in_add1532 = new BitSet(new ulong[]{0x0000000600000002UL});
    public static readonly BitSet FOLLOW_PRINT_in_print1543 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_print1545 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_printExpr_in_print1547 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_print1549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_block1571 = new BitSet(new ulong[]{0xC03E002100000000UL,0x0000000000090E00UL});
    public static readonly BitSet FOLLOW_line_in_block1573 = new BitSet(new ulong[]{0xC03E002100000000UL,0x0000000000090E00UL});
    public static readonly BitSet FOLLOW_83_in_block1576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_1601 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_if_1603 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_1605 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_if_1607 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_if_1609 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_if_1612 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_if_1614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_operations1656 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_operations1676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_operations1696 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_operations1716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_operations1736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_operations1756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_operations1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_operations1796 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator1824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_logicOperator1833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_logicOperator1842 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_logicOperator1851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_logicOperator1860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_logicOperator1869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_logicOperator1878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_logicOperator1887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_orOperation1904 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_OR_in_orOperation1906 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_orOperation1908 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_andOperation1936 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AND_in_andOperation1938 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_andOperation1940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_eqOp1970 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EQ_in_eqOp1972 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_eqOp1974 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_nonEqOp2004 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_NONEQ_in_nonEqOp2006 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_nonEqOp2008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_moreOp2039 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_MORE_in_moreOp2041 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_moreOp2043 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_moreEqOp2072 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_MOREEQ_in_moreEqOp2074 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_moreEqOp2076 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_lessOp2106 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LESS_in_lessOp2108 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_lessOp2110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_lessEqOp2139 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LESSEQ_in_lessEqOp2141 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_lessEqOp2143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle2172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle2178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_2190 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_for_2205 = new BitSet(new ulong[]{0x003E000000000000UL});
    public static readonly BitSet FOLLOW_varInit_in_for_2214 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_for_2216 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_2221 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_for_2223 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_for_2231 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_for_2236 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_for_2241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_2273 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_while_2278 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_2283 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_while_2288 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_while_2293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_methodDef2325 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_ID_in_methodDef2327 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_methodDef2329 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_block_in_methodDef2331 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod2361 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_callMethod2363 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr2393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_printExpr2400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr2407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varChangeValue_in_changeValue2422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayChangeValue_in_changeValue2430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_varChangeValue2443 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_varChangeValue2445 = new BitSet(new ulong[]{0x0001800000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_initValue_in_varChangeValue2447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_arrayChangeValue2479 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_arrayChangeValue2481 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_add_in_arrayChangeValue2483 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000008000UL});
    public static readonly BitSet FOLLOW_79_in_arrayChangeValue2485 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_arrayChangeValue2487 = new BitSet(new ulong[]{0x0001800000000000UL,0x0000000000010E00UL});
    public static readonly BitSet FOLLOW_initValue_in_arrayChangeValue2490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr2527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr2533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_init_in_expr2539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_expr2545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr2551 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_expr2557 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr2563 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr2569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_changeValue_in_expr2575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line2586 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_line2589 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_methodDef_in_exprList2603 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_exprList2607 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_varInit_in_exprList2617 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_exprList2620 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_arrayInit_in_exprList2630 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_exprList2633 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm2654 = new BitSet(new ulong[]{0x003E000000000002UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program2668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute2686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred17_MyGrammar1353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred19_MyGrammar1369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_synpred29_MyGrammar1656 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_synpred30_MyGrammar1676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_synpred31_MyGrammar1696 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_synpred32_MyGrammar1716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_synpred33_MyGrammar1736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_synpred34_MyGrammar1756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_synpred35_MyGrammar1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_synpred36_MyGrammar1824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_synpred37_MyGrammar1833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_synpred38_MyGrammar1842 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_synpred39_MyGrammar1851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_synpred40_MyGrammar1860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_synpred41_MyGrammar1869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_synpred42_MyGrammar1878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred44_MyGrammar2393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred45_MyGrammar2400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred47_MyGrammar2527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_init_in_synpred49_MyGrammar2539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_synpred50_MyGrammar2545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_synpred52_MyGrammar2557 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}