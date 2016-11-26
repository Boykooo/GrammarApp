// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-11-26 21:22:07

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
		"REAL", 
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

    public const int PRINT = 7;
    public const int T__50 = 50;
    public const int VAR = 28;
    public const int DECREMENT = 22;
    public const int MINUS = 9;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int ELSE = 13;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int CALLMETHOD = 35;
    public const int ID = 41;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int IF = 12;
    public const int TYPE = 33;
    public const int T__53 = 53;
    public const int MINUSASSIGN = 18;
    public const int T__54 = 54;
    public const int INTEGER = 39;
    public const int BLOCK = 14;
    public const int ONEARRAY = 29;
    public const int FOR = 36;
    public const int Method = 5;
    public const int REAL = 40;
    public const int PUBLIC = 32;
    public const int MULTIPLY = 10;
    public const int CONDITION = 15;
    public const int COUNT = 30;
    public const int VOID = 27;
    public const int PROGRAM = 6;
    public const int PLUS = 8;
    public const int DIVIDEASSIGN = 20;
    public const int FLOAT = 24;
    public const int MULTASSIGN = 19;
    public const int CHAR = 26;
    public const int ASSIGN = 16;
    public const int INT = 23;
    public const int DIVIDE = 11;
    public const int PLUSASSIGN = 17;
    public const int DOUBLE = 25;
    public const int WS = 42;
    public const int EOF = -1;
    public const int MOD = 34;
    public const int INCREMENT_ = 38;
    public const int PRIVATE = 31;
    public const int VarInit = 4;
    public const int INCREMENT = 21;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__46 = 46;
    public const int WHILE = 37;
    public const int T__47 = 47;
    public const int T__43 = 43;

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
    // MyGrammar.g:61:1: type : ( INT | FLOAT | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:61:6: ( INT | FLOAT | DOUBLE | CHAR | VOID )
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
    // MyGrammar.g:69:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:69:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
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
    // MyGrammar.g:76:1: incDec : ( INCREMENT | DECREMENT );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set3 = null;

        object set3_tree=null;

        try 
    	{
            // MyGrammar.g:76:8: ( INCREMENT | DECREMENT )
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
    // MyGrammar.g:80:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set4 = null;

        object set4_tree=null;

        try 
    	{
            // MyGrammar.g:80:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
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
    // MyGrammar.g:96:1: number : ( INTEGER | REAL );
    public MyGrammarParser.number_return number() // throws RecognitionException [1]
    {   
        MyGrammarParser.number_return retval = new MyGrammarParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set5 = null;

        object set5_tree=null;

        try 
    	{
            // MyGrammar.g:96:8: ( INTEGER | REAL )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set5 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INTEGER && input.LA(1) <= REAL) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set5));
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
    // MyGrammar.g:103:1: varInit : type ID ( ASSIGN add )? -> ^( VarInit type ID ( ^( ASSIGN add ) )? ) ;
    public MyGrammarParser.varInit_return varInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInit_return retval = new MyGrammarParser.varInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID7 = null;
        IToken ASSIGN8 = null;
        MyGrammarParser.type_return type6 = default(MyGrammarParser.type_return);

        MyGrammarParser.add_return add9 = default(MyGrammarParser.add_return);


        object ID7_tree=null;
        object ASSIGN8_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:103:9: ( type ID ( ASSIGN add )? -> ^( VarInit type ID ( ^( ASSIGN add ) )? ) )
            // MyGrammar.g:103:11: type ID ( ASSIGN add )?
            {
            	PushFollow(FOLLOW_type_in_varInit709);
            	type6 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type6.Tree);
            	ID7=(IToken)Match(input,ID,FOLLOW_ID_in_varInit711); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID7);

            	// MyGrammar.g:103:19: ( ASSIGN add )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == ASSIGN) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // MyGrammar.g:103:20: ASSIGN add
            	        {
            	        	ASSIGN8=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_varInit714); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN8);

            	        	PushFollow(FOLLOW_add_in_varInit716);
            	        	add9 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_add.Add(add9.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ID, add, ASSIGN, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 104:5: -> ^( VarInit type ID ( ^( ASSIGN add ) )? )
            	{
            	    // MyGrammar.g:104:8: ^( VarInit type ID ( ^( ASSIGN add ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new VarInit(VarInit), root_1);

            	    adaptor.AddChild(root_1, stream_type.NextTree());
            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    // MyGrammar.g:104:35: ( ^( ASSIGN add ) )?
            	    if ( stream_add.HasNext() || stream_ASSIGN.HasNext() )
            	    {
            	        // MyGrammar.g:104:35: ^( ASSIGN add )
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_2);

            	        adaptor.AddChild(root_2, stream_add.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_add.Reset();
            	    stream_ASSIGN.Reset();

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
    // MyGrammar.g:107:1: oneArray : type ID '[' number ']' -> ^( ONEARRAY ^( ID ^( COUNT number ) ) ) ;
    public MyGrammarParser.oneArray_return oneArray() // throws RecognitionException [1]
    {   
        MyGrammarParser.oneArray_return retval = new MyGrammarParser.oneArray_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID11 = null;
        IToken char_literal12 = null;
        IToken char_literal14 = null;
        MyGrammarParser.type_return type10 = default(MyGrammarParser.type_return);

        MyGrammarParser.number_return number13 = default(MyGrammarParser.number_return);


        object ID11_tree=null;
        object char_literal12_tree=null;
        object char_literal14_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:107:10: ( type ID '[' number ']' -> ^( ONEARRAY ^( ID ^( COUNT number ) ) ) )
            // MyGrammar.g:107:12: type ID '[' number ']'
            {
            	PushFollow(FOLLOW_type_in_oneArray753);
            	type10 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type10.Tree);
            	ID11=(IToken)Match(input,ID,FOLLOW_ID_in_oneArray755); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID11);

            	char_literal12=(IToken)Match(input,43,FOLLOW_43_in_oneArray757); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal12);

            	PushFollow(FOLLOW_number_in_oneArray759);
            	number13 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number13.Tree);
            	char_literal14=(IToken)Match(input,44,FOLLOW_44_in_oneArray761); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal14);



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
            	// 108:5: -> ^( ONEARRAY ^( ID ^( COUNT number ) ) )
            	{
            	    // MyGrammar.g:108:8: ^( ONEARRAY ^( ID ^( COUNT number ) ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ONEARRAY, "ONEARRAY"), root_1);

            	    // MyGrammar.g:108:19: ^( ID ^( COUNT number ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:108:24: ^( COUNT number )
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
    // MyGrammar.g:111:1: group : ( '(' add ')' | number );
    public MyGrammarParser.group_return group() // throws RecognitionException [1]
    {   
        MyGrammarParser.group_return retval = new MyGrammarParser.group_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal15 = null;
        IToken char_literal17 = null;
        MyGrammarParser.add_return add16 = default(MyGrammarParser.add_return);

        MyGrammarParser.number_return number18 = default(MyGrammarParser.number_return);


        object char_literal15_tree=null;
        object char_literal17_tree=null;

        try 
    	{
            // MyGrammar.g:111:7: ( '(' add ')' | number )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == 45) )
            {
                alt2 = 1;
            }
            else if ( ((LA2_0 >= INTEGER && LA2_0 <= REAL)) )
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
                    // MyGrammar.g:111:9: '(' add ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal15=(IToken)Match(input,45,FOLLOW_45_in_group793); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group796);
                    	add16 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add16.Tree);
                    	char_literal17=(IToken)Match(input,46,FOLLOW_46_in_group798); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:112:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group806);
                    	number18 = number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number18.Tree);

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
    // MyGrammar.g:115:1: mult : group ( ( MULTIPLY | DIVIDE ) group )* ;
    public MyGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        MyGrammarParser.mult_return retval = new MyGrammarParser.mult_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set20 = null;
        MyGrammarParser.group_return group19 = default(MyGrammarParser.group_return);

        MyGrammarParser.group_return group21 = default(MyGrammarParser.group_return);


        object set20_tree=null;

        try 
    	{
            // MyGrammar.g:115:6: ( group ( ( MULTIPLY | DIVIDE ) group )* )
            // MyGrammar.g:115:8: group ( ( MULTIPLY | DIVIDE ) group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult821);
            	group19 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group19.Tree);
            	// MyGrammar.g:115:14: ( ( MULTIPLY | DIVIDE ) group )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= MULTIPLY && LA3_0 <= DIVIDE)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // MyGrammar.g:115:15: ( MULTIPLY | DIVIDE ) group
            			    {
            			    	set20=(IToken)input.LT(1);
            			    	set20 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULTIPLY && input.LA(1) <= DIVIDE) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set20), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_group_in_mult833);
            			    	group21 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group21.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // MyGrammar.g:117:1: add : mult ( ( PLUS | MINUS ) mult )* ;
    public MyGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        MyGrammarParser.add_return retval = new MyGrammarParser.add_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set23 = null;
        MyGrammarParser.mult_return mult22 = default(MyGrammarParser.mult_return);

        MyGrammarParser.mult_return mult24 = default(MyGrammarParser.mult_return);


        object set23_tree=null;

        try 
    	{
            // MyGrammar.g:117:6: ( mult ( ( PLUS | MINUS ) mult )* )
            // MyGrammar.g:117:8: mult ( ( PLUS | MINUS ) mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add845);
            	mult22 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult22.Tree);
            	// MyGrammar.g:117:13: ( ( PLUS | MINUS ) mult )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= PLUS && LA4_0 <= MINUS)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // MyGrammar.g:117:14: ( PLUS | MINUS ) mult
            			    {
            			    	set23=(IToken)input.LT(1);
            			    	set23 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= PLUS && input.LA(1) <= MINUS) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set23), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add857);
            			    	mult24 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult24.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // MyGrammar.g:119:1: print : PRINT '(' printExpr ')' -> ^( PRINT printExpr ) ;
    public MyGrammarParser.print_return print() // throws RecognitionException [1]
    {   
        MyGrammarParser.print_return retval = new MyGrammarParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINT25 = null;
        IToken char_literal26 = null;
        IToken char_literal28 = null;
        MyGrammarParser.printExpr_return printExpr27 = default(MyGrammarParser.printExpr_return);


        object PRINT25_tree=null;
        object char_literal26_tree=null;
        object char_literal28_tree=null;
        RewriteRuleTokenStream stream_PRINT = new RewriteRuleTokenStream(adaptor,"token PRINT");
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_printExpr = new RewriteRuleSubtreeStream(adaptor,"rule printExpr");
        try 
    	{
            // MyGrammar.g:119:7: ( PRINT '(' printExpr ')' -> ^( PRINT printExpr ) )
            // MyGrammar.g:119:9: PRINT '(' printExpr ')'
            {
            	PRINT25=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print868); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINT.Add(PRINT25);

            	char_literal26=(IToken)Match(input,45,FOLLOW_45_in_print870); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal26);

            	PushFollow(FOLLOW_printExpr_in_print872);
            	printExpr27 = printExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_printExpr.Add(printExpr27.Tree);
            	char_literal28=(IToken)Match(input,46,FOLLOW_46_in_print874); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal28);



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
            	// 120:4: -> ^( PRINT printExpr )
            	{
            	    // MyGrammar.g:120:7: ^( PRINT printExpr )
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
    // MyGrammar.g:123:1: block : '{' ( line )* '}' -> ^( BLOCK ( line )* ) ;
    public MyGrammarParser.block_return block() // throws RecognitionException [1]
    {   
        MyGrammarParser.block_return retval = new MyGrammarParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal29 = null;
        IToken char_literal31 = null;
        MyGrammarParser.line_return line30 = default(MyGrammarParser.line_return);


        object char_literal29_tree=null;
        object char_literal31_tree=null;
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:123:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:123:9: '{' ( line )* '}'
            {
            	char_literal29=(IToken)Match(input,47,FOLLOW_47_in_block896); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal29);

            	// MyGrammar.g:123:13: ( line )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == PRINT || LA5_0 == IF || (LA5_0 >= INT && LA5_0 <= VOID) || (LA5_0 >= FOR && LA5_0 <= WHILE) || (LA5_0 >= INTEGER && LA5_0 <= ID) || LA5_0 == 45) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block898);
            			    	line30 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line30.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	char_literal31=(IToken)Match(input,48,FOLLOW_48_in_block901); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal31);



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
            	// 123:23: -> ^( BLOCK ( line )* )
            	{
            	    // MyGrammar.g:123:26: ^( BLOCK ( line )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new CodeBlock(BLOCK), root_1);

            	    // MyGrammar.g:123:45: ( line )*
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
    // MyGrammar.g:129:1: if_ : IF '(' logicOperator ')' block ( ELSE block )? -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? ) ;
    public MyGrammarParser.if__return if_() // throws RecognitionException [1]
    {   
        MyGrammarParser.if__return retval = new MyGrammarParser.if__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF32 = null;
        IToken char_literal33 = null;
        IToken char_literal35 = null;
        IToken ELSE37 = null;
        MyGrammarParser.logicOperator_return logicOperator34 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block36 = default(MyGrammarParser.block_return);

        MyGrammarParser.block_return block38 = default(MyGrammarParser.block_return);


        object IF32_tree=null;
        object char_literal33_tree=null;
        object char_literal35_tree=null;
        object ELSE37_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:129:6: ( IF '(' logicOperator ')' block ( ELSE block )? -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? ) )
            // MyGrammar.g:129:8: IF '(' logicOperator ')' block ( ELSE block )?
            {
            	IF32=(IToken)Match(input,IF,FOLLOW_IF_in_if_928); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF32);

            	char_literal33=(IToken)Match(input,45,FOLLOW_45_in_if_930); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal33);

            	PushFollow(FOLLOW_logicOperator_in_if_932);
            	logicOperator34 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator34.Tree);
            	char_literal35=(IToken)Match(input,46,FOLLOW_46_in_if_934); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal35);

            	PushFollow(FOLLOW_block_in_if_936);
            	block36 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block36.Tree);
            	// MyGrammar.g:129:39: ( ELSE block )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == ELSE) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // MyGrammar.g:129:40: ELSE block
            	        {
            	        	ELSE37=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_if_939); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE37);

            	        	PushFollow(FOLLOW_block_in_if_941);
            	        	block38 = block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block.Add(block38.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          block, IF, block, ELSE, logicOperator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 130:4: -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? )
            	{
            	    // MyGrammar.g:130:7: ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

            	    // MyGrammar.g:130:12: ^( CONDITION logicOperator )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_2);

            	    adaptor.AddChild(root_2, stream_logicOperator.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_block.NextTree());
            	    // MyGrammar.g:130:45: ( ^( ELSE block ) )?
            	    if ( stream_block.HasNext() || stream_ELSE.HasNext() )
            	    {
            	        // MyGrammar.g:130:45: ^( ELSE block )
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
    // MyGrammar.g:133:1: logicOperator : ( orOperation )+ ;
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation39 = default(MyGrammarParser.orOperation_return);



        try 
    	{
            // MyGrammar.g:133:15: ( ( orOperation )+ )
            // MyGrammar.g:133:17: ( orOperation )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:133:17: ( orOperation )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= INTEGER && LA7_0 <= REAL) || LA7_0 == 45) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: orOperation
            			    {
            			    	PushFollow(FOLLOW_orOperation_in_logicOperator981);
            			    	orOperation39 = orOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation39.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee7 =
            		                new EarlyExitException(7, input);
            		            throw eee7;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // MyGrammar.g:136:1: orOperation : andOperation ( '||' andOperation )* ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal41 = null;
        MyGrammarParser.andOperation_return andOperation40 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.andOperation_return andOperation42 = default(MyGrammarParser.andOperation_return);


        object string_literal41_tree=null;

        try 
    	{
            // MyGrammar.g:136:14: ( andOperation ( '||' andOperation )* )
            // MyGrammar.g:136:16: andOperation ( '||' andOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_andOperation_in_orOperation996);
            	andOperation40 = andOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation40.Tree);
            	// MyGrammar.g:136:29: ( '||' andOperation )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 49) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // MyGrammar.g:136:31: '||' andOperation
            			    {
            			    	string_literal41=(IToken)Match(input,49,FOLLOW_49_in_orOperation1000); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal41_tree = (object)adaptor.Create(string_literal41);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal41_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_andOperation_in_orOperation1003);
            			    	andOperation42 = andOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation42.Tree);

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
    // MyGrammar.g:139:1: andOperation : equalityOperation ( '&&' equalityOperation )* ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal44 = null;
        MyGrammarParser.equalityOperation_return equalityOperation43 = default(MyGrammarParser.equalityOperation_return);

        MyGrammarParser.equalityOperation_return equalityOperation45 = default(MyGrammarParser.equalityOperation_return);


        object string_literal44_tree=null;

        try 
    	{
            // MyGrammar.g:139:14: ( equalityOperation ( '&&' equalityOperation )* )
            // MyGrammar.g:139:16: equalityOperation ( '&&' equalityOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityOperation_in_andOperation1018);
            	equalityOperation43 = equalityOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation43.Tree);
            	// MyGrammar.g:139:34: ( '&&' equalityOperation )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 50) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // MyGrammar.g:139:36: '&&' equalityOperation
            			    {
            			    	string_literal44=(IToken)Match(input,50,FOLLOW_50_in_andOperation1022); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal44_tree = (object)adaptor.Create(string_literal44);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal44_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityOperation_in_andOperation1025);
            			    	equalityOperation45 = equalityOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation45.Tree);

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
    // MyGrammar.g:142:1: equalityOperation : defaultOperation ( ( '==' | '!=' ) defaultOperation )* ;
    public MyGrammarParser.equalityOperation_return equalityOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.equalityOperation_return retval = new MyGrammarParser.equalityOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set47 = null;
        MyGrammarParser.defaultOperation_return defaultOperation46 = default(MyGrammarParser.defaultOperation_return);

        MyGrammarParser.defaultOperation_return defaultOperation48 = default(MyGrammarParser.defaultOperation_return);


        object set47_tree=null;

        try 
    	{
            // MyGrammar.g:142:19: ( defaultOperation ( ( '==' | '!=' ) defaultOperation )* )
            // MyGrammar.g:142:21: defaultOperation ( ( '==' | '!=' ) defaultOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1040);
            	defaultOperation46 = defaultOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation46.Tree);
            	// MyGrammar.g:142:38: ( ( '==' | '!=' ) defaultOperation )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= 51 && LA10_0 <= 52)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MyGrammar.g:142:40: ( '==' | '!=' ) defaultOperation
            			    {
            			    	set47=(IToken)input.LT(1);
            			    	set47 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 51 && input.LA(1) <= 52) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set47), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1053);
            			    	defaultOperation48 = defaultOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation48.Tree);

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
    // MyGrammar.g:145:1: defaultOperation : add ( ( '>' | '<' | '>=' | '<=' ) add )* ;
    public MyGrammarParser.defaultOperation_return defaultOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.defaultOperation_return retval = new MyGrammarParser.defaultOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set50 = null;
        MyGrammarParser.add_return add49 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add51 = default(MyGrammarParser.add_return);


        object set50_tree=null;

        try 
    	{
            // MyGrammar.g:145:18: ( add ( ( '>' | '<' | '>=' | '<=' ) add )* )
            // MyGrammar.g:145:21: add ( ( '>' | '<' | '>=' | '<=' ) add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_defaultOperation1070);
            	add49 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add49.Tree);
            	// MyGrammar.g:145:25: ( ( '>' | '<' | '>=' | '<=' ) add )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= 53 && LA11_0 <= 56)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MyGrammar.g:145:27: ( '>' | '<' | '>=' | '<=' ) add
            			    {
            			    	set50=(IToken)input.LT(1);
            			    	set50 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 53 && input.LA(1) <= 56) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set50), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_add_in_defaultOperation1090);
            			    	add51 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add51.Tree);

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
    // $ANTLR end "defaultOperation"

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
    // MyGrammar.g:148:1: optionsChangeValue : ( incDec | ( typeAssign ( add )+ ) );
    public MyGrammarParser.optionsChangeValue_return optionsChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.optionsChangeValue_return retval = new MyGrammarParser.optionsChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.incDec_return incDec52 = default(MyGrammarParser.incDec_return);

        MyGrammarParser.typeAssign_return typeAssign53 = default(MyGrammarParser.typeAssign_return);

        MyGrammarParser.add_return add54 = default(MyGrammarParser.add_return);



        try 
    	{
            // MyGrammar.g:148:20: ( incDec | ( typeAssign ( add )+ ) )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( ((LA13_0 >= INCREMENT && LA13_0 <= DECREMENT)) )
            {
                alt13 = 1;
            }
            else if ( ((LA13_0 >= ASSIGN && LA13_0 <= DIVIDEASSIGN)) )
            {
                alt13 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // MyGrammar.g:148:22: incDec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_incDec_in_optionsChangeValue1106);
                    	incDec52 = incDec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, incDec52.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:148:31: ( typeAssign ( add )+ )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// MyGrammar.g:148:31: ( typeAssign ( add )+ )
                    	// MyGrammar.g:148:32: typeAssign ( add )+
                    	{
                    		PushFollow(FOLLOW_typeAssign_in_optionsChangeValue1111);
                    		typeAssign53 = typeAssign();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(typeAssign53.Tree, root_0);
                    		// MyGrammar.g:148:44: ( add )+
                    		int cnt12 = 0;
                    		do 
                    		{
                    		    int alt12 = 2;
                    		    alt12 = dfa12.Predict(input);
                    		    switch (alt12) 
                    			{
                    				case 1 :
                    				    // MyGrammar.g:0:0: add
                    				    {
                    				    	PushFollow(FOLLOW_add_in_optionsChangeValue1114);
                    				    	add54 = add();
                    				    	state.followingStackPointer--;
                    				    	if (state.failed) return retval;
                    				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add54.Tree);

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

    public class changeIDVALUE_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "changeIDVALUE"
    // MyGrammar.g:152:1: changeIDVALUE : ID optionsChangeValue ;
    public MyGrammarParser.changeIDVALUE_return changeIDVALUE() // throws RecognitionException [1]
    {   
        MyGrammarParser.changeIDVALUE_return retval = new MyGrammarParser.changeIDVALUE_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID55 = null;
        MyGrammarParser.optionsChangeValue_return optionsChangeValue56 = default(MyGrammarParser.optionsChangeValue_return);


        object ID55_tree=null;

        try 
    	{
            // MyGrammar.g:152:15: ( ID optionsChangeValue )
            // MyGrammar.g:152:17: ID optionsChangeValue
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ID55=(IToken)Match(input,ID,FOLLOW_ID_in_changeIDVALUE1131); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ID55_tree = (object)adaptor.Create(ID55);
            		root_0 = (object)adaptor.BecomeRoot(ID55_tree, root_0);
            	}
            	PushFollow(FOLLOW_optionsChangeValue_in_changeIDVALUE1134);
            	optionsChangeValue56 = optionsChangeValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, optionsChangeValue56.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "changeIDVALUE"

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
    // MyGrammar.g:156:1: methodDef : type ID '()' block -> ^( Method ^( ID ^( TYPE type ) block ) ) ;
    public MyGrammarParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        MyGrammarParser.methodDef_return retval = new MyGrammarParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID58 = null;
        IToken string_literal59 = null;
        MyGrammarParser.type_return type57 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block60 = default(MyGrammarParser.block_return);


        object ID58_tree=null;
        object string_literal59_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:156:11: ( type ID '()' block -> ^( Method ^( ID ^( TYPE type ) block ) ) )
            // MyGrammar.g:156:13: type ID '()' block
            {
            	PushFollow(FOLLOW_type_in_methodDef1148);
            	type57 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type57.Tree);
            	ID58=(IToken)Match(input,ID,FOLLOW_ID_in_methodDef1150); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID58);

            	string_literal59=(IToken)Match(input,57,FOLLOW_57_in_methodDef1152); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_57.Add(string_literal59);

            	PushFollow(FOLLOW_block_in_methodDef1154);
            	block60 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block60.Tree);


            	// AST REWRITE
            	// elements:          ID, type, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 156:32: -> ^( Method ^( ID ^( TYPE type ) block ) )
            	{
            	    // MyGrammar.g:156:35: ^( Method ^( ID ^( TYPE type ) block ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new MethodDef(Method), root_1);

            	    // MyGrammar.g:156:55: ^( ID ^( TYPE type ) block )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:156:60: ^( TYPE type )
            	    {
            	    object root_3 = (object)adaptor.GetNilNode();
            	    root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE, "TYPE"), root_3);

            	    adaptor.AddChild(root_3, stream_type.NextTree());

            	    adaptor.AddChild(root_2, root_3);
            	    }
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
    // MyGrammar.g:159:1: callMethod : ID '()' -> ^( CALLMETHOD ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID61 = null;
        IToken string_literal62 = null;

        object ID61_tree=null;
        object string_literal62_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:159:12: ( ID '()' -> ^( CALLMETHOD ID ) )
            // MyGrammar.g:159:14: ID '()'
            {
            	ID61=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod1186); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID61);

            	string_literal62=(IToken)Match(input,57,FOLLOW_57_in_callMethod1188); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_57.Add(string_literal62);



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
            	// 160:5: -> ^( CALLMETHOD ID )
            	{
            	    // MyGrammar.g:160:8: ^( CALLMETHOD ID )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALLMETHOD, "CALLMETHOD"), root_1);

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
    // MyGrammar.g:163:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_63 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_64 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:163:7: ( for_ | while_ )
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
                    // MyGrammar.g:163:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle1213);
                    	for_63 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_63.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:164:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle1219);
                    	while_64 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_64.Tree);

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
    // MyGrammar.g:167:1: for_ : FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' changeIDVALUE ')' block -> ^( FOR ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) changeIDVALUE block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR65 = null;
        IToken char_literal66 = null;
        IToken ID68 = null;
        IToken ASSIGN69 = null;
        IToken char_literal71 = null;
        IToken char_literal73 = null;
        IToken char_literal75 = null;
        MyGrammarParser.type_return type67 = default(MyGrammarParser.type_return);

        MyGrammarParser.add_return add70 = default(MyGrammarParser.add_return);

        MyGrammarParser.logicOperator_return logicOperator72 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.changeIDVALUE_return changeIDVALUE74 = default(MyGrammarParser.changeIDVALUE_return);

        MyGrammarParser.block_return block76 = default(MyGrammarParser.block_return);


        object FOR65_tree=null;
        object char_literal66_tree=null;
        object ID68_tree=null;
        object ASSIGN69_tree=null;
        object char_literal71_tree=null;
        object char_literal73_tree=null;
        object char_literal75_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_changeIDVALUE = new RewriteRuleSubtreeStream(adaptor,"rule changeIDVALUE");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:167:6: ( FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' changeIDVALUE ')' block -> ^( FOR ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) changeIDVALUE block ) )
            // MyGrammar.g:167:8: FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' changeIDVALUE ')' block
            {
            	FOR65=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_1230); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR65);

            	char_literal66=(IToken)Match(input,45,FOLLOW_45_in_for_1245); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal66);

            	// MyGrammar.g:169:7: ( type )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( ((LA15_0 >= INT && LA15_0 <= VOID)) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // MyGrammar.g:0:0: type
            	        {
            	        	PushFollow(FOLLOW_type_in_for_1254);
            	        	type67 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type67.Tree);

            	        }
            	        break;

            	}

            	ID68=(IToken)Match(input,ID,FOLLOW_ID_in_for_1257); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID68);

            	ASSIGN69=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_for_1259); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN69);

            	PushFollow(FOLLOW_add_in_for_1261);
            	add70 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add70.Tree);
            	char_literal71=(IToken)Match(input,58,FOLLOW_58_in_for_1263); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal71);

            	PushFollow(FOLLOW_logicOperator_in_for_1271);
            	logicOperator72 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator72.Tree);
            	char_literal73=(IToken)Match(input,58,FOLLOW_58_in_for_1273); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal73);

            	PushFollow(FOLLOW_changeIDVALUE_in_for_1279);
            	changeIDVALUE74 = changeIDVALUE();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_changeIDVALUE.Add(changeIDVALUE74.Tree);
            	char_literal75=(IToken)Match(input,46,FOLLOW_46_in_for_1284); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal75);

            	PushFollow(FOLLOW_block_in_for_1289);
            	block76 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block76.Tree);


            	// AST REWRITE
            	// elements:          FOR, ID, add, block, type, ASSIGN, logicOperator, changeIDVALUE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 174:4: -> ^( FOR ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) changeIDVALUE block )
            	{
            	    // MyGrammar.g:174:7: ^( FOR ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) changeIDVALUE block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ForNode(stream_FOR.NextToken()), root_1);

            	    // MyGrammar.g:174:22: ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR, "VAR"), root_2);

            	    // MyGrammar.g:174:28: ( type )?
            	    if ( stream_type.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_type.NextTree());

            	    }
            	    stream_type.Reset();
            	    // MyGrammar.g:174:34: ^( ID ^( ASSIGN add ) )
            	    {
            	    object root_3 = (object)adaptor.GetNilNode();
            	    root_3 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_3);

            	    // MyGrammar.g:174:39: ^( ASSIGN add )
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
            	    // MyGrammar.g:175:7: ^( CONDITION logicOperator )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_2);

            	    adaptor.AddChild(root_2, stream_logicOperator.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_changeIDVALUE.NextTree());
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
    // MyGrammar.g:180:1: while_ : WHILE '(' logicOperator ')' block -> ^( WHILE ^( CONDITION logicOperator ) block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE77 = null;
        IToken char_literal78 = null;
        IToken char_literal80 = null;
        MyGrammarParser.logicOperator_return logicOperator79 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block81 = default(MyGrammarParser.block_return);


        object WHILE77_tree=null;
        object char_literal78_tree=null;
        object char_literal80_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:180:8: ( WHILE '(' logicOperator ')' block -> ^( WHILE ^( CONDITION logicOperator ) block ) )
            // MyGrammar.g:180:10: WHILE '(' logicOperator ')' block
            {
            	WHILE77=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_1365); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE77);

            	char_literal78=(IToken)Match(input,45,FOLLOW_45_in_while_1370); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal78);

            	PushFollow(FOLLOW_logicOperator_in_while_1375);
            	logicOperator79 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator79.Tree);
            	char_literal80=(IToken)Match(input,46,FOLLOW_46_in_while_1380); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal80);

            	PushFollow(FOLLOW_block_in_while_1385);
            	block81 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block81.Tree);


            	// AST REWRITE
            	// elements:          WHILE, logicOperator, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 185:4: -> ^( WHILE ^( CONDITION logicOperator ) block )
            	{
            	    // MyGrammar.g:185:7: ^( WHILE ^( CONDITION logicOperator ) block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

            	    // MyGrammar.g:185:15: ^( CONDITION logicOperator )
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
    // MyGrammar.g:189:1: printExpr : ( add | ID | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID83 = null;
        MyGrammarParser.add_return add82 = default(MyGrammarParser.add_return);

        MyGrammarParser.callMethod_return callMethod84 = default(MyGrammarParser.callMethod_return);


        object ID83_tree=null;

        try 
    	{
            // MyGrammar.g:189:11: ( add | ID | callMethod )
            int alt16 = 3;
            int LA16_0 = input.LA(1);

            if ( ((LA16_0 >= INTEGER && LA16_0 <= REAL) || LA16_0 == 45) )
            {
                alt16 = 1;
            }
            else if ( (LA16_0 == ID) )
            {
                int LA16_2 = input.LA(2);

                if ( (LA16_2 == 57) )
                {
                    alt16 = 3;
                }
                else if ( (LA16_2 == 46) )
                {
                    alt16 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d16s2 =
                        new NoViableAltException("", 16, 2, input);

                    throw nvae_d16s2;
                }
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
                    // MyGrammar.g:189:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr1416);
                    	add82 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add82.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:190:6: ID
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID83=(IToken)Match(input,ID,FOLLOW_ID_in_printExpr1423); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID83_tree = (object)adaptor.Create(ID83);
                    		adaptor.AddChild(root_0, ID83_tree);
                    	}

                    }
                    break;
                case 3 :
                    // MyGrammar.g:191:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr1430);
                    	callMethod84 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod84.Tree);

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
    // MyGrammar.g:194:1: expr : ( add | if_ | varInit | oneArray | cycle | changeIDVALUE | callMethod | print );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add85 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_86 = default(MyGrammarParser.if__return);

        MyGrammarParser.varInit_return varInit87 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.oneArray_return oneArray88 = default(MyGrammarParser.oneArray_return);

        MyGrammarParser.cycle_return cycle89 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.changeIDVALUE_return changeIDVALUE90 = default(MyGrammarParser.changeIDVALUE_return);

        MyGrammarParser.callMethod_return callMethod91 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print92 = default(MyGrammarParser.print_return);



        try 
    	{
            // MyGrammar.g:194:6: ( add | if_ | varInit | oneArray | cycle | changeIDVALUE | callMethod | print )
            int alt17 = 8;
            alt17 = dfa17.Predict(input);
            switch (alt17) 
            {
                case 1 :
                    // MyGrammar.g:194:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr1444);
                    	add85 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add85.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:195:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr1450);
                    	if_86 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_86.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:196:5: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_expr1456);
                    	varInit87 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit87.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:197:5: oneArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_expr1462);
                    	oneArray88 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray88.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:198:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr1468);
                    	cycle89 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle89.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:199:5: changeIDVALUE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_changeIDVALUE_in_expr1474);
                    	changeIDVALUE90 = changeIDVALUE();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, changeIDVALUE90.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:200:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr1480);
                    	callMethod91 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod91.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:201:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr1486);
                    	print92 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print92.Tree);

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
    // MyGrammar.g:204:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal94 = null;
        MyGrammarParser.expr_return expr93 = default(MyGrammarParser.expr_return);


        object char_literal94_tree=null;

        try 
    	{
            // MyGrammar.g:204:6: ( expr ( ';' )* )
            // MyGrammar.g:204:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line1497);
            	expr93 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr93.Tree);
            	// MyGrammar.g:204:13: ( ';' )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == 58) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // MyGrammar.g:204:14: ';'
            			    {
            			    	char_literal94=(IToken)Match(input,58,FOLLOW_58_in_line1500); if (state.failed) return retval;

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
    // MyGrammar.g:207:1: exprList : methodDef ( ';' )* ;
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal96 = null;
        MyGrammarParser.methodDef_return methodDef95 = default(MyGrammarParser.methodDef_return);


        object char_literal96_tree=null;

        try 
    	{
            // MyGrammar.g:207:9: ( methodDef ( ';' )* )
            // MyGrammar.g:207:11: methodDef ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_methodDef_in_exprList1514);
            	methodDef95 = methodDef();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef95.Tree);
            	// MyGrammar.g:207:22: ( ';' )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == 58) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // MyGrammar.g:207:23: ';'
            			    {
            			    	char_literal96=(IToken)Match(input,58,FOLLOW_58_in_exprList1518); if (state.failed) return retval;

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
    // MyGrammar.g:213:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList97 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:213:13: ( ( exprList )* )
            // MyGrammar.g:214:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:214:4: ( exprList )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= INT && LA20_0 <= VOID)) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm1539);
            			    	exprList97 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList97.Tree);

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
    // MyGrammar.g:217:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm98 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:217:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:218:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program1553);
            	fullProgramm98 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm98.Tree);


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
            	// 218:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:218:19: ^( PROGRAM fullProgramm )
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
    // MyGrammar.g:221:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program99 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:221:8: ( program )
            // MyGrammar.g:222:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute1571);
            	program99 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program99.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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

    // $ANTLR start "synpred32_MyGrammar"
    public void synpred32_MyGrammar_fragment() {
        // MyGrammar.g:148:44: ( add )
        // MyGrammar.g:148:44: add
        {
        	PushFollow(FOLLOW_add_in_synpred32_MyGrammar1114);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_MyGrammar"

    // Delegated rules

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


   	protected DFA12 dfa12;
   	protected DFA17 dfa17;
	private void InitializeCyclicDFAs()
	{
    	this.dfa12 = new DFA12(this);
    	this.dfa17 = new DFA17(this);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);
	}

    const string DFA12_eotS =
        "\x0e\uffff";
    const string DFA12_eofS =
        "\x01\x01\x0d\uffff";
    const string DFA12_minS =
        "\x01\x07\x03\uffff\x02\x00\x08\uffff";
    const string DFA12_maxS =
        "\x01\x3a\x03\uffff\x02\x00\x08\uffff";
    const string DFA12_acceptS =
        "\x01\uffff\x01\x02\x0b\uffff\x01\x01";
    const string DFA12_specialS =
        "\x04\uffff\x01\x00\x01\x01\x08\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x01\x04\uffff\x01\x01\x0a\uffff\x05\x01\x08\uffff\x02"+
            "\x01\x01\uffff\x02\x05\x01\x01\x03\uffff\x01\x04\x01\x01\x01"+
            "\uffff\x01\x01\x09\uffff\x01\x01",
            "",
            "",
            "",
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
            get { return "()+ loopback of 148:44: ( add )+"; }
        }

    }


    protected internal int DFA12_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA12_4 = input.LA(1);

                   	 
                   	int index12_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_MyGrammar()) ) { s = 13; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index12_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA12_5 = input.LA(1);

                   	 
                   	int index12_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_MyGrammar()) ) { s = 13; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index12_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae12 =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae12);
        throw nvae12;
    }
    const string DFA17_eotS =
        "\x0c\uffff";
    const string DFA17_eofS =
        "\x07\uffff\x01\x0b\x04\uffff";
    const string DFA17_minS =
        "\x01\x07\x02\uffff\x01\x29\x01\uffff\x01\x10\x01\uffff\x01\x07"+
        "\x04\uffff";
    const string DFA17_maxS =
        "\x01\x2d\x02\uffff\x01\x29\x01\uffff\x01\x39\x01\uffff\x01\x3a"+
        "\x04\uffff";
    const string DFA17_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x05\x01\uffff\x01\x08"+
        "\x01\uffff\x01\x07\x01\x06\x01\x04\x01\x03";
    const string DFA17_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x06\x04\uffff\x01\x02\x0a\uffff\x05\x03\x08\uffff\x02"+
            "\x04\x01\uffff\x02\x01\x01\x05\x03\uffff\x01\x01",
            "",
            "",
            "\x01\x07",
            "",
            "\x07\x09\x22\uffff\x01\x08",
            "",
            "\x01\x0b\x04\uffff\x01\x0b\x03\uffff\x01\x0b\x06\uffff\x05"+
            "\x0b\x08\uffff\x02\x0b\x01\uffff\x03\x0b\x01\uffff\x01\x0a\x01"+
            "\uffff\x01\x0b\x02\uffff\x01\x0b\x09\uffff\x01\x0b",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "194:1: expr : ( add | if_ | varInit | oneArray | cycle | changeIDVALUE | callMethod | print );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_incDec0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_varInit709 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ID_in_varInit711 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_varInit714 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_add_in_varInit716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_oneArray753 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ID_in_oneArray755 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_oneArray757 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_number_in_oneArray759 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_oneArray761 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_group793 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_add_in_group796 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_group798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult821 = new BitSet(new ulong[]{0x0000000000000C02UL});
    public static readonly BitSet FOLLOW_set_in_mult824 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_group_in_mult833 = new BitSet(new ulong[]{0x0000000000000C02UL});
    public static readonly BitSet FOLLOW_mult_in_add845 = new BitSet(new ulong[]{0x0000000000000302UL});
    public static readonly BitSet FOLLOW_set_in_add848 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_mult_in_add857 = new BitSet(new ulong[]{0x0000000000000302UL});
    public static readonly BitSet FOLLOW_PRINT_in_print868 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_print870 = new BitSet(new ulong[]{0x0000238000000000UL});
    public static readonly BitSet FOLLOW_printExpr_in_print872 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_print874 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_block896 = new BitSet(new ulong[]{0x000123B00F801080UL});
    public static readonly BitSet FOLLOW_line_in_block898 = new BitSet(new ulong[]{0x000123B00F801080UL});
    public static readonly BitSet FOLLOW_48_in_block901 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_928 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_if_930 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_932 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_if_934 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_936 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_ELSE_in_if_939 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_941 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator981 = new BitSet(new ulong[]{0x0000218000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation996 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_49_in_orOperation1000 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation1003 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation1018 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_andOperation1022 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation1025 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1040 = new BitSet(new ulong[]{0x0018000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOperation1044 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1053 = new BitSet(new ulong[]{0x0018000000000002UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1070 = new BitSet(new ulong[]{0x01E0000000000002UL});
    public static readonly BitSet FOLLOW_set_in_defaultOperation1074 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1090 = new BitSet(new ulong[]{0x01E0000000000002UL});
    public static readonly BitSet FOLLOW_incDec_in_optionsChangeValue1106 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeAssign_in_optionsChangeValue1111 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_add_in_optionsChangeValue1114 = new BitSet(new ulong[]{0x0000218000000002UL});
    public static readonly BitSet FOLLOW_ID_in_changeIDVALUE1131 = new BitSet(new ulong[]{0x00000000007F0000UL});
    public static readonly BitSet FOLLOW_optionsChangeValue_in_changeIDVALUE1134 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_methodDef1148 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ID_in_methodDef1150 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_methodDef1152 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_block_in_methodDef1154 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod1186 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_callMethod1188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle1213 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle1219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_1230 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_for_1245 = new BitSet(new ulong[]{0x000002000F800000UL});
    public static readonly BitSet FOLLOW_type_in_for_1254 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ID_in_for_1257 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_for_1259 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_add_in_for_1261 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_for_1263 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_1271 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_for_1273 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_changeIDVALUE_in_for_1279 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_for_1284 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_block_in_for_1289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_1365 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_while_1370 = new BitSet(new ulong[]{0x0000218000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_1375 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_while_1380 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_block_in_while_1385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr1416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_printExpr1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr1430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr1444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr1450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_expr1456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_oneArray_in_expr1462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr1468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_changeIDVALUE_in_expr1474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr1480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr1486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line1497 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_58_in_line1500 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_methodDef_in_exprList1514 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_58_in_exprList1518 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm1539 = new BitSet(new ulong[]{0x000000000F800002UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program1553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute1571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred32_MyGrammar1114 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}