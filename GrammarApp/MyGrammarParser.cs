// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-10-17 01:06:59

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
		"PLUS", 
		"MINUS", 
		"MULTIPLY", 
		"DIVIDE", 
		"IF", 
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
		"ARRAY", 
		"COUNT", 
		"PRIVATE", 
		"PUBLIC", 
		"TYPE", 
		"MOD", 
		"CALLMETHOD", 
		"FOR", 
		"FOR_", 
		"WHILE", 
		"WHILE_", 
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

    public const int T__50 = 50;
    public const int ARRAY = 25;
    public const int VAR = 24;
    public const int DECREMENT = 18;
    public const int MINUS = 6;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int CALLMETHOD = 31;
    public const int ID = 39;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int IF = 9;
    public const int TYPE = 29;
    public const int T__53 = 53;
    public const int MINUSASSIGN = 14;
    public const int T__54 = 54;
    public const int INTEGER = 37;
    public const int BLOCK = 10;
    public const int FOR = 32;
    public const int REAL = 38;
    public const int PUBLIC = 28;
    public const int MULTIPLY = 7;
    public const int CONDITION = 11;
    public const int COUNT = 26;
    public const int VOID = 23;
    public const int PROGRAM = 4;
    public const int PLUS = 5;
    public const int DIVIDEASSIGN = 16;
    public const int FLOAT = 20;
    public const int MULTASSIGN = 15;
    public const int CHAR = 22;
    public const int ASSIGN = 12;
    public const int INT = 19;
    public const int DIVIDE = 8;
    public const int PLUSASSIGN = 13;
    public const int DOUBLE = 21;
    public const int WS = 40;
    public const int EOF = -1;
    public const int WHILE_ = 35;
    public const int MOD = 30;
    public const int INCREMENT_ = 36;
    public const int PRIVATE = 27;
    public const int INCREMENT = 17;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int FOR_ = 33;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__46 = 46;
    public const int WHILE = 34;
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
    // MyGrammar.g:61:1: number : ( INTEGER | REAL | ID );
    public MyGrammarParser.number_return number() // throws RecognitionException [1]
    {   
        MyGrammarParser.number_return retval = new MyGrammarParser.number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:62:2: ( INTEGER | REAL | ID )
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
    // MyGrammar.g:67:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:67:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
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
    // MyGrammar.g:76:1: var : type ID ( ASSIGN add )? -> ^( type ^( ID ( ^( ASSIGN add ) )? ) ) ;
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
            // MyGrammar.g:76:6: ( type ID ( ASSIGN add )? -> ^( type ^( ID ( ^( ASSIGN add ) )? ) ) )
            // MyGrammar.g:76:8: type ID ( ASSIGN add )?
            {
            	PushFollow(FOLLOW_type_in_var596);
            	type3 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type3.Tree);
            	ID4=(IToken)Match(input,ID,FOLLOW_ID_in_var598); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID4);

            	// MyGrammar.g:76:16: ( ASSIGN add )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == ASSIGN) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // MyGrammar.g:76:17: ASSIGN add
            	        {
            	        	ASSIGN5=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_var601); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN5);

            	        	PushFollow(FOLLOW_add_in_var603);
            	        	add6 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_add.Add(add6.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          type, ASSIGN, ID, add
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 76:30: -> ^( type ^( ID ( ^( ASSIGN add ) )? ) )
            	{
            	    // MyGrammar.g:76:34: ^( type ^( ID ( ^( ASSIGN add ) )? ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

            	    // MyGrammar.g:76:41: ^( ID ( ^( ASSIGN add ) )? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:76:46: ( ^( ASSIGN add ) )?
            	    if ( stream_ASSIGN.HasNext() || stream_add.HasNext() )
            	    {
            	        // MyGrammar.g:76:46: ^( ASSIGN add )
            	        {
            	        object root_3 = (object)adaptor.GetNilNode();
            	        root_3 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_3);

            	        adaptor.AddChild(root_3, stream_add.NextTree());

            	        adaptor.AddChild(root_2, root_3);
            	        }

            	    }
            	    stream_ASSIGN.Reset();
            	    stream_add.Reset();

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
    // MyGrammar.g:79:1: oneArray : type ID '[' number ']' -> ^( ARRAY ^( ID ^( COUNT number ) ) ) ;
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
            // MyGrammar.g:79:10: ( type ID '[' number ']' -> ^( ARRAY ^( ID ^( COUNT number ) ) ) )
            // MyGrammar.g:79:12: type ID '[' number ']'
            {
            	PushFollow(FOLLOW_type_in_oneArray634);
            	type7 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type7.Tree);
            	ID8=(IToken)Match(input,ID,FOLLOW_ID_in_oneArray636); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID8);

            	char_literal9=(IToken)Match(input,41,FOLLOW_41_in_oneArray638); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal9);

            	PushFollow(FOLLOW_number_in_oneArray640);
            	number10 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number10.Tree);
            	char_literal11=(IToken)Match(input,42,FOLLOW_42_in_oneArray642); if (state.failed) return retval; 
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
            	// 80:5: -> ^( ARRAY ^( ID ^( COUNT number ) ) )
            	{
            	    // MyGrammar.g:80:8: ^( ARRAY ^( ID ^( COUNT number ) ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY, "ARRAY"), root_1);

            	    // MyGrammar.g:80:16: ^( ID ^( COUNT number ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:80:21: ^( COUNT number )
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
    // MyGrammar.g:83:1: type : ( INT | FLOAT | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set12 = null;

        object set12_tree=null;

        try 
    	{
            // MyGrammar.g:83:6: ( INT | FLOAT | DOUBLE | CHAR | VOID )
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
    // MyGrammar.g:90:1: accessMod : ( PRIVATE | PUBLIC );
    public MyGrammarParser.accessMod_return accessMod() // throws RecognitionException [1]
    {   
        MyGrammarParser.accessMod_return retval = new MyGrammarParser.accessMod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set13 = null;

        object set13_tree=null;

        try 
    	{
            // MyGrammar.g:90:11: ( PRIVATE | PUBLIC )
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
    // MyGrammar.g:94:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set14 = null;

        object set14_tree=null;

        try 
    	{
            // MyGrammar.g:94:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
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
    // MyGrammar.g:101:1: incDec : ( INCREMENT | DECREMENT );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set15 = null;

        object set15_tree=null;

        try 
    	{
            // MyGrammar.g:101:8: ( INCREMENT | DECREMENT )
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
    // MyGrammar.g:110:1: group : ( '(' add ')' | number );
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
            // MyGrammar.g:110:7: ( '(' add ')' | number )
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
                    // MyGrammar.g:110:9: '(' add ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal16=(IToken)Match(input,43,FOLLOW_43_in_group793); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group796);
                    	add17 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);
                    	char_literal18=(IToken)Match(input,44,FOLLOW_44_in_group798); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:111:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group806);
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
    // MyGrammar.g:114:1: mult : group ( ( MULTIPLY | DIVIDE ) group )* ;
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
            // MyGrammar.g:114:6: ( group ( ( MULTIPLY | DIVIDE ) group )* )
            // MyGrammar.g:114:8: group ( ( MULTIPLY | DIVIDE ) group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult821);
            	group20 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group20.Tree);
            	// MyGrammar.g:114:14: ( ( MULTIPLY | DIVIDE ) group )*
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
            			    // MyGrammar.g:114:15: ( MULTIPLY | DIVIDE ) group
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

            			    	PushFollow(FOLLOW_group_in_mult833);
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
    // MyGrammar.g:116:1: add : mult ( ( PLUS | MINUS ) mult )* ;
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
            // MyGrammar.g:116:6: ( mult ( ( PLUS | MINUS ) mult )* )
            // MyGrammar.g:116:8: mult ( ( PLUS | MINUS ) mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add845);
            	mult23 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult23.Tree);
            	// MyGrammar.g:116:13: ( ( PLUS | MINUS ) mult )*
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
            			    // MyGrammar.g:116:14: ( PLUS | MINUS ) mult
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

            			    	PushFollow(FOLLOW_mult_in_add857);
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
    // MyGrammar.g:118:1: block : '{' ( line )* '}' -> ^( BLOCK ( line )* ) ;
    public MyGrammarParser.block_return block() // throws RecognitionException [1]
    {   
        MyGrammarParser.block_return retval = new MyGrammarParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal26 = null;
        IToken char_literal28 = null;
        MyGrammarParser.line_return line27 = default(MyGrammarParser.line_return);


        object char_literal26_tree=null;
        object char_literal28_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:118:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:118:9: '{' ( line )* '}'
            {
            	char_literal26=(IToken)Match(input,45,FOLLOW_45_in_block868); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_45.Add(char_literal26);

            	// MyGrammar.g:118:13: ( line )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == IF || (LA5_0 >= INT && LA5_0 <= VOID) || LA5_0 == FOR || LA5_0 == WHILE || (LA5_0 >= INTEGER && LA5_0 <= ID) || LA5_0 == 43) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block870);
            			    	line27 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line27.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	char_literal28=(IToken)Match(input,46,FOLLOW_46_in_block873); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_46.Add(char_literal28);



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
            	// 118:23: -> ^( BLOCK ( line )* )
            	{
            	    // MyGrammar.g:118:26: ^( BLOCK ( line )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // MyGrammar.g:118:34: ( line )*
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
    // MyGrammar.g:124:1: if_ : IF '(' logicOperator ')' block -> ^( IF ^( CONDITION logicOperator ) block ) ;
    public MyGrammarParser.if__return if_() // throws RecognitionException [1]
    {   
        MyGrammarParser.if__return retval = new MyGrammarParser.if__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF29 = null;
        IToken char_literal30 = null;
        IToken char_literal32 = null;
        MyGrammarParser.logicOperator_return logicOperator31 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block33 = default(MyGrammarParser.block_return);


        object IF29_tree=null;
        object char_literal30_tree=null;
        object char_literal32_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:124:6: ( IF '(' logicOperator ')' block -> ^( IF ^( CONDITION logicOperator ) block ) )
            // MyGrammar.g:124:8: IF '(' logicOperator ')' block
            {
            	IF29=(IToken)Match(input,IF,FOLLOW_IF_in_if_897); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF29);

            	char_literal30=(IToken)Match(input,43,FOLLOW_43_in_if_899); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal30);

            	PushFollow(FOLLOW_logicOperator_in_if_901);
            	logicOperator31 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator31.Tree);
            	char_literal32=(IToken)Match(input,44,FOLLOW_44_in_if_903); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal32);

            	PushFollow(FOLLOW_block_in_if_905);
            	block33 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block33.Tree);


            	// AST REWRITE
            	// elements:          block, IF, logicOperator
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 124:39: -> ^( IF ^( CONDITION logicOperator ) block )
            	{
            	    // MyGrammar.g:124:42: ^( IF ^( CONDITION logicOperator ) block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

            	    // MyGrammar.g:124:47: ^( CONDITION logicOperator )
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
    // MyGrammar.g:127:1: logicOperator : ( orOperation )+ ;
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation34 = default(MyGrammarParser.orOperation_return);



        try 
    	{
            // MyGrammar.g:127:15: ( ( orOperation )+ )
            // MyGrammar.g:127:17: ( orOperation )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:127:17: ( orOperation )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= INTEGER && LA6_0 <= ID) || LA6_0 == 43) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: orOperation
            			    {
            			    	PushFollow(FOLLOW_orOperation_in_logicOperator932);
            			    	orOperation34 = orOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation34.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // MyGrammar.g:130:1: orOperation : andOperation ( '||' andOperation )* ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal36 = null;
        MyGrammarParser.andOperation_return andOperation35 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.andOperation_return andOperation37 = default(MyGrammarParser.andOperation_return);


        object string_literal36_tree=null;

        try 
    	{
            // MyGrammar.g:130:14: ( andOperation ( '||' andOperation )* )
            // MyGrammar.g:130:16: andOperation ( '||' andOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_andOperation_in_orOperation947);
            	andOperation35 = andOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation35.Tree);
            	// MyGrammar.g:130:29: ( '||' andOperation )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 47) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // MyGrammar.g:130:31: '||' andOperation
            			    {
            			    	string_literal36=(IToken)Match(input,47,FOLLOW_47_in_orOperation951); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal36_tree = (object)adaptor.Create(string_literal36);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal36_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_andOperation_in_orOperation954);
            			    	andOperation37 = andOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation37.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
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
    // MyGrammar.g:133:1: andOperation : equalityOperation ( '&&' equalityOperation )* ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal39 = null;
        MyGrammarParser.equalityOperation_return equalityOperation38 = default(MyGrammarParser.equalityOperation_return);

        MyGrammarParser.equalityOperation_return equalityOperation40 = default(MyGrammarParser.equalityOperation_return);


        object string_literal39_tree=null;

        try 
    	{
            // MyGrammar.g:133:14: ( equalityOperation ( '&&' equalityOperation )* )
            // MyGrammar.g:133:16: equalityOperation ( '&&' equalityOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityOperation_in_andOperation969);
            	equalityOperation38 = equalityOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation38.Tree);
            	// MyGrammar.g:133:34: ( '&&' equalityOperation )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 48) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // MyGrammar.g:133:36: '&&' equalityOperation
            			    {
            			    	string_literal39=(IToken)Match(input,48,FOLLOW_48_in_andOperation973); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal39_tree = (object)adaptor.Create(string_literal39);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal39_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityOperation_in_andOperation976);
            			    	equalityOperation40 = equalityOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation40.Tree);

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
    // MyGrammar.g:136:1: equalityOperation : defaultOperation ( ( '==' | '!=' ) defaultOperation )* ;
    public MyGrammarParser.equalityOperation_return equalityOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.equalityOperation_return retval = new MyGrammarParser.equalityOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set42 = null;
        MyGrammarParser.defaultOperation_return defaultOperation41 = default(MyGrammarParser.defaultOperation_return);

        MyGrammarParser.defaultOperation_return defaultOperation43 = default(MyGrammarParser.defaultOperation_return);


        object set42_tree=null;

        try 
    	{
            // MyGrammar.g:136:19: ( defaultOperation ( ( '==' | '!=' ) defaultOperation )* )
            // MyGrammar.g:136:21: defaultOperation ( ( '==' | '!=' ) defaultOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_defaultOperation_in_equalityOperation991);
            	defaultOperation41 = defaultOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation41.Tree);
            	// MyGrammar.g:136:38: ( ( '==' | '!=' ) defaultOperation )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= 49 && LA9_0 <= 50)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // MyGrammar.g:136:40: ( '==' | '!=' ) defaultOperation
            			    {
            			    	set42=(IToken)input.LT(1);
            			    	set42 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 49 && input.LA(1) <= 50) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set42), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1004);
            			    	defaultOperation43 = defaultOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation43.Tree);

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
    // MyGrammar.g:139:1: defaultOperation : add ( ( '>' | '<' | '>=' | '<=' ) add )* ;
    public MyGrammarParser.defaultOperation_return defaultOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.defaultOperation_return retval = new MyGrammarParser.defaultOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set45 = null;
        MyGrammarParser.add_return add44 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add46 = default(MyGrammarParser.add_return);


        object set45_tree=null;

        try 
    	{
            // MyGrammar.g:139:18: ( add ( ( '>' | '<' | '>=' | '<=' ) add )* )
            // MyGrammar.g:139:21: add ( ( '>' | '<' | '>=' | '<=' ) add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_defaultOperation1021);
            	add44 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add44.Tree);
            	// MyGrammar.g:139:25: ( ( '>' | '<' | '>=' | '<=' ) add )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= 51 && LA10_0 <= 54)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MyGrammar.g:139:27: ( '>' | '<' | '>=' | '<=' ) add
            			    {
            			    	set45=(IToken)input.LT(1);
            			    	set45 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 51 && input.LA(1) <= 54) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set45), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_add_in_defaultOperation1041);
            			    	add46 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add46.Tree);

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
    // MyGrammar.g:142:1: optionsChangeValue : ( incDec | ( typeAssign ( add )+ ) );
    public MyGrammarParser.optionsChangeValue_return optionsChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.optionsChangeValue_return retval = new MyGrammarParser.optionsChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.incDec_return incDec47 = default(MyGrammarParser.incDec_return);

        MyGrammarParser.typeAssign_return typeAssign48 = default(MyGrammarParser.typeAssign_return);

        MyGrammarParser.add_return add49 = default(MyGrammarParser.add_return);



        try 
    	{
            // MyGrammar.g:142:20: ( incDec | ( typeAssign ( add )+ ) )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( ((LA12_0 >= INCREMENT && LA12_0 <= DECREMENT)) )
            {
                alt12 = 1;
            }
            else if ( ((LA12_0 >= ASSIGN && LA12_0 <= DIVIDEASSIGN)) )
            {
                alt12 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // MyGrammar.g:142:22: incDec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_incDec_in_optionsChangeValue1057);
                    	incDec47 = incDec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, incDec47.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:142:31: ( typeAssign ( add )+ )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// MyGrammar.g:142:31: ( typeAssign ( add )+ )
                    	// MyGrammar.g:142:32: typeAssign ( add )+
                    	{
                    		PushFollow(FOLLOW_typeAssign_in_optionsChangeValue1062);
                    		typeAssign48 = typeAssign();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(typeAssign48.Tree, root_0);
                    		// MyGrammar.g:142:44: ( add )+
                    		int cnt11 = 0;
                    		do 
                    		{
                    		    int alt11 = 2;
                    		    alt11 = dfa11.Predict(input);
                    		    switch (alt11) 
                    			{
                    				case 1 :
                    				    // MyGrammar.g:0:0: add
                    				    {
                    				    	PushFollow(FOLLOW_add_in_optionsChangeValue1065);
                    				    	add49 = add();
                    				    	state.followingStackPointer--;
                    				    	if (state.failed) return retval;
                    				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add49.Tree);

                    				    }
                    				    break;

                    				default:
                    				    if ( cnt11 >= 1 ) goto loop11;
                    				    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			            EarlyExitException eee11 =
                    			                new EarlyExitException(11, input);
                    			            throw eee11;
                    		    }
                    		    cnt11++;
                    		} while (true);

                    		loop11:
                    			;	// Stops C# compiler whining that label 'loop11' has no statements


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
    // MyGrammar.g:146:1: changeIDVALUE : ID optionsChangeValue ;
    public MyGrammarParser.changeIDVALUE_return changeIDVALUE() // throws RecognitionException [1]
    {   
        MyGrammarParser.changeIDVALUE_return retval = new MyGrammarParser.changeIDVALUE_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID50 = null;
        MyGrammarParser.optionsChangeValue_return optionsChangeValue51 = default(MyGrammarParser.optionsChangeValue_return);


        object ID50_tree=null;

        try 
    	{
            // MyGrammar.g:146:15: ( ID optionsChangeValue )
            // MyGrammar.g:146:17: ID optionsChangeValue
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ID50=(IToken)Match(input,ID,FOLLOW_ID_in_changeIDVALUE1082); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ID50_tree = (object)adaptor.Create(ID50);
            		root_0 = (object)adaptor.BecomeRoot(ID50_tree, root_0);
            	}
            	PushFollow(FOLLOW_optionsChangeValue_in_changeIDVALUE1085);
            	optionsChangeValue51 = optionsChangeValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, optionsChangeValue51.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // MyGrammar.g:150:1: method : ( accessMod )? type ID '()' block -> ^( ID ^( MOD ( accessMod )? ) ^( TYPE type ) block ) ;
    public MyGrammarParser.method_return method() // throws RecognitionException [1]
    {   
        MyGrammarParser.method_return retval = new MyGrammarParser.method_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID54 = null;
        IToken string_literal55 = null;
        MyGrammarParser.accessMod_return accessMod52 = default(MyGrammarParser.accessMod_return);

        MyGrammarParser.type_return type53 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block56 = default(MyGrammarParser.block_return);


        object ID54_tree=null;
        object string_literal55_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_accessMod = new RewriteRuleSubtreeStream(adaptor,"rule accessMod");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:150:8: ( ( accessMod )? type ID '()' block -> ^( ID ^( MOD ( accessMod )? ) ^( TYPE type ) block ) )
            // MyGrammar.g:150:10: ( accessMod )? type ID '()' block
            {
            	// MyGrammar.g:150:10: ( accessMod )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( ((LA13_0 >= PRIVATE && LA13_0 <= PUBLIC)) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // MyGrammar.g:0:0: accessMod
            	        {
            	        	PushFollow(FOLLOW_accessMod_in_method1099);
            	        	accessMod52 = accessMod();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_accessMod.Add(accessMod52.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_type_in_method1102);
            	type53 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type53.Tree);
            	ID54=(IToken)Match(input,ID,FOLLOW_ID_in_method1104); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID54);

            	string_literal55=(IToken)Match(input,55,FOLLOW_55_in_method1106); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(string_literal55);

            	PushFollow(FOLLOW_block_in_method1109);
            	block56 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block56.Tree);


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
            	// 150:41: -> ^( ID ^( MOD ( accessMod )? ) ^( TYPE type ) block )
            	{
            	    // MyGrammar.g:150:44: ^( ID ^( MOD ( accessMod )? ) ^( TYPE type ) block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_1);

            	    // MyGrammar.g:150:49: ^( MOD ( accessMod )? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(MOD, "MOD"), root_2);

            	    // MyGrammar.g:150:55: ( accessMod )?
            	    if ( stream_accessMod.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_accessMod.NextTree());

            	    }
            	    stream_accessMod.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // MyGrammar.g:150:67: ^( TYPE type )
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
    // MyGrammar.g:153:1: callMethod : ID '()' -> ^( CALLMETHOD ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID57 = null;
        IToken string_literal58 = null;

        object ID57_tree=null;
        object string_literal58_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:153:12: ( ID '()' -> ^( CALLMETHOD ID ) )
            // MyGrammar.g:153:14: ID '()'
            {
            	ID57=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod1141); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID57);

            	string_literal58=(IToken)Match(input,55,FOLLOW_55_in_callMethod1143); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(string_literal58);



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
            	// 154:5: -> ^( CALLMETHOD ID )
            	{
            	    // MyGrammar.g:154:8: ^( CALLMETHOD ID )
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
    // MyGrammar.g:157:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_59 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_60 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:157:7: ( for_ | while_ )
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
                    // MyGrammar.g:157:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle1168);
                    	for_59 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_59.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:158:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle1174);
                    	while_60 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_60.Tree);

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
    // MyGrammar.g:161:1: for_ : FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' changeIDVALUE ')' block -> ^( FOR_ ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) changeIDVALUE block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR61 = null;
        IToken char_literal62 = null;
        IToken ID64 = null;
        IToken ASSIGN65 = null;
        IToken char_literal67 = null;
        IToken char_literal69 = null;
        IToken char_literal71 = null;
        MyGrammarParser.type_return type63 = default(MyGrammarParser.type_return);

        MyGrammarParser.add_return add66 = default(MyGrammarParser.add_return);

        MyGrammarParser.logicOperator_return logicOperator68 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.changeIDVALUE_return changeIDVALUE70 = default(MyGrammarParser.changeIDVALUE_return);

        MyGrammarParser.block_return block72 = default(MyGrammarParser.block_return);


        object FOR61_tree=null;
        object char_literal62_tree=null;
        object ID64_tree=null;
        object ASSIGN65_tree=null;
        object char_literal67_tree=null;
        object char_literal69_tree=null;
        object char_literal71_tree=null;
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
            // MyGrammar.g:161:6: ( FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' changeIDVALUE ')' block -> ^( FOR_ ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) changeIDVALUE block ) )
            // MyGrammar.g:161:8: FOR '(' ( type )? ID ASSIGN add ';' logicOperator ';' changeIDVALUE ')' block
            {
            	FOR61=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_1185); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR61);

            	char_literal62=(IToken)Match(input,43,FOLLOW_43_in_for_1200); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal62);

            	// MyGrammar.g:163:7: ( type )?
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
            	        	PushFollow(FOLLOW_type_in_for_1210);
            	        	type63 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type63.Tree);

            	        }
            	        break;

            	}

            	ID64=(IToken)Match(input,ID,FOLLOW_ID_in_for_1213); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID64);

            	ASSIGN65=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_for_1215); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN65);

            	PushFollow(FOLLOW_add_in_for_1217);
            	add66 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add66.Tree);
            	char_literal67=(IToken)Match(input,56,FOLLOW_56_in_for_1219); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal67);

            	PushFollow(FOLLOW_logicOperator_in_for_1229);
            	logicOperator68 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator68.Tree);
            	char_literal69=(IToken)Match(input,56,FOLLOW_56_in_for_1231); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal69);

            	PushFollow(FOLLOW_changeIDVALUE_in_for_1238);
            	changeIDVALUE70 = changeIDVALUE();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_changeIDVALUE.Add(changeIDVALUE70.Tree);
            	char_literal71=(IToken)Match(input,44,FOLLOW_44_in_for_1243); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal71);

            	PushFollow(FOLLOW_block_in_for_1249);
            	block72 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block72.Tree);


            	// AST REWRITE
            	// elements:          ASSIGN, logicOperator, block, type, ID, add, changeIDVALUE
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 168:4: -> ^( FOR_ ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) changeIDVALUE block )
            	{
            	    // MyGrammar.g:168:7: ^( FOR_ ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) changeIDVALUE block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FOR_, "FOR_"), root_1);

            	    // MyGrammar.g:168:14: ^( VAR ( type )? ^( ID ^( ASSIGN add ) ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR, "VAR"), root_2);

            	    // MyGrammar.g:168:20: ( type )?
            	    if ( stream_type.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_type.NextTree());

            	    }
            	    stream_type.Reset();
            	    // MyGrammar.g:168:26: ^( ID ^( ASSIGN add ) )
            	    {
            	    object root_3 = (object)adaptor.GetNilNode();
            	    root_3 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_3);

            	    // MyGrammar.g:168:31: ^( ASSIGN add )
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
            	    // MyGrammar.g:169:7: ^( CONDITION logicOperator )
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
    // MyGrammar.g:174:1: while_ : WHILE '(' logicOperator ')' block -> ^( WHILE_ ^( CONDITION logicOperator ) block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE73 = null;
        IToken char_literal74 = null;
        IToken char_literal76 = null;
        MyGrammarParser.logicOperator_return logicOperator75 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block77 = default(MyGrammarParser.block_return);


        object WHILE73_tree=null;
        object char_literal74_tree=null;
        object char_literal76_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:174:8: ( WHILE '(' logicOperator ')' block -> ^( WHILE_ ^( CONDITION logicOperator ) block ) )
            // MyGrammar.g:174:10: WHILE '(' logicOperator ')' block
            {
            	WHILE73=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_1322); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE73);

            	char_literal74=(IToken)Match(input,43,FOLLOW_43_in_while_1327); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal74);

            	PushFollow(FOLLOW_logicOperator_in_while_1333);
            	logicOperator75 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator75.Tree);
            	char_literal76=(IToken)Match(input,44,FOLLOW_44_in_while_1338); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal76);

            	PushFollow(FOLLOW_block_in_while_1344);
            	block77 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block77.Tree);


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
            	// 179:4: -> ^( WHILE_ ^( CONDITION logicOperator ) block )
            	{
            	    // MyGrammar.g:179:7: ^( WHILE_ ^( CONDITION logicOperator ) block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(WHILE_, "WHILE_"), root_1);

            	    // MyGrammar.g:179:16: ^( CONDITION logicOperator )
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
    // MyGrammar.g:183:1: expr : ( add | if_ | var | oneArray | cycle | changeIDVALUE | callMethod );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add78 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_79 = default(MyGrammarParser.if__return);

        MyGrammarParser.var_return var80 = default(MyGrammarParser.var_return);

        MyGrammarParser.oneArray_return oneArray81 = default(MyGrammarParser.oneArray_return);

        MyGrammarParser.cycle_return cycle82 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.changeIDVALUE_return changeIDVALUE83 = default(MyGrammarParser.changeIDVALUE_return);

        MyGrammarParser.callMethod_return callMethod84 = default(MyGrammarParser.callMethod_return);



        try 
    	{
            // MyGrammar.g:183:6: ( add | if_ | var | oneArray | cycle | changeIDVALUE | callMethod )
            int alt16 = 7;
            alt16 = dfa16.Predict(input);
            switch (alt16) 
            {
                case 1 :
                    // MyGrammar.g:183:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr1375);
                    	add78 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add78.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:184:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr1381);
                    	if_79 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_79.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:185:5: var
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_var_in_expr1387);
                    	var80 = var();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var80.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:186:5: oneArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_expr1393);
                    	oneArray81 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray81.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:187:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr1399);
                    	cycle82 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle82.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:188:5: changeIDVALUE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_changeIDVALUE_in_expr1405);
                    	changeIDVALUE83 = changeIDVALUE();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, changeIDVALUE83.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:189:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr1411);
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
    // MyGrammar.g:192:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal86 = null;
        MyGrammarParser.expr_return expr85 = default(MyGrammarParser.expr_return);


        object char_literal86_tree=null;

        try 
    	{
            // MyGrammar.g:192:6: ( expr ( ';' )* )
            // MyGrammar.g:192:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line1422);
            	expr85 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr85.Tree);
            	// MyGrammar.g:192:13: ( ';' )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == 56) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // MyGrammar.g:192:14: ';'
            			    {
            			    	char_literal86=(IToken)Match(input,56,FOLLOW_56_in_line1425); if (state.failed) return retval;

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
    // MyGrammar.g:195:1: exprList : ( line | method ( ';' )* );
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal89 = null;
        MyGrammarParser.line_return line87 = default(MyGrammarParser.line_return);

        MyGrammarParser.method_return method88 = default(MyGrammarParser.method_return);


        object char_literal89_tree=null;

        try 
    	{
            // MyGrammar.g:195:9: ( line | method ( ';' )* )
            int alt19 = 2;
            switch ( input.LA(1) ) 
            {
            case IF:
            case FOR:
            case WHILE:
            case INTEGER:
            case REAL:
            case ID:
            case 43:
            	{
                alt19 = 1;
                }
                break;
            case INT:
            case FLOAT:
            case DOUBLE:
            case CHAR:
            case VOID:
            	{
                int LA19_2 = input.LA(2);

                if ( (LA19_2 == ID) )
                {
                    int LA19_4 = input.LA(3);

                    if ( (LA19_4 == 55) )
                    {
                        alt19 = 2;
                    }
                    else if ( (LA19_4 == EOF || LA19_4 == IF || LA19_4 == ASSIGN || (LA19_4 >= INT && LA19_4 <= VOID) || (LA19_4 >= PRIVATE && LA19_4 <= PUBLIC) || LA19_4 == FOR || LA19_4 == WHILE || (LA19_4 >= INTEGER && LA19_4 <= ID) || LA19_4 == 41 || LA19_4 == 43 || LA19_4 == 56) )
                    {
                        alt19 = 1;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                        NoViableAltException nvae_d19s4 =
                            new NoViableAltException("", 19, 4, input);

                        throw nvae_d19s4;
                    }
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d19s2 =
                        new NoViableAltException("", 19, 2, input);

                    throw nvae_d19s2;
                }
                }
                break;
            case PRIVATE:
            case PUBLIC:
            	{
                alt19 = 2;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            }

            switch (alt19) 
            {
                case 1 :
                    // MyGrammar.g:195:11: line
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_line_in_exprList1439);
                    	line87 = line();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, line87.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:196:5: method ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_method_in_exprList1446);
                    	method88 = method();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, method88.Tree);
                    	// MyGrammar.g:196:13: ( ';' )*
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    int LA18_0 = input.LA(1);

                    	    if ( (LA18_0 == 56) )
                    	    {
                    	        alt18 = 1;
                    	    }


                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:196:14: ';'
                    			    {
                    			    	char_literal89=(IToken)Match(input,56,FOLLOW_56_in_exprList1450); if (state.failed) return retval;

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

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // MyGrammar.g:200:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList90 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:200:13: ( ( exprList )* )
            // MyGrammar.g:201:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:201:4: ( exprList )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == IF || (LA20_0 >= INT && LA20_0 <= VOID) || (LA20_0 >= PRIVATE && LA20_0 <= PUBLIC) || LA20_0 == FOR || LA20_0 == WHILE || (LA20_0 >= INTEGER && LA20_0 <= ID) || LA20_0 == 43) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm1469);
            			    	exprList90 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList90.Tree);

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
    // MyGrammar.g:203:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm91 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:203:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:204:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program1482);
            	fullProgramm91 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm91.Tree);


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
            	// 204:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:204:19: ^( PROGRAM fullProgramm )
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
    // MyGrammar.g:206:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program92 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:206:8: ( program )
            // MyGrammar.g:207:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute1499);
            	program92 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program92.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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

    // $ANTLR start "synpred33_MyGrammar"
    public void synpred33_MyGrammar_fragment() {
        // MyGrammar.g:142:44: ( add )
        // MyGrammar.g:142:44: add
        {
        	PushFollow(FOLLOW_add_in_synpred33_MyGrammar1065);
        	add();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_MyGrammar"

    // Delegated rules

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


   	protected DFA11 dfa11;
   	protected DFA16 dfa16;
	private void InitializeCyclicDFAs()
	{
    	this.dfa11 = new DFA11(this);
    	this.dfa16 = new DFA16(this);
	    this.dfa11.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA11_SpecialStateTransition);
	}

    const string DFA11_eotS =
        "\x0e\uffff";
    const string DFA11_eofS =
        "\x01\x01\x0d\uffff";
    const string DFA11_minS =
        "\x01\x09\x03\uffff\x02\x00\x04\uffff\x01\x00\x03\uffff";
    const string DFA11_maxS =
        "\x01\x38\x03\uffff\x02\x00\x04\uffff\x01\x00\x03\uffff";
    const string DFA11_acceptS =
        "\x01\uffff\x01\x02\x0b\uffff\x01\x01";
    const string DFA11_specialS =
        "\x04\uffff\x01\x00\x01\x01\x04\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x09\uffff\x05\x01\x03\uffff\x02\x01\x03\uffff\x01"+
            "\x01\x01\uffff\x01\x01\x02\uffff\x02\x0a\x01\x05\x03\uffff\x01"+
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
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 142:44: ( add )+"; }
        }

    }


    protected internal int DFA11_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA11_4 = input.LA(1);

                   	 
                   	int index11_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_MyGrammar()) ) { s = 13; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index11_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA11_5 = input.LA(1);

                   	 
                   	int index11_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_MyGrammar()) ) { s = 13; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index11_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA11_10 = input.LA(1);

                   	 
                   	int index11_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_MyGrammar()) ) { s = 13; }

                   	else if ( (true) ) { s = 1; }

                   	 
                   	input.Seek(index11_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae11 =
            new NoViableAltException(dfa.Description, 11, _s, input);
        dfa.Error(nvae11);
        throw nvae11;
    }
    const string DFA16_eotS =
        "\x0b\uffff";
    const string DFA16_eofS =
        "\x02\uffff\x01\x01\x05\uffff\x01\x0a\x02\uffff";
    const string DFA16_minS =
        "\x01\x09\x01\uffff\x01\x05\x01\uffff\x01\x27\x03\uffff\x01\x09"+
        "\x02\uffff";
    const string DFA16_maxS =
        "\x01\x2b\x01\uffff\x01\x38\x01\uffff\x01\x27\x03\uffff\x01\x38"+
        "\x02\uffff";
    const string DFA16_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x01\uffff\x01\x05\x01\x07"+
        "\x01\x06\x01\uffff\x01\x04\x01\x03";
    const string DFA16_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x01\x03\x09\uffff\x05\x04\x08\uffff\x01\x05\x01\uffff\x01"+
            "\x05\x02\uffff\x02\x01\x01\x02\x03\uffff\x01\x01",
            "",
            "\x05\x01\x02\uffff\x07\x07\x05\x01\x03\uffff\x02\x01\x03\uffff"+
            "\x01\x01\x01\uffff\x01\x01\x02\uffff\x03\x01\x03\uffff\x01\x01"+
            "\x02\uffff\x01\x01\x08\uffff\x01\x06\x01\x01",
            "",
            "\x01\x08",
            "",
            "",
            "",
            "\x01\x0a\x02\uffff\x01\x0a\x06\uffff\x05\x0a\x03\uffff\x02"+
            "\x0a\x03\uffff\x01\x0a\x01\uffff\x01\x0a\x02\uffff\x03\x0a\x01"+
            "\uffff\x01\x09\x01\uffff\x01\x0a\x02\uffff\x01\x0a\x09\uffff"+
            "\x01\x0a",
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
            get { return "183:1: expr : ( add | if_ | var | oneArray | cycle | changeIDVALUE | callMethod );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_set_in_number0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_var596 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_var598 = new BitSet(new ulong[]{0x0000000000001002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_var601 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_var603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_oneArray634 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_oneArray636 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_oneArray638 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_number_in_oneArray640 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_oneArray642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_accessMod0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_incDec0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_group793 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_group796 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_group798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult821 = new BitSet(new ulong[]{0x0000000000000182UL});
    public static readonly BitSet FOLLOW_set_in_mult824 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_group_in_mult833 = new BitSet(new ulong[]{0x0000000000000182UL});
    public static readonly BitSet FOLLOW_mult_in_add845 = new BitSet(new ulong[]{0x0000000000000062UL});
    public static readonly BitSet FOLLOW_set_in_add848 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_mult_in_add857 = new BitSet(new ulong[]{0x0000000000000062UL});
    public static readonly BitSet FOLLOW_45_in_block868 = new BitSet(new ulong[]{0x000048E500F80200UL});
    public static readonly BitSet FOLLOW_line_in_block870 = new BitSet(new ulong[]{0x000048E500F80200UL});
    public static readonly BitSet FOLLOW_46_in_block873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_897 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_if_899 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_901 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_if_903 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator932 = new BitSet(new ulong[]{0x000008E000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation947 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_orOperation951 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation954 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation969 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_48_in_andOperation973 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation976 = new BitSet(new ulong[]{0x0001000000000002UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation991 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOperation995 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1004 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1021 = new BitSet(new ulong[]{0x0078000000000002UL});
    public static readonly BitSet FOLLOW_set_in_defaultOperation1025 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1041 = new BitSet(new ulong[]{0x0078000000000002UL});
    public static readonly BitSet FOLLOW_incDec_in_optionsChangeValue1057 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeAssign_in_optionsChangeValue1062 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_optionsChangeValue1065 = new BitSet(new ulong[]{0x000008E000000002UL});
    public static readonly BitSet FOLLOW_ID_in_changeIDVALUE1082 = new BitSet(new ulong[]{0x000000000007F000UL});
    public static readonly BitSet FOLLOW_optionsChangeValue_in_changeIDVALUE1085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_accessMod_in_method1099 = new BitSet(new ulong[]{0x0000000000F80000UL});
    public static readonly BitSet FOLLOW_type_in_method1102 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_method1104 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_method1106 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_method1109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod1141 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_callMethod1143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle1168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle1174 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_1185 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_for_1200 = new BitSet(new ulong[]{0x0000008000F80000UL});
    public static readonly BitSet FOLLOW_type_in_for_1210 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ID_in_for_1213 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_for_1215 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_add_in_for_1217 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_for_1219 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_1229 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_for_1231 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_changeIDVALUE_in_for_1238 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_for_1243 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_for_1249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_1322 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_43_in_while_1327 = new BitSet(new ulong[]{0x000008E000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_1333 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_while_1338 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_block_in_while_1344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr1375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr1381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_in_expr1387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_oneArray_in_expr1393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr1399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_changeIDVALUE_in_expr1405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr1411 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line1422 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_56_in_line1425 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_line_in_exprList1439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_in_exprList1446 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_56_in_exprList1450 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm1469 = new BitSet(new ulong[]{0x000008E518F80202UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program1482 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute1499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_synpred33_MyGrammar1065 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}