// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-12-26 02:58:37

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
    public const int PRINT = 35;
    public const int NEW = 46;
    public const int MoreEqOp = 21;
    public const int VAR = 59;
    public const int T__90 = 90;
    public const int CallMethod = 13;
    public const int While_ = 28;
    public const int DECREMENT = 53;
    public const int LessOp = 22;
    public const int MINUS = 39;
    public const int Print = 31;
    public const int MULT = 7;
    public const int ArrayInit = 30;
    public const int ELSE = 43;
    public const int NextLine = 33;
    public const int CALLMETHOD = 66;
    public const int ID = 80;
    public const int Plus = 9;
    public const int IF = 42;
    public const int TYPE = 64;
    public const int MINUSASSIGN = 49;
    public const int LogicOp = 25;
    public const int INTEGER = 78;
    public const int MOREEQ = 76;
    public const int LESSEQ = 77;
    public const int For = 24;
    public const int BLOCK = 44;
    public const int ONEARRAY = 60;
    public const int FOR = 67;
    public const int Method = 5;
    public const int EQ = 72;
    public const int Double = 12;
    public const int AND = 70;
    public const int Println = 32;
    public const int PUBLIC = 63;
    public const int MULTIPLY = 40;
    public const int CONDITION = 45;
    public const int COUNT = 61;
    public const int LESS = 75;
    public const int Id = 14;
    public const int VOID = 58;
    public const int If = 26;
    public const int Minus = 10;
    public const int PROGRAM = 34;
    public const int AndOp = 15;
    public const int Inc = 27;
    public const int PLUS = 38;
    public const int DIVIDEASSIGN = 51;
    public const int FLOAT = 55;
    public const int NonEqOp = 18;
    public const int PRINTLN = 36;
    public const int MULTASSIGN = 50;
    public const int CHAR = 57;
    public const int DefOp = 19;
    public const int ASSIGN = 47;
    public const int INT = 54;
    public const int DIVIDE = 41;
    public const int PLUSASSIGN = 48;
    public const int DOUBLE = 56;
    public const int WS = 81;
    public const int EOF = -1;
    public const int OrOp = 16;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int MOD = 65;
    public const int OR = 71;
    public const int INCREMENT_ = 69;
    public const int LessEqOp = 23;
    public const int NONEQ = 73;
    public const int EqOp = 17;
    public const int DOUBLE_ = 79;
    public const int PRIVATE = 62;
    public const int VarInit = 4;
    public const int Integer = 11;
    public const int NEXTLINE = 37;
    public const int INCREMENT = 52;
    public const int MORE = 74;
    public const int T__88 = 88;
    public const int T__89 = 89;
    public const int Assign = 8;
    public const int WHILE = 68;
    public const int T__84 = 84;
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
    // MyGrammar.g:101:1: type : ( INT | FLOAT | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:101:6: ( INT | FLOAT | DOUBLE | CHAR | VOID )
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
    // MyGrammar.g:109:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:109:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
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
    // MyGrammar.g:117:1: incDec : ( inc | dec );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.inc_return inc3 = default(MyGrammarParser.inc_return);

        MyGrammarParser.dec_return dec4 = default(MyGrammarParser.dec_return);



        try 
    	{
            // MyGrammar.g:117:8: ( inc | dec )
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
                    // MyGrammar.g:117:10: inc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inc_in_incDec1014);
                    	inc3 = inc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inc3.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:118:5: dec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dec_in_incDec1020);
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
    // MyGrammar.g:122:1: inc : INCREMENT -> ^( Inc INCREMENT ) ;
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
            // MyGrammar.g:122:6: ( INCREMENT -> ^( Inc INCREMENT ) )
            // MyGrammar.g:122:8: INCREMENT
            {
            	INCREMENT5=(IToken)Match(input,INCREMENT,FOLLOW_INCREMENT_in_inc1033); if (state.failed) return retval; 
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
            	// 122:18: -> ^( Inc INCREMENT )
            	{
            	    // MyGrammar.g:122:21: ^( Inc INCREMENT )
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
    // MyGrammar.g:125:1: dec : DECREMENT -> DECREMENT ;
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
            // MyGrammar.g:125:6: ( DECREMENT -> DECREMENT )
            // MyGrammar.g:125:8: DECREMENT
            {
            	DECREMENT6=(IToken)Match(input,DECREMENT,FOLLOW_DECREMENT_in_dec1056); if (state.failed) return retval; 
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
            	// 125:18: -> DECREMENT
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
    // MyGrammar.g:128:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set7 = null;

        object set7_tree=null;

        try 
    	{
            // MyGrammar.g:128:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
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
    // MyGrammar.g:144:1: number : ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) );
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
            // MyGrammar.g:144:8: ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) )
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
                    // MyGrammar.g:144:10: INTEGER
                    {
                    	INTEGER8=(IToken)Match(input,INTEGER,FOLLOW_INTEGER_in_number1147); if (state.failed) return retval; 
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
                    	// 144:18: -> ^( Integer INTEGER )
                    	{
                    	    // MyGrammar.g:144:21: ^( Integer INTEGER )
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
                    // MyGrammar.g:145:5: DOUBLE_
                    {
                    	DOUBLE_9=(IToken)Match(input,DOUBLE_,FOLLOW_DOUBLE__in_number1164); if (state.failed) return retval; 
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
                    	// 145:13: -> ^( Double DOUBLE_ )
                    	{
                    	    // MyGrammar.g:145:16: ^( Double DOUBLE_ )
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
    // MyGrammar.g:152:1: ident : ID -> ^( Id ID ) ;
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
            // MyGrammar.g:152:8: ( ID -> ^( Id ID ) )
            // MyGrammar.g:152:10: ID
            {
            	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_ident1229); if (state.failed) return retval; 
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
            	// 152:13: -> ^( Id ID )
            	{
            	    // MyGrammar.g:152:16: ^( Id ID )
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
    // MyGrammar.g:160:1: init : ( arrayInit | varInit );
    public MyGrammarParser.init_return init() // throws RecognitionException [1]
    {   
        MyGrammarParser.init_return retval = new MyGrammarParser.init_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.arrayInit_return arrayInit11 = default(MyGrammarParser.arrayInit_return);

        MyGrammarParser.varInit_return varInit12 = default(MyGrammarParser.varInit_return);



        try 
    	{
            // MyGrammar.g:160:6: ( arrayInit | varInit )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= INT && LA3_0 <= VOID)) )
            {
                int LA3_1 = input.LA(2);

                if ( (LA3_1 == ID) )
                {
                    alt3 = 2;
                }
                else if ( (LA3_1 == 82) )
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
                    // MyGrammar.g:160:8: arrayInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_init1257);
                    	arrayInit11 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit11.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:161:5: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_init1264);
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
    // MyGrammar.g:164:1: arrayInit : type '[]' ident ( '=' NEW type '[' add ']' )? -> ^( ArrayDecl type ident ( add )? ) ;
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
        RewriteRuleTokenStream stream_NEW = new RewriteRuleTokenStream(adaptor,"token NEW");
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:164:11: ( type '[]' ident ( '=' NEW type '[' add ']' )? -> ^( ArrayDecl type ident ( add )? ) )
            // MyGrammar.g:164:13: type '[]' ident ( '=' NEW type '[' add ']' )?
            {
            	PushFollow(FOLLOW_type_in_arrayInit1275);
            	type13 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type13.Tree);
            	string_literal14=(IToken)Match(input,82,FOLLOW_82_in_arrayInit1277); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal14);

            	PushFollow(FOLLOW_ident_in_arrayInit1279);
            	ident15 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident15.Tree);
            	// MyGrammar.g:164:29: ( '=' NEW type '[' add ']' )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == ASSIGN) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // MyGrammar.g:164:30: '=' NEW type '[' add ']'
            	        {
            	        	char_literal16=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_arrayInit1282); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(char_literal16);

            	        	NEW17=(IToken)Match(input,NEW,FOLLOW_NEW_in_arrayInit1284); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_NEW.Add(NEW17);

            	        	PushFollow(FOLLOW_type_in_arrayInit1286);
            	        	type18 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type18.Tree);
            	        	char_literal19=(IToken)Match(input,83,FOLLOW_83_in_arrayInit1288); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_83.Add(char_literal19);

            	        	PushFollow(FOLLOW_add_in_arrayInit1290);
            	        	add20 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_add.Add(add20.Tree);
            	        	char_literal21=(IToken)Match(input,84,FOLLOW_84_in_arrayInit1292); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_84.Add(char_literal21);


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          type, ident, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 165:6: -> ^( ArrayDecl type ident ( add )? )
            	{
            	    // MyGrammar.g:165:8: ^( ArrayDecl type ident ( add )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ArrayDeclNode(ArrayDecl), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:165:46: ( add )?
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
    // MyGrammar.g:168:1: varInit : type fieldInitValue -> ^( VarInit type fieldInitValue ) ;
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
            // MyGrammar.g:168:9: ( type fieldInitValue -> ^( VarInit type fieldInitValue ) )
            // MyGrammar.g:168:11: type fieldInitValue
            {
            	PushFollow(FOLLOW_type_in_varInit1329);
            	type22 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type22.Tree);
            	PushFollow(FOLLOW_fieldInitValue_in_varInit1331);
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
            	// 169:5: -> ^( VarInit type fieldInitValue )
            	{
            	    // MyGrammar.g:169:8: ^( VarInit type fieldInitValue )
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
    // MyGrammar.g:173:1: fieldInitValue : ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) ;
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
            // MyGrammar.g:173:16: ( ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) )
            // MyGrammar.g:173:19: ident ( ASSIGN initValue )?
            {
            	PushFollow(FOLLOW_ident_in_fieldInitValue1361);
            	ident24 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident24.Tree);
            	// MyGrammar.g:173:26: ( ASSIGN initValue )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == ASSIGN) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // MyGrammar.g:173:27: ASSIGN initValue
            	        {
            	        	ASSIGN25=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_fieldInitValue1365); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN25);

            	        	PushFollow(FOLLOW_initValue_in_fieldInitValue1367);
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
            	// 174:7: -> ^( Assign ident ( initValue )? )
            	{
            	    // MyGrammar.g:174:10: ^( Assign ident ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AssignNode(Assign), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:174:37: ( initValue )?
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
    // MyGrammar.g:179:1: initValue : ( addOrArray | callMethod | ident | inc | dec );
    public MyGrammarParser.initValue_return initValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.initValue_return retval = new MyGrammarParser.initValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.addOrArray_return addOrArray27 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.callMethod_return callMethod28 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.ident_return ident29 = default(MyGrammarParser.ident_return);

        MyGrammarParser.inc_return inc30 = default(MyGrammarParser.inc_return);

        MyGrammarParser.dec_return dec31 = default(MyGrammarParser.dec_return);



        try 
    	{
            // MyGrammar.g:179:12: ( addOrArray | callMethod | ident | inc | dec )
            int alt6 = 5;
            switch ( input.LA(1) ) 
            {
            case INTEGER:
            case DOUBLE_:
            case 85:
            	{
                alt6 = 1;
                }
                break;
            case ID:
            	{
                int LA6_2 = input.LA(2);

                if ( (LA6_2 == 90) )
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
                    // MyGrammar.g:179:14: addOrArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_addOrArray_in_initValue1407);
                    	addOrArray27 = addOrArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, addOrArray27.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:180:7: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_initValue1415);
                    	callMethod28 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod28.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:181:7: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_initValue1423);
                    	ident29 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident29.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:182:7: inc
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_inc_in_initValue1431);
                    	inc30 = inc();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inc30.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:183:7: dec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_dec_in_initValue1439);
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
    // MyGrammar.g:187:1: addOperation : ( PLUS -> Plus | MINUS -> Minus );
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
            // MyGrammar.g:187:14: ( PLUS -> Plus | MINUS -> Minus )
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
                    // MyGrammar.g:187:16: PLUS
                    {
                    	PLUS32=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addOperation1453); if (state.failed) return retval; 
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
                    	// 187:21: -> Plus
                    	{
                    	    adaptor.AddChild(root_0, new PlusNode(Plus));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:188:7: MINUS
                    {
                    	MINUS33=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_addOperation1468); if (state.failed) return retval; 
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
                    	// 188:13: -> Minus
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
    // MyGrammar.g:191:1: multOperation : ( MULTIPLY -> MULT | DIVIDE -> DIVIDE );
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
            // MyGrammar.g:191:15: ( MULTIPLY -> MULT | DIVIDE -> DIVIDE )
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
                    // MyGrammar.g:191:17: MULTIPLY
                    {
                    	MULTIPLY34=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multOperation1488); if (state.failed) return retval; 
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
                    	// 191:26: -> MULT
                    	{
                    	    adaptor.AddChild(root_0, new MultNode(MULT));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:192:7: DIVIDE
                    {
                    	DIVIDE35=(IToken)Match(input,DIVIDE,FOLLOW_DIVIDE_in_multOperation1503); if (state.failed) return retval; 
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
                    	// 192:14: -> DIVIDE
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
    // MyGrammar.g:195:1: group : ( '(' add ')' | number | ident );
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
            // MyGrammar.g:195:7: ( '(' add ')' | number | ident )
            int alt9 = 3;
            switch ( input.LA(1) ) 
            {
            case 85:
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
                    // MyGrammar.g:195:9: '(' add ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal36=(IToken)Match(input,85,FOLLOW_85_in_group1526); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group1529);
                    	add37 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add37.Tree);
                    	char_literal38=(IToken)Match(input,86,FOLLOW_86_in_group1531); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:196:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group1539);
                    	number39 = number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number39.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:197:5: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_group1545);
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
    // MyGrammar.g:200:1: mult : group ( multOperation group )* ;
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
            // MyGrammar.g:200:6: ( group ( multOperation group )* )
            // MyGrammar.g:200:8: group ( multOperation group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult1560);
            	group41 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group41.Tree);
            	// MyGrammar.g:200:14: ( multOperation group )*
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
            			    // MyGrammar.g:200:16: multOperation group
            			    {
            			    	PushFollow(FOLLOW_multOperation_in_mult1564);
            			    	multOperation42 = multOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperation42.Tree, root_0);
            			    	PushFollow(FOLLOW_group_in_mult1567);
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
    // MyGrammar.g:202:1: add : mult ( addOperation mult )* ;
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
            // MyGrammar.g:202:6: ( mult ( addOperation mult )* )
            // MyGrammar.g:202:8: mult ( addOperation mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1579);
            	mult44 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult44.Tree);
            	// MyGrammar.g:202:13: ( addOperation mult )*
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
            			    // MyGrammar.g:202:15: addOperation mult
            			    {
            			    	PushFollow(FOLLOW_addOperation_in_add1583);
            			    	addOperation45 = addOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperation45.Tree, root_0);
            			    	PushFollow(FOLLOW_mult_in_add1586);
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
    // MyGrammar.g:205:1: block : '{' ( line )* '}' -> ^( BLOCK ( line )* ) ;
    public MyGrammarParser.block_return block() // throws RecognitionException [1]
    {   
        MyGrammarParser.block_return retval = new MyGrammarParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal47 = null;
        IToken char_literal49 = null;
        MyGrammarParser.line_return line48 = default(MyGrammarParser.line_return);


        object char_literal47_tree=null;
        object char_literal49_tree=null;
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:205:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:205:9: '{' ( line )* '}'
            {
            	char_literal47=(IToken)Match(input,87,FOLLOW_87_in_block1598); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(char_literal47);

            	// MyGrammar.g:205:13: ( line )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= PRINT && LA12_0 <= NEXTLINE) || LA12_0 == IF || (LA12_0 >= INT && LA12_0 <= VOID) || (LA12_0 >= FOR && LA12_0 <= WHILE) || (LA12_0 >= INTEGER && LA12_0 <= ID) || LA12_0 == 85) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block1600);
            			    	line48 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line48.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	char_literal49=(IToken)Match(input,88,FOLLOW_88_in_block1603); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(char_literal49);



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
            	// 205:23: -> ^( BLOCK ( line )* )
            	{
            	    // MyGrammar.g:205:26: ^( BLOCK ( line )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(BLOCK), root_1);

            	    // MyGrammar.g:205:49: ( line )*
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
    // MyGrammar.g:209:1: if_ : IF '(' logicOperator ')' block ( ELSE block )? -> ^( If logicOperator block ( ^( ELSE block ) )? ) ;
    public MyGrammarParser.if__return if_() // throws RecognitionException [1]
    {   
        MyGrammarParser.if__return retval = new MyGrammarParser.if__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF50 = null;
        IToken char_literal51 = null;
        IToken char_literal53 = null;
        IToken ELSE55 = null;
        MyGrammarParser.logicOperator_return logicOperator52 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block54 = default(MyGrammarParser.block_return);

        MyGrammarParser.block_return block56 = default(MyGrammarParser.block_return);


        object IF50_tree=null;
        object char_literal51_tree=null;
        object char_literal53_tree=null;
        object ELSE55_tree=null;
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:209:6: ( IF '(' logicOperator ')' block ( ELSE block )? -> ^( If logicOperator block ( ^( ELSE block ) )? ) )
            // MyGrammar.g:209:8: IF '(' logicOperator ')' block ( ELSE block )?
            {
            	IF50=(IToken)Match(input,IF,FOLLOW_IF_in_if_1628); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF50);

            	char_literal51=(IToken)Match(input,85,FOLLOW_85_in_if_1630); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(char_literal51);

            	PushFollow(FOLLOW_logicOperator_in_if_1632);
            	logicOperator52 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator52.Tree);
            	char_literal53=(IToken)Match(input,86,FOLLOW_86_in_if_1634); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal53);

            	PushFollow(FOLLOW_block_in_if_1636);
            	block54 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block54.Tree);
            	// MyGrammar.g:209:39: ( ELSE block )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == ELSE) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // MyGrammar.g:209:40: ELSE block
            	        {
            	        	ELSE55=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_if_1639); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE55);

            	        	PushFollow(FOLLOW_block_in_if_1641);
            	        	block56 = block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block.Add(block56.Tree);

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
            	// 210:4: -> ^( If logicOperator block ( ^( ELSE block ) )? )
            	{
            	    // MyGrammar.g:210:7: ^( If logicOperator block ( ^( ELSE block ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new IfNode(If), root_1);

            	    adaptor.AddChild(root_1, stream_logicOperator.NextTree());
            	    adaptor.AddChild(root_1, stream_block.NextTree());
            	    // MyGrammar.g:210:40: ( ^( ELSE block ) )?
            	    if ( stream_ELSE.HasNext() || stream_block.HasNext() )
            	    {
            	        // MyGrammar.g:210:40: ^( ELSE block )
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
    // MyGrammar.g:216:1: operations : ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) );
    public MyGrammarParser.operations_return operations() // throws RecognitionException [1]
    {   
        MyGrammarParser.operations_return retval = new MyGrammarParser.operations_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation57 = default(MyGrammarParser.orOperation_return);

        MyGrammarParser.andOperation_return andOperation58 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.eqOp_return eqOp59 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp60 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.moreOp_return moreOp61 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp62 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.lessOp_return lessOp63 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp64 = default(MyGrammarParser.lessEqOp_return);


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
            // MyGrammar.g:216:14: ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) )
            int alt14 = 8;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // MyGrammar.g:216:16: orOperation
                    {
                    	PushFollow(FOLLOW_orOperation_in_operations1683);
                    	orOperation57 = orOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_orOperation.Add(orOperation57.Tree);


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
                    	// 216:28: -> ^( OrOp orOperation )
                    	{
                    	    // MyGrammar.g:216:31: ^( OrOp orOperation )
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
                    // MyGrammar.g:217:8: andOperation
                    {
                    	PushFollow(FOLLOW_andOperation_in_operations1703);
                    	andOperation58 = andOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_andOperation.Add(andOperation58.Tree);


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
                    	// 217:21: -> ^( AndOp andOperation )
                    	{
                    	    // MyGrammar.g:217:24: ^( AndOp andOperation )
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
                    // MyGrammar.g:218:8: eqOp
                    {
                    	PushFollow(FOLLOW_eqOp_in_operations1723);
                    	eqOp59 = eqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_eqOp.Add(eqOp59.Tree);


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
                    	// 218:13: -> ^( EqOp eqOp )
                    	{
                    	    // MyGrammar.g:218:16: ^( EqOp eqOp )
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
                    // MyGrammar.g:219:8: nonEqOp
                    {
                    	PushFollow(FOLLOW_nonEqOp_in_operations1743);
                    	nonEqOp60 = nonEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_nonEqOp.Add(nonEqOp60.Tree);


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
                    	// 219:16: -> ^( NonEqOp nonEqOp )
                    	{
                    	    // MyGrammar.g:219:19: ^( NonEqOp nonEqOp )
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
                    // MyGrammar.g:220:8: moreOp
                    {
                    	PushFollow(FOLLOW_moreOp_in_operations1763);
                    	moreOp61 = moreOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_moreOp.Add(moreOp61.Tree);


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
                    	// 220:15: -> ^( MoreOp moreOp )
                    	{
                    	    // MyGrammar.g:220:18: ^( MoreOp moreOp )
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
                    // MyGrammar.g:221:8: moreEqOp
                    {
                    	PushFollow(FOLLOW_moreEqOp_in_operations1783);
                    	moreEqOp62 = moreEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_moreEqOp.Add(moreEqOp62.Tree);


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
                    	// 221:17: -> ^( MoreEqOp moreEqOp )
                    	{
                    	    // MyGrammar.g:221:20: ^( MoreEqOp moreEqOp )
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
                    // MyGrammar.g:222:8: lessOp
                    {
                    	PushFollow(FOLLOW_lessOp_in_operations1803);
                    	lessOp63 = lessOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lessOp.Add(lessOp63.Tree);


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
                    	// 222:15: -> ^( LessOp lessOp )
                    	{
                    	    // MyGrammar.g:222:18: ^( LessOp lessOp )
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
                    // MyGrammar.g:223:8: lessEqOp
                    {
                    	PushFollow(FOLLOW_lessEqOp_in_operations1823);
                    	lessEqOp64 = lessEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_lessEqOp.Add(lessEqOp64.Tree);


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
                    	// 223:17: -> ^( LessEqOp lessEqOp )
                    	{
                    	    // MyGrammar.g:223:20: ^( LessEqOp lessEqOp )
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
    // MyGrammar.g:226:1: logicOperator : ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp );
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation65 = default(MyGrammarParser.orOperation_return);

        MyGrammarParser.andOperation_return andOperation66 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.eqOp_return eqOp67 = default(MyGrammarParser.eqOp_return);

        MyGrammarParser.nonEqOp_return nonEqOp68 = default(MyGrammarParser.nonEqOp_return);

        MyGrammarParser.moreOp_return moreOp69 = default(MyGrammarParser.moreOp_return);

        MyGrammarParser.moreEqOp_return moreEqOp70 = default(MyGrammarParser.moreEqOp_return);

        MyGrammarParser.lessOp_return lessOp71 = default(MyGrammarParser.lessOp_return);

        MyGrammarParser.lessEqOp_return lessEqOp72 = default(MyGrammarParser.lessEqOp_return);



        try 
    	{
            // MyGrammar.g:226:16: ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp )
            int alt15 = 8;
            alt15 = dfa15.Predict(input);
            switch (alt15) 
            {
                case 1 :
                    // MyGrammar.g:226:18: orOperation
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_orOperation_in_logicOperator1851);
                    	orOperation65 = orOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation65.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:227:8: andOperation
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_andOperation_in_logicOperator1860);
                    	andOperation66 = andOperation();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation66.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:228:8: eqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_eqOp_in_logicOperator1869);
                    	eqOp67 = eqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, eqOp67.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:229:8: nonEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nonEqOp_in_logicOperator1878);
                    	nonEqOp68 = nonEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEqOp68.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:230:8: moreOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moreOp_in_logicOperator1887);
                    	moreOp69 = moreOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreOp69.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:231:8: moreEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moreEqOp_in_logicOperator1896);
                    	moreEqOp70 = moreEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moreEqOp70.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:232:8: lessOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lessOp_in_logicOperator1905);
                    	lessOp71 = lessOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessOp71.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:233:8: lessEqOp
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lessEqOp_in_logicOperator1914);
                    	lessEqOp72 = lessEqOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lessEqOp72.Tree);

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
    // MyGrammar.g:237:1: orOperation : addOrArray OR addOrArray -> ^( OrOp addOrArray addOrArray ) ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OR74 = null;
        MyGrammarParser.addOrArray_return addOrArray73 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray75 = default(MyGrammarParser.addOrArray_return);


        object OR74_tree=null;
        RewriteRuleTokenStream stream_OR = new RewriteRuleTokenStream(adaptor,"token OR");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:237:15: ( addOrArray OR addOrArray -> ^( OrOp addOrArray addOrArray ) )
            // MyGrammar.g:237:17: addOrArray OR addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_orOperation1931);
            	addOrArray73 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray73.Tree);
            	OR74=(IToken)Match(input,OR,FOLLOW_OR_in_orOperation1933); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_OR.Add(OR74);

            	PushFollow(FOLLOW_addOrArray_in_orOperation1935);
            	addOrArray75 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray75.Tree);


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
            	// 237:42: -> ^( OrOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:237:45: ^( OrOp addOrArray addOrArray )
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
    // MyGrammar.g:240:1: andOperation : addOrArray AND addOrArray -> ^( AndOp addOrArray addOrArray ) ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken AND77 = null;
        MyGrammarParser.addOrArray_return addOrArray76 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray78 = default(MyGrammarParser.addOrArray_return);


        object AND77_tree=null;
        RewriteRuleTokenStream stream_AND = new RewriteRuleTokenStream(adaptor,"token AND");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:240:15: ( addOrArray AND addOrArray -> ^( AndOp addOrArray addOrArray ) )
            // MyGrammar.g:240:17: addOrArray AND addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_andOperation1963);
            	addOrArray76 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray76.Tree);
            	AND77=(IToken)Match(input,AND,FOLLOW_AND_in_andOperation1965); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_AND.Add(AND77);

            	PushFollow(FOLLOW_addOrArray_in_andOperation1967);
            	addOrArray78 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray78.Tree);


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
            	// 240:43: -> ^( AndOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:240:46: ^( AndOp addOrArray addOrArray )
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
    // MyGrammar.g:243:1: eqOp : addOrArray EQ addOrArray -> ^( EqOp addOrArray addOrArray ) ;
    public MyGrammarParser.eqOp_return eqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.eqOp_return retval = new MyGrammarParser.eqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQ80 = null;
        MyGrammarParser.addOrArray_return addOrArray79 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray81 = default(MyGrammarParser.addOrArray_return);


        object EQ80_tree=null;
        RewriteRuleTokenStream stream_EQ = new RewriteRuleTokenStream(adaptor,"token EQ");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:243:9: ( addOrArray EQ addOrArray -> ^( EqOp addOrArray addOrArray ) )
            // MyGrammar.g:243:11: addOrArray EQ addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_eqOp1997);
            	addOrArray79 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray79.Tree);
            	EQ80=(IToken)Match(input,EQ,FOLLOW_EQ_in_eqOp1999); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_EQ.Add(EQ80);

            	PushFollow(FOLLOW_addOrArray_in_eqOp2001);
            	addOrArray81 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray81.Tree);


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
            	// 243:36: -> ^( EqOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:243:39: ^( EqOp addOrArray addOrArray )
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
    // MyGrammar.g:246:1: nonEqOp : addOrArray NONEQ addOrArray -> ^( NonEqOp addOrArray addOrArray ) ;
    public MyGrammarParser.nonEqOp_return nonEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.nonEqOp_return retval = new MyGrammarParser.nonEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NONEQ83 = null;
        MyGrammarParser.addOrArray_return addOrArray82 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray84 = default(MyGrammarParser.addOrArray_return);


        object NONEQ83_tree=null;
        RewriteRuleTokenStream stream_NONEQ = new RewriteRuleTokenStream(adaptor,"token NONEQ");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:246:12: ( addOrArray NONEQ addOrArray -> ^( NonEqOp addOrArray addOrArray ) )
            // MyGrammar.g:246:14: addOrArray NONEQ addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_nonEqOp2031);
            	addOrArray82 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray82.Tree);
            	NONEQ83=(IToken)Match(input,NONEQ,FOLLOW_NONEQ_in_nonEqOp2033); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NONEQ.Add(NONEQ83);

            	PushFollow(FOLLOW_addOrArray_in_nonEqOp2035);
            	addOrArray84 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray84.Tree);


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
            	// 246:42: -> ^( NonEqOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:246:45: ^( NonEqOp addOrArray addOrArray )
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
    // MyGrammar.g:249:1: moreOp : addOrArray MORE addOrArray -> ^( MoreOp addOrArray addOrArray ) ;
    public MyGrammarParser.moreOp_return moreOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreOp_return retval = new MyGrammarParser.moreOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MORE86 = null;
        MyGrammarParser.addOrArray_return addOrArray85 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray87 = default(MyGrammarParser.addOrArray_return);


        object MORE86_tree=null;
        RewriteRuleTokenStream stream_MORE = new RewriteRuleTokenStream(adaptor,"token MORE");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:249:11: ( addOrArray MORE addOrArray -> ^( MoreOp addOrArray addOrArray ) )
            // MyGrammar.g:249:14: addOrArray MORE addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_moreOp2066);
            	addOrArray85 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray85.Tree);
            	MORE86=(IToken)Match(input,MORE,FOLLOW_MORE_in_moreOp2068); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MORE.Add(MORE86);

            	PushFollow(FOLLOW_addOrArray_in_moreOp2070);
            	addOrArray87 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray87.Tree);


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
            	// 249:41: -> ^( MoreOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:249:44: ^( MoreOp addOrArray addOrArray )
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
    // MyGrammar.g:252:1: moreEqOp : addOrArray MOREEQ addOrArray -> ^( MoreEqOp addOrArray addOrArray ) ;
    public MyGrammarParser.moreEqOp_return moreEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.moreEqOp_return retval = new MyGrammarParser.moreEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MOREEQ89 = null;
        MyGrammarParser.addOrArray_return addOrArray88 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray90 = default(MyGrammarParser.addOrArray_return);


        object MOREEQ89_tree=null;
        RewriteRuleTokenStream stream_MOREEQ = new RewriteRuleTokenStream(adaptor,"token MOREEQ");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:252:12: ( addOrArray MOREEQ addOrArray -> ^( MoreEqOp addOrArray addOrArray ) )
            // MyGrammar.g:252:14: addOrArray MOREEQ addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_moreEqOp2099);
            	addOrArray88 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray88.Tree);
            	MOREEQ89=(IToken)Match(input,MOREEQ,FOLLOW_MOREEQ_in_moreEqOp2101); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MOREEQ.Add(MOREEQ89);

            	PushFollow(FOLLOW_addOrArray_in_moreEqOp2103);
            	addOrArray90 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray90.Tree);


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
            	// 252:43: -> ^( MoreEqOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:252:46: ^( MoreEqOp addOrArray addOrArray )
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
    // MyGrammar.g:255:1: lessOp : addOrArray LESS addOrArray -> ^( LessOp addOrArray addOrArray ) ;
    public MyGrammarParser.lessOp_return lessOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessOp_return retval = new MyGrammarParser.lessOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESS92 = null;
        MyGrammarParser.addOrArray_return addOrArray91 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray93 = default(MyGrammarParser.addOrArray_return);


        object LESS92_tree=null;
        RewriteRuleTokenStream stream_LESS = new RewriteRuleTokenStream(adaptor,"token LESS");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:255:11: ( addOrArray LESS addOrArray -> ^( LessOp addOrArray addOrArray ) )
            // MyGrammar.g:255:13: addOrArray LESS addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_lessOp2133);
            	addOrArray91 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray91.Tree);
            	LESS92=(IToken)Match(input,LESS,FOLLOW_LESS_in_lessOp2135); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LESS.Add(LESS92);

            	PushFollow(FOLLOW_addOrArray_in_lessOp2137);
            	addOrArray93 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray93.Tree);


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
            	// 255:40: -> ^( LessOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:255:43: ^( LessOp addOrArray addOrArray )
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
    // MyGrammar.g:258:1: lessEqOp : addOrArray LESSEQ addOrArray -> ^( LessEqOp addOrArray addOrArray ) ;
    public MyGrammarParser.lessEqOp_return lessEqOp() // throws RecognitionException [1]
    {   
        MyGrammarParser.lessEqOp_return retval = new MyGrammarParser.lessEqOp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSEQ95 = null;
        MyGrammarParser.addOrArray_return addOrArray94 = default(MyGrammarParser.addOrArray_return);

        MyGrammarParser.addOrArray_return addOrArray96 = default(MyGrammarParser.addOrArray_return);


        object LESSEQ95_tree=null;
        RewriteRuleTokenStream stream_LESSEQ = new RewriteRuleTokenStream(adaptor,"token LESSEQ");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:258:12: ( addOrArray LESSEQ addOrArray -> ^( LessEqOp addOrArray addOrArray ) )
            // MyGrammar.g:258:14: addOrArray LESSEQ addOrArray
            {
            	PushFollow(FOLLOW_addOrArray_in_lessEqOp2166);
            	addOrArray94 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray94.Tree);
            	LESSEQ95=(IToken)Match(input,LESSEQ,FOLLOW_LESSEQ_in_lessEqOp2168); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LESSEQ.Add(LESSEQ95);

            	PushFollow(FOLLOW_addOrArray_in_lessEqOp2170);
            	addOrArray96 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray96.Tree);


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
            	// 258:43: -> ^( LessEqOp addOrArray addOrArray )
            	{
            	    // MyGrammar.g:258:46: ^( LessEqOp addOrArray addOrArray )
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
    // MyGrammar.g:263:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_97 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_98 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:263:7: ( for_ | while_ )
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
                    // MyGrammar.g:263:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle2199);
                    	for_97 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_97.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:264:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle2205);
                    	while_98 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_98.Tree);

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
    // MyGrammar.g:268:1: for_ : FOR '(' varInitOrChangeValue ';' logicOperator ';' fieldInitValue ')' block -> ^( For varInitOrChangeValue logicOperator fieldInitValue block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR99 = null;
        IToken char_literal100 = null;
        IToken char_literal102 = null;
        IToken char_literal104 = null;
        IToken char_literal106 = null;
        MyGrammarParser.varInitOrChangeValue_return varInitOrChangeValue101 = default(MyGrammarParser.varInitOrChangeValue_return);

        MyGrammarParser.logicOperator_return logicOperator103 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.fieldInitValue_return fieldInitValue105 = default(MyGrammarParser.fieldInitValue_return);

        MyGrammarParser.block_return block107 = default(MyGrammarParser.block_return);


        object FOR99_tree=null;
        object char_literal100_tree=null;
        object char_literal102_tree=null;
        object char_literal104_tree=null;
        object char_literal106_tree=null;
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_fieldInitValue = new RewriteRuleSubtreeStream(adaptor,"rule fieldInitValue");
        RewriteRuleSubtreeStream stream_varInitOrChangeValue = new RewriteRuleSubtreeStream(adaptor,"rule varInitOrChangeValue");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:268:6: ( FOR '(' varInitOrChangeValue ';' logicOperator ';' fieldInitValue ')' block -> ^( For varInitOrChangeValue logicOperator fieldInitValue block ) )
            // MyGrammar.g:268:8: FOR '(' varInitOrChangeValue ';' logicOperator ';' fieldInitValue ')' block
            {
            	FOR99=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_2217); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR99);

            	char_literal100=(IToken)Match(input,85,FOLLOW_85_in_for_2232); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(char_literal100);

            	PushFollow(FOLLOW_varInitOrChangeValue_in_for_2241);
            	varInitOrChangeValue101 = varInitOrChangeValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitOrChangeValue.Add(varInitOrChangeValue101.Tree);
            	char_literal102=(IToken)Match(input,89,FOLLOW_89_in_for_2243); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_89.Add(char_literal102);

            	PushFollow(FOLLOW_logicOperator_in_for_2248);
            	logicOperator103 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator103.Tree);
            	char_literal104=(IToken)Match(input,89,FOLLOW_89_in_for_2250); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_89.Add(char_literal104);

            	PushFollow(FOLLOW_fieldInitValue_in_for_2258);
            	fieldInitValue105 = fieldInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fieldInitValue.Add(fieldInitValue105.Tree);
            	char_literal106=(IToken)Match(input,86,FOLLOW_86_in_for_2263); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal106);

            	PushFollow(FOLLOW_block_in_for_2268);
            	block107 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block107.Tree);


            	// AST REWRITE
            	// elements:          varInitOrChangeValue, block, logicOperator, fieldInitValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 275:4: -> ^( For varInitOrChangeValue logicOperator fieldInitValue block )
            	{
            	    // MyGrammar.g:275:7: ^( For varInitOrChangeValue logicOperator fieldInitValue block )
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
    // MyGrammar.g:278:1: varInitOrChangeValue : ( varChangeValue | varInit );
    public MyGrammarParser.varInitOrChangeValue_return varInitOrChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInitOrChangeValue_return retval = new MyGrammarParser.varInitOrChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.varChangeValue_return varChangeValue108 = default(MyGrammarParser.varChangeValue_return);

        MyGrammarParser.varInit_return varInit109 = default(MyGrammarParser.varInit_return);



        try 
    	{
            // MyGrammar.g:278:22: ( varChangeValue | varInit )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == ID) )
            {
                alt17 = 1;
            }
            else if ( ((LA17_0 >= INT && LA17_0 <= VOID)) )
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
                    // MyGrammar.g:278:24: varChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varChangeValue_in_varInitOrChangeValue2299);
                    	varChangeValue108 = varChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varChangeValue108.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:279:9: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_varInitOrChangeValue2309);
                    	varInit109 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit109.Tree);

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
    // MyGrammar.g:282:1: while_ : WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE110 = null;
        IToken char_literal111 = null;
        IToken char_literal113 = null;
        MyGrammarParser.logicOperator_return logicOperator112 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block114 = default(MyGrammarParser.block_return);


        object WHILE110_tree=null;
        object char_literal111_tree=null;
        object char_literal113_tree=null;
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:282:8: ( WHILE '(' logicOperator ')' block -> ^( While_ logicOperator block ) )
            // MyGrammar.g:282:10: WHILE '(' logicOperator ')' block
            {
            	WHILE110=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_2324); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE110);

            	char_literal111=(IToken)Match(input,85,FOLLOW_85_in_while_2329); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(char_literal111);

            	PushFollow(FOLLOW_logicOperator_in_while_2334);
            	logicOperator112 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator112.Tree);
            	char_literal113=(IToken)Match(input,86,FOLLOW_86_in_while_2339); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(char_literal113);

            	PushFollow(FOLLOW_block_in_while_2344);
            	block114 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block114.Tree);


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
            	// 287:4: -> ^( While_ logicOperator block )
            	{
            	    // MyGrammar.g:287:7: ^( While_ logicOperator block )
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
    // MyGrammar.g:293:1: methodDef : type ID '()' block -> ^( Method ^( ID ( type )? block ) ) ;
    public MyGrammarParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        MyGrammarParser.methodDef_return retval = new MyGrammarParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID116 = null;
        IToken string_literal117 = null;
        MyGrammarParser.type_return type115 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block118 = default(MyGrammarParser.block_return);


        object ID116_tree=null;
        object string_literal117_tree=null;
        RewriteRuleTokenStream stream_90 = new RewriteRuleTokenStream(adaptor,"token 90");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:293:11: ( type ID '()' block -> ^( Method ^( ID ( type )? block ) ) )
            // MyGrammar.g:293:13: type ID '()' block
            {
            	PushFollow(FOLLOW_type_in_methodDef2376);
            	type115 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type115.Tree);
            	ID116=(IToken)Match(input,ID,FOLLOW_ID_in_methodDef2378); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID116);

            	string_literal117=(IToken)Match(input,90,FOLLOW_90_in_methodDef2380); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_90.Add(string_literal117);

            	PushFollow(FOLLOW_block_in_methodDef2382);
            	block118 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block118.Tree);


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
            	// 293:32: -> ^( Method ^( ID ( type )? block ) )
            	{
            	    // MyGrammar.g:293:35: ^( Method ^( ID ( type )? block ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(Method), root_1);

            	    // MyGrammar.g:293:59: ^( ID ( type )? block )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:293:64: ( type )?
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
    // MyGrammar.g:297:1: callMethod : ID '()' -> ^( CallMethod ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID119 = null;
        IToken string_literal120 = null;

        object ID119_tree=null;
        object string_literal120_tree=null;
        RewriteRuleTokenStream stream_90 = new RewriteRuleTokenStream(adaptor,"token 90");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:297:12: ( ID '()' -> ^( CallMethod ID ) )
            // MyGrammar.g:297:14: ID '()'
            {
            	ID119=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod2412); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID119);

            	string_literal120=(IToken)Match(input,90,FOLLOW_90_in_callMethod2414); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_90.Add(string_literal120);



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
            	// 298:5: -> ^( CallMethod ID )
            	{
            	    // MyGrammar.g:298:8: ^( CallMethod ID )
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
    // MyGrammar.g:303:1: printExpr : ( add | ident | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add121 = default(MyGrammarParser.add_return);

        MyGrammarParser.ident_return ident122 = default(MyGrammarParser.ident_return);

        MyGrammarParser.callMethod_return callMethod123 = default(MyGrammarParser.callMethod_return);



        try 
    	{
            // MyGrammar.g:303:11: ( add | ident | callMethod )
            int alt18 = 3;
            int LA18_0 = input.LA(1);

            if ( ((LA18_0 >= INTEGER && LA18_0 <= DOUBLE_) || LA18_0 == 85) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == ID) )
            {
                int LA18_2 = input.LA(2);

                if ( (LA18_2 == 90) )
                {
                    alt18 = 3;
                }
                else if ( (synpred45_MyGrammar()) )
                {
                    alt18 = 1;
                }
                else if ( (synpred46_MyGrammar()) )
                {
                    alt18 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d18s2 =
                        new NoViableAltException("", 18, 2, input);

                    throw nvae_d18s2;
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
                    // MyGrammar.g:303:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr2444);
                    	add121 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add121.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:304:6: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_printExpr2451);
                    	ident122 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident122.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:305:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr2458);
                    	callMethod123 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod123.Tree);

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
    // MyGrammar.g:308:1: changeValue : ( varChangeValue | arrayChangeValue );
    public MyGrammarParser.changeValue_return changeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.changeValue_return retval = new MyGrammarParser.changeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.varChangeValue_return varChangeValue124 = default(MyGrammarParser.varChangeValue_return);

        MyGrammarParser.arrayChangeValue_return arrayChangeValue125 = default(MyGrammarParser.arrayChangeValue_return);



        try 
    	{
            // MyGrammar.g:308:14: ( varChangeValue | arrayChangeValue )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == ID) )
            {
                int LA19_1 = input.LA(2);

                if ( (LA19_1 == ASSIGN) )
                {
                    alt19 = 1;
                }
                else if ( (LA19_1 == 83) )
                {
                    alt19 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d19s1 =
                        new NoViableAltException("", 19, 1, input);

                    throw nvae_d19s1;
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
                    // MyGrammar.g:308:16: varChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varChangeValue_in_changeValue2473);
                    	varChangeValue124 = varChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varChangeValue124.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:309:7: arrayChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayChangeValue_in_changeValue2481);
                    	arrayChangeValue125 = arrayChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayChangeValue125.Tree);

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
    // MyGrammar.g:312:1: varChangeValue : ident ASSIGN initValue -> ^( Assign ident initValue ) ;
    public MyGrammarParser.varChangeValue_return varChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.varChangeValue_return retval = new MyGrammarParser.varChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN127 = null;
        MyGrammarParser.ident_return ident126 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue128 = default(MyGrammarParser.initValue_return);


        object ASSIGN127_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:312:16: ( ident ASSIGN initValue -> ^( Assign ident initValue ) )
            // MyGrammar.g:312:18: ident ASSIGN initValue
            {
            	PushFollow(FOLLOW_ident_in_varChangeValue2494);
            	ident126 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident126.Tree);
            	ASSIGN127=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_varChangeValue2496); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN127);

            	PushFollow(FOLLOW_initValue_in_varChangeValue2498);
            	initValue128 = initValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_initValue.Add(initValue128.Tree);


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
            	// 313:7: -> ^( Assign ident initValue )
            	{
            	    // MyGrammar.g:313:10: ^( Assign ident initValue )
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
    // MyGrammar.g:316:1: arrayChangeValue : ident '[' add ']' ( ASSIGN initValue )? -> ^( ArrayInit ident add ( initValue )? ) ;
    public MyGrammarParser.arrayChangeValue_return arrayChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.arrayChangeValue_return retval = new MyGrammarParser.arrayChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal130 = null;
        IToken char_literal132 = null;
        IToken ASSIGN133 = null;
        MyGrammarParser.ident_return ident129 = default(MyGrammarParser.ident_return);

        MyGrammarParser.add_return add131 = default(MyGrammarParser.add_return);

        MyGrammarParser.initValue_return initValue134 = default(MyGrammarParser.initValue_return);


        object char_literal130_tree=null;
        object char_literal132_tree=null;
        object ASSIGN133_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:316:18: ( ident '[' add ']' ( ASSIGN initValue )? -> ^( ArrayInit ident add ( initValue )? ) )
            // MyGrammar.g:316:20: ident '[' add ']' ( ASSIGN initValue )?
            {
            	PushFollow(FOLLOW_ident_in_arrayChangeValue2530);
            	ident129 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident129.Tree);
            	char_literal130=(IToken)Match(input,83,FOLLOW_83_in_arrayChangeValue2532); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(char_literal130);

            	PushFollow(FOLLOW_add_in_arrayChangeValue2534);
            	add131 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add131.Tree);
            	char_literal132=(IToken)Match(input,84,FOLLOW_84_in_arrayChangeValue2536); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(char_literal132);

            	// MyGrammar.g:316:38: ( ASSIGN initValue )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == ASSIGN) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // MyGrammar.g:316:39: ASSIGN initValue
            	        {
            	        	ASSIGN133=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_arrayChangeValue2539); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN133);

            	        	PushFollow(FOLLOW_initValue_in_arrayChangeValue2542);
            	        	initValue134 = initValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initValue.Add(initValue134.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ident, initValue, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 317:8: -> ^( ArrayInit ident add ( initValue )? )
            	{
            	    // MyGrammar.g:317:11: ^( ArrayInit ident add ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ArrayInitNode(ArrayInit), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    adaptor.AddChild(root_1, stream_add.NextTree());
            	    // MyGrammar.g:317:48: ( initValue )?
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
    // MyGrammar.g:320:1: addOrArray : ( add | arrayChangeValue );
    public MyGrammarParser.addOrArray_return addOrArray() // throws RecognitionException [1]
    {   
        MyGrammarParser.addOrArray_return retval = new MyGrammarParser.addOrArray_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add135 = default(MyGrammarParser.add_return);

        MyGrammarParser.arrayChangeValue_return arrayChangeValue136 = default(MyGrammarParser.arrayChangeValue_return);



        try 
    	{
            // MyGrammar.g:320:13: ( add | arrayChangeValue )
            int alt21 = 2;
            int LA21_0 = input.LA(1);

            if ( ((LA21_0 >= INTEGER && LA21_0 <= DOUBLE_) || LA21_0 == 85) )
            {
                alt21 = 1;
            }
            else if ( (LA21_0 == ID) )
            {
                int LA21_2 = input.LA(2);

                if ( (LA21_2 == EOF || (LA21_2 >= PRINT && LA21_2 <= IF) || (LA21_2 >= INT && LA21_2 <= VOID) || (LA21_2 >= FOR && LA21_2 <= WHILE) || (LA21_2 >= AND && LA21_2 <= ID) || (LA21_2 >= 85 && LA21_2 <= 86) || (LA21_2 >= 88 && LA21_2 <= 89)) )
                {
                    alt21 = 1;
                }
                else if ( (LA21_2 == 83) )
                {
                    alt21 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d21s2 =
                        new NoViableAltException("", 21, 2, input);

                    throw nvae_d21s2;
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
                    // MyGrammar.g:320:15: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_addOrArray2584);
                    	add135 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add135.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:321:7: arrayChangeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayChangeValue_in_addOrArray2592);
                    	arrayChangeValue136 = arrayChangeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayChangeValue136.Tree);

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
    // MyGrammar.g:324:1: print : PRINT addOrArray -> ^( Print addOrArray ) ;
    public MyGrammarParser.print_return print() // throws RecognitionException [1]
    {   
        MyGrammarParser.print_return retval = new MyGrammarParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINT137 = null;
        MyGrammarParser.addOrArray_return addOrArray138 = default(MyGrammarParser.addOrArray_return);


        object PRINT137_tree=null;
        RewriteRuleTokenStream stream_PRINT = new RewriteRuleTokenStream(adaptor,"token PRINT");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:324:8: ( PRINT addOrArray -> ^( Print addOrArray ) )
            // MyGrammar.g:324:10: PRINT addOrArray
            {
            	PRINT137=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print2606); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINT.Add(PRINT137);

            	PushFollow(FOLLOW_addOrArray_in_print2608);
            	addOrArray138 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray138.Tree);


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
            	// 325:6: -> ^( Print addOrArray )
            	{
            	    // MyGrammar.g:325:9: ^( Print addOrArray )
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
    // MyGrammar.g:328:1: println : PRINTLN addOrArray -> ^( Println addOrArray ) ;
    public MyGrammarParser.println_return println() // throws RecognitionException [1]
    {   
        MyGrammarParser.println_return retval = new MyGrammarParser.println_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINTLN139 = null;
        MyGrammarParser.addOrArray_return addOrArray140 = default(MyGrammarParser.addOrArray_return);


        object PRINTLN139_tree=null;
        RewriteRuleTokenStream stream_PRINTLN = new RewriteRuleTokenStream(adaptor,"token PRINTLN");
        RewriteRuleSubtreeStream stream_addOrArray = new RewriteRuleSubtreeStream(adaptor,"rule addOrArray");
        try 
    	{
            // MyGrammar.g:328:10: ( PRINTLN addOrArray -> ^( Println addOrArray ) )
            // MyGrammar.g:328:12: PRINTLN addOrArray
            {
            	PRINTLN139=(IToken)Match(input,PRINTLN,FOLLOW_PRINTLN_in_println2637); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINTLN.Add(PRINTLN139);

            	PushFollow(FOLLOW_addOrArray_in_println2639);
            	addOrArray140 = addOrArray();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_addOrArray.Add(addOrArray140.Tree);


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
            	// 329:6: -> ^( Println addOrArray )
            	{
            	    // MyGrammar.g:329:9: ^( Println addOrArray )
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
    // MyGrammar.g:332:1: nextLine : NEXTLINE -> NextLine ;
    public MyGrammarParser.nextLine_return nextLine() // throws RecognitionException [1]
    {   
        MyGrammarParser.nextLine_return retval = new MyGrammarParser.nextLine_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEXTLINE141 = null;

        object NEXTLINE141_tree=null;
        RewriteRuleTokenStream stream_NEXTLINE = new RewriteRuleTokenStream(adaptor,"token NEXTLINE");

        try 
    	{
            // MyGrammar.g:332:10: ( NEXTLINE -> NextLine )
            // MyGrammar.g:332:12: NEXTLINE
            {
            	NEXTLINE141=(IToken)Match(input,NEXTLINE,FOLLOW_NEXTLINE_in_nextLine2667); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NEXTLINE.Add(NEXTLINE141);



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
            	// 333:6: -> NextLine
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
    // MyGrammar.g:336:1: expr : ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | println | nextLine | changeValue );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add142 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_143 = default(MyGrammarParser.if__return);

        MyGrammarParser.init_return init144 = default(MyGrammarParser.init_return);

        MyGrammarParser.arrayInit_return arrayInit145 = default(MyGrammarParser.arrayInit_return);

        MyGrammarParser.cycle_return cycle146 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.fieldInitValue_return fieldInitValue147 = default(MyGrammarParser.fieldInitValue_return);

        MyGrammarParser.callMethod_return callMethod148 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print149 = default(MyGrammarParser.print_return);

        MyGrammarParser.println_return println150 = default(MyGrammarParser.println_return);

        MyGrammarParser.nextLine_return nextLine151 = default(MyGrammarParser.nextLine_return);

        MyGrammarParser.changeValue_return changeValue152 = default(MyGrammarParser.changeValue_return);



        try 
    	{
            // MyGrammar.g:336:6: ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | println | nextLine | changeValue )
            int alt22 = 11;
            alt22 = dfa22.Predict(input);
            switch (alt22) 
            {
                case 1 :
                    // MyGrammar.g:336:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr2691);
                    	add142 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add142.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:337:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr2697);
                    	if_143 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_143.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:338:5: init
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_init_in_expr2703);
                    	init144 = init();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, init144.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:339:5: arrayInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_expr2709);
                    	arrayInit145 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit145.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:340:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr2715);
                    	cycle146 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle146.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:341:5: fieldInitValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_fieldInitValue_in_expr2721);
                    	fieldInitValue147 = fieldInitValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fieldInitValue147.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:342:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr2727);
                    	callMethod148 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod148.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:343:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr2733);
                    	print149 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print149.Tree);

                    }
                    break;
                case 9 :
                    // MyGrammar.g:344:5: println
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_println_in_expr2739);
                    	println150 = println();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, println150.Tree);

                    }
                    break;
                case 10 :
                    // MyGrammar.g:345:5: nextLine
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nextLine_in_expr2745);
                    	nextLine151 = nextLine();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nextLine151.Tree);

                    }
                    break;
                case 11 :
                    // MyGrammar.g:346:5: changeValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_changeValue_in_expr2751);
                    	changeValue152 = changeValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, changeValue152.Tree);

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
    // MyGrammar.g:349:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal154 = null;
        MyGrammarParser.expr_return expr153 = default(MyGrammarParser.expr_return);


        object char_literal154_tree=null;

        try 
    	{
            // MyGrammar.g:349:6: ( expr ( ';' )* )
            // MyGrammar.g:349:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line2762);
            	expr153 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr153.Tree);
            	// MyGrammar.g:349:13: ( ';' )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == 89) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // MyGrammar.g:349:14: ';'
            			    {
            			    	char_literal154=(IToken)Match(input,89,FOLLOW_89_in_line2765); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements


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
    // MyGrammar.g:352:1: exprList : ( methodDef ( ';' )* | varInit ( ';' )* | arrayInit ( ';' )* );
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal156 = null;
        IToken char_literal158 = null;
        IToken char_literal160 = null;
        MyGrammarParser.methodDef_return methodDef155 = default(MyGrammarParser.methodDef_return);

        MyGrammarParser.varInit_return varInit157 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.arrayInit_return arrayInit159 = default(MyGrammarParser.arrayInit_return);


        object char_literal156_tree=null;
        object char_literal158_tree=null;
        object char_literal160_tree=null;

        try 
    	{
            // MyGrammar.g:352:9: ( methodDef ( ';' )* | varInit ( ';' )* | arrayInit ( ';' )* )
            int alt27 = 3;
            int LA27_0 = input.LA(1);

            if ( ((LA27_0 >= INT && LA27_0 <= VOID)) )
            {
                int LA27_1 = input.LA(2);

                if ( (LA27_1 == ID) )
                {
                    int LA27_2 = input.LA(3);

                    if ( (LA27_2 == 90) )
                    {
                        alt27 = 1;
                    }
                    else if ( (LA27_2 == EOF || LA27_2 == ASSIGN || (LA27_2 >= INT && LA27_2 <= VOID) || LA27_2 == 89) )
                    {
                        alt27 = 2;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d27s2 =
                            new NoViableAltException("", 27, 2, input);

                        throw nvae_d27s2;
                    }
                }
                else if ( (LA27_1 == 82) )
                {
                    alt27 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d27s1 =
                        new NoViableAltException("", 27, 1, input);

                    throw nvae_d27s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d27s0 =
                    new NoViableAltException("", 27, 0, input);

                throw nvae_d27s0;
            }
            switch (alt27) 
            {
                case 1 :
                    // MyGrammar.g:352:11: methodDef ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodDef_in_exprList2779);
                    	methodDef155 = methodDef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef155.Tree);
                    	// MyGrammar.g:352:22: ( ';' )*
                    	do 
                    	{
                    	    int alt24 = 2;
                    	    int LA24_0 = input.LA(1);

                    	    if ( (LA24_0 == 89) )
                    	    {
                    	        alt24 = 1;
                    	    }


                    	    switch (alt24) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:352:23: ';'
                    			    {
                    			    	char_literal156=(IToken)Match(input,89,FOLLOW_89_in_exprList2783); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop24;
                    	    }
                    	} while (true);

                    	loop24:
                    		;	// Stops C# compiler whining that label 'loop24' has no statements


                    }
                    break;
                case 2 :
                    // MyGrammar.g:353:5: varInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_exprList2793);
                    	varInit157 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit157.Tree);
                    	// MyGrammar.g:353:13: ( ';' )*
                    	do 
                    	{
                    	    int alt25 = 2;
                    	    int LA25_0 = input.LA(1);

                    	    if ( (LA25_0 == 89) )
                    	    {
                    	        alt25 = 1;
                    	    }


                    	    switch (alt25) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:353:14: ';'
                    			    {
                    			    	char_literal158=(IToken)Match(input,89,FOLLOW_89_in_exprList2796); if (state.failed) return retval;

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
                case 3 :
                    // MyGrammar.g:354:5: arrayInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayInit_in_exprList2806);
                    	arrayInit159 = arrayInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayInit159.Tree);
                    	// MyGrammar.g:354:15: ( ';' )*
                    	do 
                    	{
                    	    int alt26 = 2;
                    	    int LA26_0 = input.LA(1);

                    	    if ( (LA26_0 == 89) )
                    	    {
                    	        alt26 = 1;
                    	    }


                    	    switch (alt26) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:354:16: ';'
                    			    {
                    			    	char_literal160=(IToken)Match(input,89,FOLLOW_89_in_exprList2809); if (state.failed) return retval;

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
    // MyGrammar.g:360:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList161 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:360:13: ( ( exprList )* )
            // MyGrammar.g:361:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:361:4: ( exprList )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( ((LA28_0 >= INT && LA28_0 <= VOID)) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm2830);
            			    	exprList161 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList161.Tree);

            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements


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
    // MyGrammar.g:364:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm162 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:364:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:365:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program2844);
            	fullProgramm162 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm162.Tree);


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
            	// 365:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:365:19: ^( PROGRAM fullProgramm )
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
    // MyGrammar.g:368:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program163 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:368:8: ( program )
            // MyGrammar.g:369:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute2862);
            	program163 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program163.Tree);

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
        // MyGrammar.g:179:14: ( addOrArray )
        // MyGrammar.g:179:14: addOrArray
        {
        	PushFollow(FOLLOW_addOrArray_in_synpred17_MyGrammar1407);
        	addOrArray();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_MyGrammar"

    // $ANTLR start "synpred19_MyGrammar"
    public void synpred19_MyGrammar_fragment() {
        // MyGrammar.g:181:7: ( ident )
        // MyGrammar.g:181:7: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred19_MyGrammar1423);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_MyGrammar"

    // $ANTLR start "synpred29_MyGrammar"
    public void synpred29_MyGrammar_fragment() {
        // MyGrammar.g:216:16: ( orOperation )
        // MyGrammar.g:216:16: orOperation
        {
        	PushFollow(FOLLOW_orOperation_in_synpred29_MyGrammar1683);
        	orOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred29_MyGrammar"

    // $ANTLR start "synpred30_MyGrammar"
    public void synpred30_MyGrammar_fragment() {
        // MyGrammar.g:217:8: ( andOperation )
        // MyGrammar.g:217:8: andOperation
        {
        	PushFollow(FOLLOW_andOperation_in_synpred30_MyGrammar1703);
        	andOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_MyGrammar"

    // $ANTLR start "synpred31_MyGrammar"
    public void synpred31_MyGrammar_fragment() {
        // MyGrammar.g:218:8: ( eqOp )
        // MyGrammar.g:218:8: eqOp
        {
        	PushFollow(FOLLOW_eqOp_in_synpred31_MyGrammar1723);
        	eqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_MyGrammar"

    // $ANTLR start "synpred32_MyGrammar"
    public void synpred32_MyGrammar_fragment() {
        // MyGrammar.g:219:8: ( nonEqOp )
        // MyGrammar.g:219:8: nonEqOp
        {
        	PushFollow(FOLLOW_nonEqOp_in_synpred32_MyGrammar1743);
        	nonEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_MyGrammar"

    // $ANTLR start "synpred33_MyGrammar"
    public void synpred33_MyGrammar_fragment() {
        // MyGrammar.g:220:8: ( moreOp )
        // MyGrammar.g:220:8: moreOp
        {
        	PushFollow(FOLLOW_moreOp_in_synpred33_MyGrammar1763);
        	moreOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_MyGrammar"

    // $ANTLR start "synpred34_MyGrammar"
    public void synpred34_MyGrammar_fragment() {
        // MyGrammar.g:221:8: ( moreEqOp )
        // MyGrammar.g:221:8: moreEqOp
        {
        	PushFollow(FOLLOW_moreEqOp_in_synpred34_MyGrammar1783);
        	moreEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_MyGrammar"

    // $ANTLR start "synpred35_MyGrammar"
    public void synpred35_MyGrammar_fragment() {
        // MyGrammar.g:222:8: ( lessOp )
        // MyGrammar.g:222:8: lessOp
        {
        	PushFollow(FOLLOW_lessOp_in_synpred35_MyGrammar1803);
        	lessOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred35_MyGrammar"

    // $ANTLR start "synpred36_MyGrammar"
    public void synpred36_MyGrammar_fragment() {
        // MyGrammar.g:226:18: ( orOperation )
        // MyGrammar.g:226:18: orOperation
        {
        	PushFollow(FOLLOW_orOperation_in_synpred36_MyGrammar1851);
        	orOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred36_MyGrammar"

    // $ANTLR start "synpred37_MyGrammar"
    public void synpred37_MyGrammar_fragment() {
        // MyGrammar.g:227:8: ( andOperation )
        // MyGrammar.g:227:8: andOperation
        {
        	PushFollow(FOLLOW_andOperation_in_synpred37_MyGrammar1860);
        	andOperation();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred37_MyGrammar"

    // $ANTLR start "synpred38_MyGrammar"
    public void synpred38_MyGrammar_fragment() {
        // MyGrammar.g:228:8: ( eqOp )
        // MyGrammar.g:228:8: eqOp
        {
        	PushFollow(FOLLOW_eqOp_in_synpred38_MyGrammar1869);
        	eqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_MyGrammar"

    // $ANTLR start "synpred39_MyGrammar"
    public void synpred39_MyGrammar_fragment() {
        // MyGrammar.g:229:8: ( nonEqOp )
        // MyGrammar.g:229:8: nonEqOp
        {
        	PushFollow(FOLLOW_nonEqOp_in_synpred39_MyGrammar1878);
        	nonEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_MyGrammar"

    // $ANTLR start "synpred40_MyGrammar"
    public void synpred40_MyGrammar_fragment() {
        // MyGrammar.g:230:8: ( moreOp )
        // MyGrammar.g:230:8: moreOp
        {
        	PushFollow(FOLLOW_moreOp_in_synpred40_MyGrammar1887);
        	moreOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred40_MyGrammar"

    // $ANTLR start "synpred41_MyGrammar"
    public void synpred41_MyGrammar_fragment() {
        // MyGrammar.g:231:8: ( moreEqOp )
        // MyGrammar.g:231:8: moreEqOp
        {
        	PushFollow(FOLLOW_moreEqOp_in_synpred41_MyGrammar1896);
        	moreEqOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred41_MyGrammar"

    // $ANTLR start "synpred42_MyGrammar"
    public void synpred42_MyGrammar_fragment() {
        // MyGrammar.g:232:8: ( lessOp )
        // MyGrammar.g:232:8: lessOp
        {
        	PushFollow(FOLLOW_lessOp_in_synpred42_MyGrammar1905);
        	lessOp();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred42_MyGrammar"

    // $ANTLR start "synpred45_MyGrammar"
    public void synpred45_MyGrammar_fragment() {
        // MyGrammar.g:303:13: ( add )
        // MyGrammar.g:303:13: add
        {
        	PushFollow(FOLLOW_add_in_synpred45_MyGrammar2444);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred45_MyGrammar"

    // $ANTLR start "synpred46_MyGrammar"
    public void synpred46_MyGrammar_fragment() {
        // MyGrammar.g:304:6: ( ident )
        // MyGrammar.g:304:6: ident
        {
        	PushFollow(FOLLOW_ident_in_synpred46_MyGrammar2451);
        	ident();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred46_MyGrammar"

    // $ANTLR start "synpred50_MyGrammar"
    public void synpred50_MyGrammar_fragment() {
        // MyGrammar.g:336:8: ( add )
        // MyGrammar.g:336:8: add
        {
        	PushFollow(FOLLOW_add_in_synpred50_MyGrammar2691);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred50_MyGrammar"

    // $ANTLR start "synpred52_MyGrammar"
    public void synpred52_MyGrammar_fragment() {
        // MyGrammar.g:338:5: ( init )
        // MyGrammar.g:338:5: init
        {
        	PushFollow(FOLLOW_init_in_synpred52_MyGrammar2703);
        	init();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred52_MyGrammar"

    // $ANTLR start "synpred53_MyGrammar"
    public void synpred53_MyGrammar_fragment() {
        // MyGrammar.g:339:5: ( arrayInit )
        // MyGrammar.g:339:5: arrayInit
        {
        	PushFollow(FOLLOW_arrayInit_in_synpred53_MyGrammar2709);
        	arrayInit();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred53_MyGrammar"

    // $ANTLR start "synpred55_MyGrammar"
    public void synpred55_MyGrammar_fragment() {
        // MyGrammar.g:341:5: ( fieldInitValue )
        // MyGrammar.g:341:5: fieldInitValue
        {
        	PushFollow(FOLLOW_fieldInitValue_in_synpred55_MyGrammar2721);
        	fieldInitValue();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred55_MyGrammar"

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
   	public bool synpred55_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred55_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred46_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred46_MyGrammar_fragment(); // can never throw exception
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
   	public bool synpred53_MyGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred53_MyGrammar_fragment(); // can never throw exception
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
   	protected DFA22 dfa22;
	private void InitializeCyclicDFAs()
	{
    	this.dfa14 = new DFA14(this);
    	this.dfa15 = new DFA15(this);
    	this.dfa22 = new DFA22(this);
	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);
	    this.dfa15.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA15_SpecialStateTransition);
	    this.dfa22.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA22_SpecialStateTransition);
	}

    const string DFA14_eotS =
        "\x0d\uffff";
    const string DFA14_eofS =
        "\x0d\uffff";
    const string DFA14_minS =
        "\x01\x4e\x04\x00\x08\uffff";
    const string DFA14_maxS =
        "\x01\x55\x04\x00\x08\uffff";
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
            get { return "216:1: operations : ( orOperation -> ^( OrOp orOperation ) | andOperation -> ^( AndOp andOperation ) | eqOp -> ^( EqOp eqOp ) | nonEqOp -> ^( NonEqOp nonEqOp ) | moreOp -> ^( MoreOp moreOp ) | moreEqOp -> ^( MoreEqOp moreEqOp ) | lessOp -> ^( LessOp lessOp ) | lessEqOp -> ^( LessEqOp lessEqOp ) );"; }
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
        "\x01\x4e\x04\x00\x08\uffff";
    const string DFA15_maxS =
        "\x01\x55\x04\x00\x08\uffff";
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
            get { return "226:1: logicOperator : ( orOperation | andOperation | eqOp | nonEqOp | moreOp | moreEqOp | lessOp | lessEqOp );"; }
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
    const string DFA22_eotS =
        "\x10\uffff";
    const string DFA22_eofS =
        "\x10\uffff";
    const string DFA22_minS =
        "\x01\x23\x01\uffff\x01\x2f\x01\uffff\x01\x50\x07\uffff\x01\x50"+
        "\x01\uffff\x01\x00\x01\uffff";
    const string DFA22_maxS =
        "\x01\x55\x01\uffff\x01\x5a\x01\uffff\x01\x52\x07\uffff\x01\x50"+
        "\x01\uffff\x01\x00\x01\uffff";
    const string DFA22_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\uffff\x01\x05\x01\x08"+
        "\x01\x09\x01\x0a\x01\x07\x01\x0b\x01\x06\x01\uffff\x01\x03\x01\uffff"+
        "\x01\x04";
    const string DFA22_specialS =
        "\x02\uffff\x01\x01\x0b\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA22_transitionS = {
            "\x01\x06\x01\x07\x01\x08\x04\uffff\x01\x03\x0b\uffff\x05\x04"+
            "\x08\uffff\x02\x05\x09\uffff\x02\x01\x01\x02\x04\uffff\x01\x01",
            "",
            "\x01\x0a\x23\uffff\x01\x0a\x06\uffff\x01\x09",
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

    static readonly short[] DFA22_eot = DFA.UnpackEncodedString(DFA22_eotS);
    static readonly short[] DFA22_eof = DFA.UnpackEncodedString(DFA22_eofS);
    static readonly char[] DFA22_min = DFA.UnpackEncodedStringToUnsignedChars(DFA22_minS);
    static readonly char[] DFA22_max = DFA.UnpackEncodedStringToUnsignedChars(DFA22_maxS);
    static readonly short[] DFA22_accept = DFA.UnpackEncodedString(DFA22_acceptS);
    static readonly short[] DFA22_special = DFA.UnpackEncodedString(DFA22_specialS);
    static readonly short[][] DFA22_transition = DFA.UnpackEncodedStringArray(DFA22_transitionS);

    protected class DFA22 : DFA
    {
        public DFA22(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 22;
            this.eot = DFA22_eot;
            this.eof = DFA22_eof;
            this.min = DFA22_min;
            this.max = DFA22_max;
            this.accept = DFA22_accept;
            this.special = DFA22_special;
            this.transition = DFA22_transition;

        }

        override public string Description
        {
            get { return "336:1: expr : ( add | if_ | init | arrayInit | cycle | fieldInitValue | callMethod | print | println | nextLine | changeValue );"; }
        }

    }


    protected internal int DFA22_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA22_14 = input.LA(1);

                   	 
                   	int index22_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred52_MyGrammar()) ) { s = 13; }

                   	else if ( (synpred53_MyGrammar()) ) { s = 15; }

                   	 
                   	input.Seek(index22_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA22_2 = input.LA(1);

                   	 
                   	int index22_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA22_2 == 90) ) { s = 9; }

                   	else if ( (LA22_2 == ASSIGN || LA22_2 == 83) ) { s = 10; }

                   	else if ( (synpred50_MyGrammar()) ) { s = 1; }

                   	else if ( (synpred55_MyGrammar()) ) { s = 11; }

                   	 
                   	input.Seek(index22_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae22 =
            new NoViableAltException(dfa.Description, 22, _s, input);
        dfa.Error(nvae22);
        throw nvae22;
    }
 

    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inc_in_incDec1014 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dec_in_incDec1020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_inc1033 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DECREMENT_in_dec1056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_in_number1147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE__in_number1164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_ident1229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_init1257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_init1264 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_arrayInit1275 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_arrayInit1277 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ident_in_arrayInit1279 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_arrayInit1282 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_NEW_in_arrayInit1284 = new BitSet(new ulong[]{0x07C0000000000000UL});
    public static readonly BitSet FOLLOW_type_in_arrayInit1286 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_arrayInit1288 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_add_in_arrayInit1290 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_arrayInit1292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_varInit1329 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_varInit1331 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_fieldInitValue1361 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_fieldInitValue1365 = new BitSet(new ulong[]{0x0030000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_initValue_in_fieldInitValue1367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_initValue1407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_initValue1415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_initValue1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_inc_in_initValue1431 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dec_in_initValue1439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_addOperation1453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_addOperation1468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multOperation1488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multOperation1503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_group1526 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_add_in_group1529 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_group1531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group1539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_group1545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult1560 = new BitSet(new ulong[]{0x0000030000000002UL});
    public static readonly BitSet FOLLOW_multOperation_in_mult1564 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_group_in_mult1567 = new BitSet(new ulong[]{0x0000030000000002UL});
    public static readonly BitSet FOLLOW_mult_in_add1579 = new BitSet(new ulong[]{0x000000C000000002UL});
    public static readonly BitSet FOLLOW_addOperation_in_add1583 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_mult_in_add1586 = new BitSet(new ulong[]{0x000000C000000002UL});
    public static readonly BitSet FOLLOW_87_in_block1598 = new BitSet(new ulong[]{0x07C0043800000000UL,0x000000000121C018UL});
    public static readonly BitSet FOLLOW_line_in_block1600 = new BitSet(new ulong[]{0x07C0043800000000UL,0x000000000121C018UL});
    public static readonly BitSet FOLLOW_88_in_block1603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_1628 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_if_1630 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_1632 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_if_1634 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_block_in_if_1636 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_if_1639 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_block_in_if_1641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_operations1683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_operations1703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_operations1723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_operations1743 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_operations1763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_operations1783 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_operations1803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_operations1823 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator1851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_logicOperator1860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_logicOperator1869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_logicOperator1878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_logicOperator1887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_logicOperator1896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_logicOperator1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessEqOp_in_logicOperator1914 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_orOperation1931 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_OR_in_orOperation1933 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_orOperation1935 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_andOperation1963 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_AND_in_andOperation1965 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_andOperation1967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_eqOp1997 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_EQ_in_eqOp1999 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_eqOp2001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_nonEqOp2031 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_NONEQ_in_nonEqOp2033 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_nonEqOp2035 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_moreOp2066 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_MORE_in_moreOp2068 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_moreOp2070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_moreEqOp2099 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_MOREEQ_in_moreEqOp2101 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_moreEqOp2103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_lessOp2133 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LESS_in_lessOp2135 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_lessOp2137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_lessEqOp2166 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LESSEQ_in_lessEqOp2168 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_lessEqOp2170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle2199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle2205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_2217 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_for_2232 = new BitSet(new ulong[]{0x07C0000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_varInitOrChangeValue_in_for_2241 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_for_2243 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_2248 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_for_2250 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_for_2258 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_for_2263 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_block_in_for_2268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varChangeValue_in_varInitOrChangeValue2299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_varInitOrChangeValue2309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_2324 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_while_2329 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_2334 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_while_2339 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_block_in_while_2344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_methodDef2376 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_methodDef2378 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_90_in_methodDef2380 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_block_in_methodDef2382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod2412 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_90_in_callMethod2414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr2444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_printExpr2451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr2458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varChangeValue_in_changeValue2473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayChangeValue_in_changeValue2481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_varChangeValue2494 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_varChangeValue2496 = new BitSet(new ulong[]{0x0030000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_initValue_in_varChangeValue2498 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_arrayChangeValue2530 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_arrayChangeValue2532 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_add_in_arrayChangeValue2534 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_arrayChangeValue2536 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_arrayChangeValue2539 = new BitSet(new ulong[]{0x0030000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_initValue_in_arrayChangeValue2542 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_addOrArray2584 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayChangeValue_in_addOrArray2592 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINT_in_print2606 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_print2608 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINTLN_in_println2637 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000021C000UL});
    public static readonly BitSet FOLLOW_addOrArray_in_println2639 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEXTLINE_in_nextLine2667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr2691 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr2697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_init_in_expr2703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_expr2709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr2715 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_expr2721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr2727 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr2733 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_println_in_expr2739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nextLine_in_expr2745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_changeValue_in_expr2751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line2762 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_line2765 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_methodDef_in_exprList2779 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_exprList2783 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_varInit_in_exprList2793 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_exprList2796 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_arrayInit_in_exprList2806 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_89_in_exprList2809 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm2830 = new BitSet(new ulong[]{0x07C0000000000002UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program2844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute2862 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_addOrArray_in_synpred17_MyGrammar1407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred19_MyGrammar1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_synpred29_MyGrammar1683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_synpred30_MyGrammar1703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_synpred31_MyGrammar1723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_synpred32_MyGrammar1743 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_synpred33_MyGrammar1763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_synpred34_MyGrammar1783 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_synpred35_MyGrammar1803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_synpred36_MyGrammar1851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_synpred37_MyGrammar1860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_eqOp_in_synpred38_MyGrammar1869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonEqOp_in_synpred39_MyGrammar1878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreOp_in_synpred40_MyGrammar1887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moreEqOp_in_synpred41_MyGrammar1896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lessOp_in_synpred42_MyGrammar1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred45_MyGrammar2444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_synpred46_MyGrammar2451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred50_MyGrammar2691 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_init_in_synpred52_MyGrammar2703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayInit_in_synpred53_MyGrammar2709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fieldInitValue_in_synpred55_MyGrammar2721 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}