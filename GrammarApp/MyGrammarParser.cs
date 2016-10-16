// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-10-17 02:47:05

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

    public const int PRINT = 5;
    public const int T__50 = 50;
    public const int VAR = 26;
    public const int DECREMENT = 20;
    public const int MINUS = 7;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int ELSE = 11;
    public const int CALLMETHOD = 33;
    public const int ID = 39;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int IF = 10;
    public const int TYPE = 31;
    public const int T__53 = 53;
    public const int MINUSASSIGN = 16;
    public const int T__54 = 54;
    public const int INTEGER = 37;
    public const int BLOCK = 12;
    public const int ONEARRAY = 27;
    public const int FOR = 34;
    public const int REAL = 38;
    public const int PUBLIC = 30;
    public const int MULTIPLY = 8;
    public const int CONDITION = 13;
    public const int COUNT = 28;
    public const int VOID = 25;
    public const int PROGRAM = 4;
    public const int PLUS = 6;
    public const int DIVIDEASSIGN = 18;
    public const int FLOAT = 22;
    public const int MULTASSIGN = 17;
    public const int CHAR = 24;
    public const int ASSIGN = 14;
    public const int INT = 21;
    public const int DIVIDE = 9;
    public const int PLUSASSIGN = 15;
    public const int DOUBLE = 23;
    public const int WS = 40;
    public const int EOF = -1;
    public const int MOD = 32;
    public const int INCREMENT_ = 36;
    public const int PRIVATE = 29;
    public const int INCREMENT = 19;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__46 = 46;
    public const int WHILE = 35;
    public const int T__47 = 47;
    public const int T__41 = 41;
    public const int T__42 = 42;
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
    // MyGrammar.g:62:1: number : ( INTEGER | REAL | ID );
    public MyGrammarParser.number_return number() // throws RecognitionException [1]
    {   
        MyGrammarParser.number_return retval = new MyGrammarParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:63:2: ( INTEGER | REAL | ID )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set1 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INTEGER && input.LA(1) <= ID) ) 
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
    // $ANTLR end "number"

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
    // MyGrammar.g:68:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:68:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set2 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PLUS && input.LA(1) <= DIVIDE) ) 
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
    // $ANTLR end "elementarySign"

    public class var_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "var"
    // MyGrammar.g:77:1: var : type ID ( ASSIGN add )? -> ^( type ^( ID ( ^( ASSIGN add ) )? ) ) ;
    public MyGrammarParser.var_return var() // throws RecognitionException [1]
    {   
        MyGrammarParser.var_return retval = new MyGrammarParser.var_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID4 = null;
        IToken ASSIGN5 = null;
        MyGrammarParser.type_return type3 = default(MyGrammarParser.type_return);

        MyGrammarParser.add_return add6 = default(MyGrammarParser.add_return);


        object ID4_tree=null;
        object ASSIGN5_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:77:6: ( type ID ( ASSIGN add )? -> ^( type ^( ID ( ^( ASSIGN add ) )? ) ) )
            // MyGrammar.g:77:8: type ID ( ASSIGN add )?
            {
            	PushFollow(FOLLOW_type_in_var588);
            	type3 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type3.Tree);
            	ID4=(IToken)Match(input,ID,FOLLOW_ID_in_var590); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID4);

            	// MyGrammar.g:77:16: ( ASSIGN add )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == ASSIGN) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // MyGrammar.g:77:17: ASSIGN add
            	        {
            	        	ASSIGN5=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_var593); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN5);

            	        	PushFollow(FOLLOW_add_in_var595);
            	        	add6 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_add.Add(add6.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          type, add, ID, ASSIGN
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 77:30: -> ^( type ^( ID ( ^( ASSIGN add ) )? ) )
            	{
            	    // MyGrammar.g:77:34: ^( type ^( ID ( ^( ASSIGN add ) )? ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

            	    // MyGrammar.g:77:41: ^( ID ( ^( ASSIGN add ) )? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:77:46: ( ^( ASSIGN add ) )?
            	    if ( stream_add.HasNext() || stream_ASSIGN.HasNext() )
            	    {
            	        // MyGrammar.g:77:46: ^( ASSIGN add )
            	        {
            	        object root_3 = (object)adaptor.GetNilNode();
            	        root_3 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_3);

            	        adaptor.AddChild(root_3, stream_add.NextTree());

            	        adaptor.AddChild(root_2, root_3);
            	        }

            	    }
            	    stream_add.Reset();
            	    stream_ASSIGN.Reset();

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
    // $ANTLR end "var"

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
    // MyGrammar.g:80:1: oneArray : type ID '[' number ']' -> ^( ONEARRAY ^( ID ^( COUNT number ) ) ) ;
    public MyGrammarParser.oneArray_return oneArray() // throws RecognitionException [1]
    {   
        MyGrammarParser.oneArray_return retval = new MyGrammarParser.oneArray_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID8 = null;
        IToken char_literal9 = null;
        IToken char_literal11 = null;
        MyGrammarParser.type_return type7 = default(MyGrammarParser.type_return);

        MyGrammarParser.number_return number10 = default(MyGrammarParser.number_return);


        object ID8_tree=null;
        object char_literal9_tree=null;
        object char_literal11_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:80:10: ( type ID '[' number ']' -> ^( ONEARRAY ^( ID ^( COUNT number ) ) ) )
            // MyGrammar.g:80:12: type ID '[' number ']'
            {
            	PushFollow(FOLLOW_type_in_oneArray626);
            	type7 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type7.Tree);
            	ID8=(IToken)Match(input,ID,FOLLOW_ID_in_oneArray628); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID8);

            	char_literal9=(IToken)Match(input,41,FOLLOW_41_in_oneArray630); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal9);

            	PushFollow(FOLLOW_number_in_oneArray632);
            	number10 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number10.Tree);
            	char_literal11=(IToken)Match(input,42,FOLLOW_42_in_oneArray634); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal11);



            	// AST REWRITE
            	// elements:          ID, number
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 81:5: -> ^( ONEARRAY ^( ID ^( COUNT number ) ) )
            	{
            	    // MyGrammar.g:81:8: ^( ONEARRAY ^( ID ^( COUNT number ) ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ONEARRAY, "ONEARRAY"), root_1);

            	    // MyGrammar.g:81:19: ^( ID ^( COUNT number ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:81:24: ^( COUNT number )
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
    // MyGrammar.g:84:1: type : ( INT | FLOAT | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set12 = null;

        object set12_tree=null;

        try 
    	{
            // MyGrammar.g:84:6: ( INT | FLOAT | DOUBLE | CHAR | VOID )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set12 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INT && input.LA(1) <= VOID) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set12));
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

    public class accessMod_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "accessMod"
    // MyGrammar.g:91:1: accessMod : ( PRIVATE | PUBLIC );
    public MyGrammarParser.accessMod_return accessMod() // throws RecognitionException [1]
    {   
        MyGrammarParser.accessMod_return retval = new MyGrammarParser.accessMod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set13 = null;

        object set13_tree=null;

        try 
    	{
            // MyGrammar.g:91:11: ( PRIVATE | PUBLIC )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set13 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= PRIVATE && input.LA(1) <= PUBLIC) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set13));
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
    // $ANTLR end "accessMod"

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
    // MyGrammar.g:95:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // MyGrammar.g:95:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set14 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= ASSIGN && input.LA(1) <= DIVIDEASSIGN) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set14));
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
    // MyGrammar.g:102:1: incDec : ( INCREMENT | DECREMENT );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set15 = null;

        object set15_tree=null;

        try 
    	{
            // MyGrammar.g:102:8: ( INCREMENT | DECREMENT )
            // MyGrammar.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set15 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INCREMENT && input.LA(1) <= DECREMENT) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set15));
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

        IToken char_literal16 = null;
        IToken char_literal18 = null;
        MyGrammarParser.add_return add17 = default(MyGrammarParser.add_return);

        MyGrammarParser.number_return number19 = default(MyGrammarParser.number_return);


        object char_literal16_tree=null;
        object char_literal18_tree=null;

        try 
    	{
            // MyGrammar.g:111:7: ( '(' add ')' | number )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == 43) )
            {
                alt2 = 1;
            }
            else if ( ((LA2_0 >= INTEGER && LA2_0 <= ID)) )
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

                    	char_literal16=(IToken)Match(input,43,FOLLOW_43_in_group785); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group788);
                    	add17 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);
                    	char_literal18=(IToken)Match(input,44,FOLLOW_44_in_group790); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:112:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group798);
                    	number19 = number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number19.Tree);

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

        IToken set21 = null;
        MyGrammarParser.group_return group20 = default(MyGrammarParser.group_return);

        MyGrammarParser.group_return group22 = default(MyGrammarParser.group_return);


        object set21_tree=null;

        try 
    	{
            // MyGrammar.g:115:6: ( group ( ( MULTIPLY | DIVIDE ) group )* )
            // MyGrammar.g:115:8: group ( ( MULTIPLY | DIVIDE ) group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult813);
            	group20 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group20.Tree);
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
            			    	set21=(IToken)input.LT(1);
            			    	set21 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= MULTIPLY && input.LA(1) <= DIVIDE) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set21), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_group_in_mult825);
            			    	group22 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group22.Tree);

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

        IToken set24 = null;
        MyGrammarParser.mult_return mult23 = default(MyGrammarParser.mult_return);

        MyGrammarParser.mult_return mult25 = default(MyGrammarParser.mult_return);


        object set24_tree=null;

        try 
    	{
            // MyGrammar.g:117:6: ( mult ( ( PLUS | MINUS ) mult )* )
            // MyGrammar.g:117:8: mult ( ( PLUS | MINUS ) mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add837);
            	mult23 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult23.Tree);
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
            			    	set24=(IToken)input.LT(1);
            			    	set24 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= PLUS && input.LA(1) <= MINUS) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set24), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add849);
            			    	mult25 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult25.Tree);

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

        IToken PRINT26 = null;
        IToken char_literal27 = null;
        IToken char_literal29 = null;
        MyGrammarParser.printExpr_return printExpr28 = default(MyGrammarParser.printExpr_return);


        object PRINT26_tree=null;
        object char_literal27_tree=null;
        object char_literal29_tree=null;
        RewriteRuleTokenStream stream_PRINT = new RewriteRuleTokenStream(adaptor,"token PRINT");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_printExpr = new RewriteRuleSubtreeStream(adaptor,"rule printExpr");
        try 
    	{
            // MyGrammar.g:119:7: ( PRINT '(' printExpr ')' -> ^( PRINT printExpr ) )
            // MyGrammar.g:119:9: PRINT '(' printExpr ')'
            {
            	PRINT26=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print860); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINT.Add(PRINT26);

            	char_literal27=(IToken)Match(input,43,FOLLOW_43_in_print862); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal27);

            	PushFollow(FOLLOW_printExpr_in_print864);
            	printExpr28 = printExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_printExpr.Add(printExpr28.Tree);
            	char_literal29=(IToken)Match(input,44,FOLLOW_44_in_print866); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal29);



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

        IToken char_literal30 = null;
        IToken char_literal32 = null;
        MyGrammarParser.line_return line31 = default(MyGrammarParser.line_return);


        object char_literal30_tree=null;
        object char_literal32_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:123:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:123:9: '{' ( line )* '}'
            {
            	char_literal30=(IToken)Match(input,45,FOLLOW_45_in_block888); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal30);

            	// MyGrammar.g:123:13: ( line )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == PRINT || LA5_0 == IF || (LA5_0 >= INT && LA5_0 <= VOID) || (LA5_0 >= FOR && LA5_0 <= WHILE) || (LA5_0 >= INTEGER && LA5_0 <= ID) || LA5_0 == 43) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block890);
            			    	line31 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line31.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	char_literal32=(IToken)Match(input,46,FOLLOW_46_in_block893); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal32);



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
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // MyGrammar.g:123:34: ( line )*
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

        IToken IF33 = null;
        IToken char_literal34 = null;
        IToken char_literal36 = null;
        IToken ELSE38 = null;
        MyGrammarParser.logicOperator_return logicOperator35 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block37 = default(MyGrammarParser.block_return);

        MyGrammarParser.block_return block39 = default(MyGrammarParser.block_return);


        object IF33_tree=null;
        object char_literal34_tree=null;
        object char_literal36_tree=null;
        object ELSE38_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:129:6: ( IF '(' logicOperator ')' block ( ELSE block )? -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? ) )
            // MyGrammar.g:129:8: IF '(' logicOperator ')' block ( ELSE block )?
            {
            	IF33=(IToken)Match(input,IF,FOLLOW_IF_in_if_917); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF33);

            	char_literal34=(IToken)Match(input,43,FOLLOW_43_in_if_919); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal34);

            	PushFollow(FOLLOW_logicOperator_in_if_921);
            	logicOperator35 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator35.Tree);
            	char_literal36=(IToken)Match(input,44,FOLLOW_44_in_if_923); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal36);

            	PushFollow(FOLLOW_block_in_if_925);
            	block37 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block37.Tree);
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
            	        	ELSE38=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_if_928); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE38);

            	        	PushFollow(FOLLOW_block_in_if_930);
            	        	block39 = block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block.Add(block39.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ELSE, block, IF, logicOperator, block
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
            	    if ( stream_ELSE.HasNext() || stream_block.HasNext() )
            	    {
            	        // MyGrammar.g:130:45: ^( ELSE block )
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
    // MyGrammar.g:133:1: logicOperator : ( orOperation )+ ;
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation40 = default(MyGrammarParser.orOperation_return);



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

            	    if ( ((LA7_0 >= INTEGER && LA7_0 <= ID) || LA7_0 == 43) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: orOperation
            			    {
            			    	PushFollow(FOLLOW_orOperation_in_logicOperator970);
            			    	orOperation40 = orOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation40.Tree);

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

        IToken string_literal42 = null;
        MyGrammarParser.andOperation_return andOperation41 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.andOperation_return andOperation43 = default(MyGrammarParser.andOperation_return);


        object string_literal42_tree=null;

        try 
    	{
            // MyGrammar.g:136:14: ( andOperation ( '||' andOperation )* )
            // MyGrammar.g:136:16: andOperation ( '||' andOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_andOperation_in_orOperation985);
            	andOperation41 = andOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation41.Tree);
            	// MyGrammar.g:136:29: ( '||' andOperation )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 47) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // MyGrammar.g:136:31: '||' andOperation
            			    {
            			    	string_literal42=(IToken)Match(input,47,FOLLOW_47_in_orOperation989); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal42_tree = (object)adaptor.Create(string_literal42);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal42_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_andOperation_in_orOperation992);
            			    	andOperation43 = andOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation43.Tree);

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

        IToken string_literal45 = null;
        MyGrammarParser.equalityOperation_return equalityOperation44 = default(MyGrammarParser.equalityOperation_return);

        MyGrammarParser.equalityOperation_return equalityOperation46 = default(MyGrammarParser.equalityOperation_return);


        object string_literal45_tree=null;

        try 
    	{
            // MyGrammar.g:139:14: ( equalityOperation ( '&&' equalityOperation )* )
            // MyGrammar.g:139:16: equalityOperation ( '&&' equalityOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityOperation_in_andOperation1007);
            	equalityOperation44 = equalityOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation44.Tree);
            	// MyGrammar.g:139:34: ( '&&' equalityOperation )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 48) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // MyGrammar.g:139:36: '&&' equalityOperation
            			    {
            			    	string_literal45=(IToken)Match(input,48,FOLLOW_48_in_andOperation1011); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal45_tree = (object)adaptor.Create(string_literal45);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal45_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityOperation_in_andOperation1014);
            			    	equalityOperation46 = equalityOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation46.Tree);

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

        IToken set48 = null;
        MyGrammarParser.defaultOperation_return defaultOperation47 = default(MyGrammarParser.defaultOperation_return);

        MyGrammarParser.defaultOperation_return defaultOperation49 = default(MyGrammarParser.defaultOperation_return);


        object set48_tree=null;

        try 
    	{
            // MyGrammar.g:142:19: ( defaultOperation ( ( '==' | '!=' ) defaultOperation )* )
            // MyGrammar.g:142:21: defaultOperation ( ( '==' | '!=' ) defaultOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1029);
            	defaultOperation47 = defaultOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation47.Tree);
            	// MyGrammar.g:142:38: ( ( '==' | '!=' ) defaultOperation )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= 49 && LA10_0 <= 50)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MyGrammar.g:142:40: ( '==' | '!=' ) defaultOperation
            			    {
            			    	set48=(IToken)input.LT(1);
            			    	set48 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 49 && input.LA(1) <= 50) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set48), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1042);
            			    	defaultOperation49 = defaultOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation49.Tree);

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

        IToken set51 = null;
        MyGrammarParser.add_return add50 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add52 = default(MyGrammarParser.add_return);


        object set51_tree=null;

        try 
    	{
            // MyGrammar.g:145:18: ( add ( ( '>' | '<' | '>=' | '<=' ) add )* )
            // MyGrammar.g:145:21: add ( ( '>' | '<' | '>=' | '<=' ) add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_defaultOperation1059);
            	add50 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add50.Tree);
            	// MyGrammar.g:145:25: ( ( '>' | '<' | '>=' | '<=' ) add )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= 51 && LA11_0 <= 54)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MyGrammar.g:145:27: ( '>' | '<' | '>=' | '<=' ) add
            			    {
            			    	set51=(IToken)input.LT(1);
            			    	set51 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 51 && input.LA(1) <= 54) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set51), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_add_in_defaultOperation1079);
            			    	add52 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add52.Tree);

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

        MyGrammarParser.incDec_return incDec53 = default(MyGrammarParser.incDec_return);

        MyGrammarParser.typeAssign_return typeAssign54 = default(MyGrammarParser.typeAssign_return);

        MyGrammarParser.add_return add55 = default(MyGrammarParser.add_return);



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

                    	PushFollow(FOLLOW_incDec_in_optionsChangeValue1095);
                    	incDec53 = incDec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, incDec53.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:148:31: ( typeAssign ( add )+ )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// MyGrammar.g:148:31: ( typeAssign ( add )+ )
                    	// MyGrammar.g:148:32: typeAssign ( add )+
                    	{
                    		PushFollow(FOLLOW_typeAssign_in_optionsChangeValue1100);
                    		typeAssign54 = typeAssign();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(typeAssign54.Tree, root_0);
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
                    				    	PushFollow(FOLLOW_add_in_optionsChangeValue1103);
                    				    	add55 = add();
                    				    	state.followingStackPointer--;
                    				    	if (state.failed) return retval;
                    				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add55.Tree);

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

        IToken ID56 = null;
        MyGrammarParser.optionsChangeValue_return optionsChangeValue57 = default(MyGrammarParser.optionsChangeValue_return);


        object ID56_tree=null;

        try 
    	{
            // MyGrammar.g:152:15: ( ID optionsChangeValue )
            // MyGrammar.g:152:17: ID optionsChangeValue
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ID56=(IToken)Match(input,ID,FOLLOW_ID_in_changeIDVALUE1120); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ID56_tree = (object)adaptor.Create(ID56);
            		root_0 = (object)adaptor.BecomeRoot(ID56_tree, root_0);
            	}
            	PushFollow(FOLLOW_optionsChangeValue_in_changeIDVALUE1123);
            	optionsChangeValue57 = optionsChangeValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, optionsChangeValue57.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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

    public class method_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "method"
    // MyGrammar.g:156:1: method : ( accessMod )? type ID '()' block -> ^( ID ^( MOD ( accessMod )? ) ^( TYPE type ) block ) ;
    public MyGrammarParser.method_return method() // throws RecognitionException [1]
    {   
        MyGrammarParser.method_return retval = new MyGrammarParser.method_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID60 = null;
        IToken string_literal61 = null;
        MyGrammarParser.accessMod_return accessMod58 = default(MyGrammarParser.accessMod_return);

        MyGrammarParser.type_return type59 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block62 = default(MyGrammarParser.block_return);


        object ID60_tree=null;
        object string_literal61_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_accessMod = new RewriteRuleSubtreeStream(adaptor,"rule accessMod");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:156:8: ( ( accessMod )? type ID '()' block -> ^( ID ^( MOD ( accessMod )? ) ^( TYPE type ) block ) )
            // MyGrammar.g:156:10: ( accessMod )? type ID '()' block
            {
            	// MyGrammar.g:156:10: ( accessMod )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( ((LA14_0 >= PRIVATE && LA14_0 <= PUBLIC)) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // MyGrammar.g:0:0: accessMod
            	        {
            	        	PushFollow(FOLLOW_accessMod_in_method1137);
            	        	accessMod58 = accessMod();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_accessMod.Add(accessMod58.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_type_in_method1140);
            	type59 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type59.Tree);
            	ID60=(IToken)Match(input,ID,FOLLOW_ID_in_method1142); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID60);

            	string_literal61=(IToken)Match(input,55,FOLLOW_55_in_method1144); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(string_literal61);

            	PushFollow(FOLLOW_block_in_method1147);
            	block62 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block62.Tree);


            	// AST REWRITE
            	// elements:          type, ID, block, accessMod
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 156:41: -> ^( ID ^( MOD ( accessMod )? ) ^( TYPE type ) block )
            	{
            	    // MyGrammar.g:156:44: ^( ID ^( MOD ( accessMod )? ) ^( TYPE type ) block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_1);

            	    // MyGrammar.g:156:49: ^( MOD ( accessMod )? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MOD, "MOD"), root_2);

            	    // MyGrammar.g:156:55: ( accessMod )?
            	    if ( stream_accessMod.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_accessMod.NextTree());

            	    }
            	    stream_accessMod.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // MyGrammar.g:156:67: ^( TYPE type )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE, "TYPE"), root_2);

            	    adaptor.AddChild(root_2, stream_type.NextTree());

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
    // $ANTLR end "method"

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

        IToken ID63 = null;
        IToken string_literal64 = null;

        object ID63_tree=null;
        object string_literal64_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:159:12: ( ID '()' -> ^( CALLMETHOD ID ) )
            // MyGrammar.g:159:14: ID '()'
            {
            	ID63=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod1179); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID63);

            	string_literal64=(IToken)Match(input,55,FOLLOW_55_in_callMethod1181); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(string_literal64);



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

        MyGrammarParser.for__return for_65 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_66 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:163:7: ( for_ | while_ )
            int alt15 = 2;
            int LA15_0 = input.LA(1);

            if ( (LA15_0 == FOR) )
            {
                alt15 = 1;
            }
            else if ( (LA15_0 == WHILE) )
            {
                alt15 = 2;
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
                    // MyGrammar.g:163:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle1206);
                    	for_65 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_65.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:164:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle1212);
                    	while_66 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_66.Tree);

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

        IToken FOR67 = null;
        IToken char_literal68 = null;
        IToken ID70 = null;
        IToken ASSIGN71 = null;
        IToken char_literal73 = null;
        IToken char_literal75 = null;
        IToken char_literal77 = null;
        MyGrammarParser.type_return type69 = default(MyGrammarParser.type_return);

        MyGrammarParser.add_return add72 = default(MyGrammarParser.add_return);

        MyGrammarParser.logicOperator_return logicOperator74 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.changeIDVALUE_return changeIDVALUE76 = default(MyGrammarParser.changeIDVALUE_return);

        MyGrammarParser.block_return block78 = default(MyGrammarParser.block_return);


        object FOR67_tree=null;
        object char_literal68_tree=null;
        object ID70_tree=null;
        object ASSIGN71_tree=null;
        object char_literal73_tree=null;
        object char_literal75_tree=null;
        object char_literal77_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
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
            	FOR67=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_1223); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR67);

            	char_literal68=(IToken)Match(input,43,FOLLOW_43_in_for_1238); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal68);

            	// MyGrammar.g:169:7: ( type )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( ((LA16_0 >= INT && LA16_0 <= VOID)) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // MyGrammar.g:0:0: type
            	        {
            	        	PushFollow(FOLLOW_type_in_for_1248);
            	        	type69 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type69.Tree);

            	        }
            	        break;

            	}

            	ID70=(IToken)Match(input,ID,FOLLOW_ID_in_for_1251); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID70);

            	ASSIGN71=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_for_1253); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN71);

            	PushFollow(FOLLOW_add_in_for_1255);
            	add72 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add72.Tree);
            	char_literal73=(IToken)Match(input,56,FOLLOW_56_in_for_1257); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal73);

            	PushFollow(FOLLOW_logicOperator_in_for_1267);
            	logicOperator74 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator74.Tree);
            	char_literal75=(IToken)Match(input,56,FOLLOW_56_in_for_1269); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal75);

            	PushFollow(FOLLOW_changeIDVALUE_in_for_1276);
            	changeIDVALUE76 = changeIDVALUE();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_changeIDVALUE.Add(changeIDVALUE76.Tree);
            	char_literal77=(IToken)Match(input,44,FOLLOW_44_in_for_1281); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal77);

            	PushFollow(FOLLOW_block_in_for_1287);
            	block78 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block78.Tree);


            	// AST REWRITE
            	// elements:          ASSIGN, add, changeIDVALUE, ID, FOR, block, type, logicOperator
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
            	    root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

            	    // MyGrammar.g:174:13: ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR, "VAR"), root_2);

            	    // MyGrammar.g:174:19: ( type )?
            	    if ( stream_type.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_type.NextTree());

            	    }
            	    stream_type.Reset();
            	    // MyGrammar.g:174:25: ^( ID ^( ASSIGN add ) )
            	    {
            	    object root_3 = (object)adaptor.GetNilNode();
            	    root_3 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_3);

            	    // MyGrammar.g:174:30: ^( ASSIGN add )
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

        IToken WHILE79 = null;
        IToken char_literal80 = null;
        IToken char_literal82 = null;
        MyGrammarParser.logicOperator_return logicOperator81 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block83 = default(MyGrammarParser.block_return);


        object WHILE79_tree=null;
        object char_literal80_tree=null;
        object char_literal82_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:180:8: ( WHILE '(' logicOperator ')' block -> ^( WHILE ^( CONDITION logicOperator ) block ) )
            // MyGrammar.g:180:10: WHILE '(' logicOperator ')' block
            {
            	WHILE79=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_1360); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE79);

            	char_literal80=(IToken)Match(input,43,FOLLOW_43_in_while_1365); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal80);

            	PushFollow(FOLLOW_logicOperator_in_while_1371);
            	logicOperator81 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator81.Tree);
            	char_literal82=(IToken)Match(input,44,FOLLOW_44_in_while_1376); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal82);

            	PushFollow(FOLLOW_block_in_while_1382);
            	block83 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block83.Tree);


            	// AST REWRITE
            	// elements:          block, logicOperator, WHILE
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
    // MyGrammar.g:190:1: printExpr : ( add | ID | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID85 = null;
        MyGrammarParser.add_return add84 = default(MyGrammarParser.add_return);

        MyGrammarParser.callMethod_return callMethod86 = default(MyGrammarParser.callMethod_return);


        object ID85_tree=null;

        try 
    	{
            // MyGrammar.g:190:11: ( add | ID | callMethod )
            int alt17 = 3;
            int LA17_0 = input.LA(1);

            if ( ((LA17_0 >= INTEGER && LA17_0 <= REAL) || LA17_0 == 43) )
            {
                alt17 = 1;
            }
            else if ( (LA17_0 == ID) )
            {
                int LA17_2 = input.LA(2);

                if ( (LA17_2 == 55) )
                {
                    alt17 = 3;
                }
                else if ( (synpred38_MyGrammar()) )
                {
                    alt17 = 1;
                }
                else if ( (synpred39_MyGrammar()) )
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
                    // MyGrammar.g:190:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr1414);
                    	add84 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add84.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:191:6: ID
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ID85=(IToken)Match(input,ID,FOLLOW_ID_in_printExpr1421); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ID85_tree = (object)adaptor.Create(ID85);
                    		adaptor.AddChild(root_0, ID85_tree);
                    	}

                    }
                    break;
                case 3 :
                    // MyGrammar.g:192:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr1428);
                    	callMethod86 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod86.Tree);

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
    // MyGrammar.g:195:1: expr : ( add | if_ | var | oneArray | cycle | changeIDVALUE | callMethod | print );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add87 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_88 = default(MyGrammarParser.if__return);

        MyGrammarParser.var_return var89 = default(MyGrammarParser.var_return);

        MyGrammarParser.oneArray_return oneArray90 = default(MyGrammarParser.oneArray_return);

        MyGrammarParser.cycle_return cycle91 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.changeIDVALUE_return changeIDVALUE92 = default(MyGrammarParser.changeIDVALUE_return);

        MyGrammarParser.callMethod_return callMethod93 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print94 = default(MyGrammarParser.print_return);



        try 
    	{
            // MyGrammar.g:195:6: ( add | if_ | var | oneArray | cycle | changeIDVALUE | callMethod | print )
            int alt18 = 8;
            alt18 = dfa18.Predict(input);
            switch (alt18) 
            {
                case 1 :
                    // MyGrammar.g:195:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr1442);
                    	add87 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add87.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:196:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr1448);
                    	if_88 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_88.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:197:5: var
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_var_in_expr1454);
                    	var89 = var();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var89.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:198:5: oneArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_expr1460);
                    	oneArray90 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray90.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:199:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr1466);
                    	cycle91 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle91.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:200:5: changeIDVALUE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_changeIDVALUE_in_expr1472);
                    	changeIDVALUE92 = changeIDVALUE();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, changeIDVALUE92.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:201:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr1478);
                    	callMethod93 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod93.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:202:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr1484);
                    	print94 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print94.Tree);

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
    // MyGrammar.g:205:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal96 = null;
        MyGrammarParser.expr_return expr95 = default(MyGrammarParser.expr_return);


        object char_literal96_tree=null;

        try 
    	{
            // MyGrammar.g:205:6: ( expr ( ';' )* )
            // MyGrammar.g:205:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line1495);
            	expr95 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr95.Tree);
            	// MyGrammar.g:205:13: ( ';' )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == 56) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // MyGrammar.g:205:14: ';'
            			    {
            			    	char_literal96=(IToken)Match(input,56,FOLLOW_56_in_line1498); if (state.failed) return retval;

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
    // MyGrammar.g:208:1: exprList : ( line | method ( ';' )* );
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal99 = null;
        MyGrammarParser.line_return line97 = default(MyGrammarParser.line_return);

        MyGrammarParser.method_return method98 = default(MyGrammarParser.method_return);


        object char_literal99_tree=null;

        try 
    	{
            // MyGrammar.g:208:9: ( line | method ( ';' )* )
            int alt21 = 2;
            switch ( input.LA(1) ) 
            {
            case PRINT:
            case IF:
            case FOR:
            case WHILE:
            case INTEGER:
            case REAL:
            case ID:
            case 43:
            	{
                alt21 = 1;
                }
                break;
            case INT:
            case FLOAT:
            case DOUBLE:
            case CHAR:
            case VOID:
            	{
                int LA21_2 = input.LA(2);

                if ( (LA21_2 == ID) )
                {
                    int LA21_4 = input.LA(3);

                    if ( (LA21_4 == 55) )
                    {
                        alt21 = 2;
                    }
                    else if ( (LA21_4 == EOF || LA21_4 == PRINT || LA21_4 == IF || LA21_4 == ASSIGN || (LA21_4 >= INT && LA21_4 <= VOID) || (LA21_4 >= PRIVATE && LA21_4 <= PUBLIC) || (LA21_4 >= FOR && LA21_4 <= WHILE) || (LA21_4 >= INTEGER && LA21_4 <= ID) || LA21_4 == 41 || LA21_4 == 43 || LA21_4 == 56) )
                    {
                        alt21 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d21s4 =
                            new NoViableAltException("", 21, 4, input);

                        throw nvae_d21s4;
                    }
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d21s2 =
                        new NoViableAltException("", 21, 2, input);

                    throw nvae_d21s2;
                }
                }
                break;
            case PRIVATE:
            case PUBLIC:
            	{
                alt21 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // MyGrammar.g:208:11: line
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_line_in_exprList1512);
                    	line97 = line();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, line97.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:209:5: method ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_method_in_exprList1519);
                    	method98 = method();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, method98.Tree);
                    	// MyGrammar.g:209:13: ( ';' )*
                    	do 
                    	{
                    	    int alt20 = 2;
                    	    int LA20_0 = input.LA(1);

                    	    if ( (LA20_0 == 56) )
                    	    {
                    	        alt20 = 1;
                    	    }


                    	    switch (alt20) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:209:14: ';'
                    			    {
                    			    	char_literal99=(IToken)Match(input,56,FOLLOW_56_in_exprList1523); if (state.failed) return retval;

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
    // MyGrammar.g:214:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList100 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:214:13: ( ( exprList )* )
            // MyGrammar.g:215:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:215:4: ( exprList )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == PRINT || LA22_0 == IF || (LA22_0 >= INT && LA22_0 <= VOID) || (LA22_0 >= PRIVATE && LA22_0 <= PUBLIC) || (LA22_0 >= FOR && LA22_0 <= WHILE) || (LA22_0 >= INTEGER && LA22_0 <= ID) || LA22_0 == 43) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm1543);
            			    	exprList100 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList100.Tree);

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
    // MyGrammar.g:217:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm101 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:217:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:218:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program1556);
            	fullProgramm101 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm101.Tree);


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
    // MyGrammar.g:220:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program102 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:220:8: ( program )
            // MyGrammar.g:221:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute1573);
            	program102 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program102.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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

    // $ANTLR start "synpred34_MyGrammar"
    public void synpred34_MyGrammar_fragment() {
        // MyGrammar.g:148:44: ( add )
        // MyGrammar.g:148:44: add
        {
        	PushFollow(FOLLOW_add_in_synpred34_MyGrammar1103);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_MyGrammar"

    // $ANTLR start "synpred38_MyGrammar"
    public void synpred38_MyGrammar_fragment() {
        // MyGrammar.g:190:13: ( add )
        // MyGrammar.g:190:13: add
        {
        	PushFollow(FOLLOW_add_in_synpred38_MyGrammar1414);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_MyGrammar"

    // $ANTLR start "synpred39_MyGrammar"
    public void synpred39_MyGrammar_fragment() {
        // MyGrammar.g:191:6: ( ID )
        // MyGrammar.g:191:6: ID
        {
        	Match(input,ID,FOLLOW_ID_in_synpred39_MyGrammar1421); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_MyGrammar"

    // Delegated rules

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


   	protected DFA12 dfa12;
   	protected DFA18 dfa18;
	private void InitializeCyclicDFAs()
	{
    	this.dfa12 = new DFA12(this);
    	this.dfa18 = new DFA18(this);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);
	}

    const string DFA12_eotS =
        "\x0f\uffff";
    const string DFA12_eofS =
        "\x01\x01\x0e\uffff";
    const string DFA12_minS =
        "\x01\x05\x03\uffff\x02\x00\x04\uffff\x01\x00\x04\uffff";
    const string DFA12_maxS =
        "\x01\x38\x03\uffff\x02\x00\x04\uffff\x01\x00\x04\uffff";
    const string DFA12_acceptS =
        "\x01\uffff\x01\x02\x0c\uffff\x01\x01";
    const string DFA12_specialS =
        "\x04\uffff\x01\x00\x01\x01\x04\uffff\x01\x02\x04\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x01\x04\uffff\x01\x01\x0a\uffff\x05\x01\x03\uffff\x02"+
            "\x01\x03\uffff\x02\x01\x01\uffff\x02\x0a\x01\x05\x03\uffff\x01"+
            "\x04\x01\x01\x01\uffff\x01\x01\x09\uffff\x01\x01",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "\x01\uffff",
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
                   	if ( (synpred34_MyGrammar()) ) { s = 14; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index12_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA12_5 = input.LA(1);

                   	 
                   	int index12_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred34_MyGrammar()) ) { s = 14; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index12_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA12_10 = input.LA(1);

                   	 
                   	int index12_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred34_MyGrammar()) ) { s = 14; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index12_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae12 =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae12);
        throw nvae12;
    }
    const string DFA18_eotS =
        "\x0c\uffff";
    const string DFA18_eofS =
        "\x02\uffff\x01\x01\x06\uffff\x01\x0b\x02\uffff";
    const string DFA18_minS =
        "\x01\x05\x01\uffff\x01\x05\x01\uffff\x01\x27\x04\uffff\x01\x05"+
        "\x02\uffff";
    const string DFA18_maxS =
        "\x01\x2b\x01\uffff\x01\x38\x01\uffff\x01\x27\x04\uffff\x01\x38"+
        "\x02\uffff";
    const string DFA18_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\uffff\x01\x05\x01\x08"+
        "\x01\x07\x01\x06\x01\uffff\x01\x04\x01\x03";
    const string DFA18_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x01\x06\x04\uffff\x01\x03\x0a\uffff\x05\x04\x08\uffff\x02"+
            "\x05\x01\uffff\x02\x01\x01\x02\x03\uffff\x01\x01",
            "",
            "\x06\x01\x03\uffff\x07\x08\x05\x01\x03\uffff\x02\x01\x03\uffff"+
            "\x02\x01\x01\uffff\x03\x01\x03\uffff\x01\x01\x02\uffff\x01\x01"+
            "\x08\uffff\x01\x07\x01\x01",
            "",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "\x01\x0b\x04\uffff\x01\x0b\x03\uffff\x01\x0b\x06\uffff\x05"+
            "\x0b\x03\uffff\x02\x0b\x03\uffff\x02\x0b\x01\uffff\x03\x0b\x01"+
            "\uffff\x01\x0a\x01\uffff\x01\x0b\x02\uffff\x01\x0b\x09\uffff"+
            "\x01\x0b",
            "",
            ""
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "195:1: expr : ( add | if_ | var | oneArray | cycle | changeIDVALUE | callMethod | print );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_set_in_number0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_var588 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_var590 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_var593 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_var595 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_oneArray626 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_oneArray628 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_oneArray630 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_number_in_oneArray632 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_oneArray634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_accessMod0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_incDec0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_group785 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_group788 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_group790 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult813 = new BitSet(new ulong[]{0x0000000000000302UL});
    public static readonly BitSet FOLLOW_set_in_mult816 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_group_in_mult825 = new BitSet(new ulong[]{0x0000000000000302UL});
    public static readonly BitSet FOLLOW_mult_in_add837 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_set_in_add840 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_mult_in_add849 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_PRINT_in_print860 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_print862 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_printExpr_in_print864 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_print866 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_block888 = new BitSet(new ulong[]{0x000048EC03E00420UL});
    public static readonly BitSet FOLLOW_line_in_block890 = new BitSet(new ulong[]{0x000048EC03E00420UL});
    public static readonly BitSet FOLLOW_46_in_block893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_917 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_if_919 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_921 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_if_923 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_925 = new BitSet(new ulong[]{0x0000000000000802UL});
    public static readonly BitSet FOLLOW_ELSE_in_if_928 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_930 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator970 = new BitSet(new ulong[]{0x000008E000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation985 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_orOperation989 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation992 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation1007 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_48_in_andOperation1011 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation1014 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1029 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOperation1033 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1042 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1059 = new BitSet(new ulong[]{0x0078000000000002UL});
    public static readonly BitSet FOLLOW_set_in_defaultOperation1063 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1079 = new BitSet(new ulong[]{0x0078000000000002UL});
    public static readonly BitSet FOLLOW_incDec_in_optionsChangeValue1095 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeAssign_in_optionsChangeValue1100 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_optionsChangeValue1103 = new BitSet(new ulong[]{0x000008E000000002UL});
    public static readonly BitSet FOLLOW_ID_in_changeIDVALUE1120 = new BitSet(new ulong[]{0x00000000001FC000UL});
    public static readonly BitSet FOLLOW_optionsChangeValue_in_changeIDVALUE1123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_accessMod_in_method1137 = new BitSet(new ulong[]{0x0000000003E00000UL});
    public static readonly BitSet FOLLOW_type_in_method1140 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_method1142 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_method1144 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_method1147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod1179 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_callMethod1181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle1206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle1212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_1223 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_for_1238 = new BitSet(new ulong[]{0x0000008003E00000UL});
    public static readonly BitSet FOLLOW_type_in_for_1248 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_for_1251 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_for_1253 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_for_1255 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_for_1257 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_1267 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_for_1269 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_changeIDVALUE_in_for_1276 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_for_1281 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_for_1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_1360 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_while_1365 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_1371 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_while_1376 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_while_1382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr1414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_printExpr1421 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr1428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr1442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr1448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_in_expr1454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_oneArray_in_expr1460 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr1466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_changeIDVALUE_in_expr1472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr1484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line1495 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_56_in_line1498 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_line_in_exprList1512 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_in_exprList1519 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_56_in_exprList1523 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm1543 = new BitSet(new ulong[]{0x000008EC63E00422UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program1556 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute1573 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred34_MyGrammar1103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred38_MyGrammar1414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_synpred39_MyGrammar1421 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}