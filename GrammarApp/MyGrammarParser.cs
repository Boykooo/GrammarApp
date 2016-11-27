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
            	// elements:          type, varInitValue
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
            	// elements:          number, ident
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
            	// elements:          printExpr, PRINT
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
    // MyGrammar.g:201:1: logicOperator : ( orOperation )+ -> ^( LogicOp ( orOperation )+ ) ;
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation55 = default(MyGrammarParser.orOperation_return);


        RewriteRuleSubtreeStream stream_orOperation = new RewriteRuleSubtreeStream(adaptor,"rule orOperation");
        try 
    	{
            // MyGrammar.g:201:16: ( ( orOperation )+ -> ^( LogicOp ( orOperation )+ ) )
            // MyGrammar.g:201:18: ( orOperation )+
            {
            	// MyGrammar.g:201:18: ( orOperation )+
            	int cnt12 = 0;
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= INTEGER && LA12_0 <= ID) || LA12_0 == 76) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: orOperation
            			    {
            			    	PushFollow(FOLLOW_orOperation_in_logicOperator1584);
            			    	orOperation55 = orOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_orOperation.Add(orOperation55.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt12 >= 1 ) goto loop12;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee12 =
            		                new EarlyExitException(12, input);
            		            throw eee12;
            	    }
            	    cnt12++;
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements



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
            	// 201:31: -> ^( LogicOp ( orOperation )+ )
            	{
            	    // MyGrammar.g:201:34: ^( LogicOp ( orOperation )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new LogicOperation(LogicOp), root_1);

            	    if ( !(stream_orOperation.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_orOperation.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_orOperation.NextTree());

            	    }
            	    stream_orOperation.Reset();

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
    // MyGrammar.g:204:1: orOperation : andOperation ( OR andOperation )* ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OR57 = null;
        MyGrammarParser.andOperation_return andOperation56 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.andOperation_return andOperation58 = default(MyGrammarParser.andOperation_return);


        object OR57_tree=null;

        try 
    	{
            // MyGrammar.g:204:15: ( andOperation ( OR andOperation )* )
            // MyGrammar.g:204:17: andOperation ( OR andOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_andOperation_in_orOperation1613);
            	andOperation56 = andOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation56.Tree);
            	// MyGrammar.g:204:30: ( OR andOperation )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == OR) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // MyGrammar.g:204:32: OR andOperation
            			    {
            			    	OR57=(IToken)Match(input,OR,FOLLOW_OR_in_orOperation1617); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{OR57_tree = new OrOperationNode(OR57) ;
            			    		root_0 = (object)adaptor.BecomeRoot(OR57_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_andOperation_in_orOperation1623);
            			    	andOperation58 = andOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation58.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


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
    // MyGrammar.g:207:1: andOperation : eqOp ( AND eqOp )* ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AND60 = null;
        MyGrammarParser.eqOp_return eqOp59 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.eqOp_return eqOp61 = default(MyGrammarParser.eqOp_return);


        object AND60_tree=null;

        try 
    	{
            // MyGrammar.g:207:15: ( eqOp ( AND eqOp )* )
            // MyGrammar.g:207:17: eqOp ( AND eqOp )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_eqOp_in_andOperation1641);
            	eqOp59 = eqOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, eqOp59.Tree);
            	// MyGrammar.g:207:22: ( AND eqOp )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == AND) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // MyGrammar.g:207:23: AND eqOp
            			    {
            			    	AND60=(IToken)Match(input,AND,FOLLOW_AND_in_andOperation1644); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{AND60_tree = new AndOperationNode(AND60) ;
            			    		root_0 = (object)adaptor.BecomeRoot(AND60_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_eqOp_in_andOperation1650);
            			    	eqOp61 = eqOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, eqOp61.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


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
    // MyGrammar.g:210:1: eqOp : nonEqOp ( EQ nonEqOp )* ;
    public MyGrammarParser.eqOp_return eqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.eqOp_return retval = new MyGrammarParser.eqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQ63 = null;
        MyGrammarParser.nonEqOp_return nonEqOp62 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp64 = default(MyGrammarParser.nonEqOp_return);


        object EQ63_tree=null;

        try 
    	{
            // MyGrammar.g:210:9: ( nonEqOp ( EQ nonEqOp )* )
            // MyGrammar.g:210:11: nonEqOp ( EQ nonEqOp )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_nonEqOp_in_eqOp1670);
            	nonEqOp62 = nonEqOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEqOp62.Tree);
            	// MyGrammar.g:210:19: ( EQ nonEqOp )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == EQ) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // MyGrammar.g:210:20: EQ nonEqOp
            			    {
            			    	EQ63=(IToken)Match(input,EQ,FOLLOW_EQ_in_eqOp1673); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{EQ63_tree = new EqualityOperationNode(EQ63) ;
            			    		root_0 = (object)adaptor.BecomeRoot(EQ63_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_nonEqOp_in_eqOp1679);
            			    	nonEqOp64 = nonEqOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEqOp64.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements


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
    // MyGrammar.g:213:1: nonEqOp : moreOp ( NONEQ moreOp )* ;
    public MyGrammarParser.nonEqOp_return nonEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.nonEqOp_return retval = new MyGrammarParser.nonEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NONEQ66 = null;
        MyGrammarParser.moreOp_return moreOp65 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreOp_return moreOp67 = default(MyGrammarParser.moreOp_return);


        object NONEQ66_tree=null;

        try 
    	{
            // MyGrammar.g:213:12: ( moreOp ( NONEQ moreOp )* )
            // MyGrammar.g:213:14: moreOp ( NONEQ moreOp )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_moreOp_in_nonEqOp1698);
            	moreOp65 = moreOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreOp65.Tree);
            	// MyGrammar.g:213:21: ( NONEQ moreOp )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == NONEQ) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // MyGrammar.g:213:22: NONEQ moreOp
            			    {
            			    	NONEQ66=(IToken)Match(input,NONEQ,FOLLOW_NONEQ_in_nonEqOp1701); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{NONEQ66_tree = new NonEqualityOperationNode(NONEQ66) ;
            			    		root_0 = (object)adaptor.BecomeRoot(NONEQ66_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_moreOp_in_nonEqOp1707);
            			    	moreOp67 = moreOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreOp67.Tree);

            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


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
    // MyGrammar.g:216:1: moreOp : moreEqOp ( MORE moreEqOp )* ;
    public MyGrammarParser.moreOp_return moreOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreOp_return retval = new MyGrammarParser.moreOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MORE69 = null;
        MyGrammarParser.moreEqOp_return moreEqOp68 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp70 = default(MyGrammarParser.moreEqOp_return);


        object MORE69_tree=null;

        try 
    	{
            // MyGrammar.g:216:11: ( moreEqOp ( MORE moreEqOp )* )
            // MyGrammar.g:216:14: moreEqOp ( MORE moreEqOp )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_moreEqOp_in_moreOp1728);
            	moreEqOp68 = moreEqOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreEqOp68.Tree);
            	// MyGrammar.g:216:23: ( MORE moreEqOp )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == MORE) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // MyGrammar.g:216:24: MORE moreEqOp
            			    {
            			    	MORE69=(IToken)Match(input,MORE,FOLLOW_MORE_in_moreOp1731); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{MORE69_tree = new LogicOperationMoreNode(MORE69) ;
            			    		root_0 = (object)adaptor.BecomeRoot(MORE69_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_moreEqOp_in_moreOp1737);
            			    	moreEqOp70 = moreEqOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreEqOp70.Tree);

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
    // MyGrammar.g:219:1: moreEqOp : lessOp ( MOREEQ lessOp )* ;
    public MyGrammarParser.moreEqOp_return moreEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreEqOp_return retval = new MyGrammarParser.moreEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MOREEQ72 = null;
        MyGrammarParser.lessOp_return lessOp71 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessOp_return lessOp73 = default(MyGrammarParser.lessOp_return);


        object MOREEQ72_tree=null;

        try 
    	{
            // MyGrammar.g:219:12: ( lessOp ( MOREEQ lessOp )* )
            // MyGrammar.g:219:14: lessOp ( MOREEQ lessOp )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_lessOp_in_moreEqOp1756);
            	lessOp71 = lessOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessOp71.Tree);
            	// MyGrammar.g:219:21: ( MOREEQ lessOp )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == MOREEQ) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // MyGrammar.g:219:22: MOREEQ lessOp
            			    {
            			    	MOREEQ72=(IToken)Match(input,MOREEQ,FOLLOW_MOREEQ_in_moreEqOp1759); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{MOREEQ72_tree = new LogicOperationMoreEqNode(MOREEQ72) ;
            			    		root_0 = (object)adaptor.BecomeRoot(MOREEQ72_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_lessOp_in_moreEqOp1765);
            			    	lessOp73 = lessOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessOp73.Tree);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


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
    // MyGrammar.g:222:1: lessOp : lessEqOp ( LESS lessEqOp )* ;
    public MyGrammarParser.lessOp_return lessOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessOp_return retval = new MyGrammarParser.lessOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESS75 = null;
        MyGrammarParser.lessEqOp_return lessEqOp74 = default(MyGrammarParser.lessEqOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp76 = default(MyGrammarParser.lessEqOp_return);


        object LESS75_tree=null;

        try 
    	{
            // MyGrammar.g:222:11: ( lessEqOp ( LESS lessEqOp )* )
            // MyGrammar.g:222:13: lessEqOp ( LESS lessEqOp )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_lessEqOp_in_lessOp1784);
            	lessEqOp74 = lessEqOp();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessEqOp74.Tree);
            	// MyGrammar.g:222:22: ( LESS lessEqOp )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == LESS) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // MyGrammar.g:222:23: LESS lessEqOp
            			    {
            			    	LESS75=(IToken)Match(input,LESS,FOLLOW_LESS_in_lessOp1787); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LESS75_tree = new LogicOperationLessNode(LESS75) ;
            			    		root_0 = (object)adaptor.BecomeRoot(LESS75_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_lessEqOp_in_lessOp1793);
            			    	lessEqOp76 = lessEqOp();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessEqOp76.Tree);

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


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
    // MyGrammar.g:225:1: lessEqOp : add ( LESSEQ add )* ;
    public MyGrammarParser.lessEqOp_return lessEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessEqOp_return retval = new MyGrammarParser.lessEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSEQ78 = null;
        MyGrammarParser.add_return add77 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add79 = default(MyGrammarParser.add_return);


        object LESSEQ78_tree=null;

        try 
    	{
            // MyGrammar.g:225:12: ( add ( LESSEQ add )* )
            // MyGrammar.g:225:14: add ( LESSEQ add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_lessEqOp1811);
            	add77 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add77.Tree);
            	// MyGrammar.g:225:18: ( LESSEQ add )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == LESSEQ) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // MyGrammar.g:225:19: LESSEQ add
            			    {
            			    	LESSEQ78=(IToken)Match(input,LESSEQ,FOLLOW_LESSEQ_in_lessEqOp1814); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LESSEQ78_tree = new LogicOperationLessEqNode(LESSEQ78) ;
            			    		root_0 = (object)adaptor.BecomeRoot(LESSEQ78_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_add_in_lessEqOp1820);
            			    	add79 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add79.Tree);

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
    // MyGrammar.g:229:1: for_ : FOR '(' varInit ';' logicOperator ';' varInitValue ')' block -> ^( For varInit logicOperator varInitValue block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR80 = null;
        IToken char_literal81 = null;
        IToken char_literal83 = null;
        IToken char_literal85 = null;
        IToken char_literal87 = null;
        MyGrammarParser.varInit_return varInit82 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.logicOperator_return logicOperator84 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.varInitValue_return varInitValue86 = default(MyGrammarParser.varInitValue_return);

        MyGrammarParser.block_return block88 = default(MyGrammarParser.block_return);


        object FOR80_tree=null;
        object char_literal81_tree=null;
        object char_literal83_tree=null;
        object char_literal85_tree=null;
        object char_literal87_tree=null;
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
            // MyGrammar.g:229:6: ( FOR '(' varInit ';' logicOperator ';' varInitValue ')' block -> ^( For varInit logicOperator varInitValue block ) )
            // MyGrammar.g:229:8: FOR '(' varInit ';' logicOperator ';' varInitValue ')' block
            {
            	FOR80=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_1838); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR80);

            	char_literal81=(IToken)Match(input,76,FOLLOW_76_in_for_1853); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(char_literal81);

            	PushFollow(FOLLOW_varInit_in_for_1862);
            	varInit82 = varInit();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInit.Add(varInit82.Tree);
            	char_literal83=(IToken)Match(input,80,FOLLOW_80_in_for_1864); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(char_literal83);

            	PushFollow(FOLLOW_logicOperator_in_for_1869);
            	logicOperator84 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator84.Tree);
            	char_literal85=(IToken)Match(input,80,FOLLOW_80_in_for_1871); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(char_literal85);

            	PushFollow(FOLLOW_varInitValue_in_for_1879);
            	varInitValue86 = varInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitValue.Add(varInitValue86.Tree);
            	char_literal87=(IToken)Match(input,77,FOLLOW_77_in_for_1884); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(char_literal87);

            	PushFollow(FOLLOW_block_in_for_1889);
            	block88 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block88.Tree);


            	// AST REWRITE
            	// elements:          varInitValue, block, logicOperator, varInit
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 236:4: -> ^( For varInit logicOperator varInitValue block )
            	{
            	    // MyGrammar.g:236:7: ^( For varInit logicOperator varInitValue block )
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
    // MyGrammar.g:243:1: while_ : WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE89 = null;
        IToken char_literal90 = null;
        IToken char_literal92 = null;
        MyGrammarParser.logicOperator_return logicOperator91 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block93 = default(MyGrammarParser.block_return);


        object WHILE89_tree=null;
        object char_literal90_tree=null;
        object char_literal92_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:243:8: ( WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) )
            // MyGrammar.g:243:10: WHILE '(' logicOperator ')' block
            {
            	WHILE89=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_1924); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE89);

            	char_literal90=(IToken)Match(input,76,FOLLOW_76_in_while_1929); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_76.Add(char_literal90);

            	PushFollow(FOLLOW_logicOperator_in_while_1934);
            	logicOperator91 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator91.Tree);
            	char_literal92=(IToken)Match(input,77,FOLLOW_77_in_while_1939); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(char_literal92);

            	PushFollow(FOLLOW_block_in_while_1944);
            	block93 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block93.Tree);


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
            	// 248:4: -> ^( While_ logicOperator block )
            	{
            	    // MyGrammar.g:248:7: ^( While_ logicOperator block )
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
    // MyGrammar.g:256:1: methodDef : type ID '()' block -> ^( Method ^( ID ( type )? block ) ) ;
    public MyGrammarParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        MyGrammarParser.methodDef_return retval = new MyGrammarParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID95 = null;
        IToken string_literal96 = null;
        MyGrammarParser.type_return type94 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block97 = default(MyGrammarParser.block_return);


        object ID95_tree=null;
        object string_literal96_tree=null;
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:256:11: ( type ID '()' block -> ^( Method ^( ID ( type )? block ) ) )
            // MyGrammar.g:256:13: type ID '()' block
            {
            	PushFollow(FOLLOW_type_in_methodDef1978);
            	type94 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type94.Tree);
            	ID95=(IToken)Match(input,ID,FOLLOW_ID_in_methodDef1980); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID95);

            	string_literal96=(IToken)Match(input,81,FOLLOW_81_in_methodDef1982); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(string_literal96);

            	PushFollow(FOLLOW_block_in_methodDef1984);
            	block97 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block97.Tree);


            	// AST REWRITE
            	// elements:          type, block, ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 256:32: -> ^( Method ^( ID ( type )? block ) )
            	{
            	    // MyGrammar.g:256:35: ^( Method ^( ID ( type )? block ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(Method), root_1);

            	    // MyGrammar.g:256:59: ^( ID ( type )? block )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:256:64: ( type )?
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
    // MyGrammar.g:259:1: callMethod : ID '()' -> ^( CallMethod ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID98 = null;
        IToken string_literal99 = null;

        object ID98_tree=null;
        object string_literal99_tree=null;
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:259:12: ( ID '()' -> ^( CallMethod ID ) )
            // MyGrammar.g:259:14: ID '()'
            {
            	ID98=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod2013); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID98);

            	string_literal99=(IToken)Match(input,81,FOLLOW_81_in_callMethod2015); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(string_literal99);



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
            	// 260:5: -> ^( CallMethod ID )
            	{
            	    // MyGrammar.g:260:8: ^( CallMethod ID )
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
    // MyGrammar.g:263:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_100 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_101 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:263:7: ( for_ | while_ )
            int alt21 = 2;
            int LA21_0 = input.LA(1);

            if ( (LA21_0 == FOR) )
            {
                alt21 = 1;
            }
            else if ( (LA21_0 == WHILE) )
            {
                alt21 = 2;
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
                    // MyGrammar.g:263:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle2043);
                    	for_100 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_100.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:264:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle2049);
                    	while_101 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_101.Tree);

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
    // MyGrammar.g:269:1: printExpr : ( add | ident | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add102 = default(MyGrammarParser.add_return);

        MyGrammarParser.ident_return ident103 = default(MyGrammarParser.ident_return);

        MyGrammarParser.callMethod_return callMethod104 = default(MyGrammarParser.callMethod_return);



        try 
    	{
            // MyGrammar.g:269:11: ( add | ident | callMethod )
            int alt22 = 3;
            int LA22_0 = input.LA(1);

            if ( ((LA22_0 >= INTEGER && LA22_0 <= DOUBLE_) || LA22_0 == 76) )
            {
                alt22 = 1;
            }
            else if ( (LA22_0 == ID) )
            {
                int LA22_2 = input.LA(2);

                if ( (LA22_2 == 81) )
                {
                    alt22 = 3;
                }
                else if ( (synpred37_MyGrammar()) )
                {
                    alt22 = 1;
                }
                else if ( (synpred38_MyGrammar()) )
                {
                    alt22 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d22s2 =
                        new NoViableAltException("", 22, 2, input);

                    throw nvae_d22s2;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // MyGrammar.g:269:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr2062);
                    	add102 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add102.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:270:6: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_printExpr2069);
                    	ident103 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident103.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:271:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr2076);
                    	callMethod104 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod104.Tree);

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
    // MyGrammar.g:274:1: expr : ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add105 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_106 = default(MyGrammarParser.if__return);

        MyGrammarParser.varInit_return varInit107 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.oneArray_return oneArray108 = default(MyGrammarParser.oneArray_return);

        MyGrammarParser.cycle_return cycle109 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.varInitValue_return varInitValue110 = default(MyGrammarParser.varInitValue_return);

        MyGrammarParser.callMethod_return callMethod111 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print112 = default(MyGrammarParser.print_return);



        try 
    	{
            // MyGrammar.g:274:6: ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print )
            int alt23 = 8;
            alt23 = dfa23.Predict(input);
            switch (alt23) 
            {
                case 1 :
                    // MyGrammar.g:274:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr2090);
                    	add105 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add105.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:275:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr2096);
                    	if_106 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_106.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:276:5: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_expr2102);
                    	varInit107 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit107.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:277:5: oneArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_expr2108);
                    	oneArray108 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray108.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:278:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr2114);
                    	cycle109 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle109.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:279:5: varInitValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInitValue_in_expr2120);
                    	varInitValue110 = varInitValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInitValue110.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:280:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr2126);
                    	callMethod111 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod111.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:281:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr2132);
                    	print112 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print112.Tree);

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
    // MyGrammar.g:284:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal114 = null;
        MyGrammarParser.expr_return expr113 = default(MyGrammarParser.expr_return);


        object char_literal114_tree=null;

        try 
    	{
            // MyGrammar.g:284:6: ( expr ( ';' )* )
            // MyGrammar.g:284:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line2143);
            	expr113 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr113.Tree);
            	// MyGrammar.g:284:13: ( ';' )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == 80) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // MyGrammar.g:284:14: ';'
            			    {
            			    	char_literal114=(IToken)Match(input,80,FOLLOW_80_in_line2146); if (state.failed) return retval;

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
    // MyGrammar.g:287:1: exprList : ( methodDef ( ';' )* | varInit ( ';' )* | oneArray ( ';' )* );
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal116 = null;
        IToken char_literal118 = null;
        IToken char_literal120 = null;
        MyGrammarParser.methodDef_return methodDef115 = default(MyGrammarParser.methodDef_return);

        MyGrammarParser.varInit_return varInit117 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.oneArray_return oneArray119 = default(MyGrammarParser.oneArray_return);


        object char_literal116_tree=null;
        object char_literal118_tree=null;
        object char_literal120_tree=null;

        try 
    	{
            // MyGrammar.g:287:9: ( methodDef ( ';' )* | varInit ( ';' )* | oneArray ( ';' )* )
            int alt28 = 3;
            int LA28_0 = input.LA(1);

            if ( ((LA28_0 >= INT && LA28_0 <= VOID)) )
            {
                int LA28_1 = input.LA(2);

                if ( (LA28_1 == ID) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case 81:
                    	{
                        alt28 = 1;
                        }
                        break;
                    case 74:
                    	{
                        alt28 = 3;
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
                        alt28 = 2;
                        }
                        break;
                    	default:
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d28s2 =
                    	        new NoViableAltException("", 28, 2, input);

                    	    throw nvae_d28s2;
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
                    // MyGrammar.g:287:11: methodDef ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodDef_in_exprList2160);
                    	methodDef115 = methodDef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef115.Tree);
                    	// MyGrammar.g:287:22: ( ';' )*
                    	do 
                    	{
                    	    int alt25 = 2;
                    	    int LA25_0 = input.LA(1);

                    	    if ( (LA25_0 == 80) )
                    	    {
                    	        alt25 = 1;
                    	    }


                    	    switch (alt25) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:287:23: ';'
                    			    {
                    			    	char_literal116=(IToken)Match(input,80,FOLLOW_80_in_exprList2164); if (state.failed) return retval;

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
                    // MyGrammar.g:288:5: varInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_exprList2174);
                    	varInit117 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit117.Tree);
                    	// MyGrammar.g:288:13: ( ';' )*
                    	do 
                    	{
                    	    int alt26 = 2;
                    	    int LA26_0 = input.LA(1);

                    	    if ( (LA26_0 == 80) )
                    	    {
                    	        alt26 = 1;
                    	    }


                    	    switch (alt26) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:288:14: ';'
                    			    {
                    			    	char_literal118=(IToken)Match(input,80,FOLLOW_80_in_exprList2177); if (state.failed) return retval;

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
                    // MyGrammar.g:289:5: oneArray ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_exprList2187);
                    	oneArray119 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray119.Tree);
                    	// MyGrammar.g:289:14: ( ';' )*
                    	do 
                    	{
                    	    int alt27 = 2;
                    	    int LA27_0 = input.LA(1);

                    	    if ( (LA27_0 == 80) )
                    	    {
                    	        alt27 = 1;
                    	    }


                    	    switch (alt27) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:289:15: ';'
                    			    {
                    			    	char_literal120=(IToken)Match(input,80,FOLLOW_80_in_exprList2190); if (state.failed) return retval;

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
    // MyGrammar.g:295:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList121 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:295:13: ( ( exprList )* )
            // MyGrammar.g:296:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:296:4: ( exprList )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( ((LA29_0 >= INT && LA29_0 <= VOID)) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm2211);
            			    	exprList121 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList121.Tree);

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
    // MyGrammar.g:299:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm122 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:299:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:300:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program2225);
            	fullProgramm122 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm122.Tree);


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
            	// 300:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:300:19: ^( PROGRAM fullProgramm )
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
    // MyGrammar.g:303:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program123 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:303:8: ( program )
            // MyGrammar.g:304:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute2243);
            	program123 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program123.Tree);

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

    // $ANTLR start "synpred37_MyGrammar"
    public void synpred37_MyGrammar_fragment() {
        // MyGrammar.g:269:13: ( add )
        // MyGrammar.g:269:13: add
        {
        	PushFollow(FOLLOW_add_in_synpred37_MyGrammar2062);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred37_MyGrammar"

    // $ANTLR start "synpred38_MyGrammar"
    public void synpred38_MyGrammar_fragment() {
        // MyGrammar.g:270:6: ( ident )
        // MyGrammar.g:270:6: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred38_MyGrammar2069);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_MyGrammar"

    // $ANTLR start "synpred39_MyGrammar"
    public void synpred39_MyGrammar_fragment() {
        // MyGrammar.g:274:8: ( add )
        // MyGrammar.g:274:8: add
        {
        	PushFollow(FOLLOW_add_in_synpred39_MyGrammar2090);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_MyGrammar"

    // $ANTLR start "synpred44_MyGrammar"
    public void synpred44_MyGrammar_fragment() {
        // MyGrammar.g:279:5: ( varInitValue )
        // MyGrammar.g:279:5: varInitValue
        {
        	PushFollow(FOLLOW_varInitValue_in_synpred44_MyGrammar2120);
        	varInitValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred44_MyGrammar"

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


   	protected DFA23 dfa23;
	private void InitializeCyclicDFAs()
	{
    	this.dfa23 = new DFA23(this);
	    this.dfa23.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA23_SpecialStateTransition);
	}

    const string DFA23_eotS =
        "\x0c\uffff";
    const string DFA23_eofS =
        "\x09\uffff\x01\x0b\x02\uffff";
    const string DFA23_minS =
        "\x01\x1e\x01\uffff\x01\x51\x01\uffff\x01\x48\x04\uffff\x01\x1e"+
        "\x02\uffff";
    const string DFA23_maxS =
        "\x01\x4c\x01\uffff\x01\x51\x01\uffff\x01\x48\x04\uffff\x01\x50"+
        "\x02\uffff";
    const string DFA23_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\uffff\x01\x05\x01\x08"+
        "\x01\x07\x01\x06\x01\uffff\x01\x04\x01\x03";
    const string DFA23_specialS =
        "\x02\uffff\x01\x00\x09\uffff}>";
    static readonly string[] DFA23_transitionS = {
            "\x01\x06\x04\uffff\x01\x03\x0a\uffff\x05\x04\x08\uffff\x02"+
            "\x05\x09\uffff\x02\x01\x01\x02\x03\uffff\x01\x01",
            "",
            "\x01\x07",
            "",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "\x01\x0b\x04\uffff\x01\x0b\x03\uffff\x01\x0b\x06\uffff\x05"+
            "\x0b\x08\uffff\x02\x0b\x09\uffff\x03\x0b\x01\uffff\x01\x0a\x01"+
            "\uffff\x01\x0b\x02\uffff\x02\x0b",
            "",
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
            get { return "274:1: expr : ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print );"; }
        }

    }


    protected internal int DFA23_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA23_2 = input.LA(1);

                   	 
                   	int index23_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA23_2 == 81) ) { s = 7; }

                   	else if ( (synpred39_MyGrammar()) ) { s = 1; }

                   	else if ( (synpred44_MyGrammar()) ) { s = 8; }

                   	 
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
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator1584 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation1613 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_OR_in_orOperation1617 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation1623 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_andOperation1641 = new BitSet(new ulong[]{0x4000000000000002UL});
    public static readonly BitSet FOLLOW_AND_in_andOperation1644 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_eqOp_in_andOperation1650 = new BitSet(new ulong[]{0x4000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_eqOp1670 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_EQ_in_eqOp1673 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_eqOp1679 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_moreOp_in_nonEqOp1698 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NONEQ_in_nonEqOp1701 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_moreOp_in_nonEqOp1707 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_moreOp1728 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_MORE_in_moreOp1731 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_moreOp1737 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_lessOp_in_moreEqOp1756 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_MOREEQ_in_moreEqOp1759 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_lessOp_in_moreEqOp1765 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_lessOp1784 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LESS_in_lessOp1787 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_lessOp1793 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_add_in_lessEqOp1811 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_LESSEQ_in_lessEqOp1814 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_add_in_lessEqOp1820 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_FOR_in_for_1838 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_for_1853 = new BitSet(new ulong[]{0x0007C00000000000UL});
    public static readonly BitSet FOLLOW_varInit_in_for_1862 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_for_1864 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_1869 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_for_1871 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_varInitValue_in_for_1879 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_for_1884 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_block_in_for_1889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_1924 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_while_1929 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000011C0UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_1934 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_while_1939 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_block_in_while_1944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_methodDef1978 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ID_in_methodDef1980 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_methodDef1982 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_block_in_methodDef1984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod2013 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_callMethod2015 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle2043 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle2049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr2062 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_printExpr2069 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr2076 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr2090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr2096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_expr2102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_oneArray_in_expr2108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr2114 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInitValue_in_expr2120 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr2126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr2132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line2143 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_line2146 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_methodDef_in_exprList2160 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_exprList2164 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_varInit_in_exprList2174 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_exprList2177 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_oneArray_in_exprList2187 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_80_in_exprList2190 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm2211 = new BitSet(new ulong[]{0x0007C00000000002UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program2225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute2243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred15_MyGrammar1239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred17_MyGrammar1255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred37_MyGrammar2062 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred38_MyGrammar2069 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred39_MyGrammar2090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInitValue_in_synpred44_MyGrammar2120 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}