// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-11-27 04:11:22

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
		"'||'", 
		"'&&'", 
		"'=='", 
		"'!='", 
		"'>'", 
		"'<'", 
		"'>='", 
		"'<='", 
		"'()'", 
		"';'"
    };

    public const int Add = 6;
    public const int PRINT = 15;
    public const int VAR = 36;
    public const int CallMethod = 13;
    public const int DECREMENT = 30;
    public const int MINUS = 17;
    public const int T__59 = 59;
    public const int MULT = 7;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int ELSE = 21;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int CALLMETHOD = 43;
    public const int ID = 49;
    public const int T__51 = 51;
    public const int Plus = 9;
    public const int T__52 = 52;
    public const int IF = 20;
    public const int TYPE = 41;
    public const int T__53 = 53;
    public const int MINUSASSIGN = 26;
    public const int T__54 = 54;
    public const int INTEGER = 47;
    public const int T__60 = 60;
    public const int T__61 = 61;
    public const int BLOCK = 22;
    public const int ONEARRAY = 37;
    public const int FOR = 44;
    public const int Method = 5;
    public const int Double = 12;
    public const int T__66 = 66;
    public const int PUBLIC = 40;
    public const int MULTIPLY = 18;
    public const int CONDITION = 23;
    public const int COUNT = 38;
    public const int T__62 = 62;
    public const int VOID = 35;
    public const int T__63 = 63;
    public const int T__64 = 64;
    public const int Minus = 10;
    public const int PROGRAM = 14;
    public const int T__65 = 65;
    public const int PLUS = 16;
    public const int DIVIDEASSIGN = 28;
    public const int FLOAT = 32;
    public const int MULTASSIGN = 27;
    public const int CHAR = 34;
    public const int ASSIGN = 24;
    public const int INT = 31;
    public const int DIVIDE = 19;
    public const int PLUSASSIGN = 25;
    public const int DOUBLE = 33;
    public const int WS = 50;
    public const int EOF = -1;
    public const int MOD = 42;
    public const int INCREMENT_ = 46;
    public const int DOUBLE_ = 48;
    public const int PRIVATE = 39;
    public const int VarInit = 4;
    public const int Integer = 11;
    public const int INCREMENT = 29;
    public const int Assign = 8;
    public const int WHILE = 45;

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
    // MyGrammar.g:69:1: type : ( INT | FLOAT | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:69:6: ( INT | FLOAT | DOUBLE | CHAR | VOID )
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
    // MyGrammar.g:77:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:77:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
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
    // MyGrammar.g:84:1: incDec : ( INCREMENT | DECREMENT );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set3 = null;

        object set3_tree=null;

        try 
    	{
            // MyGrammar.g:84:8: ( INCREMENT | DECREMENT )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set3 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INCREMENT && input.LA(1) <= DECREMENT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set3));
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
    // $ANTLR end "incDec"

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
    // MyGrammar.g:88:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set4 = null;

        object set4_tree=null;

        try 
    	{
            // MyGrammar.g:88:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set4 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PLUS && input.LA(1) <= DIVIDE) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set4));
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
    // MyGrammar.g:104:1: number : ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) );
    public MyGrammarParser.number_return number() // throws RecognitionException [1]
    {   
        MyGrammarParser.number_return retval = new MyGrammarParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INTEGER5 = null;
        IToken DOUBLE_6 = null;

        object INTEGER5_tree=null;
        object DOUBLE_6_tree=null;
        RewriteRuleTokenStream stream_DOUBLE_ = new RewriteRuleTokenStream(adaptor,"token DOUBLE_");
        RewriteRuleTokenStream stream_INTEGER = new RewriteRuleTokenStream(adaptor,"token INTEGER");

        try 
    	{
            // MyGrammar.g:104:8: ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == INTEGER) )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == DOUBLE_) )
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
                    // MyGrammar.g:104:10: INTEGER
                    {
                    	INTEGER5=(IToken)Match(input,INTEGER,FOLLOW_INTEGER_in_number738); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INTEGER.Add(INTEGER5);



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
                    	// 104:18: -> ^( Integer INTEGER )
                    	{
                    	    // MyGrammar.g:104:21: ^( Integer INTEGER )
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
                    // MyGrammar.g:105:5: DOUBLE_
                    {
                    	DOUBLE_6=(IToken)Match(input,DOUBLE_,FOLLOW_DOUBLE__in_number755); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DOUBLE_.Add(DOUBLE_6);



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
                    	// 105:13: -> ^( Double DOUBLE_ )
                    	{
                    	    // MyGrammar.g:105:16: ^( Double DOUBLE_ )
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
    // MyGrammar.g:112:1: varInit : type varInitValue -> ^( VarInit type varInitValue ) ;
    public MyGrammarParser.varInit_return varInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInit_return retval = new MyGrammarParser.varInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.type_return type7 = default(MyGrammarParser.type_return);

        MyGrammarParser.varInitValue_return varInitValue8 = default(MyGrammarParser.varInitValue_return);


        RewriteRuleSubtreeStream stream_varInitValue = new RewriteRuleSubtreeStream(adaptor,"rule varInitValue");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:112:9: ( type varInitValue -> ^( VarInit type varInitValue ) )
            // MyGrammar.g:112:11: type varInitValue
            {
            	PushFollow(FOLLOW_type_in_varInit819);
            	type7 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type7.Tree);
            	PushFollow(FOLLOW_varInitValue_in_varInit821);
            	varInitValue8 = varInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitValue.Add(varInitValue8.Tree);


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
            	// 113:5: -> ^( VarInit type varInitValue )
            	{
            	    // MyGrammar.g:113:8: ^( VarInit type varInitValue )
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
    // MyGrammar.g:117:1: varInitValue : ID ( ASSIGN initValue )? -> ^( Assign ID ( initValue )? ) ;
    public MyGrammarParser.varInitValue_return varInitValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInitValue_return retval = new MyGrammarParser.varInitValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID9 = null;
        IToken ASSIGN10 = null;
        MyGrammarParser.initValue_return initValue11 = default(MyGrammarParser.initValue_return);


        object ID9_tree=null;
        object ASSIGN10_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:117:14: ( ID ( ASSIGN initValue )? -> ^( Assign ID ( initValue )? ) )
            // MyGrammar.g:117:17: ID ( ASSIGN initValue )?
            {
            	ID9=(IToken)Match(input,ID,FOLLOW_ID_in_varInitValue851); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID9);

            	// MyGrammar.g:117:20: ( ASSIGN initValue )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == ASSIGN) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // MyGrammar.g:117:21: ASSIGN initValue
            	        {
            	        	ASSIGN10=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_varInitValue854); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN10);

            	        	PushFollow(FOLLOW_initValue_in_varInitValue856);
            	        	initValue11 = initValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initValue.Add(initValue11.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ID, initValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 118:7: -> ^( Assign ID ( initValue )? )
            	{
            	    // MyGrammar.g:118:10: ^( Assign ID ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AssignNode(Assign), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // MyGrammar.g:118:34: ( initValue )?
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
    // MyGrammar.g:121:1: initValue : ( add | callMethod );
    public MyGrammarParser.initValue_return initValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.initValue_return retval = new MyGrammarParser.initValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add12 = default(MyGrammarParser.add_return);

        MyGrammarParser.callMethod_return callMethod13 = default(MyGrammarParser.callMethod_return);



        try 
    	{
            // MyGrammar.g:121:12: ( add | callMethod )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= INTEGER && LA3_0 <= DOUBLE_) || LA3_0 == 53) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == ID) )
            {
                alt3 = 2;
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
                    // MyGrammar.g:121:14: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_initValue894);
                    	add12 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add12.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:122:7: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_initValue902);
                    	callMethod13 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod13.Tree);

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

    public class optionsChangeValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "optionsChangeValue"
    // MyGrammar.g:125:1: optionsChangeValue : ( incDec | ( typeAssign ( add )+ ) );
    public MyGrammarParser.optionsChangeValue_return optionsChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.optionsChangeValue_return retval = new MyGrammarParser.optionsChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.incDec_return incDec14 = default(MyGrammarParser.incDec_return);

        MyGrammarParser.typeAssign_return typeAssign15 = default(MyGrammarParser.typeAssign_return);

        MyGrammarParser.add_return add16 = default(MyGrammarParser.add_return);



        try 
    	{
            // MyGrammar.g:125:20: ( incDec | ( typeAssign ( add )+ ) )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( ((LA5_0 >= INCREMENT && LA5_0 <= DECREMENT)) )
            {
                alt5 = 1;
            }
            else if ( ((LA5_0 >= ASSIGN && LA5_0 <= DIVIDEASSIGN)) )
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
                    // MyGrammar.g:125:22: incDec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_incDec_in_optionsChangeValue915);
                    	incDec14 = incDec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, incDec14.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:126:8: ( typeAssign ( add )+ )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// MyGrammar.g:126:8: ( typeAssign ( add )+ )
                    	// MyGrammar.g:126:9: typeAssign ( add )+
                    	{
                    		PushFollow(FOLLOW_typeAssign_in_optionsChangeValue926);
                    		typeAssign15 = typeAssign();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(typeAssign15.Tree, root_0);
                    		// MyGrammar.g:126:21: ( add )+
                    		int cnt4 = 0;
                    		do 
                    		{
                    		    int alt4 = 2;
                    		    int LA4_0 = input.LA(1);

                    		    if ( ((LA4_0 >= INTEGER && LA4_0 <= DOUBLE_) || LA4_0 == 53) )
                    		    {
                    		        alt4 = 1;
                    		    }


                    		    switch (alt4) 
                    			{
                    				case 1 :
                    				    // MyGrammar.g:0:0: add
                    				    {
                    				    	PushFollow(FOLLOW_add_in_optionsChangeValue929);
                    				    	add16 = add();
                    				    	state.followingStackPointer--;
                    				    	if (state.failed) return retval;
                    				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add16.Tree);

                    				    }
                    				    break;

                    				default:
                    				    if ( cnt4 >= 1 ) goto loop4;
                    				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			            EarlyExitException eee4 =
                    			                new EarlyExitException(4, input);
                    			            throw eee4;
                    		    }
                    		    cnt4++;
                    		} while (true);

                    		loop4:
                    			;	// Stops C# compiler whining that label 'loop4' has no statements


                    	}


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
    // $ANTLR end "optionsChangeValue"

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
    // MyGrammar.g:129:1: oneArray : type ID '[' number ']' -> ^( ONEARRAY ^( ID ^( COUNT number ) ) ) ;
    public MyGrammarParser.oneArray_return oneArray() // throws RecognitionException [1]
    {   
        MyGrammarParser.oneArray_return retval = new MyGrammarParser.oneArray_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID18 = null;
        IToken char_literal19 = null;
        IToken char_literal21 = null;
        MyGrammarParser.type_return type17 = default(MyGrammarParser.type_return);

        MyGrammarParser.number_return number20 = default(MyGrammarParser.number_return);


        object ID18_tree=null;
        object char_literal19_tree=null;
        object char_literal21_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:129:10: ( type ID '[' number ']' -> ^( ONEARRAY ^( ID ^( COUNT number ) ) ) )
            // MyGrammar.g:129:12: type ID '[' number ']'
            {
            	PushFollow(FOLLOW_type_in_oneArray945);
            	type17 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type17.Tree);
            	ID18=(IToken)Match(input,ID,FOLLOW_ID_in_oneArray947); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID18);

            	char_literal19=(IToken)Match(input,51,FOLLOW_51_in_oneArray949); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal19);

            	PushFollow(FOLLOW_number_in_oneArray951);
            	number20 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number20.Tree);
            	char_literal21=(IToken)Match(input,52,FOLLOW_52_in_oneArray953); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal21);



            	// AST REWRITE
            	// elements:          number, ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 130:5: -> ^( ONEARRAY ^( ID ^( COUNT number ) ) )
            	{
            	    // MyGrammar.g:130:8: ^( ONEARRAY ^( ID ^( COUNT number ) ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ONEARRAY, "ONEARRAY"), root_1);

            	    // MyGrammar.g:130:19: ^( ID ^( COUNT number ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:130:24: ^( COUNT number )
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
    // MyGrammar.g:133:1: addOperation : ( PLUS -> Plus | MINUS -> Minus );
    public MyGrammarParser.addOperation_return addOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.addOperation_return retval = new MyGrammarParser.addOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS22 = null;
        IToken MINUS23 = null;

        object PLUS22_tree=null;
        object MINUS23_tree=null;
        RewriteRuleTokenStream stream_PLUS = new RewriteRuleTokenStream(adaptor,"token PLUS");
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor,"token MINUS");

        try 
    	{
            // MyGrammar.g:133:14: ( PLUS -> Plus | MINUS -> Minus )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == PLUS) )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == MINUS) )
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
                    // MyGrammar.g:133:16: PLUS
                    {
                    	PLUS22=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addOperation985); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_PLUS.Add(PLUS22);



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
                    	// 133:21: -> Plus
                    	{
                    	    adaptor.AddChild(root_0, new PlusNode(Plus));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:134:7: MINUS
                    {
                    	MINUS23=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_addOperation1000); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MINUS.Add(MINUS23);



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
                    	// 134:13: -> Minus
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
    // MyGrammar.g:137:1: multOperation : ( MULTIPLY -> MULT | DIVIDE -> DIVIDE );
    public MyGrammarParser.multOperation_return multOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.multOperation_return retval = new MyGrammarParser.multOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULTIPLY24 = null;
        IToken DIVIDE25 = null;

        object MULTIPLY24_tree=null;
        object DIVIDE25_tree=null;
        RewriteRuleTokenStream stream_MULTIPLY = new RewriteRuleTokenStream(adaptor,"token MULTIPLY");
        RewriteRuleTokenStream stream_DIVIDE = new RewriteRuleTokenStream(adaptor,"token DIVIDE");

        try 
    	{
            // MyGrammar.g:137:15: ( MULTIPLY -> MULT | DIVIDE -> DIVIDE )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == MULTIPLY) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == DIVIDE) )
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
                    // MyGrammar.g:137:17: MULTIPLY
                    {
                    	MULTIPLY24=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multOperation1020); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MULTIPLY.Add(MULTIPLY24);



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
                    	// 137:26: -> MULT
                    	{
                    	    adaptor.AddChild(root_0, new MultNode(MULT));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:138:7: DIVIDE
                    {
                    	DIVIDE25=(IToken)Match(input,DIVIDE,FOLLOW_DIVIDE_in_multOperation1035); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DIVIDE.Add(DIVIDE25);



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
                    	// 138:14: -> DIVIDE
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
    // MyGrammar.g:141:1: group : ( '(' add ')' | number );
    public MyGrammarParser.group_return group() // throws RecognitionException [1]
    {   
        MyGrammarParser.group_return retval = new MyGrammarParser.group_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal26 = null;
        IToken char_literal28 = null;
        MyGrammarParser.add_return add27 = default(MyGrammarParser.add_return);

        MyGrammarParser.number_return number29 = default(MyGrammarParser.number_return);


        object char_literal26_tree=null;
        object char_literal28_tree=null;

        try 
    	{
            // MyGrammar.g:141:7: ( '(' add ')' | number )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 53) )
            {
                alt8 = 1;
            }
            else if ( ((LA8_0 >= INTEGER && LA8_0 <= DOUBLE_)) )
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
                    // MyGrammar.g:141:9: '(' add ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal26=(IToken)Match(input,53,FOLLOW_53_in_group1058); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group1061);
                    	add27 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add27.Tree);
                    	char_literal28=(IToken)Match(input,54,FOLLOW_54_in_group1063); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:142:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group1071);
                    	number29 = number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number29.Tree);

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
    // MyGrammar.g:145:1: mult : group ( multOperation group )* ;
    public MyGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        MyGrammarParser.mult_return retval = new MyGrammarParser.mult_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.group_return group30 = default(MyGrammarParser.group_return);

        MyGrammarParser.multOperation_return multOperation31 = default(MyGrammarParser.multOperation_return);

        MyGrammarParser.group_return group32 = default(MyGrammarParser.group_return);



        try 
    	{
            // MyGrammar.g:145:6: ( group ( multOperation group )* )
            // MyGrammar.g:145:8: group ( multOperation group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult1086);
            	group30 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group30.Tree);
            	// MyGrammar.g:145:14: ( multOperation group )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= MULTIPLY && LA9_0 <= DIVIDE)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // MyGrammar.g:145:16: multOperation group
            			    {
            			    	PushFollow(FOLLOW_multOperation_in_mult1090);
            			    	multOperation31 = multOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperation31.Tree, root_0);
            			    	PushFollow(FOLLOW_group_in_mult1093);
            			    	group32 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group32.Tree);

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
    // MyGrammar.g:147:1: add : mult ( addOperation mult )* ;
    public MyGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        MyGrammarParser.add_return retval = new MyGrammarParser.add_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.mult_return mult33 = default(MyGrammarParser.mult_return);

        MyGrammarParser.addOperation_return addOperation34 = default(MyGrammarParser.addOperation_return);

        MyGrammarParser.mult_return mult35 = default(MyGrammarParser.mult_return);



        try 
    	{
            // MyGrammar.g:147:6: ( mult ( addOperation mult )* )
            // MyGrammar.g:147:8: mult ( addOperation mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1105);
            	mult33 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult33.Tree);
            	// MyGrammar.g:147:13: ( addOperation mult )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= PLUS && LA10_0 <= MINUS)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MyGrammar.g:147:15: addOperation mult
            			    {
            			    	PushFollow(FOLLOW_addOperation_in_add1109);
            			    	addOperation34 = addOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperation34.Tree, root_0);
            			    	PushFollow(FOLLOW_mult_in_add1112);
            			    	mult35 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult35.Tree);

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
    // MyGrammar.g:149:1: print : PRINT '(' printExpr ')' -> ^( PRINT printExpr ) ;
    public MyGrammarParser.print_return print() // throws RecognitionException [1]
    {   
        MyGrammarParser.print_return retval = new MyGrammarParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINT36 = null;
        IToken char_literal37 = null;
        IToken char_literal39 = null;
        MyGrammarParser.printExpr_return printExpr38 = default(MyGrammarParser.printExpr_return);


        object PRINT36_tree=null;
        object char_literal37_tree=null;
        object char_literal39_tree=null;
        RewriteRuleTokenStream stream_PRINT = new RewriteRuleTokenStream(adaptor,"token PRINT");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_printExpr = new RewriteRuleSubtreeStream(adaptor,"rule printExpr");
        try 
    	{
            // MyGrammar.g:149:7: ( PRINT '(' printExpr ')' -> ^( PRINT printExpr ) )
            // MyGrammar.g:149:9: PRINT '(' printExpr ')'
            {
            	PRINT36=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print1123); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINT.Add(PRINT36);

            	char_literal37=(IToken)Match(input,53,FOLLOW_53_in_print1125); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal37);

            	PushFollow(FOLLOW_printExpr_in_print1127);
            	printExpr38 = printExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_printExpr.Add(printExpr38.Tree);
            	char_literal39=(IToken)Match(input,54,FOLLOW_54_in_print1129); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal39);



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
            	// 150:4: -> ^( PRINT printExpr )
            	{
            	    // MyGrammar.g:150:7: ^( PRINT printExpr )
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
    // MyGrammar.g:153:1: block : '{' ( line )* '}' -> ^( BLOCK ( line )* ) ;
    public MyGrammarParser.block_return block() // throws RecognitionException [1]
    {   
        MyGrammarParser.block_return retval = new MyGrammarParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal40 = null;
        IToken char_literal42 = null;
        MyGrammarParser.line_return line41 = default(MyGrammarParser.line_return);


        object char_literal40_tree=null;
        object char_literal42_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:153:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:153:9: '{' ( line )* '}'
            {
            	char_literal40=(IToken)Match(input,55,FOLLOW_55_in_block1151); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal40);

            	// MyGrammar.g:153:13: ( line )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == PRINT || LA11_0 == IF || (LA11_0 >= INT && LA11_0 <= VOID) || (LA11_0 >= FOR && LA11_0 <= WHILE) || (LA11_0 >= INTEGER && LA11_0 <= ID) || LA11_0 == 53) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block1153);
            			    	line41 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line41.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	char_literal42=(IToken)Match(input,56,FOLLOW_56_in_block1156); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal42);



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
            	// 153:23: -> ^( BLOCK ( line )* )
            	{
            	    // MyGrammar.g:153:26: ^( BLOCK ( line )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(BLOCK), root_1);

            	    // MyGrammar.g:153:49: ( line )*
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
    // MyGrammar.g:157:1: if_ : IF '(' logicOperator ')' block ( ELSE block )? -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? ) ;
    public MyGrammarParser.if__return if_() // throws RecognitionException [1]
    {   
        MyGrammarParser.if__return retval = new MyGrammarParser.if__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF43 = null;
        IToken char_literal44 = null;
        IToken char_literal46 = null;
        IToken ELSE48 = null;
        MyGrammarParser.logicOperator_return logicOperator45 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block47 = default(MyGrammarParser.block_return);

        MyGrammarParser.block_return block49 = default(MyGrammarParser.block_return);


        object IF43_tree=null;
        object char_literal44_tree=null;
        object char_literal46_tree=null;
        object ELSE48_tree=null;
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:157:6: ( IF '(' logicOperator ')' block ( ELSE block )? -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? ) )
            // MyGrammar.g:157:8: IF '(' logicOperator ')' block ( ELSE block )?
            {
            	IF43=(IToken)Match(input,IF,FOLLOW_IF_in_if_1181); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF43);

            	char_literal44=(IToken)Match(input,53,FOLLOW_53_in_if_1183); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal44);

            	PushFollow(FOLLOW_logicOperator_in_if_1185);
            	logicOperator45 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator45.Tree);
            	char_literal46=(IToken)Match(input,54,FOLLOW_54_in_if_1187); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal46);

            	PushFollow(FOLLOW_block_in_if_1189);
            	block47 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block47.Tree);
            	// MyGrammar.g:157:39: ( ELSE block )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == ELSE) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // MyGrammar.g:157:40: ELSE block
            	        {
            	        	ELSE48=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_if_1192); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE48);

            	        	PushFollow(FOLLOW_block_in_if_1194);
            	        	block49 = block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block.Add(block49.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          logicOperator, block, ELSE, block, IF
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 158:4: -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? )
            	{
            	    // MyGrammar.g:158:7: ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

            	    // MyGrammar.g:158:12: ^( CONDITION logicOperator )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_2);

            	    adaptor.AddChild(root_2, stream_logicOperator.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_block.NextTree());
            	    // MyGrammar.g:158:45: ( ^( ELSE block ) )?
            	    if ( stream_ELSE.HasNext() || stream_block.HasNext() )
            	    {
            	        // MyGrammar.g:158:45: ^( ELSE block )
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
    // MyGrammar.g:161:1: logicOperator : ( orOperation )+ ;
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation50 = default(MyGrammarParser.orOperation_return);



        try 
    	{
            // MyGrammar.g:161:15: ( ( orOperation )+ )
            // MyGrammar.g:161:17: ( orOperation )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:161:17: ( orOperation )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= INTEGER && LA13_0 <= DOUBLE_) || LA13_0 == 53) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: orOperation
            			    {
            			    	PushFollow(FOLLOW_orOperation_in_logicOperator1234);
            			    	orOperation50 = orOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation50.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt13 >= 1 ) goto loop13;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee13 =
            		                new EarlyExitException(13, input);
            		            throw eee13;
            	    }
            	    cnt13++;
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
    // MyGrammar.g:164:1: orOperation : andOperation ( '||' andOperation )* ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal52 = null;
        MyGrammarParser.andOperation_return andOperation51 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.andOperation_return andOperation53 = default(MyGrammarParser.andOperation_return);


        object string_literal52_tree=null;

        try 
    	{
            // MyGrammar.g:164:14: ( andOperation ( '||' andOperation )* )
            // MyGrammar.g:164:16: andOperation ( '||' andOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_andOperation_in_orOperation1249);
            	andOperation51 = andOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation51.Tree);
            	// MyGrammar.g:164:29: ( '||' andOperation )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 57) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // MyGrammar.g:164:31: '||' andOperation
            			    {
            			    	string_literal52=(IToken)Match(input,57,FOLLOW_57_in_orOperation1253); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal52_tree = (object)adaptor.Create(string_literal52);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal52_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_andOperation_in_orOperation1256);
            			    	andOperation53 = andOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation53.Tree);

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
    // MyGrammar.g:167:1: andOperation : equalityOperation ( '&&' equalityOperation )* ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal55 = null;
        MyGrammarParser.equalityOperation_return equalityOperation54 = default(MyGrammarParser.equalityOperation_return);

        MyGrammarParser.equalityOperation_return equalityOperation56 = default(MyGrammarParser.equalityOperation_return);


        object string_literal55_tree=null;

        try 
    	{
            // MyGrammar.g:167:14: ( equalityOperation ( '&&' equalityOperation )* )
            // MyGrammar.g:167:16: equalityOperation ( '&&' equalityOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityOperation_in_andOperation1271);
            	equalityOperation54 = equalityOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation54.Tree);
            	// MyGrammar.g:167:34: ( '&&' equalityOperation )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == 58) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // MyGrammar.g:167:36: '&&' equalityOperation
            			    {
            			    	string_literal55=(IToken)Match(input,58,FOLLOW_58_in_andOperation1275); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal55_tree = (object)adaptor.Create(string_literal55);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal55_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityOperation_in_andOperation1278);
            			    	equalityOperation56 = equalityOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation56.Tree);

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
    // $ANTLR end "andOperation"

    public class equalityOperation_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "equalityOperation"
    // MyGrammar.g:170:1: equalityOperation : defaultOperation ( ( '==' | '!=' ) defaultOperation )* ;
    public MyGrammarParser.equalityOperation_return equalityOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.equalityOperation_return retval = new MyGrammarParser.equalityOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set58 = null;
        MyGrammarParser.defaultOperation_return defaultOperation57 = default(MyGrammarParser.defaultOperation_return);

        MyGrammarParser.defaultOperation_return defaultOperation59 = default(MyGrammarParser.defaultOperation_return);


        object set58_tree=null;

        try 
    	{
            // MyGrammar.g:170:19: ( defaultOperation ( ( '==' | '!=' ) defaultOperation )* )
            // MyGrammar.g:170:21: defaultOperation ( ( '==' | '!=' ) defaultOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1293);
            	defaultOperation57 = defaultOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation57.Tree);
            	// MyGrammar.g:170:38: ( ( '==' | '!=' ) defaultOperation )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= 59 && LA16_0 <= 60)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // MyGrammar.g:170:40: ( '==' | '!=' ) defaultOperation
            			    {
            			    	set58=(IToken)input.LT(1);
            			    	set58 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 59 && input.LA(1) <= 60) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set58), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1306);
            			    	defaultOperation59 = defaultOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation59.Tree);

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
    // $ANTLR end "equalityOperation"

    public class defaultOperation_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "defaultOperation"
    // MyGrammar.g:173:1: defaultOperation : add ( ( '>' | '<' | '>=' | '<=' ) add )* ;
    public MyGrammarParser.defaultOperation_return defaultOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.defaultOperation_return retval = new MyGrammarParser.defaultOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set61 = null;
        MyGrammarParser.add_return add60 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add62 = default(MyGrammarParser.add_return);


        object set61_tree=null;

        try 
    	{
            // MyGrammar.g:173:18: ( add ( ( '>' | '<' | '>=' | '<=' ) add )* )
            // MyGrammar.g:173:21: add ( ( '>' | '<' | '>=' | '<=' ) add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_defaultOperation1323);
            	add60 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add60.Tree);
            	// MyGrammar.g:173:25: ( ( '>' | '<' | '>=' | '<=' ) add )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= 61 && LA17_0 <= 64)) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // MyGrammar.g:173:27: ( '>' | '<' | '>=' | '<=' ) add
            			    {
            			    	set61=(IToken)input.LT(1);
            			    	set61 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 61 && input.LA(1) <= 64) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set61), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_add_in_defaultOperation1343);
            			    	add62 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add62.Tree);

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
    // $ANTLR end "defaultOperation"

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
    // MyGrammar.g:182:1: methodDef : type ID '()' block -> ^( Method ^( ID ( type )? block ) ) ;
    public MyGrammarParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        MyGrammarParser.methodDef_return retval = new MyGrammarParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID64 = null;
        IToken string_literal65 = null;
        MyGrammarParser.type_return type63 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block66 = default(MyGrammarParser.block_return);


        object ID64_tree=null;
        object string_literal65_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:182:11: ( type ID '()' block -> ^( Method ^( ID ( type )? block ) ) )
            // MyGrammar.g:182:13: type ID '()' block
            {
            	PushFollow(FOLLOW_type_in_methodDef1365);
            	type63 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type63.Tree);
            	ID64=(IToken)Match(input,ID,FOLLOW_ID_in_methodDef1367); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID64);

            	string_literal65=(IToken)Match(input,65,FOLLOW_65_in_methodDef1369); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_65.Add(string_literal65);

            	PushFollow(FOLLOW_block_in_methodDef1371);
            	block66 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block66.Tree);


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
            	// 182:32: -> ^( Method ^( ID ( type )? block ) )
            	{
            	    // MyGrammar.g:182:35: ^( Method ^( ID ( type )? block ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(Method), root_1);

            	    // MyGrammar.g:182:59: ^( ID ( type )? block )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:182:64: ( type )?
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
    // MyGrammar.g:185:1: callMethod : ID '()' -> ^( CallMethod ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID67 = null;
        IToken string_literal68 = null;

        object ID67_tree=null;
        object string_literal68_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");

        try 
    	{
            // MyGrammar.g:185:12: ( ID '()' -> ^( CallMethod ID ) )
            // MyGrammar.g:185:14: ID '()'
            {
            	ID67=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod1400); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID67);

            	string_literal68=(IToken)Match(input,65,FOLLOW_65_in_callMethod1402); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_65.Add(string_literal68);



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
            	// 186:5: -> ^( CallMethod ID )
            	{
            	    // MyGrammar.g:186:8: ^( CallMethod ID )
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
    // MyGrammar.g:189:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_69 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_70 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:189:7: ( for_ | while_ )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == FOR) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == WHILE) )
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
                    // MyGrammar.g:189:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle1430);
                    	for_69 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_69.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:190:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle1436);
                    	while_70 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_70.Tree);

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
    // MyGrammar.g:193:1: for_ : FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' varInitValue ')' block -> ^( FOR ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) varInitValue block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR71 = null;
        IToken char_literal72 = null;
        IToken ID74 = null;
        IToken ASSIGN75 = null;
        IToken char_literal77 = null;
        IToken char_literal79 = null;
        IToken char_literal81 = null;
        MyGrammarParser.type_return type73 = default(MyGrammarParser.type_return);

        MyGrammarParser.add_return add76 = default(MyGrammarParser.add_return);

        MyGrammarParser.logicOperator_return logicOperator78 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.varInitValue_return varInitValue80 = default(MyGrammarParser.varInitValue_return);

        MyGrammarParser.block_return block82 = default(MyGrammarParser.block_return);


        object FOR71_tree=null;
        object char_literal72_tree=null;
        object ID74_tree=null;
        object ASSIGN75_tree=null;
        object char_literal77_tree=null;
        object char_literal79_tree=null;
        object char_literal81_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_varInitValue = new RewriteRuleSubtreeStream(adaptor,"rule varInitValue");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:193:6: ( FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' varInitValue ')' block -> ^( FOR ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) varInitValue block ) )
            // MyGrammar.g:193:8: FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' varInitValue ')' block
            {
            	FOR71=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_1447); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR71);

            	char_literal72=(IToken)Match(input,53,FOLLOW_53_in_for_1462); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal72);

            	// MyGrammar.g:195:7: ( type )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( ((LA19_0 >= INT && LA19_0 <= VOID)) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // MyGrammar.g:0:0: type
            	        {
            	        	PushFollow(FOLLOW_type_in_for_1471);
            	        	type73 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type73.Tree);

            	        }
            	        break;

            	}

            	ID74=(IToken)Match(input,ID,FOLLOW_ID_in_for_1474); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID74);

            	ASSIGN75=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_for_1476); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN75);

            	PushFollow(FOLLOW_add_in_for_1478);
            	add76 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add76.Tree);
            	char_literal77=(IToken)Match(input,66,FOLLOW_66_in_for_1480); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_66.Add(char_literal77);

            	PushFollow(FOLLOW_logicOperator_in_for_1488);
            	logicOperator78 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator78.Tree);
            	char_literal79=(IToken)Match(input,66,FOLLOW_66_in_for_1490); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_66.Add(char_literal79);

            	PushFollow(FOLLOW_varInitValue_in_for_1496);
            	varInitValue80 = varInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitValue.Add(varInitValue80.Tree);
            	char_literal81=(IToken)Match(input,54,FOLLOW_54_in_for_1501); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal81);

            	PushFollow(FOLLOW_block_in_for_1506);
            	block82 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block82.Tree);


            	// AST REWRITE
            	// elements:          add, logicOperator, block, ASSIGN, type, FOR, ID, varInitValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 200:4: -> ^( FOR ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) varInitValue block )
            	{
            	    // MyGrammar.g:200:7: ^( FOR ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) varInitValue block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ForNode(stream_FOR.NextToken()), root_1);

            	    // MyGrammar.g:200:22: ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR, "VAR"), root_2);

            	    // MyGrammar.g:200:28: ( type )?
            	    if ( stream_type.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_type.NextTree());

            	    }
            	    stream_type.Reset();
            	    // MyGrammar.g:200:34: ^( ID ^( ASSIGN add ) )
            	    {
            	    object root_3 = (object)adaptor.GetNilNode();
            	    root_3 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_3);

            	    // MyGrammar.g:200:39: ^( ASSIGN add )
            	    {
            	    object root_4 = (object)adaptor.GetNilNode();
            	    root_4 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_4);

            	    adaptor.AddChild(root_4, stream_add.NextTree());

            	    adaptor.AddChild(root_3, root_4);
            	    }

            	    adaptor.AddChild(root_2, root_3);
            	    }

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // MyGrammar.g:201:7: ^( CONDITION logicOperator )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_2);

            	    adaptor.AddChild(root_2, stream_logicOperator.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
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
    // MyGrammar.g:206:1: while_ : WHILE '(' logicOperator ')' block -> ^( WHILE ^( CONDITION logicOperator ) block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE83 = null;
        IToken char_literal84 = null;
        IToken char_literal86 = null;
        MyGrammarParser.logicOperator_return logicOperator85 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block87 = default(MyGrammarParser.block_return);


        object WHILE83_tree=null;
        object char_literal84_tree=null;
        object char_literal86_tree=null;
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:206:8: ( WHILE '(' logicOperator ')' block -> ^( WHILE ^( CONDITION logicOperator ) block ) )
            // MyGrammar.g:206:10: WHILE '(' logicOperator ')' block
            {
            	WHILE83=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_1582); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE83);

            	char_literal84=(IToken)Match(input,53,FOLLOW_53_in_while_1587); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal84);

            	PushFollow(FOLLOW_logicOperator_in_while_1592);
            	logicOperator85 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator85.Tree);
            	char_literal86=(IToken)Match(input,54,FOLLOW_54_in_while_1597); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal86);

            	PushFollow(FOLLOW_block_in_while_1602);
            	block87 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block87.Tree);


            	// AST REWRITE
            	// elements:          WHILE, block, logicOperator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 211:4: -> ^( WHILE ^( CONDITION logicOperator ) block )
            	{
            	    // MyGrammar.g:211:7: ^( WHILE ^( CONDITION logicOperator ) block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

            	    // MyGrammar.g:211:15: ^( CONDITION logicOperator )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_2);

            	    adaptor.AddChild(root_2, stream_logicOperator.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
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
    // MyGrammar.g:215:1: printExpr : ( add | ID | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID89 = null;
        MyGrammarParser.add_return add88 = default(MyGrammarParser.add_return);

        MyGrammarParser.callMethod_return callMethod90 = default(MyGrammarParser.callMethod_return);


        object ID89_tree=null;

        try 
    	{
            // MyGrammar.g:215:11: ( add | ID | callMethod )
            int alt20 = 3;
            int LA20_0 = input.LA(1);

            if ( ((LA20_0 >= INTEGER && LA20_0 <= DOUBLE_) || LA20_0 == 53) )
            {
                alt20 = 1;
            }
            else if ( (LA20_0 == ID) )
            {
                int LA20_2 = input.LA(2);

                if ( (LA20_2 == 65) )
                {
                    alt20 = 3;
                }
                else if ( (LA20_2 == 54) )
                {
                    alt20 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d20s2 =
                        new NoViableAltException("", 20, 2, input);

                    throw nvae_d20s2;
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
                    // MyGrammar.g:215:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr1633);
                    	add88 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add88.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:216:6: ID
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID89=(IToken)Match(input,ID,FOLLOW_ID_in_printExpr1640); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID89_tree = (object)adaptor.Create(ID89);
                    		adaptor.AddChild(root_0, ID89_tree);
                    	}

                    }
                    break;
                case 3 :
                    // MyGrammar.g:217:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr1647);
                    	callMethod90 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod90.Tree);

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
    // MyGrammar.g:220:1: expr : ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add91 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_92 = default(MyGrammarParser.if__return);

        MyGrammarParser.varInit_return varInit93 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.oneArray_return oneArray94 = default(MyGrammarParser.oneArray_return);

        MyGrammarParser.cycle_return cycle95 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.varInitValue_return varInitValue96 = default(MyGrammarParser.varInitValue_return);

        MyGrammarParser.callMethod_return callMethod97 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print98 = default(MyGrammarParser.print_return);



        try 
    	{
            // MyGrammar.g:220:6: ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print )
            int alt21 = 8;
            alt21 = dfa21.Predict(input);
            switch (alt21) 
            {
                case 1 :
                    // MyGrammar.g:220:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr1661);
                    	add91 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add91.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:221:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr1667);
                    	if_92 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_92.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:222:5: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_expr1673);
                    	varInit93 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit93.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:223:5: oneArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_expr1679);
                    	oneArray94 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray94.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:224:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr1685);
                    	cycle95 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle95.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:225:5: varInitValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInitValue_in_expr1691);
                    	varInitValue96 = varInitValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInitValue96.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:226:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr1697);
                    	callMethod97 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod97.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:227:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr1703);
                    	print98 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print98.Tree);

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
    // MyGrammar.g:230:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal100 = null;
        MyGrammarParser.expr_return expr99 = default(MyGrammarParser.expr_return);


        object char_literal100_tree=null;

        try 
    	{
            // MyGrammar.g:230:6: ( expr ( ';' )* )
            // MyGrammar.g:230:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line1714);
            	expr99 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr99.Tree);
            	// MyGrammar.g:230:13: ( ';' )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == 66) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // MyGrammar.g:230:14: ';'
            			    {
            			    	char_literal100=(IToken)Match(input,66,FOLLOW_66_in_line1717); if (state.failed) return retval;

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
    // MyGrammar.g:233:1: exprList : methodDef ( ';' )* ;
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal102 = null;
        MyGrammarParser.methodDef_return methodDef101 = default(MyGrammarParser.methodDef_return);


        object char_literal102_tree=null;

        try 
    	{
            // MyGrammar.g:233:9: ( methodDef ( ';' )* )
            // MyGrammar.g:233:11: methodDef ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_methodDef_in_exprList1731);
            	methodDef101 = methodDef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef101.Tree);
            	// MyGrammar.g:233:22: ( ';' )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == 66) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // MyGrammar.g:233:23: ';'
            			    {
            			    	char_literal102=(IToken)Match(input,66,FOLLOW_66_in_exprList1735); if (state.failed) return retval;

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
    // MyGrammar.g:239:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList103 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:239:13: ( ( exprList )* )
            // MyGrammar.g:240:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:240:4: ( exprList )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( ((LA24_0 >= INT && LA24_0 <= VOID)) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm1756);
            			    	exprList103 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList103.Tree);

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
    // MyGrammar.g:243:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm104 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:243:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:244:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program1770);
            	fullProgramm104 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm104.Tree);


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
            	// 244:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:244:19: ^( PROGRAM fullProgramm )
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
    // MyGrammar.g:247:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program105 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:247:8: ( program )
            // MyGrammar.g:248:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute1788);
            	program105 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program105.Tree);

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

    // Delegated rules


   	protected DFA21 dfa21;
	private void InitializeCyclicDFAs()
	{
    	this.dfa21 = new DFA21(this);
	}

    const string DFA21_eotS =
        "\x0c\uffff";
    const string DFA21_eofS =
        "\x05\uffff\x01\x09\x01\uffff\x01\x0b\x04\uffff";
    const string DFA21_minS =
        "\x01\x0f\x02\uffff\x01\x31\x01\uffff\x01\x0f\x01\uffff\x01\x0f"+
        "\x04\uffff";
    const string DFA21_maxS =
        "\x01\x35\x02\uffff\x01\x31\x01\uffff\x01\x42\x01\uffff\x01\x42"+
        "\x04\uffff";
    const string DFA21_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x05\x01\uffff\x01\x08"+
        "\x01\uffff\x01\x07\x01\x06\x01\x04\x01\x03";
    const string DFA21_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x01\x06\x04\uffff\x01\x02\x0a\uffff\x05\x03\x08\uffff\x02"+
            "\x04\x01\uffff\x02\x01\x01\x05\x03\uffff\x01\x01",
            "",
            "",
            "\x01\x07",
            "",
            "\x01\x09\x04\uffff\x01\x09\x03\uffff\x01\x09\x06\uffff\x05"+
            "\x09\x08\uffff\x02\x09\x01\uffff\x03\x09\x03\uffff\x01\x09\x02"+
            "\uffff\x01\x09\x08\uffff\x01\x08\x01\x09",
            "",
            "\x01\x0b\x04\uffff\x01\x0b\x03\uffff\x01\x0b\x06\uffff\x05"+
            "\x0b\x08\uffff\x02\x0b\x01\uffff\x03\x0b\x01\uffff\x01\x0a\x01"+
            "\uffff\x01\x0b\x02\uffff\x01\x0b\x09\uffff\x01\x0b",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "220:1: expr : ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_incDec0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_in_number738 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE__in_number755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_varInit819 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_varInitValue_in_varInit821 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_varInitValue851 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_varInitValue854 = new BitSet(new ulong[]{0x0023800000000000UL});
    public static readonly BitSet FOLLOW_initValue_in_varInitValue856 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_initValue894 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_initValue902 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_incDec_in_optionsChangeValue915 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeAssign_in_optionsChangeValue926 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_add_in_optionsChangeValue929 = new BitSet(new ulong[]{0x0021800000000002UL});
    public static readonly BitSet FOLLOW_type_in_oneArray945 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_oneArray947 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_oneArray949 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_number_in_oneArray951 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_oneArray953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_addOperation985 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_addOperation1000 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multOperation1020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multOperation1035 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_group1058 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_add_in_group1061 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_group1063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group1071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult1086 = new BitSet(new ulong[]{0x00000000000C0002UL});
    public static readonly BitSet FOLLOW_multOperation_in_mult1090 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_group_in_mult1093 = new BitSet(new ulong[]{0x00000000000C0002UL});
    public static readonly BitSet FOLLOW_mult_in_add1105 = new BitSet(new ulong[]{0x0000000000030002UL});
    public static readonly BitSet FOLLOW_addOperation_in_add1109 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_mult_in_add1112 = new BitSet(new ulong[]{0x0000000000030002UL});
    public static readonly BitSet FOLLOW_PRINT_in_print1123 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_print1125 = new BitSet(new ulong[]{0x0023800000000000UL});
    public static readonly BitSet FOLLOW_printExpr_in_print1127 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_print1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_block1151 = new BitSet(new ulong[]{0x0123B00F80108000UL});
    public static readonly BitSet FOLLOW_line_in_block1153 = new BitSet(new ulong[]{0x0123B00F80108000UL});
    public static readonly BitSet FOLLOW_56_in_block1156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_1181 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_if_1183 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_1185 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_if_1187 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_1189 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_ELSE_in_if_1192 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_1194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator1234 = new BitSet(new ulong[]{0x0021800000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation1249 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_57_in_orOperation1253 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation1256 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation1271 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_58_in_andOperation1275 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation1278 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1293 = new BitSet(new ulong[]{0x1800000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOperation1297 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1306 = new BitSet(new ulong[]{0x1800000000000002UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1323 = new BitSet(new ulong[]{0xE000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_set_in_defaultOperation1327 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1343 = new BitSet(new ulong[]{0xE000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_type_in_methodDef1365 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_methodDef1367 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_methodDef1369 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_block_in_methodDef1371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod1400 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_callMethod1402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle1430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle1436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_1447 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_for_1462 = new BitSet(new ulong[]{0x0002000F80000000UL});
    public static readonly BitSet FOLLOW_type_in_for_1471 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_for_1474 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_for_1476 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_add_in_for_1478 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_for_1480 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_1488 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_for_1490 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_varInitValue_in_for_1496 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_for_1501 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_block_in_for_1506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_1582 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_while_1587 = new BitSet(new ulong[]{0x0021800000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_1592 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_while_1597 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_block_in_while_1602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr1633 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_printExpr1640 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr1647 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr1661 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr1667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_expr1673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_oneArray_in_expr1679 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr1685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInitValue_in_expr1691 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr1697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr1703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line1714 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_line1717 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_methodDef_in_exprList1731 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_exprList1735 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm1756 = new BitSet(new ulong[]{0x0000000F80000002UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program1770 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute1788 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}