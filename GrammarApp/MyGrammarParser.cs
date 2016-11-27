// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-11-27 20:57:05

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
    // MyGrammar.g:93:1: type : ( INT | FLOAT | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:93:6: ( INT | FLOAT | DOUBLE | CHAR | VOID )
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
    // MyGrammar.g:101:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:101:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
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
    // MyGrammar.g:109:1: incDec : ( inc | dec );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.inc_return inc3 = default(MyGrammarParser.inc_return);

        MyGrammarParser.dec_return dec4 = default(MyGrammarParser.dec_return);



        try 
    	{
            // MyGrammar.g:109:8: ( inc | dec )
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
                    // MyGrammar.g:109:10: inc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inc_in_incDec926);
                    	inc3 = inc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inc3.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:110:5: dec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dec_in_incDec932);
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
    // MyGrammar.g:114:1: inc : INCREMENT -> ^( Inc INCREMENT ) ;
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
            // MyGrammar.g:114:6: ( INCREMENT -> ^( Inc INCREMENT ) )
            // MyGrammar.g:114:8: INCREMENT
            {
            	INCREMENT5=(IToken)Match(input,INCREMENT,FOLLOW_INCREMENT_in_inc945); if (state.failed) return retval; 
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
            	// 114:18: -> ^( Inc INCREMENT )
            	{
            	    // MyGrammar.g:114:21: ^( Inc INCREMENT )
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
    // MyGrammar.g:117:1: dec : DECREMENT -> DECREMENT ;
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
            // MyGrammar.g:117:6: ( DECREMENT -> DECREMENT )
            // MyGrammar.g:117:8: DECREMENT
            {
            	DECREMENT6=(IToken)Match(input,DECREMENT,FOLLOW_DECREMENT_in_dec968); if (state.failed) return retval; 
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
            	// 117:18: -> DECREMENT
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
    // MyGrammar.g:120:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set7 = null;

        object set7_tree=null;

        try 
    	{
            // MyGrammar.g:120:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
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
    // MyGrammar.g:136:1: number : ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) );
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
            // MyGrammar.g:136:8: ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) )
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
                    // MyGrammar.g:136:10: INTEGER
                    {
                    	INTEGER8=(IToken)Match(input,INTEGER,FOLLOW_INTEGER_in_number1059); if (state.failed) return retval; 
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
                    	// 136:18: -> ^( Integer INTEGER )
                    	{
                    	    // MyGrammar.g:136:21: ^( Integer INTEGER )
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
                    // MyGrammar.g:137:5: DOUBLE_
                    {
                    	DOUBLE_9=(IToken)Match(input,DOUBLE_,FOLLOW_DOUBLE__in_number1076); if (state.failed) return retval; 
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
                    	// 137:13: -> ^( Double DOUBLE_ )
                    	{
                    	    // MyGrammar.g:137:16: ^( Double DOUBLE_ )
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
    // MyGrammar.g:144:1: ident : ID -> ^( Id ID ) ;
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
            // MyGrammar.g:144:8: ( ID -> ^( Id ID ) )
            // MyGrammar.g:144:10: ID
            {
            	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_ident1141); if (state.failed) return retval; 
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
            	// 144:13: -> ^( Id ID )
            	{
            	    // MyGrammar.g:144:16: ^( Id ID )
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
    // MyGrammar.g:147:1: varInit : type varInitValue -> ^( VarInit type varInitValue ) ;
    public MyGrammarParser.varInit_return varInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInit_return retval = new MyGrammarParser.varInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.type_return type11 = default(MyGrammarParser.type_return);

        MyGrammarParser.varInitValue_return varInitValue12 = default(MyGrammarParser.varInitValue_return);


        RewriteRuleSubtreeStream stream_varInitValue = new RewriteRuleSubtreeStream(adaptor,"rule varInitValue");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:147:9: ( type varInitValue -> ^( VarInit type varInitValue ) )
            // MyGrammar.g:147:11: type varInitValue
            {
            	PushFollow(FOLLOW_type_in_varInit1164);
            	type11 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type11.Tree);
            	PushFollow(FOLLOW_varInitValue_in_varInit1166);
            	varInitValue12 = varInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitValue.Add(varInitValue12.Tree);


            	// AST REWRITE
            	// elements:          varInitValue, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 148:5: -> ^( VarInit type varInitValue )
            	{
            	    // MyGrammar.g:148:8: ^( VarInit type varInitValue )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new VarInitNode(VarInit), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_varInitValue.NextTree());

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

    public class varInitValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "varInitValue"
    // MyGrammar.g:152:1: varInitValue : ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) ;
    public MyGrammarParser.varInitValue_return varInitValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInitValue_return retval = new MyGrammarParser.varInitValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN14 = null;
        MyGrammarParser.ident_return ident13 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue15 = default(MyGrammarParser.initValue_return);


        object ASSIGN14_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:152:14: ( ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) )
            // MyGrammar.g:152:17: ident ( ASSIGN initValue )?
            {
            	PushFollow(FOLLOW_ident_in_varInitValue1196);
            	ident13 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident13.Tree);
            	// MyGrammar.g:152:23: ( ASSIGN initValue )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == ASSIGN) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // MyGrammar.g:152:24: ASSIGN initValue
            	        {
            	        	ASSIGN14=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_varInitValue1199); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN14);

            	        	PushFollow(FOLLOW_initValue_in_varInitValue1201);
            	        	initValue15 = initValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initValue.Add(initValue15.Tree);

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
            	// 153:7: -> ^( Assign ident ( initValue )? )
            	{
            	    // MyGrammar.g:153:10: ^( Assign ident ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AssignNode(Assign), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:153:37: ( initValue )?
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
    // $ANTLR end "varInitValue"

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
    // MyGrammar.g:156:1: initValue : ( add | callMethod | ident | inc | dec );
    public MyGrammarParser.initValue_return initValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.initValue_return retval = new MyGrammarParser.initValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add16 = default(MyGrammarParser.add_return);

        MyGrammarParser.callMethod_return callMethod17 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.ident_return ident18 = default(MyGrammarParser.ident_return);

        MyGrammarParser.inc_return inc19 = default(MyGrammarParser.inc_return);

        MyGrammarParser.dec_return dec20 = default(MyGrammarParser.dec_return);



        try 
    	{
            // MyGrammar.g:156:12: ( add | callMethod | ident | inc | dec )
            int alt4 = 5;
            switch ( input.LA(1) ) 
            {
            case INTEGER:
            case DOUBLE_:
            case 76:
            	{
                alt4 = 1;
                }
                break;
            case ID:
            	{
                int LA4_2 = input.LA(2);

                if ( (LA4_2 == 81) )
                {
                    alt4 = 2;
                }
                else if ( (synpred15_MyGrammar()) )
                {
                    alt4 = 1;
                }
                else if ( (synpred17_MyGrammar()) )
                {
                    alt4 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d4s2 =
                        new NoViableAltException("", 4, 2, input);

                    throw nvae_d4s2;
                }
                }
                break;
            case INCREMENT:
            	{
                alt4 = 4;
                }
                break;
            case DECREMENT:
            	{
                alt4 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            }

            switch (alt4) 
            {
                case 1 :
                    // MyGrammar.g:156:14: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_initValue1239);
                    	add16 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add16.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:157:7: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_initValue1247);
                    	callMethod17 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod17.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:158:7: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_initValue1255);
                    	ident18 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident18.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:159:7: inc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inc_in_initValue1263);
                    	inc19 = inc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inc19.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:160:7: dec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dec_in_initValue1271);
                    	dec20 = dec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dec20.Tree);

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

    public class oneArray_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "oneArray"
    // MyGrammar.g:163:1: oneArray : type ident '[' number ']' -> ^( ONEARRAY ^( ident ^( COUNT number ) ) ) ;
    public MyGrammarParser.oneArray_return oneArray() // throws RecognitionException [1]
    {   
        MyGrammarParser.oneArray_return retval = new MyGrammarParser.oneArray_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal23 = null;
        IToken char_literal25 = null;
        MyGrammarParser.type_return type21 = default(MyGrammarParser.type_return);

        MyGrammarParser.ident_return ident22 = default(MyGrammarParser.ident_return);

        MyGrammarParser.number_return number24 = default(MyGrammarParser.number_return);


        object char_literal23_tree=null;
        object char_literal25_tree=null;
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:163:10: ( type ident '[' number ']' -> ^( ONEARRAY ^( ident ^( COUNT number ) ) ) )
            // MyGrammar.g:163:12: type ident '[' number ']'
            {
            	PushFollow(FOLLOW_type_in_oneArray1284);
            	type21 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type21.Tree);
            	PushFollow(FOLLOW_ident_in_oneArray1286);
            	ident22 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident22.Tree);
            	char_literal23=(IToken)Match(input,74,FOLLOW_74_in_oneArray1288); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_74.Add(char_literal23);

            	PushFollow(FOLLOW_number_in_oneArray1290);
            	number24 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number24.Tree);
            	char_literal25=(IToken)Match(input,75,FOLLOW_75_in_oneArray1292); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_75.Add(char_literal25);



            	// AST REWRITE
            	// elements:          ident, number
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 164:5: -> ^( ONEARRAY ^( ident ^( COUNT number ) ) )
            	{
            	    // MyGrammar.g:164:8: ^( ONEARRAY ^( ident ^( COUNT number ) ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ONEARRAY, "ONEARRAY"), root_1);

            	    // MyGrammar.g:164:19: ^( ident ^( COUNT number ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ident.NextNode(), root_2);

            	    // MyGrammar.g:164:27: ^( COUNT number )
            	    {
            	    object root_3 = (object)adaptor.GetNilNode();
            	    root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(COUNT, "COUNT"), root_3);

            	    adaptor.AddChild(root_3, stream_number.NextTree());

            	    adaptor.AddChild(root_2, root_3);
            	    }

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
    // $ANTLR end "oneArray"

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
    // MyGrammar.g:167:1: addOperation : ( PLUS -> Plus | MINUS -> Minus );
    public MyGrammarParser.addOperation_return addOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.addOperation_return retval = new MyGrammarParser.addOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS26 = null;
        IToken MINUS27 = null;

        object PLUS26_tree=null;
        object MINUS27_tree=null;
        RewriteRuleTokenStream stream_PLUS = new RewriteRuleTokenStream(adaptor,"token PLUS");
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor,"token MINUS");

        try 
    	{
            // MyGrammar.g:167:14: ( PLUS -> Plus | MINUS -> Minus )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == PLUS) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == MINUS) )
            {
                alt5 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // MyGrammar.g:167:16: PLUS
                    {
                    	PLUS26=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addOperation1324); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_PLUS.Add(PLUS26);



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
                    	// 167:21: -> Plus
                    	{
                    	    adaptor.AddChild(root_0, new PlusNode(Plus));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:168:7: MINUS
                    {
                    	MINUS27=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_addOperation1339); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MINUS.Add(MINUS27);



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
                    	// 168:13: -> Minus
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
    // MyGrammar.g:171:1: multOperation : ( MULTIPLY -> MULT | DIVIDE -> DIVIDE );
    public MyGrammarParser.multOperation_return multOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.multOperation_return retval = new MyGrammarParser.multOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULTIPLY28 = null;
        IToken DIVIDE29 = null;

        object MULTIPLY28_tree=null;
        object DIVIDE29_tree=null;
        RewriteRuleTokenStream stream_MULTIPLY = new RewriteRuleTokenStream(adaptor,"token MULTIPLY");
        RewriteRuleTokenStream stream_DIVIDE = new RewriteRuleTokenStream(adaptor,"token DIVIDE");

        try 
    	{
            // MyGrammar.g:171:15: ( MULTIPLY -> MULT | DIVIDE -> DIVIDE )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == MULTIPLY) )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == DIVIDE) )
            {
                alt6 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // MyGrammar.g:171:17: MULTIPLY
                    {
                    	MULTIPLY28=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multOperation1359); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MULTIPLY.Add(MULTIPLY28);



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
                    	// 171:26: -> MULT
                    	{
                    	    adaptor.AddChild(root_0, new MultNode(MULT));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:172:7: DIVIDE
                    {
                    	DIVIDE29=(IToken)Match(input,DIVIDE,FOLLOW_DIVIDE_in_multOperation1374); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DIVIDE.Add(DIVIDE29);



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
                    	// 172:14: -> DIVIDE
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
    // MyGrammar.g:175:1: group : ( '(' add ')' | number | ident );
    public MyGrammarParser.group_return group() // throws RecognitionException [1]
    {   
        MyGrammarParser.group_return retval = new MyGrammarParser.group_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal30 = null;
        IToken char_literal32 = null;
        MyGrammarParser.add_return add31 = default(MyGrammarParser.add_return);

        MyGrammarParser.number_return number33 = default(MyGrammarParser.number_return);

        MyGrammarParser.ident_return ident34 = default(MyGrammarParser.ident_return);


        object char_literal30_tree=null;
        object char_literal32_tree=null;

        try 
    	{
            // MyGrammar.g:175:7: ( '(' add ')' | number | ident )
            int alt7 = 3;
            switch ( input.LA(1) ) 
            {
            case 76:
            	{
                alt7 = 1;
                }
                break;
            case INTEGER:
            case DOUBLE_:
            	{
                alt7 = 2;
                }
                break;
            case ID:
            	{
                alt7 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            }

            switch (alt7) 
            {
                case 1 :
                    // MyGrammar.g:175:9: '(' add ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal30=(IToken)Match(input,76,FOLLOW_76_in_group1397); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group1400);
                    	add31 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add31.Tree);
                    	char_literal32=(IToken)Match(input,77,FOLLOW_77_in_group1402); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:176:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group1410);
                    	number33 = number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number33.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:177:5: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_group1416);
                    	ident34 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident34.Tree);

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
    // MyGrammar.g:180:1: mult : group ( multOperation group )* ;
    public MyGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        MyGrammarParser.mult_return retval = new MyGrammarParser.mult_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.group_return group35 = default(MyGrammarParser.group_return);

        MyGrammarParser.multOperation_return multOperation36 = default(MyGrammarParser.multOperation_return);

        MyGrammarParser.group_return group37 = default(MyGrammarParser.group_return);



        try 
    	{
            // MyGrammar.g:180:6: ( group ( multOperation group )* )
            // MyGrammar.g:180:8: group ( multOperation group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult1431);
            	group35 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group35.Tree);
            	// MyGrammar.g:180:14: ( multOperation group )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= MULTIPLY && LA8_0 <= DIVIDE)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // MyGrammar.g:180:16: multOperation group
            			    {
            			    	PushFollow(FOLLOW_multOperation_in_mult1435);
            			    	multOperation36 = multOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperation36.Tree, root_0);
            			    	PushFollow(FOLLOW_group_in_mult1438);
            			    	group37 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group37.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


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
    // MyGrammar.g:182:1: add : mult ( addOperation mult )* ;
    public MyGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        MyGrammarParser.add_return retval = new MyGrammarParser.add_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.mult_return mult38 = default(MyGrammarParser.mult_return);

        MyGrammarParser.addOperation_return addOperation39 = default(MyGrammarParser.addOperation_return);

        MyGrammarParser.mult_return mult40 = default(MyGrammarParser.mult_return);



        try 
    	{
            // MyGrammar.g:182:6: ( mult ( addOperation mult )* )
            // MyGrammar.g:182:8: mult ( addOperation mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1450);
            	mult38 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult38.Tree);
            	// MyGrammar.g:182:13: ( addOperation mult )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= PLUS && LA9_0 <= MINUS)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // MyGrammar.g:182:15: addOperation mult
            			    {
            			    	PushFollow(FOLLOW_addOperation_in_add1454);
            			    	addOperation39 = addOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperation39.Tree, root_0);
            			    	PushFollow(FOLLOW_mult_in_add1457);
            			    	mult40 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult40.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


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
    // MyGrammar.g:184:1: print : PRINT '(' printExpr ')' -> ^( PRINT printExpr ) ;
    public MyGrammarParser.print_return print() // throws RecognitionException [1]
    {   
        MyGrammarParser.print_return retval = new MyGrammarParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINT41 = null;
        IToken char_literal42 = null;
        IToken char_literal44 = null;
        MyGrammarParser.printExpr_return printExpr43 = default(MyGrammarParser.printExpr_return);


        object PRINT41_tree=null;
        object char_literal42_tree=null;
        object char_literal44_tree=null;
        RewriteRuleTokenStream stream_PRINT = new RewriteRuleTokenStream(adaptor,"token PRINT");
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_printExpr = new RewriteRuleSubtreeStream(adaptor,"rule printExpr");
        try 
    	{
            // MyGrammar.g:184:7: ( PRINT '(' printExpr ')' -> ^( PRINT printExpr ) )
            // MyGrammar.g:184:9: PRINT '(' printExpr ')'
            {
            	PRINT41=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print1468); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINT.Add(PRINT41);

            	char_literal42=(IToken)Match(input,76,FOLLOW_76_in_print1470); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(char_literal42);

            	PushFollow(FOLLOW_printExpr_in_print1472);
            	printExpr43 = printExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_printExpr.Add(printExpr43.Tree);
            	char_literal44=(IToken)Match(input,77,FOLLOW_77_in_print1474); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(char_literal44);



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
            	// 185:4: -> ^( PRINT printExpr )
            	{
            	    // MyGrammar.g:185:7: ^( PRINT printExpr )
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
    // MyGrammar.g:188:1: block : '{' ( line )* '}' -> ^( BLOCK ( line )* ) ;
    public MyGrammarParser.block_return block() // throws RecognitionException [1]
    {   
        MyGrammarParser.block_return retval = new MyGrammarParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal45 = null;
        IToken char_literal47 = null;
        MyGrammarParser.line_return line46 = default(MyGrammarParser.line_return);


        object char_literal45_tree=null;
        object char_literal47_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:188:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:188:9: '{' ( line )* '}'
            {
            	char_literal45=(IToken)Match(input,78,FOLLOW_78_in_block1496); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_78.Add(char_literal45);

            	// MyGrammar.g:188:13: ( line )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == PRINT || LA10_0 == IF || (LA10_0 >= INT && LA10_0 <= VOID) || (LA10_0 >= FOR && LA10_0 <= WHILE) || (LA10_0 >= INTEGER && LA10_0 <= ID) || LA10_0 == 76) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block1498);
            			    	line46 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line46.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	char_literal47=(IToken)Match(input,79,FOLLOW_79_in_block1501); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_79.Add(char_literal47);



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
            	// 188:23: -> ^( BLOCK ( line )* )
            	{
            	    // MyGrammar.g:188:26: ^( BLOCK ( line )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(BLOCK), root_1);

            	    // MyGrammar.g:188:49: ( line )*
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
    // MyGrammar.g:192:1: if_ : IF '(' logicOperator ')' block ( ELSE block )? -> ^( If logicOperator block ( ^( ELSE block ) )? ) ;
    public MyGrammarParser.if__return if_() // throws RecognitionException [1]
    {   
        MyGrammarParser.if__return retval = new MyGrammarParser.if__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF48 = null;
        IToken char_literal49 = null;
        IToken char_literal51 = null;
        IToken ELSE53 = null;
        MyGrammarParser.logicOperator_return logicOperator50 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block52 = default(MyGrammarParser.block_return);

        MyGrammarParser.block_return block54 = default(MyGrammarParser.block_return);


        object IF48_tree=null;
        object char_literal49_tree=null;
        object char_literal51_tree=null;
        object ELSE53_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:192:6: ( IF '(' logicOperator ')' block ( ELSE block )? -> ^( If logicOperator block ( ^( ELSE block ) )? ) )
            // MyGrammar.g:192:8: IF '(' logicOperator ')' block ( ELSE block )?
            {
            	IF48=(IToken)Match(input,IF,FOLLOW_IF_in_if_1526); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF48);

            	char_literal49=(IToken)Match(input,76,FOLLOW_76_in_if_1528); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(char_literal49);

            	PushFollow(FOLLOW_logicOperator_in_if_1530);
            	logicOperator50 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator50.Tree);
            	char_literal51=(IToken)Match(input,77,FOLLOW_77_in_if_1532); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(char_literal51);

            	PushFollow(FOLLOW_block_in_if_1534);
            	block52 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block52.Tree);
            	// MyGrammar.g:192:39: ( ELSE block )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == ELSE) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // MyGrammar.g:192:40: ELSE block
            	        {
            	        	ELSE53=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_if_1537); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE53);

            	        	PushFollow(FOLLOW_block_in_if_1539);
            	        	block54 = block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block.Add(block54.Tree);

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
            	// 193:4: -> ^( If logicOperator block ( ^( ELSE block ) )? )
            	{
            	    // MyGrammar.g:193:7: ^( If logicOperator block ( ^( ELSE block ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new IfNode(If), root_1);

            	    adaptor.AddChild(root_1, stream_logicOperator.NextTree());
            	    adaptor.AddChild(root_1, stream_block.NextTree());
            	    // MyGrammar.g:193:40: ( ^( ELSE block ) )?
            	    if ( stream_ELSE.HasNext() || stream_block.HasNext() )
            	    {
            	        // MyGrammar.g:193:40: ^( ELSE block )
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
    // MyGrammar.g:199:1: operations : ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) );
    public MyGrammarParser.operations_return operations() // throws RecognitionException [1]
    {   
        MyGrammarParser.operations_return retval = new MyGrammarParser.operations_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation55 = default(MyGrammarParser.orOperation_return);

        MyGrammarParser.andOperation_return andOperation56 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.eqOp_return eqOp57 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp58 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.moreOp_return moreOp59 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp60 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.lessOp_return lessOp61 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp62 = default(MyGrammarParser.lessEqOp_return);


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
            // MyGrammar.g:199:14: ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) )
            int alt12 = 8;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // MyGrammar.g:199:16: orOperation
                    {
                    	PushFollow(FOLLOW_orOperation_in_operations1581);
                    	orOperation55 = orOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_orOperation.Add(orOperation55.Tree);


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
                    	// 199:28: -> ^( OrOp orOperation )
                    	{
                    	    // MyGrammar.g:199:31: ^( OrOp orOperation )
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
                    // MyGrammar.g:200:8: andOperation
                    {
                    	PushFollow(FOLLOW_andOperation_in_operations1601);
                    	andOperation56 = andOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_andOperation.Add(andOperation56.Tree);


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
                    	// 200:21: -> ^( AndOp andOperation )
                    	{
                    	    // MyGrammar.g:200:24: ^( AndOp andOperation )
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
                    // MyGrammar.g:201:8: eqOp
                    {
                    	PushFollow(FOLLOW_eqOp_in_operations1621);
                    	eqOp57 = eqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_eqOp.Add(eqOp57.Tree);


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
                    	// 201:13: -> ^( EqOp eqOp )
                    	{
                    	    // MyGrammar.g:201:16: ^( EqOp eqOp )
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
                    // MyGrammar.g:202:8: nonEqOp
                    {
                    	PushFollow(FOLLOW_nonEqOp_in_operations1641);
                    	nonEqOp58 = nonEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nonEqOp.Add(nonEqOp58.Tree);


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
                    	// 202:16: -> ^( NonEqOp nonEqOp )
                    	{
                    	    // MyGrammar.g:202:19: ^( NonEqOp nonEqOp )
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
                    // MyGrammar.g:203:8: moreOp
                    {
                    	PushFollow(FOLLOW_moreOp_in_operations1661);
                    	moreOp59 = moreOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_moreOp.Add(moreOp59.Tree);


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
                    	// 203:15: -> ^( MoreOp moreOp )
                    	{
                    	    // MyGrammar.g:203:18: ^( MoreOp moreOp )
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
                    // MyGrammar.g:204:8: moreEqOp
                    {
                    	PushFollow(FOLLOW_moreEqOp_in_operations1681);
                    	moreEqOp60 = moreEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_moreEqOp.Add(moreEqOp60.Tree);


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
                    	// 204:17: -> ^( MoreEqOp moreEqOp )
                    	{
                    	    // MyGrammar.g:204:20: ^( MoreEqOp moreEqOp )
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
                    // MyGrammar.g:205:8: lessOp
                    {
                    	PushFollow(FOLLOW_lessOp_in_operations1701);
                    	lessOp61 = lessOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lessOp.Add(lessOp61.Tree);


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
                    	// 205:15: -> ^( LessOp lessOp )
                    	{
                    	    // MyGrammar.g:205:18: ^( LessOp lessOp )
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
                    // MyGrammar.g:206:8: lessEqOp
                    {
                    	PushFollow(FOLLOW_lessEqOp_in_operations1721);
                    	lessEqOp62 = lessEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lessEqOp.Add(lessEqOp62.Tree);


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
                    	// 206:17: -> ^( LessEqOp lessEqOp )
                    	{
                    	    // MyGrammar.g:206:20: ^( LessEqOp lessEqOp )
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
    // MyGrammar.g:209:1: logicOperator : ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp );
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation63 = default(MyGrammarParser.orOperation_return);

        MyGrammarParser.andOperation_return andOperation64 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.eqOp_return eqOp65 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp66 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.moreOp_return moreOp67 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp68 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.lessOp_return lessOp69 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp70 = default(MyGrammarParser.lessEqOp_return);



        try 
    	{
            // MyGrammar.g:209:16: ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp )
            int alt13 = 8;
            alt13 = dfa13.Predict(input);
            switch (alt13) 
            {
                case 1 :
                    // MyGrammar.g:209:18: orOperation
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_orOperation_in_logicOperator1749);
                    	orOperation63 = orOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation63.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:210:8: andOperation
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_andOperation_in_logicOperator1758);
                    	andOperation64 = andOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation64.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:211:8: eqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_eqOp_in_logicOperator1767);
                    	eqOp65 = eqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, eqOp65.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:212:8: nonEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nonEqOp_in_logicOperator1776);
                    	nonEqOp66 = nonEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEqOp66.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:213:8: moreOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moreOp_in_logicOperator1785);
                    	moreOp67 = moreOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreOp67.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:214:8: moreEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moreEqOp_in_logicOperator1794);
                    	moreEqOp68 = moreEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreEqOp68.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:215:8: lessOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lessOp_in_logicOperator1803);
                    	lessOp69 = lessOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessOp69.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:216:8: lessEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lessEqOp_in_logicOperator1812);
                    	lessEqOp70 = lessEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessEqOp70.Tree);

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
    // MyGrammar.g:220:1: orOperation : add OR add -> ^( OrOp add add ) ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OR72 = null;
        MyGrammarParser.add_return add71 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add73 = default(MyGrammarParser.add_return);


        object OR72_tree=null;
        RewriteRuleTokenStream stream_OR = new RewriteRuleTokenStream(adaptor,"token OR");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:220:15: ( add OR add -> ^( OrOp add add ) )
            // MyGrammar.g:220:17: add OR add
            {
            	PushFollow(FOLLOW_add_in_orOperation1829);
            	add71 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add71.Tree);
            	OR72=(IToken)Match(input,OR,FOLLOW_OR_in_orOperation1831); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_OR.Add(OR72);

            	PushFollow(FOLLOW_add_in_orOperation1833);
            	add73 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add73.Tree);


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
            	// 220:28: -> ^( OrOp add add )
            	{
            	    // MyGrammar.g:220:31: ^( OrOp add add )
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
    // MyGrammar.g:223:1: andOperation : add AND add -> ^( AndOp add add ) ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AND75 = null;
        MyGrammarParser.add_return add74 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add76 = default(MyGrammarParser.add_return);


        object AND75_tree=null;
        RewriteRuleTokenStream stream_AND = new RewriteRuleTokenStream(adaptor,"token AND");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:223:15: ( add AND add -> ^( AndOp add add ) )
            // MyGrammar.g:223:17: add AND add
            {
            	PushFollow(FOLLOW_add_in_andOperation1861);
            	add74 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add74.Tree);
            	AND75=(IToken)Match(input,AND,FOLLOW_AND_in_andOperation1863); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_AND.Add(AND75);

            	PushFollow(FOLLOW_add_in_andOperation1865);
            	add76 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add76.Tree);


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
            	// 223:29: -> ^( AndOp add add )
            	{
            	    // MyGrammar.g:223:32: ^( AndOp add add )
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
    // MyGrammar.g:226:1: eqOp : add EQ add -> ^( EqOp add add ) ;
    public MyGrammarParser.eqOp_return eqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.eqOp_return retval = new MyGrammarParser.eqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQ78 = null;
        MyGrammarParser.add_return add77 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add79 = default(MyGrammarParser.add_return);


        object EQ78_tree=null;
        RewriteRuleTokenStream stream_EQ = new RewriteRuleTokenStream(adaptor,"token EQ");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:226:9: ( add EQ add -> ^( EqOp add add ) )
            // MyGrammar.g:226:11: add EQ add
            {
            	PushFollow(FOLLOW_add_in_eqOp1895);
            	add77 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add77.Tree);
            	EQ78=(IToken)Match(input,EQ,FOLLOW_EQ_in_eqOp1897); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQ.Add(EQ78);

            	PushFollow(FOLLOW_add_in_eqOp1899);
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
            	// 226:22: -> ^( EqOp add add )
            	{
            	    // MyGrammar.g:226:25: ^( EqOp add add )
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
    // MyGrammar.g:229:1: nonEqOp : add NONEQ add -> ^( NonEqOp add add ) ;
    public MyGrammarParser.nonEqOp_return nonEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.nonEqOp_return retval = new MyGrammarParser.nonEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NONEQ81 = null;
        MyGrammarParser.add_return add80 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add82 = default(MyGrammarParser.add_return);


        object NONEQ81_tree=null;
        RewriteRuleTokenStream stream_NONEQ = new RewriteRuleTokenStream(adaptor,"token NONEQ");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:229:12: ( add NONEQ add -> ^( NonEqOp add add ) )
            // MyGrammar.g:229:14: add NONEQ add
            {
            	PushFollow(FOLLOW_add_in_nonEqOp1929);
            	add80 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add80.Tree);
            	NONEQ81=(IToken)Match(input,NONEQ,FOLLOW_NONEQ_in_nonEqOp1931); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NONEQ.Add(NONEQ81);

            	PushFollow(FOLLOW_add_in_nonEqOp1933);
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
            	// 229:28: -> ^( NonEqOp add add )
            	{
            	    // MyGrammar.g:229:31: ^( NonEqOp add add )
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
    // MyGrammar.g:232:1: moreOp : add MORE add -> ^( MoreOp add add ) ;
    public MyGrammarParser.moreOp_return moreOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreOp_return retval = new MyGrammarParser.moreOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MORE84 = null;
        MyGrammarParser.add_return add83 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add85 = default(MyGrammarParser.add_return);


        object MORE84_tree=null;
        RewriteRuleTokenStream stream_MORE = new RewriteRuleTokenStream(adaptor,"token MORE");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:232:11: ( add MORE add -> ^( MoreOp add add ) )
            // MyGrammar.g:232:14: add MORE add
            {
            	PushFollow(FOLLOW_add_in_moreOp1964);
            	add83 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add83.Tree);
            	MORE84=(IToken)Match(input,MORE,FOLLOW_MORE_in_moreOp1966); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MORE.Add(MORE84);

            	PushFollow(FOLLOW_add_in_moreOp1968);
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
            	// 232:27: -> ^( MoreOp add add )
            	{
            	    // MyGrammar.g:232:30: ^( MoreOp add add )
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
    // MyGrammar.g:235:1: moreEqOp : add MOREEQ add -> ^( MoreEqOp add add ) ;
    public MyGrammarParser.moreEqOp_return moreEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreEqOp_return retval = new MyGrammarParser.moreEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MOREEQ87 = null;
        MyGrammarParser.add_return add86 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add88 = default(MyGrammarParser.add_return);


        object MOREEQ87_tree=null;
        RewriteRuleTokenStream stream_MOREEQ = new RewriteRuleTokenStream(adaptor,"token MOREEQ");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:235:12: ( add MOREEQ add -> ^( MoreEqOp add add ) )
            // MyGrammar.g:235:14: add MOREEQ add
            {
            	PushFollow(FOLLOW_add_in_moreEqOp1997);
            	add86 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add86.Tree);
            	MOREEQ87=(IToken)Match(input,MOREEQ,FOLLOW_MOREEQ_in_moreEqOp1999); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MOREEQ.Add(MOREEQ87);

            	PushFollow(FOLLOW_add_in_moreEqOp2001);
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
            	// 235:29: -> ^( MoreEqOp add add )
            	{
            	    // MyGrammar.g:235:32: ^( MoreEqOp add add )
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
    // MyGrammar.g:238:1: lessOp : add LESS add -> ^( LessOp add add ) ;
    public MyGrammarParser.lessOp_return lessOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessOp_return retval = new MyGrammarParser.lessOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESS90 = null;
        MyGrammarParser.add_return add89 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add91 = default(MyGrammarParser.add_return);


        object LESS90_tree=null;
        RewriteRuleTokenStream stream_LESS = new RewriteRuleTokenStream(adaptor,"token LESS");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:238:11: ( add LESS add -> ^( LessOp add add ) )
            // MyGrammar.g:238:13: add LESS add
            {
            	PushFollow(FOLLOW_add_in_lessOp2031);
            	add89 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add89.Tree);
            	LESS90=(IToken)Match(input,LESS,FOLLOW_LESS_in_lessOp2033); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LESS.Add(LESS90);

            	PushFollow(FOLLOW_add_in_lessOp2035);
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
            	// 238:26: -> ^( LessOp add add )
            	{
            	    // MyGrammar.g:238:29: ^( LessOp add add )
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
    // MyGrammar.g:241:1: lessEqOp : add LESSEQ add -> ^( LessEqOp add add ) ;
    public MyGrammarParser.lessEqOp_return lessEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessEqOp_return retval = new MyGrammarParser.lessEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSEQ93 = null;
        MyGrammarParser.add_return add92 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add94 = default(MyGrammarParser.add_return);


        object LESSEQ93_tree=null;
        RewriteRuleTokenStream stream_LESSEQ = new RewriteRuleTokenStream(adaptor,"token LESSEQ");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        try 
    	{
            // MyGrammar.g:241:12: ( add LESSEQ add -> ^( LessEqOp add add ) )
            // MyGrammar.g:241:14: add LESSEQ add
            {
            	PushFollow(FOLLOW_add_in_lessEqOp2064);
            	add92 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add92.Tree);
            	LESSEQ93=(IToken)Match(input,LESSEQ,FOLLOW_LESSEQ_in_lessEqOp2066); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LESSEQ.Add(LESSEQ93);

            	PushFollow(FOLLOW_add_in_lessEqOp2068);
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
            	// 241:29: -> ^( LessEqOp add add )
            	{
            	    // MyGrammar.g:241:32: ^( LessEqOp add add )
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
    // MyGrammar.g:245:1: for_ : FOR '(' varInit ';' logicOperator ';' varInitValue ')' block -> ^( For varInit logicOperator varInitValue block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR95 = null;
        IToken char_literal96 = null;
        IToken char_literal98 = null;
        IToken char_literal100 = null;
        IToken char_literal102 = null;
        MyGrammarParser.varInit_return varInit97 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.logicOperator_return logicOperator99 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.varInitValue_return varInitValue101 = default(MyGrammarParser.varInitValue_return);

        MyGrammarParser.block_return block103 = default(MyGrammarParser.block_return);


        object FOR95_tree=null;
        object char_literal96_tree=null;
        object char_literal98_tree=null;
        object char_literal100_tree=null;
        object char_literal102_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_varInitValue = new RewriteRuleSubtreeStream(adaptor,"rule varInitValue");
        RewriteRuleSubtreeStream stream_varInit = new RewriteRuleSubtreeStream(adaptor,"rule varInit");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:245:6: ( FOR '(' varInit ';' logicOperator ';' varInitValue ')' block -> ^( For varInit logicOperator varInitValue block ) )
            // MyGrammar.g:245:8: FOR '(' varInit ';' logicOperator ';' varInitValue ')' block
            {
            	FOR95=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_2096); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR95);

            	char_literal96=(IToken)Match(input,76,FOLLOW_76_in_for_2111); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(char_literal96);

            	PushFollow(FOLLOW_varInit_in_for_2120);
            	varInit97 = varInit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInit.Add(varInit97.Tree);
            	char_literal98=(IToken)Match(input,80,FOLLOW_80_in_for_2122); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(char_literal98);

            	PushFollow(FOLLOW_logicOperator_in_for_2127);
            	logicOperator99 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator99.Tree);
            	char_literal100=(IToken)Match(input,80,FOLLOW_80_in_for_2129); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(char_literal100);

            	PushFollow(FOLLOW_varInitValue_in_for_2137);
            	varInitValue101 = varInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitValue.Add(varInitValue101.Tree);
            	char_literal102=(IToken)Match(input,77,FOLLOW_77_in_for_2142); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(char_literal102);

            	PushFollow(FOLLOW_block_in_for_2147);
            	block103 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block103.Tree);


            	// AST REWRITE
            	// elements:          varInitValue, logicOperator, varInit, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 252:4: -> ^( For varInit logicOperator varInitValue block )
            	{
            	    // MyGrammar.g:252:7: ^( For varInit logicOperator varInitValue block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ForNode(For), root_1);

            	    adaptor.AddChild(root_1, stream_varInit.NextTree());
            	    adaptor.AddChild(root_1, stream_logicOperator.NextTree());
            	    adaptor.AddChild(root_1, stream_varInitValue.NextTree());
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
    // MyGrammar.g:256:1: while_ : WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE104 = null;
        IToken char_literal105 = null;
        IToken char_literal107 = null;
        MyGrammarParser.logicOperator_return logicOperator106 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block108 = default(MyGrammarParser.block_return);


        object WHILE104_tree=null;
        object char_literal105_tree=null;
        object char_literal107_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:256:8: ( WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) )
            // MyGrammar.g:256:10: WHILE '(' logicOperator ')' block
            {
            	WHILE104=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_2179); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE104);

            	char_literal105=(IToken)Match(input,76,FOLLOW_76_in_while_2184); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(char_literal105);

            	PushFollow(FOLLOW_logicOperator_in_while_2189);
            	logicOperator106 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator106.Tree);
            	char_literal107=(IToken)Match(input,77,FOLLOW_77_in_while_2194); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(char_literal107);

            	PushFollow(FOLLOW_block_in_while_2199);
            	block108 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block108.Tree);


            	// AST REWRITE
            	// elements:          logicOperator, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 261:4: -> ^( While_ logicOperator block )
            	{
            	    // MyGrammar.g:261:7: ^( While_ logicOperator block )
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
    // MyGrammar.g:269:1: methodDef : type ID '()' block -> ^( Method ^( ID ( type )? block ) ) ;
    public MyGrammarParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        MyGrammarParser.methodDef_return retval = new MyGrammarParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID110 = null;
        IToken string_literal111 = null;
        MyGrammarParser.type_return type109 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block112 = default(MyGrammarParser.block_return);


        object ID110_tree=null;
        object string_literal111_tree=null;
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:269:11: ( type ID '()' block -> ^( Method ^( ID ( type )? block ) ) )
            // MyGrammar.g:269:13: type ID '()' block
            {
            	PushFollow(FOLLOW_type_in_methodDef2233);
            	type109 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type109.Tree);
            	ID110=(IToken)Match(input,ID,FOLLOW_ID_in_methodDef2235); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID110);

            	string_literal111=(IToken)Match(input,81,FOLLOW_81_in_methodDef2237); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(string_literal111);

            	PushFollow(FOLLOW_block_in_methodDef2239);
            	block112 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block112.Tree);


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
            	// 269:32: -> ^( Method ^( ID ( type )? block ) )
            	{
            	    // MyGrammar.g:269:35: ^( Method ^( ID ( type )? block ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(Method), root_1);

            	    // MyGrammar.g:269:59: ^( ID ( type )? block )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:269:64: ( type )?
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
    // MyGrammar.g:272:1: callMethod : ID '()' -> ^( CallMethod ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID113 = null;
        IToken string_literal114 = null;

        object ID113_tree=null;
        object string_literal114_tree=null;
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:272:12: ( ID '()' -> ^( CallMethod ID ) )
            // MyGrammar.g:272:14: ID '()'
            {
            	ID113=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod2268); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID113);

            	string_literal114=(IToken)Match(input,81,FOLLOW_81_in_callMethod2270); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(string_literal114);



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
            	// 273:5: -> ^( CallMethod ID )
            	{
            	    // MyGrammar.g:273:8: ^( CallMethod ID )
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
    // MyGrammar.g:276:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_115 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_116 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:276:7: ( for_ | while_ )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == FOR) )
            {
                alt14 = 1;
            }
            else if ( (LA14_0 == WHILE) )
            {
                alt14 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("", 14, 0, input);

                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // MyGrammar.g:276:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle2298);
                    	for_115 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_115.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:277:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle2304);
                    	while_116 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_116.Tree);

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
    // MyGrammar.g:282:1: printExpr : ( add | ident | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add117 = default(MyGrammarParser.add_return);

        MyGrammarParser.ident_return ident118 = default(MyGrammarParser.ident_return);

        MyGrammarParser.callMethod_return callMethod119 = default(MyGrammarParser.callMethod_return);



        try 
    	{
            // MyGrammar.g:282:11: ( add | ident | callMethod )
            int alt15 = 3;
            int LA15_0 = input.LA(1);

            if ( ((LA15_0 >= INTEGER && LA15_0 <= DOUBLE_) || LA15_0 == 76) )
            {
                alt15 = 1;
            }
            else if ( (LA15_0 == ID) )
            {
                int LA15_2 = input.LA(2);

                if ( (LA15_2 == 81) )
                {
                    alt15 = 3;
                }
                else if ( (synpred42_MyGrammar()) )
                {
                    alt15 = 1;
                }
                else if ( (synpred43_MyGrammar()) )
                {
                    alt15 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d15s2 =
                        new NoViableAltException("", 15, 2, input);

                    throw nvae_d15s2;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d15s0 =
                    new NoViableAltException("", 15, 0, input);

                throw nvae_d15s0;
            }
            switch (alt15) 
            {
                case 1 :
                    // MyGrammar.g:282:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr2317);
                    	add117 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add117.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:283:6: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_printExpr2324);
                    	ident118 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident118.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:284:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr2331);
                    	callMethod119 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod119.Tree);

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
    // MyGrammar.g:287:1: changeValue : ident ASSIGN initValue -> ^( Assign ident initValue ) ;
    public MyGrammarParser.changeValue_return changeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.changeValue_return retval = new MyGrammarParser.changeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN121 = null;
        MyGrammarParser.ident_return ident120 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue122 = default(MyGrammarParser.initValue_return);


        object ASSIGN121_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:287:13: ( ident ASSIGN initValue -> ^( Assign ident initValue ) )
            // MyGrammar.g:287:15: ident ASSIGN initValue
            {
            	PushFollow(FOLLOW_ident_in_changeValue2345);
            	ident120 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident120.Tree);
            	ASSIGN121=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_changeValue2347); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN121);

            	PushFollow(FOLLOW_initValue_in_changeValue2349);
            	initValue122 = initValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_initValue.Add(initValue122.Tree);


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
            	// 288:7: -> ^( Assign ident initValue )
            	{
            	    // MyGrammar.g:288:10: ^( Assign ident initValue )
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
    // $ANTLR end "changeValue"

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
    // MyGrammar.g:290:1: expr : ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print | changeValue );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add123 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_124 = default(MyGrammarParser.if__return);

        MyGrammarParser.varInit_return varInit125 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.oneArray_return oneArray126 = default(MyGrammarParser.oneArray_return);

        MyGrammarParser.cycle_return cycle127 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.varInitValue_return varInitValue128 = default(MyGrammarParser.varInitValue_return);

        MyGrammarParser.callMethod_return callMethod129 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print130 = default(MyGrammarParser.print_return);

        MyGrammarParser.changeValue_return changeValue131 = default(MyGrammarParser.changeValue_return);



        try 
    	{
            // MyGrammar.g:290:6: ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print | changeValue )
            int alt16 = 9;
            alt16 = dfa16.Predict(input);
            switch (alt16) 
            {
                case 1 :
                    // MyGrammar.g:290:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr2380);
                    	add123 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add123.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:291:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr2386);
                    	if_124 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_124.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:292:5: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_expr2392);
                    	varInit125 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit125.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:293:5: oneArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_expr2398);
                    	oneArray126 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray126.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:294:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr2404);
                    	cycle127 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle127.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:295:5: varInitValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInitValue_in_expr2410);
                    	varInitValue128 = varInitValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInitValue128.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:296:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr2416);
                    	callMethod129 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod129.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:297:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr2422);
                    	print130 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print130.Tree);

                    }
                    break;
                case 9 :
                    // MyGrammar.g:298:5: changeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_changeValue_in_expr2428);
                    	changeValue131 = changeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, changeValue131.Tree);

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
    // MyGrammar.g:301:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal133 = null;
        MyGrammarParser.expr_return expr132 = default(MyGrammarParser.expr_return);


        object char_literal133_tree=null;

        try 
    	{
            // MyGrammar.g:301:6: ( expr ( ';' )* )
            // MyGrammar.g:301:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line2439);
            	expr132 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr132.Tree);
            	// MyGrammar.g:301:13: ( ';' )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == 80) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // MyGrammar.g:301:14: ';'
            			    {
            			    	char_literal133=(IToken)Match(input,80,FOLLOW_80_in_line2442); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


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
    // MyGrammar.g:304:1: exprList : ( methodDef ( ';' )* | varInit ( ';' )* | oneArray ( ';' )* );
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal135 = null;
        IToken char_literal137 = null;
        IToken char_literal139 = null;
        MyGrammarParser.methodDef_return methodDef134 = default(MyGrammarParser.methodDef_return);

        MyGrammarParser.varInit_return varInit136 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.oneArray_return oneArray138 = default(MyGrammarParser.oneArray_return);


        object char_literal135_tree=null;
        object char_literal137_tree=null;
        object char_literal139_tree=null;

        try 
    	{
            // MyGrammar.g:304:9: ( methodDef ( ';' )* | varInit ( ';' )* | oneArray ( ';' )* )
            int alt21 = 3;
            int LA21_0 = input.LA(1);

            if ( ((LA21_0 >= INT && LA21_0 <= VOID)) )
            {
                int LA21_1 = input.LA(2);

                if ( (LA21_1 == ID) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case 81:
                    	{
                        alt21 = 1;
                        }
                        break;
                    case EOF:
                    case ASSIGN:
                    case INT:
                    case FLOAT:
                    case DOUBLE:
                    case CHAR:
                    case VOID:
                    case 80:
                    	{
                        alt21 = 2;
                        }
                        break;
                    case 74:
                    	{
                        alt21 = 3;
                        }
                        break;
                    	default:
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d21s2 =
                    	        new NoViableAltException("", 21, 2, input);

                    	    throw nvae_d21s2;
                    }

                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d21s1 =
                        new NoViableAltException("", 21, 1, input);

                    throw nvae_d21s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d21s0 =
                    new NoViableAltException("", 21, 0, input);

                throw nvae_d21s0;
            }
            switch (alt21) 
            {
                case 1 :
                    // MyGrammar.g:304:11: methodDef ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodDef_in_exprList2456);
                    	methodDef134 = methodDef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef134.Tree);
                    	// MyGrammar.g:304:22: ( ';' )*
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    int LA18_0 = input.LA(1);

                    	    if ( (LA18_0 == 80) )
                    	    {
                    	        alt18 = 1;
                    	    }


                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:304:23: ';'
                    			    {
                    			    	char_literal135=(IToken)Match(input,80,FOLLOW_80_in_exprList2460); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop18;
                    	    }
                    	} while (true);

                    	loop18:
                    		;	// Stops C# compiler whining that label 'loop18' has no statements


                    }
                    break;
                case 2 :
                    // MyGrammar.g:305:5: varInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_exprList2470);
                    	varInit136 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit136.Tree);
                    	// MyGrammar.g:305:13: ( ';' )*
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);

                    	    if ( (LA19_0 == 80) )
                    	    {
                    	        alt19 = 1;
                    	    }


                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:305:14: ';'
                    			    {
                    			    	char_literal137=(IToken)Match(input,80,FOLLOW_80_in_exprList2473); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop19;
                    	    }
                    	} while (true);

                    	loop19:
                    		;	// Stops C# compiler whining that label 'loop19' has no statements


                    }
                    break;
                case 3 :
                    // MyGrammar.g:306:5: oneArray ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_exprList2483);
                    	oneArray138 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray138.Tree);
                    	// MyGrammar.g:306:14: ( ';' )*
                    	do 
                    	{
                    	    int alt20 = 2;
                    	    int LA20_0 = input.LA(1);

                    	    if ( (LA20_0 == 80) )
                    	    {
                    	        alt20 = 1;
                    	    }


                    	    switch (alt20) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:306:15: ';'
                    			    {
                    			    	char_literal139=(IToken)Match(input,80,FOLLOW_80_in_exprList2486); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop20;
                    	    }
                    	} while (true);

                    	loop20:
                    		;	// Stops C# compiler whining that label 'loop20' has no statements


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
    // MyGrammar.g:312:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList140 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:312:13: ( ( exprList )* )
            // MyGrammar.g:313:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:313:4: ( exprList )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( ((LA22_0 >= INT && LA22_0 <= VOID)) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm2507);
            			    	exprList140 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList140.Tree);

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


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
    // MyGrammar.g:316:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm141 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:316:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:317:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program2521);
            	fullProgramm141 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm141.Tree);


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
            	// 317:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:317:19: ^( PROGRAM fullProgramm )
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
    // MyGrammar.g:320:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program142 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:320:8: ( program )
            // MyGrammar.g:321:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute2539);
            	program142 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program142.Tree);

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

    // $ANTLR start "synpred15_MyGrammar"
    public void synpred15_MyGrammar_fragment() {
        // MyGrammar.g:156:14: ( add )
        // MyGrammar.g:156:14: add
        {
        	PushFollow(FOLLOW_add_in_synpred15_MyGrammar1239);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_MyGrammar"

    // $ANTLR start "synpred17_MyGrammar"
    public void synpred17_MyGrammar_fragment() {
        // MyGrammar.g:158:7: ( ident )
        // MyGrammar.g:158:7: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred17_MyGrammar1255);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_MyGrammar"

    // $ANTLR start "synpred27_MyGrammar"
    public void synpred27_MyGrammar_fragment() {
        // MyGrammar.g:199:16: ( orOperation )
        // MyGrammar.g:199:16: orOperation
        {
        	PushFollow(FOLLOW_orOperation_in_synpred27_MyGrammar1581);
        	orOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred27_MyGrammar"

    // $ANTLR start "synpred28_MyGrammar"
    public void synpred28_MyGrammar_fragment() {
        // MyGrammar.g:200:8: ( andOperation )
        // MyGrammar.g:200:8: andOperation
        {
        	PushFollow(FOLLOW_andOperation_in_synpred28_MyGrammar1601);
        	andOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred28_MyGrammar"

    // $ANTLR start "synpred29_MyGrammar"
    public void synpred29_MyGrammar_fragment() {
        // MyGrammar.g:201:8: ( eqOp )
        // MyGrammar.g:201:8: eqOp
        {
        	PushFollow(FOLLOW_eqOp_in_synpred29_MyGrammar1621);
        	eqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred29_MyGrammar"

    // $ANTLR start "synpred30_MyGrammar"
    public void synpred30_MyGrammar_fragment() {
        // MyGrammar.g:202:8: ( nonEqOp )
        // MyGrammar.g:202:8: nonEqOp
        {
        	PushFollow(FOLLOW_nonEqOp_in_synpred30_MyGrammar1641);
        	nonEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_MyGrammar"

    // $ANTLR start "synpred31_MyGrammar"
    public void synpred31_MyGrammar_fragment() {
        // MyGrammar.g:203:8: ( moreOp )
        // MyGrammar.g:203:8: moreOp
        {
        	PushFollow(FOLLOW_moreOp_in_synpred31_MyGrammar1661);
        	moreOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_MyGrammar"

    // $ANTLR start "synpred32_MyGrammar"
    public void synpred32_MyGrammar_fragment() {
        // MyGrammar.g:204:8: ( moreEqOp )
        // MyGrammar.g:204:8: moreEqOp
        {
        	PushFollow(FOLLOW_moreEqOp_in_synpred32_MyGrammar1681);
        	moreEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_MyGrammar"

    // $ANTLR start "synpred33_MyGrammar"
    public void synpred33_MyGrammar_fragment() {
        // MyGrammar.g:205:8: ( lessOp )
        // MyGrammar.g:205:8: lessOp
        {
        	PushFollow(FOLLOW_lessOp_in_synpred33_MyGrammar1701);
        	lessOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_MyGrammar"

    // $ANTLR start "synpred34_MyGrammar"
    public void synpred34_MyGrammar_fragment() {
        // MyGrammar.g:209:18: ( orOperation )
        // MyGrammar.g:209:18: orOperation
        {
        	PushFollow(FOLLOW_orOperation_in_synpred34_MyGrammar1749);
        	orOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_MyGrammar"

    // $ANTLR start "synpred35_MyGrammar"
    public void synpred35_MyGrammar_fragment() {
        // MyGrammar.g:210:8: ( andOperation )
        // MyGrammar.g:210:8: andOperation
        {
        	PushFollow(FOLLOW_andOperation_in_synpred35_MyGrammar1758);
        	andOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred35_MyGrammar"

    // $ANTLR start "synpred36_MyGrammar"
    public void synpred36_MyGrammar_fragment() {
        // MyGrammar.g:211:8: ( eqOp )
        // MyGrammar.g:211:8: eqOp
        {
        	PushFollow(FOLLOW_eqOp_in_synpred36_MyGrammar1767);
        	eqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred36_MyGrammar"

    // $ANTLR start "synpred37_MyGrammar"
    public void synpred37_MyGrammar_fragment() {
        // MyGrammar.g:212:8: ( nonEqOp )
        // MyGrammar.g:212:8: nonEqOp
        {
        	PushFollow(FOLLOW_nonEqOp_in_synpred37_MyGrammar1776);
        	nonEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred37_MyGrammar"

    // $ANTLR start "synpred38_MyGrammar"
    public void synpred38_MyGrammar_fragment() {
        // MyGrammar.g:213:8: ( moreOp )
        // MyGrammar.g:213:8: moreOp
        {
        	PushFollow(FOLLOW_moreOp_in_synpred38_MyGrammar1785);
        	moreOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_MyGrammar"

    // $ANTLR start "synpred39_MyGrammar"
    public void synpred39_MyGrammar_fragment() {
        // MyGrammar.g:214:8: ( moreEqOp )
        // MyGrammar.g:214:8: moreEqOp
        {
        	PushFollow(FOLLOW_moreEqOp_in_synpred39_MyGrammar1794);
        	moreEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_MyGrammar"

    // $ANTLR start "synpred40_MyGrammar"
    public void synpred40_MyGrammar_fragment() {
        // MyGrammar.g:215:8: ( lessOp )
        // MyGrammar.g:215:8: lessOp
        {
        	PushFollow(FOLLOW_lessOp_in_synpred40_MyGrammar1803);
        	lessOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred40_MyGrammar"

    // $ANTLR start "synpred42_MyGrammar"
    public void synpred42_MyGrammar_fragment() {
        // MyGrammar.g:282:13: ( add )
        // MyGrammar.g:282:13: add
        {
        	PushFollow(FOLLOW_add_in_synpred42_MyGrammar2317);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred42_MyGrammar"

    // $ANTLR start "synpred43_MyGrammar"
    public void synpred43_MyGrammar_fragment() {
        // MyGrammar.g:283:6: ( ident )
        // MyGrammar.g:283:6: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred43_MyGrammar2324);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred43_MyGrammar"

    // $ANTLR start "synpred44_MyGrammar"
    public void synpred44_MyGrammar_fragment() {
        // MyGrammar.g:290:8: ( add )
        // MyGrammar.g:290:8: add
        {
        	PushFollow(FOLLOW_add_in_synpred44_MyGrammar2380);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred44_MyGrammar"

    // $ANTLR start "synpred49_MyGrammar"
    public void synpred49_MyGrammar_fragment() {
        // MyGrammar.g:295:5: ( varInitValue )
        // MyGrammar.g:295:5: varInitValue
        {
        	PushFollow(FOLLOW_varInitValue_in_synpred49_MyGrammar2410);
        	varInitValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_MyGrammar"

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
   	public bool synpred28_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred28_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred15_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred27_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred27_MyGrammar_fragment(); // can never throw exception
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


   	protected DFA12 dfa12;
   	protected DFA13 dfa13;
   	protected DFA16 dfa16;
	private void InitializeCyclicDFAs()
	{
    	this.dfa12 = new DFA12(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa16 = new DFA16(this);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);
	    this.dfa13.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA13_SpecialStateTransition);
	    this.dfa16.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA16_SpecialStateTransition);
	}

    const string DFA12_eotS =
        "\x0d\uffff";
    const string DFA12_eofS =
        "\x0d\uffff";
    const string DFA12_minS =
        "\x01\x46\x04\x00\x08\uffff";
    const string DFA12_maxS =
        "\x01\x4c\x04\x00\x08\uffff";
    const string DFA12_acceptS =
        "\x05\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08";
    const string DFA12_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x08\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x02\x01\x03\x01\x04\x03\uffff\x01\x01",
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

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "199:1: operations : ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) );"; }
        }

    }


    protected internal int DFA12_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA12_1 = input.LA(1);

                   	 
                   	int index12_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred27_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred28_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred29_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred30_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred31_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred32_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index12_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA12_2 = input.LA(1);

                   	 
                   	int index12_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred27_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred28_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred29_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred30_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred31_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred32_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index12_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA12_3 = input.LA(1);

                   	 
                   	int index12_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred27_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred28_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred29_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred30_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred31_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred32_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index12_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA12_4 = input.LA(1);

                   	 
                   	int index12_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred27_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred28_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred29_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred30_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred31_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred32_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred33_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index12_4);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae12 =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae12);
        throw nvae12;
    }
    const string DFA13_eotS =
        "\x0d\uffff";
    const string DFA13_eofS =
        "\x0d\uffff";
    const string DFA13_minS =
        "\x01\x46\x04\x00\x08\uffff";
    const string DFA13_maxS =
        "\x01\x4c\x04\x00\x08\uffff";
    const string DFA13_acceptS =
        "\x05\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08";
    const string DFA13_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x08\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x02\x01\x03\x01\x04\x03\uffff\x01\x01",
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

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "209:1: logicOperator : ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp );"; }
        }

    }


    protected internal int DFA13_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA13_1 = input.LA(1);

                   	 
                   	int index13_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred34_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index13_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA13_2 = input.LA(1);

                   	 
                   	int index13_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred34_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index13_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA13_3 = input.LA(1);

                   	 
                   	int index13_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred34_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index13_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA13_4 = input.LA(1);

                   	 
                   	int index13_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred34_MyGrammar()) ) { s = 5; }

                   	else if ( (synpred35_MyGrammar()) ) { s = 6; }

                   	else if ( (synpred36_MyGrammar()) ) { s = 7; }

                   	else if ( (synpred37_MyGrammar()) ) { s = 8; }

                   	else if ( (synpred38_MyGrammar()) ) { s = 9; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 10; }

                   	else if ( (synpred40_MyGrammar()) ) { s = 11; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index13_4);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae13 =
            new NoViableAltException(dfa.Description, 13, _s, input);
        dfa.Error(nvae13);
        throw nvae13;
    }
    const string DFA16_eotS =
        "\x0d\uffff";
    const string DFA16_eofS =
        "\x0a\uffff\x01\x0c\x02\uffff";
    const string DFA16_minS =
        "\x01\x1e\x01\uffff\x01\x27\x01\uffff\x01\x48\x05\uffff\x01\x1e"+
        "\x02\uffff";
    const string DFA16_maxS =
        "\x01\x4c\x01\uffff\x01\x51\x01\uffff\x01\x48\x05\uffff\x01\x50"+
        "\x02\uffff";
    const string DFA16_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\uffff\x01\x05\x01\x08"+
        "\x01\x07\x01\x09\x01\x06\x01\uffff\x01\x04\x01\x03";
    const string DFA16_specialS =
        "\x02\uffff\x01\x00\x0a\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x01\x06\x04\uffff\x01\x03\x0a\uffff\x05\x04\x08\uffff\x02"+
            "\x05\x09\uffff\x02\x01\x01\x02\x03\uffff\x01\x01",
            "",
            "\x01\x08\x29\uffff\x01\x07",
            "",
            "\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c\x04\uffff\x01\x0c\x03\uffff\x01\x0c\x06\uffff\x05"+
            "\x0c\x08\uffff\x02\x0c\x09\uffff\x03\x0c\x01\uffff\x01\x0b\x01"+
            "\uffff\x01\x0c\x02\uffff\x02\x0c",
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
            get { return "290:1: expr : ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print | changeValue );"; }
        }

    }


    protected internal int DFA16_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA16_2 = input.LA(1);

                   	 
                   	int index16_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA16_2 == 81) ) { s = 7; }

                   	else if ( (LA16_2 == ASSIGN) ) { s = 8; }

                   	else if ( (synpred44_MyGrammar()) ) { s = 1; }

                   	else if ( (synpred49_MyGrammar()) ) { s = 9; }

                   	 
                   	input.Seek(index16_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae16 =
            new NoViableAltException(dfa.Description, 16, _s, input);
        dfa.Error(nvae16);
        throw nvae16;
    }
 

    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inc_in_incDec926 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dec_in_incDec932 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_inc945 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECREMENT_in_dec968 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_in_number1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE__in_number1076 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_ident1141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_varInit1164 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_varInitValue_in_varInit1166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_varInitValue1196 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_varInitValue1199 = new BitSet(new ulong[]{0x0000300000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_initValue_in_varInitValue1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_initValue1239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_initValue1247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_initValue1255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inc_in_initValue1263 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dec_in_initValue1271 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_oneArray1284 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ident_in_oneArray1286 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_74_in_oneArray1288 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_number_in_oneArray1290 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_oneArray1292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_addOperation1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_addOperation1339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multOperation1359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multOperation1374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_group1397 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_group1400 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_group1402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group1410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_group1416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult1431 = new BitSet(new ulong[]{0x0000000600000002UL});
    public static readonly BitSet FOLLOW_multOperation_in_mult1435 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_group_in_mult1438 = new BitSet(new ulong[]{0x0000000600000002UL});
    public static readonly BitSet FOLLOW_mult_in_add1450 = new BitSet(new ulong[]{0x0000000180000002UL});
    public static readonly BitSet FOLLOW_addOperation_in_add1454 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_mult_in_add1457 = new BitSet(new ulong[]{0x0000000180000002UL});
    public static readonly BitSet FOLLOW_PRINT_in_print1468 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_print1470 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_printExpr_in_print1472 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_print1474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_block1496 = new BitSet(new ulong[]{0x1807C00840000000UL,0x00000000000091C0UL});
    public static readonly BitSet FOLLOW_line_in_block1498 = new BitSet(new ulong[]{0x1807C00840000000UL,0x00000000000091C0UL});
    public static readonly BitSet FOLLOW_79_in_block1501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_1526 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_if_1528 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_1530 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_if_1532 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_block_in_if_1534 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_if_1537 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_block_in_if_1539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_operations1581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_operations1601 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_operations1621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_operations1641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_operations1661 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_operations1681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_operations1701 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_operations1721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator1749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_logicOperator1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_logicOperator1767 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_logicOperator1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_logicOperator1785 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_logicOperator1794 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_logicOperator1803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_logicOperator1812 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_orOperation1829 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_OR_in_orOperation1831 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_orOperation1833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_andOperation1861 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_AND_in_andOperation1863 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_andOperation1865 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_eqOp1895 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_EQ_in_eqOp1897 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_eqOp1899 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_nonEqOp1929 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NONEQ_in_nonEqOp1931 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_nonEqOp1933 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_moreOp1964 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_MORE_in_moreOp1966 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_moreOp1968 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_moreEqOp1997 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_MOREEQ_in_moreEqOp1999 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_moreEqOp2001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_lessOp2031 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LESS_in_lessOp2033 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_lessOp2035 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_lessEqOp2064 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_LESSEQ_in_lessEqOp2066 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_lessEqOp2068 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_2096 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_for_2111 = new BitSet(new ulong[]{0x0007C00000000000UL});
    public static readonly BitSet FOLLOW_varInit_in_for_2120 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_for_2122 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_2127 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_for_2129 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_varInitValue_in_for_2137 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_for_2142 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_block_in_for_2147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_2179 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_while_2184 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_2189 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_while_2194 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_block_in_while_2199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_methodDef2233 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_methodDef2235 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_methodDef2237 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_block_in_methodDef2239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod2268 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_callMethod2270 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle2298 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle2304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr2317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_printExpr2324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr2331 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_changeValue2345 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_changeValue2347 = new BitSet(new ulong[]{0x0000300000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_initValue_in_changeValue2349 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr2380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr2386 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_expr2392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_oneArray_in_expr2398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr2404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInitValue_in_expr2410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr2416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr2422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_changeValue_in_expr2428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line2439 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_line2442 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_methodDef_in_exprList2456 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_exprList2460 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_varInit_in_exprList2470 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_exprList2473 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_oneArray_in_exprList2483 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_exprList2486 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm2507 = new BitSet(new ulong[]{0x0007C00000000002UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program2521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute2539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred15_MyGrammar1239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred17_MyGrammar1255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_synpred27_MyGrammar1581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_synpred28_MyGrammar1601 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_synpred29_MyGrammar1621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_synpred30_MyGrammar1641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_synpred31_MyGrammar1661 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_synpred32_MyGrammar1681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_synpred33_MyGrammar1701 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_synpred34_MyGrammar1749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_synpred35_MyGrammar1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_synpred36_MyGrammar1767 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_synpred37_MyGrammar1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_synpred38_MyGrammar1785 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_synpred39_MyGrammar1794 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_synpred40_MyGrammar1803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred42_MyGrammar2317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred43_MyGrammar2324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred44_MyGrammar2380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInitValue_in_synpred49_MyGrammar2410 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}