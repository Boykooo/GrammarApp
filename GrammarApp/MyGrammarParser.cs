// $ANTLR 3.2 Sep 23, 2009 12:02:23 MyGrammar.g 2016-11-27 14:59:13

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
    public const int PRINT = 16;
    public const int VAR = 37;
    public const int CallMethod = 13;
    public const int DECREMENT = 31;
    public const int MINUS = 18;
    public const int T__59 = 59;
    public const int MULT = 7;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int ELSE = 22;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int CALLMETHOD = 44;
    public const int ID = 50;
    public const int Plus = 9;
    public const int T__52 = 52;
    public const int IF = 21;
    public const int TYPE = 42;
    public const int T__53 = 53;
    public const int MINUSASSIGN = 27;
    public const int T__54 = 54;
    public const int INTEGER = 48;
    public const int T__60 = 60;
    public const int T__61 = 61;
    public const int BLOCK = 23;
    public const int ONEARRAY = 38;
    public const int FOR = 45;
    public const int Method = 5;
    public const int Double = 12;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int PUBLIC = 41;
    public const int MULTIPLY = 19;
    public const int CONDITION = 24;
    public const int COUNT = 39;
    public const int Id = 14;
    public const int T__62 = 62;
    public const int VOID = 36;
    public const int T__63 = 63;
    public const int T__64 = 64;
    public const int Minus = 10;
    public const int PROGRAM = 15;
    public const int T__65 = 65;
    public const int PLUS = 17;
    public const int DIVIDEASSIGN = 29;
    public const int FLOAT = 33;
    public const int MULTASSIGN = 28;
    public const int CHAR = 35;
    public const int ASSIGN = 25;
    public const int INT = 32;
    public const int DIVIDE = 20;
    public const int PLUSASSIGN = 26;
    public const int DOUBLE = 34;
    public const int WS = 51;
    public const int EOF = -1;
    public const int MOD = 43;
    public const int INCREMENT_ = 47;
    public const int DOUBLE_ = 49;
    public const int PRIVATE = 40;
    public const int VarInit = 4;
    public const int Integer = 11;
    public const int INCREMENT = 30;
    public const int Assign = 8;
    public const int WHILE = 46;

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
    // MyGrammar.g:70:1: type : ( INT | FLOAT | DOUBLE | CHAR | VOID );
    public MyGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        MyGrammarParser.type_return retval = new MyGrammarParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set1 = null;

        object set1_tree=null;

        try 
    	{
            // MyGrammar.g:70:6: ( INT | FLOAT | DOUBLE | CHAR | VOID )
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
    // MyGrammar.g:78:1: typeAssign : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN );
    public MyGrammarParser.typeAssign_return typeAssign() // throws RecognitionException [1]
    {   
        MyGrammarParser.typeAssign_return retval = new MyGrammarParser.typeAssign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;

        object set2_tree=null;

        try 
    	{
            // MyGrammar.g:78:12: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVIDEASSIGN )
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
    // MyGrammar.g:85:1: incDec : ( INCREMENT | DECREMENT );
    public MyGrammarParser.incDec_return incDec() // throws RecognitionException [1]
    {   
        MyGrammarParser.incDec_return retval = new MyGrammarParser.incDec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set3 = null;

        object set3_tree=null;

        try 
    	{
            // MyGrammar.g:85:8: ( INCREMENT | DECREMENT )
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
    // MyGrammar.g:89:1: elementarySign : ( PLUS | MINUS | MULTIPLY | DIVIDE );
    public MyGrammarParser.elementarySign_return elementarySign() // throws RecognitionException [1]
    {   
        MyGrammarParser.elementarySign_return retval = new MyGrammarParser.elementarySign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set4 = null;

        object set4_tree=null;

        try 
    	{
            // MyGrammar.g:89:16: ( PLUS | MINUS | MULTIPLY | DIVIDE )
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
    // MyGrammar.g:106:1: number : ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) );
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
            // MyGrammar.g:106:8: ( INTEGER -> ^( Integer INTEGER ) | DOUBLE_ -> ^( Double DOUBLE_ ) )
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
                    // MyGrammar.g:106:10: INTEGER
                    {
                    	INTEGER5=(IToken)Match(input,INTEGER,FOLLOW_INTEGER_in_number751); if (state.failed) return retval; 
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
                    	// 106:18: -> ^( Integer INTEGER )
                    	{
                    	    // MyGrammar.g:106:21: ^( Integer INTEGER )
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
                    // MyGrammar.g:107:5: DOUBLE_
                    {
                    	DOUBLE_6=(IToken)Match(input,DOUBLE_,FOLLOW_DOUBLE__in_number768); if (state.failed) return retval; 
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
                    	// 107:13: -> ^( Double DOUBLE_ )
                    	{
                    	    // MyGrammar.g:107:16: ^( Double DOUBLE_ )
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
    // MyGrammar.g:114:1: ident : ID -> ^( Id ID ) ;
    public MyGrammarParser.ident_return ident() // throws RecognitionException [1]
    {   
        MyGrammarParser.ident_return retval = new MyGrammarParser.ident_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID7 = null;

        object ID7_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:114:8: ( ID -> ^( Id ID ) )
            // MyGrammar.g:114:10: ID
            {
            	ID7=(IToken)Match(input,ID,FOLLOW_ID_in_ident833); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID7);



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
            	// 114:13: -> ^( Id ID )
            	{
            	    // MyGrammar.g:114:16: ^( Id ID )
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
    // MyGrammar.g:117:1: varInit : type varInitValue -> ^( VarInit type varInitValue ) ;
    public MyGrammarParser.varInit_return varInit() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInit_return retval = new MyGrammarParser.varInit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.type_return type8 = default(MyGrammarParser.type_return);

        MyGrammarParser.varInitValue_return varInitValue9 = default(MyGrammarParser.varInitValue_return);


        RewriteRuleSubtreeStream stream_varInitValue = new RewriteRuleSubtreeStream(adaptor,"rule varInitValue");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:117:9: ( type varInitValue -> ^( VarInit type varInitValue ) )
            // MyGrammar.g:117:11: type varInitValue
            {
            	PushFollow(FOLLOW_type_in_varInit856);
            	type8 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type8.Tree);
            	PushFollow(FOLLOW_varInitValue_in_varInit858);
            	varInitValue9 = varInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitValue.Add(varInitValue9.Tree);


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
            	// 118:5: -> ^( VarInit type varInitValue )
            	{
            	    // MyGrammar.g:118:8: ^( VarInit type varInitValue )
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
    // MyGrammar.g:122:1: varInitValue : ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) ;
    public MyGrammarParser.varInitValue_return varInitValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.varInitValue_return retval = new MyGrammarParser.varInitValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGN11 = null;
        MyGrammarParser.ident_return ident10 = default(MyGrammarParser.ident_return);

        MyGrammarParser.initValue_return initValue12 = default(MyGrammarParser.initValue_return);


        object ASSIGN11_tree=null;
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_initValue = new RewriteRuleSubtreeStream(adaptor,"rule initValue");
        try 
    	{
            // MyGrammar.g:122:14: ( ident ( ASSIGN initValue )? -> ^( Assign ident ( initValue )? ) )
            // MyGrammar.g:122:17: ident ( ASSIGN initValue )?
            {
            	PushFollow(FOLLOW_ident_in_varInitValue888);
            	ident10 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident10.Tree);
            	// MyGrammar.g:122:23: ( ASSIGN initValue )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == ASSIGN) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // MyGrammar.g:122:24: ASSIGN initValue
            	        {
            	        	ASSIGN11=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_varInitValue891); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN11);

            	        	PushFollow(FOLLOW_initValue_in_varInitValue893);
            	        	initValue12 = initValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initValue.Add(initValue12.Tree);

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
            	// 123:7: -> ^( Assign ident ( initValue )? )
            	{
            	    // MyGrammar.g:123:10: ^( Assign ident ( initValue )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new AssignNode(Assign), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MyGrammar.g:123:37: ( initValue )?
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
    // MyGrammar.g:126:1: initValue : ( add | callMethod | ident );
    public MyGrammarParser.initValue_return initValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.initValue_return retval = new MyGrammarParser.initValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add13 = default(MyGrammarParser.add_return);

        MyGrammarParser.callMethod_return callMethod14 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.ident_return ident15 = default(MyGrammarParser.ident_return);



        try 
    	{
            // MyGrammar.g:126:12: ( add | callMethod | ident )
            int alt3 = 3;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= INTEGER && LA3_0 <= DOUBLE_) || LA3_0 == 54) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == ID) )
            {
                int LA3_2 = input.LA(2);

                if ( (LA3_2 == 66) )
                {
                    alt3 = 2;
                }
                else if ( (LA3_2 == EOF || LA3_2 == PRINT || LA3_2 == IF || (LA3_2 >= INT && LA3_2 <= VOID) || (LA3_2 >= FOR && LA3_2 <= WHILE) || (LA3_2 >= INTEGER && LA3_2 <= ID) || (LA3_2 >= 54 && LA3_2 <= 55) || LA3_2 == 57 || LA3_2 == 67) )
                {
                    alt3 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d3s2 =
                        new NoViableAltException("", 3, 2, input);

                    throw nvae_d3s2;
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
                    // MyGrammar.g:126:14: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_initValue931);
                    	add13 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add13.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:127:7: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_initValue939);
                    	callMethod14 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod14.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:128:7: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_initValue947);
                    	ident15 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident15.Tree);

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
    // MyGrammar.g:131:1: optionsChangeValue : ( incDec | ( typeAssign ( add )+ ) );
    public MyGrammarParser.optionsChangeValue_return optionsChangeValue() // throws RecognitionException [1]
    {   
        MyGrammarParser.optionsChangeValue_return retval = new MyGrammarParser.optionsChangeValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.incDec_return incDec16 = default(MyGrammarParser.incDec_return);

        MyGrammarParser.typeAssign_return typeAssign17 = default(MyGrammarParser.typeAssign_return);

        MyGrammarParser.add_return add18 = default(MyGrammarParser.add_return);



        try 
    	{
            // MyGrammar.g:131:20: ( incDec | ( typeAssign ( add )+ ) )
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
                    // MyGrammar.g:131:22: incDec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_incDec_in_optionsChangeValue960);
                    	incDec16 = incDec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, incDec16.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:132:8: ( typeAssign ( add )+ )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// MyGrammar.g:132:8: ( typeAssign ( add )+ )
                    	// MyGrammar.g:132:9: typeAssign ( add )+
                    	{
                    		PushFollow(FOLLOW_typeAssign_in_optionsChangeValue971);
                    		typeAssign17 = typeAssign();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(typeAssign17.Tree, root_0);
                    		// MyGrammar.g:132:21: ( add )+
                    		int cnt4 = 0;
                    		do 
                    		{
                    		    int alt4 = 2;
                    		    int LA4_0 = input.LA(1);

                    		    if ( ((LA4_0 >= INTEGER && LA4_0 <= DOUBLE_) || LA4_0 == 54) )
                    		    {
                    		        alt4 = 1;
                    		    }


                    		    switch (alt4) 
                    			{
                    				case 1 :
                    				    // MyGrammar.g:0:0: add
                    				    {
                    				    	PushFollow(FOLLOW_add_in_optionsChangeValue974);
                    				    	add18 = add();
                    				    	state.followingStackPointer--;
                    				    	if (state.failed) return retval;
                    				    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add18.Tree);

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
    // MyGrammar.g:135:1: oneArray : type ident '[' number ']' -> ^( ONEARRAY ^( ident ^( COUNT number ) ) ) ;
    public MyGrammarParser.oneArray_return oneArray() // throws RecognitionException [1]
    {   
        MyGrammarParser.oneArray_return retval = new MyGrammarParser.oneArray_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal21 = null;
        IToken char_literal23 = null;
        MyGrammarParser.type_return type19 = default(MyGrammarParser.type_return);

        MyGrammarParser.ident_return ident20 = default(MyGrammarParser.ident_return);

        MyGrammarParser.number_return number22 = default(MyGrammarParser.number_return);


        object char_literal21_tree=null;
        object char_literal23_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_number = new RewriteRuleSubtreeStream(adaptor,"rule number");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:135:10: ( type ident '[' number ']' -> ^( ONEARRAY ^( ident ^( COUNT number ) ) ) )
            // MyGrammar.g:135:12: type ident '[' number ']'
            {
            	PushFollow(FOLLOW_type_in_oneArray990);
            	type19 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type19.Tree);
            	PushFollow(FOLLOW_ident_in_oneArray992);
            	ident20 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident20.Tree);
            	char_literal21=(IToken)Match(input,52,FOLLOW_52_in_oneArray994); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal21);

            	PushFollow(FOLLOW_number_in_oneArray996);
            	number22 = number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_number.Add(number22.Tree);
            	char_literal23=(IToken)Match(input,53,FOLLOW_53_in_oneArray998); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal23);



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
            	// 136:5: -> ^( ONEARRAY ^( ident ^( COUNT number ) ) )
            	{
            	    // MyGrammar.g:136:8: ^( ONEARRAY ^( ident ^( COUNT number ) ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ONEARRAY, "ONEARRAY"), root_1);

            	    // MyGrammar.g:136:19: ^( ident ^( COUNT number ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ident.NextNode(), root_2);

            	    // MyGrammar.g:136:27: ^( COUNT number )
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
    // MyGrammar.g:139:1: addOperation : ( PLUS -> Plus | MINUS -> Minus );
    public MyGrammarParser.addOperation_return addOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.addOperation_return retval = new MyGrammarParser.addOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS24 = null;
        IToken MINUS25 = null;

        object PLUS24_tree=null;
        object MINUS25_tree=null;
        RewriteRuleTokenStream stream_PLUS = new RewriteRuleTokenStream(adaptor,"token PLUS");
        RewriteRuleTokenStream stream_MINUS = new RewriteRuleTokenStream(adaptor,"token MINUS");

        try 
    	{
            // MyGrammar.g:139:14: ( PLUS -> Plus | MINUS -> Minus )
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
                    // MyGrammar.g:139:16: PLUS
                    {
                    	PLUS24=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addOperation1030); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_PLUS.Add(PLUS24);



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
                    	// 139:21: -> Plus
                    	{
                    	    adaptor.AddChild(root_0, new PlusNode(Plus));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:140:7: MINUS
                    {
                    	MINUS25=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_addOperation1045); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MINUS.Add(MINUS25);



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
                    	// 140:13: -> Minus
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
    // MyGrammar.g:143:1: multOperation : ( MULTIPLY -> MULT | DIVIDE -> DIVIDE );
    public MyGrammarParser.multOperation_return multOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.multOperation_return retval = new MyGrammarParser.multOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULTIPLY26 = null;
        IToken DIVIDE27 = null;

        object MULTIPLY26_tree=null;
        object DIVIDE27_tree=null;
        RewriteRuleTokenStream stream_MULTIPLY = new RewriteRuleTokenStream(adaptor,"token MULTIPLY");
        RewriteRuleTokenStream stream_DIVIDE = new RewriteRuleTokenStream(adaptor,"token DIVIDE");

        try 
    	{
            // MyGrammar.g:143:15: ( MULTIPLY -> MULT | DIVIDE -> DIVIDE )
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
                    // MyGrammar.g:143:17: MULTIPLY
                    {
                    	MULTIPLY26=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multOperation1065); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_MULTIPLY.Add(MULTIPLY26);



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
                    	// 143:26: -> MULT
                    	{
                    	    adaptor.AddChild(root_0, new MultNode(MULT));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // MyGrammar.g:144:7: DIVIDE
                    {
                    	DIVIDE27=(IToken)Match(input,DIVIDE,FOLLOW_DIVIDE_in_multOperation1080); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DIVIDE.Add(DIVIDE27);



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
                    	// 144:14: -> DIVIDE
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
    // MyGrammar.g:147:1: group : ( '(' add ')' | number );
    public MyGrammarParser.group_return group() // throws RecognitionException [1]
    {   
        MyGrammarParser.group_return retval = new MyGrammarParser.group_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal28 = null;
        IToken char_literal30 = null;
        MyGrammarParser.add_return add29 = default(MyGrammarParser.add_return);

        MyGrammarParser.number_return number31 = default(MyGrammarParser.number_return);


        object char_literal28_tree=null;
        object char_literal30_tree=null;

        try 
    	{
            // MyGrammar.g:147:7: ( '(' add ')' | number )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 54) )
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
                    // MyGrammar.g:147:9: '(' add ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal28=(IToken)Match(input,54,FOLLOW_54_in_group1103); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_group1106);
                    	add29 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add29.Tree);
                    	char_literal30=(IToken)Match(input,55,FOLLOW_55_in_group1108); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MyGrammar.g:148:5: number
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_group1116);
                    	number31 = number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number31.Tree);

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
    // MyGrammar.g:151:1: mult : group ( multOperation group )* ;
    public MyGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        MyGrammarParser.mult_return retval = new MyGrammarParser.mult_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.group_return group32 = default(MyGrammarParser.group_return);

        MyGrammarParser.multOperation_return multOperation33 = default(MyGrammarParser.multOperation_return);

        MyGrammarParser.group_return group34 = default(MyGrammarParser.group_return);



        try 
    	{
            // MyGrammar.g:151:6: ( group ( multOperation group )* )
            // MyGrammar.g:151:8: group ( multOperation group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult1131);
            	group32 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group32.Tree);
            	// MyGrammar.g:151:14: ( multOperation group )*
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
            			    // MyGrammar.g:151:16: multOperation group
            			    {
            			    	PushFollow(FOLLOW_multOperation_in_mult1135);
            			    	multOperation33 = multOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperation33.Tree, root_0);
            			    	PushFollow(FOLLOW_group_in_mult1138);
            			    	group34 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group34.Tree);

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
    // MyGrammar.g:153:1: add : mult ( addOperation mult )* ;
    public MyGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        MyGrammarParser.add_return retval = new MyGrammarParser.add_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.mult_return mult35 = default(MyGrammarParser.mult_return);

        MyGrammarParser.addOperation_return addOperation36 = default(MyGrammarParser.addOperation_return);

        MyGrammarParser.mult_return mult37 = default(MyGrammarParser.mult_return);



        try 
    	{
            // MyGrammar.g:153:6: ( mult ( addOperation mult )* )
            // MyGrammar.g:153:8: mult ( addOperation mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1150);
            	mult35 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult35.Tree);
            	// MyGrammar.g:153:13: ( addOperation mult )*
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
            			    // MyGrammar.g:153:15: addOperation mult
            			    {
            			    	PushFollow(FOLLOW_addOperation_in_add1154);
            			    	addOperation36 = addOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperation36.Tree, root_0);
            			    	PushFollow(FOLLOW_mult_in_add1157);
            			    	mult37 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult37.Tree);

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
    // MyGrammar.g:155:1: print : PRINT '(' printExpr ')' -> ^( PRINT printExpr ) ;
    public MyGrammarParser.print_return print() // throws RecognitionException [1]
    {   
        MyGrammarParser.print_return retval = new MyGrammarParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PRINT38 = null;
        IToken char_literal39 = null;
        IToken char_literal41 = null;
        MyGrammarParser.printExpr_return printExpr40 = default(MyGrammarParser.printExpr_return);


        object PRINT38_tree=null;
        object char_literal39_tree=null;
        object char_literal41_tree=null;
        RewriteRuleTokenStream stream_PRINT = new RewriteRuleTokenStream(adaptor,"token PRINT");
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_printExpr = new RewriteRuleSubtreeStream(adaptor,"rule printExpr");
        try 
    	{
            // MyGrammar.g:155:7: ( PRINT '(' printExpr ')' -> ^( PRINT printExpr ) )
            // MyGrammar.g:155:9: PRINT '(' printExpr ')'
            {
            	PRINT38=(IToken)Match(input,PRINT,FOLLOW_PRINT_in_print1168); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PRINT.Add(PRINT38);

            	char_literal39=(IToken)Match(input,54,FOLLOW_54_in_print1170); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal39);

            	PushFollow(FOLLOW_printExpr_in_print1172);
            	printExpr40 = printExpr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_printExpr.Add(printExpr40.Tree);
            	char_literal41=(IToken)Match(input,55,FOLLOW_55_in_print1174); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal41);



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
            	// 156:4: -> ^( PRINT printExpr )
            	{
            	    // MyGrammar.g:156:7: ^( PRINT printExpr )
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
    // MyGrammar.g:159:1: block : '{' ( line )* '}' -> ^( BLOCK ( line )* ) ;
    public MyGrammarParser.block_return block() // throws RecognitionException [1]
    {   
        MyGrammarParser.block_return retval = new MyGrammarParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal42 = null;
        IToken char_literal44 = null;
        MyGrammarParser.line_return line43 = default(MyGrammarParser.line_return);


        object char_literal42_tree=null;
        object char_literal44_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleSubtreeStream stream_line = new RewriteRuleSubtreeStream(adaptor,"rule line");
        try 
    	{
            // MyGrammar.g:159:7: ( '{' ( line )* '}' -> ^( BLOCK ( line )* ) )
            // MyGrammar.g:159:9: '{' ( line )* '}'
            {
            	char_literal42=(IToken)Match(input,56,FOLLOW_56_in_block1196); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal42);

            	// MyGrammar.g:159:13: ( line )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == PRINT || LA11_0 == IF || (LA11_0 >= INT && LA11_0 <= VOID) || (LA11_0 >= FOR && LA11_0 <= WHILE) || (LA11_0 >= INTEGER && LA11_0 <= ID) || LA11_0 == 54) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: line
            			    {
            			    	PushFollow(FOLLOW_line_in_block1198);
            			    	line43 = line();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_line.Add(line43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	char_literal44=(IToken)Match(input,57,FOLLOW_57_in_block1201); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_57.Add(char_literal44);



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
            	// 159:23: -> ^( BLOCK ( line )* )
            	{
            	    // MyGrammar.g:159:26: ^( BLOCK ( line )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(BLOCK), root_1);

            	    // MyGrammar.g:159:49: ( line )*
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
    // MyGrammar.g:163:1: if_ : IF '(' logicOperator ')' block ( ELSE block )? -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? ) ;
    public MyGrammarParser.if__return if_() // throws RecognitionException [1]
    {   
        MyGrammarParser.if__return retval = new MyGrammarParser.if__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IF45 = null;
        IToken char_literal46 = null;
        IToken char_literal48 = null;
        IToken ELSE50 = null;
        MyGrammarParser.logicOperator_return logicOperator47 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block49 = default(MyGrammarParser.block_return);

        MyGrammarParser.block_return block51 = default(MyGrammarParser.block_return);


        object IF45_tree=null;
        object char_literal46_tree=null;
        object char_literal48_tree=null;
        object ELSE50_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_ELSE = new RewriteRuleTokenStream(adaptor,"token ELSE");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:163:6: ( IF '(' logicOperator ')' block ( ELSE block )? -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? ) )
            // MyGrammar.g:163:8: IF '(' logicOperator ')' block ( ELSE block )?
            {
            	IF45=(IToken)Match(input,IF,FOLLOW_IF_in_if_1226); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IF.Add(IF45);

            	char_literal46=(IToken)Match(input,54,FOLLOW_54_in_if_1228); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal46);

            	PushFollow(FOLLOW_logicOperator_in_if_1230);
            	logicOperator47 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator47.Tree);
            	char_literal48=(IToken)Match(input,55,FOLLOW_55_in_if_1232); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal48);

            	PushFollow(FOLLOW_block_in_if_1234);
            	block49 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block49.Tree);
            	// MyGrammar.g:163:39: ( ELSE block )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == ELSE) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // MyGrammar.g:163:40: ELSE block
            	        {
            	        	ELSE50=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_if_1237); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_ELSE.Add(ELSE50);

            	        	PushFollow(FOLLOW_block_in_if_1239);
            	        	block51 = block();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_block.Add(block51.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ELSE, IF, logicOperator, block, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 164:4: -> ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? )
            	{
            	    // MyGrammar.g:164:7: ^( IF ^( CONDITION logicOperator ) block ( ^( ELSE block ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

            	    // MyGrammar.g:164:12: ^( CONDITION logicOperator )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_2);

            	    adaptor.AddChild(root_2, stream_logicOperator.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_block.NextTree());
            	    // MyGrammar.g:164:45: ( ^( ELSE block ) )?
            	    if ( stream_ELSE.HasNext() || stream_block.HasNext() )
            	    {
            	        // MyGrammar.g:164:45: ^( ELSE block )
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
    // MyGrammar.g:167:1: logicOperator : ( orOperation )+ ;
    public MyGrammarParser.logicOperator_return logicOperator() // throws RecognitionException [1]
    {   
        MyGrammarParser.logicOperator_return retval = new MyGrammarParser.logicOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.orOperation_return orOperation52 = default(MyGrammarParser.orOperation_return);



        try 
    	{
            // MyGrammar.g:167:15: ( ( orOperation )+ )
            // MyGrammar.g:167:17: ( orOperation )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:167:17: ( orOperation )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= INTEGER && LA13_0 <= DOUBLE_) || LA13_0 == 54) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: orOperation
            			    {
            			    	PushFollow(FOLLOW_orOperation_in_logicOperator1279);
            			    	orOperation52 = orOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, orOperation52.Tree);

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
    // MyGrammar.g:170:1: orOperation : andOperation ( '||' andOperation )* ;
    public MyGrammarParser.orOperation_return orOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.orOperation_return retval = new MyGrammarParser.orOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal54 = null;
        MyGrammarParser.andOperation_return andOperation53 = default(MyGrammarParser.andOperation_return);

        MyGrammarParser.andOperation_return andOperation55 = default(MyGrammarParser.andOperation_return);


        object string_literal54_tree=null;

        try 
    	{
            // MyGrammar.g:170:14: ( andOperation ( '||' andOperation )* )
            // MyGrammar.g:170:16: andOperation ( '||' andOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_andOperation_in_orOperation1294);
            	andOperation53 = andOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation53.Tree);
            	// MyGrammar.g:170:29: ( '||' andOperation )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 58) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // MyGrammar.g:170:31: '||' andOperation
            			    {
            			    	string_literal54=(IToken)Match(input,58,FOLLOW_58_in_orOperation1298); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal54_tree = (object)adaptor.Create(string_literal54);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal54_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_andOperation_in_orOperation1301);
            			    	andOperation55 = andOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, andOperation55.Tree);

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
    // MyGrammar.g:173:1: andOperation : equalityOperation ( '&&' equalityOperation )* ;
    public MyGrammarParser.andOperation_return andOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.andOperation_return retval = new MyGrammarParser.andOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal57 = null;
        MyGrammarParser.equalityOperation_return equalityOperation56 = default(MyGrammarParser.equalityOperation_return);

        MyGrammarParser.equalityOperation_return equalityOperation58 = default(MyGrammarParser.equalityOperation_return);


        object string_literal57_tree=null;

        try 
    	{
            // MyGrammar.g:173:14: ( equalityOperation ( '&&' equalityOperation )* )
            // MyGrammar.g:173:16: equalityOperation ( '&&' equalityOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityOperation_in_andOperation1316);
            	equalityOperation56 = equalityOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation56.Tree);
            	// MyGrammar.g:173:34: ( '&&' equalityOperation )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == 59) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // MyGrammar.g:173:36: '&&' equalityOperation
            			    {
            			    	string_literal57=(IToken)Match(input,59,FOLLOW_59_in_andOperation1320); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal57_tree = (object)adaptor.Create(string_literal57);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal57_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityOperation_in_andOperation1323);
            			    	equalityOperation58 = equalityOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityOperation58.Tree);

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
    // MyGrammar.g:176:1: equalityOperation : defaultOperation ( ( '==' | '!=' ) defaultOperation )* ;
    public MyGrammarParser.equalityOperation_return equalityOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.equalityOperation_return retval = new MyGrammarParser.equalityOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set60 = null;
        MyGrammarParser.defaultOperation_return defaultOperation59 = default(MyGrammarParser.defaultOperation_return);

        MyGrammarParser.defaultOperation_return defaultOperation61 = default(MyGrammarParser.defaultOperation_return);


        object set60_tree=null;

        try 
    	{
            // MyGrammar.g:176:19: ( defaultOperation ( ( '==' | '!=' ) defaultOperation )* )
            // MyGrammar.g:176:21: defaultOperation ( ( '==' | '!=' ) defaultOperation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1338);
            	defaultOperation59 = defaultOperation();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation59.Tree);
            	// MyGrammar.g:176:38: ( ( '==' | '!=' ) defaultOperation )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= 60 && LA16_0 <= 61)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // MyGrammar.g:176:40: ( '==' | '!=' ) defaultOperation
            			    {
            			    	set60=(IToken)input.LT(1);
            			    	set60 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 60 && input.LA(1) <= 61) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set60), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_defaultOperation_in_equalityOperation1351);
            			    	defaultOperation61 = defaultOperation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultOperation61.Tree);

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
    // MyGrammar.g:179:1: defaultOperation : add ( ( '>' | '<' | '>=' | '<=' ) add )* ;
    public MyGrammarParser.defaultOperation_return defaultOperation() // throws RecognitionException [1]
    {   
        MyGrammarParser.defaultOperation_return retval = new MyGrammarParser.defaultOperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set63 = null;
        MyGrammarParser.add_return add62 = default(MyGrammarParser.add_return);

        MyGrammarParser.add_return add64 = default(MyGrammarParser.add_return);


        object set63_tree=null;

        try 
    	{
            // MyGrammar.g:179:18: ( add ( ( '>' | '<' | '>=' | '<=' ) add )* )
            // MyGrammar.g:179:21: add ( ( '>' | '<' | '>=' | '<=' ) add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_defaultOperation1368);
            	add62 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add62.Tree);
            	// MyGrammar.g:179:25: ( ( '>' | '<' | '>=' | '<=' ) add )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= 62 && LA17_0 <= 65)) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // MyGrammar.g:179:27: ( '>' | '<' | '>=' | '<=' ) add
            			    {
            			    	set63=(IToken)input.LT(1);
            			    	set63 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 62 && input.LA(1) <= 65) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set63), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_add_in_defaultOperation1388);
            			    	add64 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add64.Tree);

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
    // MyGrammar.g:188:1: methodDef : type ID '()' block -> ^( Method ^( ID ( type )? block ) ) ;
    public MyGrammarParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        MyGrammarParser.methodDef_return retval = new MyGrammarParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID66 = null;
        IToken string_literal67 = null;
        MyGrammarParser.type_return type65 = default(MyGrammarParser.type_return);

        MyGrammarParser.block_return block68 = default(MyGrammarParser.block_return);


        object ID66_tree=null;
        object string_literal67_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
            // MyGrammar.g:188:11: ( type ID '()' block -> ^( Method ^( ID ( type )? block ) ) )
            // MyGrammar.g:188:13: type ID '()' block
            {
            	PushFollow(FOLLOW_type_in_methodDef1410);
            	type65 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_type.Add(type65.Tree);
            	ID66=(IToken)Match(input,ID,FOLLOW_ID_in_methodDef1412); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID66);

            	string_literal67=(IToken)Match(input,66,FOLLOW_66_in_methodDef1414); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_66.Add(string_literal67);

            	PushFollow(FOLLOW_block_in_methodDef1416);
            	block68 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block68.Tree);


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
            	// 188:32: -> ^( Method ^( ID ( type )? block ) )
            	{
            	    // MyGrammar.g:188:35: ^( Method ^( ID ( type )? block ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(Method), root_1);

            	    // MyGrammar.g:188:59: ^( ID ( type )? block )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(stream_ID.NextNode(), root_2);

            	    // MyGrammar.g:188:64: ( type )?
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
    // MyGrammar.g:191:1: callMethod : ID '()' -> ^( CallMethod ID ) ;
    public MyGrammarParser.callMethod_return callMethod() // throws RecognitionException [1]
    {   
        MyGrammarParser.callMethod_return retval = new MyGrammarParser.callMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID69 = null;
        IToken string_literal70 = null;

        object ID69_tree=null;
        object string_literal70_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // MyGrammar.g:191:12: ( ID '()' -> ^( CallMethod ID ) )
            // MyGrammar.g:191:14: ID '()'
            {
            	ID69=(IToken)Match(input,ID,FOLLOW_ID_in_callMethod1445); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ID.Add(ID69);

            	string_literal70=(IToken)Match(input,66,FOLLOW_66_in_callMethod1447); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_66.Add(string_literal70);



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
            	// 192:5: -> ^( CallMethod ID )
            	{
            	    // MyGrammar.g:192:8: ^( CallMethod ID )
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
    // MyGrammar.g:195:1: cycle : ( for_ | while_ );
    public MyGrammarParser.cycle_return cycle() // throws RecognitionException [1]
    {   
        MyGrammarParser.cycle_return retval = new MyGrammarParser.cycle_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.for__return for_71 = default(MyGrammarParser.for__return);

        MyGrammarParser.while__return while_72 = default(MyGrammarParser.while__return);



        try 
    	{
            // MyGrammar.g:195:7: ( for_ | while_ )
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
                    // MyGrammar.g:195:9: for_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_for__in_cycle1475);
                    	for_71 = for_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_71.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:196:5: while_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_while__in_cycle1481);
                    	while_72 = while_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_72.Tree);

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
    // MyGrammar.g:199:1: for_ : FOR '(' ( type )? ident ASSIGN add ';' logicOperator ';' varInitValue ')' block -> ^( FOR ^( VAR ( type )? ^( ident ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) varInitValue block ) ;
    public MyGrammarParser.for__return for_() // throws RecognitionException [1]
    {   
        MyGrammarParser.for__return retval = new MyGrammarParser.for__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FOR73 = null;
        IToken char_literal74 = null;
        IToken ASSIGN77 = null;
        IToken char_literal79 = null;
        IToken char_literal81 = null;
        IToken char_literal83 = null;
        MyGrammarParser.type_return type75 = default(MyGrammarParser.type_return);

        MyGrammarParser.ident_return ident76 = default(MyGrammarParser.ident_return);

        MyGrammarParser.add_return add78 = default(MyGrammarParser.add_return);

        MyGrammarParser.logicOperator_return logicOperator80 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.varInitValue_return varInitValue82 = default(MyGrammarParser.varInitValue_return);

        MyGrammarParser.block_return block84 = default(MyGrammarParser.block_return);


        object FOR73_tree=null;
        object char_literal74_tree=null;
        object ASSIGN77_tree=null;
        object char_literal79_tree=null;
        object char_literal81_tree=null;
        object char_literal83_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_FOR = new RewriteRuleTokenStream(adaptor,"token FOR");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_add = new RewriteRuleSubtreeStream(adaptor,"rule add");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_varInitValue = new RewriteRuleSubtreeStream(adaptor,"rule varInitValue");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:199:6: ( FOR '(' ( type )? ident ASSIGN add ';' logicOperator ';' varInitValue ')' block -> ^( FOR ^( VAR ( type )? ^( ident ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) varInitValue block ) )
            // MyGrammar.g:199:8: FOR '(' ( type )? ident ASSIGN add ';' logicOperator ';' varInitValue ')' block
            {
            	FOR73=(IToken)Match(input,FOR,FOLLOW_FOR_in_for_1492); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FOR.Add(FOR73);

            	char_literal74=(IToken)Match(input,54,FOLLOW_54_in_for_1507); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal74);

            	// MyGrammar.g:201:7: ( type )?
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
            	        	PushFollow(FOLLOW_type_in_for_1516);
            	        	type75 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_type.Add(type75.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_ident_in_for_1519);
            	ident76 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident76.Tree);
            	ASSIGN77=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_for_1521); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_ASSIGN.Add(ASSIGN77);

            	PushFollow(FOLLOW_add_in_for_1523);
            	add78 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_add.Add(add78.Tree);
            	char_literal79=(IToken)Match(input,67,FOLLOW_67_in_for_1525); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_67.Add(char_literal79);

            	PushFollow(FOLLOW_logicOperator_in_for_1533);
            	logicOperator80 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator80.Tree);
            	char_literal81=(IToken)Match(input,67,FOLLOW_67_in_for_1535); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_67.Add(char_literal81);

            	PushFollow(FOLLOW_varInitValue_in_for_1541);
            	varInitValue82 = varInitValue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_varInitValue.Add(varInitValue82.Tree);
            	char_literal83=(IToken)Match(input,55,FOLLOW_55_in_for_1546); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal83);

            	PushFollow(FOLLOW_block_in_for_1551);
            	block84 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block84.Tree);


            	// AST REWRITE
            	// elements:          type, logicOperator, add, ident, FOR, block, ASSIGN, varInitValue
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 206:4: -> ^( FOR ^( VAR ( type )? ^( ident ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) varInitValue block )
            	{
            	    // MyGrammar.g:206:7: ^( FOR ^( VAR ( type )? ^( ident ^( ASSIGN add ) ) ) ^( CONDITION logicOperator ) varInitValue block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ForNode(stream_FOR.NextToken()), root_1);

            	    // MyGrammar.g:206:22: ^( VAR ( type )? ^( ident ^( ASSIGN add ) ) )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR, "VAR"), root_2);

            	    // MyGrammar.g:206:28: ( type )?
            	    if ( stream_type.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_type.NextTree());

            	    }
            	    stream_type.Reset();
            	    // MyGrammar.g:206:34: ^( ident ^( ASSIGN add ) )
            	    {
            	    object root_3 = (object)adaptor.GetNilNode();
            	    root_3 = (object)adaptor.BecomeRoot(stream_ident.NextNode(), root_3);

            	    // MyGrammar.g:206:42: ^( ASSIGN add )
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
            	    // MyGrammar.g:207:7: ^( CONDITION logicOperator )
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
    // MyGrammar.g:212:1: while_ : WHILE '(' logicOperator ')' block -> ^( WHILE ^( CONDITION logicOperator ) block ) ;
    public MyGrammarParser.while__return while_() // throws RecognitionException [1]
    {   
        MyGrammarParser.while__return retval = new MyGrammarParser.while__return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken WHILE85 = null;
        IToken char_literal86 = null;
        IToken char_literal88 = null;
        MyGrammarParser.logicOperator_return logicOperator87 = default(MyGrammarParser.logicOperator_return);

        MyGrammarParser.block_return block89 = default(MyGrammarParser.block_return);


        object WHILE85_tree=null;
        object char_literal86_tree=null;
        object char_literal88_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_WHILE = new RewriteRuleTokenStream(adaptor,"token WHILE");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        RewriteRuleSubtreeStream stream_logicOperator = new RewriteRuleSubtreeStream(adaptor,"rule logicOperator");
        try 
    	{
            // MyGrammar.g:212:8: ( WHILE '(' logicOperator ')' block -> ^( WHILE ^( CONDITION logicOperator ) block ) )
            // MyGrammar.g:212:10: WHILE '(' logicOperator ')' block
            {
            	WHILE85=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_while_1627); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_WHILE.Add(WHILE85);

            	char_literal86=(IToken)Match(input,54,FOLLOW_54_in_while_1632); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal86);

            	PushFollow(FOLLOW_logicOperator_in_while_1637);
            	logicOperator87 = logicOperator();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_logicOperator.Add(logicOperator87.Tree);
            	char_literal88=(IToken)Match(input,55,FOLLOW_55_in_while_1642); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal88);

            	PushFollow(FOLLOW_block_in_while_1647);
            	block89 = block();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_block.Add(block89.Tree);


            	// AST REWRITE
            	// elements:          logicOperator, WHILE, block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 217:4: -> ^( WHILE ^( CONDITION logicOperator ) block )
            	{
            	    // MyGrammar.g:217:7: ^( WHILE ^( CONDITION logicOperator ) block )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

            	    // MyGrammar.g:217:15: ^( CONDITION logicOperator )
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
    // MyGrammar.g:221:1: printExpr : ( add | ident | callMethod );
    public MyGrammarParser.printExpr_return printExpr() // throws RecognitionException [1]
    {   
        MyGrammarParser.printExpr_return retval = new MyGrammarParser.printExpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add90 = default(MyGrammarParser.add_return);

        MyGrammarParser.ident_return ident91 = default(MyGrammarParser.ident_return);

        MyGrammarParser.callMethod_return callMethod92 = default(MyGrammarParser.callMethod_return);



        try 
    	{
            // MyGrammar.g:221:11: ( add | ident | callMethod )
            int alt20 = 3;
            int LA20_0 = input.LA(1);

            if ( ((LA20_0 >= INTEGER && LA20_0 <= DOUBLE_) || LA20_0 == 54) )
            {
                alt20 = 1;
            }
            else if ( (LA20_0 == ID) )
            {
                int LA20_2 = input.LA(2);

                if ( (LA20_2 == 66) )
                {
                    alt20 = 3;
                }
                else if ( (LA20_2 == 55) )
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
                    // MyGrammar.g:221:13: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_printExpr1678);
                    	add90 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add90.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:222:6: ident
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_printExpr1685);
                    	ident91 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident91.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:223:6: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_printExpr1692);
                    	callMethod92 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod92.Tree);

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
    // MyGrammar.g:226:1: expr : ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print );
    public MyGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        MyGrammarParser.expr_return retval = new MyGrammarParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.add_return add93 = default(MyGrammarParser.add_return);

        MyGrammarParser.if__return if_94 = default(MyGrammarParser.if__return);

        MyGrammarParser.varInit_return varInit95 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.oneArray_return oneArray96 = default(MyGrammarParser.oneArray_return);

        MyGrammarParser.cycle_return cycle97 = default(MyGrammarParser.cycle_return);

        MyGrammarParser.varInitValue_return varInitValue98 = default(MyGrammarParser.varInitValue_return);

        MyGrammarParser.callMethod_return callMethod99 = default(MyGrammarParser.callMethod_return);

        MyGrammarParser.print_return print100 = default(MyGrammarParser.print_return);



        try 
    	{
            // MyGrammar.g:226:6: ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print )
            int alt21 = 8;
            alt21 = dfa21.Predict(input);
            switch (alt21) 
            {
                case 1 :
                    // MyGrammar.g:226:8: add
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_add_in_expr1706);
                    	add93 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add93.Tree);

                    }
                    break;
                case 2 :
                    // MyGrammar.g:227:5: if_
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_if__in_expr1712);
                    	if_94 = if_();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_94.Tree);

                    }
                    break;
                case 3 :
                    // MyGrammar.g:228:5: varInit
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_expr1718);
                    	varInit95 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit95.Tree);

                    }
                    break;
                case 4 :
                    // MyGrammar.g:229:5: oneArray
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_expr1724);
                    	oneArray96 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray96.Tree);

                    }
                    break;
                case 5 :
                    // MyGrammar.g:230:5: cycle
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_cycle_in_expr1730);
                    	cycle97 = cycle();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle97.Tree);

                    }
                    break;
                case 6 :
                    // MyGrammar.g:231:5: varInitValue
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInitValue_in_expr1736);
                    	varInitValue98 = varInitValue();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInitValue98.Tree);

                    }
                    break;
                case 7 :
                    // MyGrammar.g:232:5: callMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_callMethod_in_expr1742);
                    	callMethod99 = callMethod();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callMethod99.Tree);

                    }
                    break;
                case 8 :
                    // MyGrammar.g:233:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr1748);
                    	print100 = print();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, print100.Tree);

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
    // MyGrammar.g:236:1: line : expr ( ';' )* ;
    public MyGrammarParser.line_return line() // throws RecognitionException [1]
    {   
        MyGrammarParser.line_return retval = new MyGrammarParser.line_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal102 = null;
        MyGrammarParser.expr_return expr101 = default(MyGrammarParser.expr_return);


        object char_literal102_tree=null;

        try 
    	{
            // MyGrammar.g:236:6: ( expr ( ';' )* )
            // MyGrammar.g:236:8: expr ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expr_in_line1759);
            	expr101 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr101.Tree);
            	// MyGrammar.g:236:13: ( ';' )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == 67) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // MyGrammar.g:236:14: ';'
            			    {
            			    	char_literal102=(IToken)Match(input,67,FOLLOW_67_in_line1762); if (state.failed) return retval;

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
    // MyGrammar.g:239:1: exprList : ( methodDef ( ';' )* | varInit ( ';' )* | oneArray ( ';' )* );
    public MyGrammarParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MyGrammarParser.exprList_return retval = new MyGrammarParser.exprList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal104 = null;
        IToken char_literal106 = null;
        IToken char_literal108 = null;
        MyGrammarParser.methodDef_return methodDef103 = default(MyGrammarParser.methodDef_return);

        MyGrammarParser.varInit_return varInit105 = default(MyGrammarParser.varInit_return);

        MyGrammarParser.oneArray_return oneArray107 = default(MyGrammarParser.oneArray_return);


        object char_literal104_tree=null;
        object char_literal106_tree=null;
        object char_literal108_tree=null;

        try 
    	{
            // MyGrammar.g:239:9: ( methodDef ( ';' )* | varInit ( ';' )* | oneArray ( ';' )* )
            int alt26 = 3;
            int LA26_0 = input.LA(1);

            if ( ((LA26_0 >= INT && LA26_0 <= VOID)) )
            {
                int LA26_1 = input.LA(2);

                if ( (LA26_1 == ID) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case 66:
                    	{
                        alt26 = 1;
                        }
                        break;
                    case EOF:
                    case ASSIGN:
                    case INT:
                    case FLOAT:
                    case DOUBLE:
                    case CHAR:
                    case VOID:
                    case 67:
                    	{
                        alt26 = 2;
                        }
                        break;
                    case 52:
                    	{
                        alt26 = 3;
                        }
                        break;
                    	default:
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d26s2 =
                    	        new NoViableAltException("", 26, 2, input);

                    	    throw nvae_d26s2;
                    }

                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d26s1 =
                        new NoViableAltException("", 26, 1, input);

                    throw nvae_d26s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d26s0 =
                    new NoViableAltException("", 26, 0, input);

                throw nvae_d26s0;
            }
            switch (alt26) 
            {
                case 1 :
                    // MyGrammar.g:239:11: methodDef ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodDef_in_exprList1776);
                    	methodDef103 = methodDef();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef103.Tree);
                    	// MyGrammar.g:239:22: ( ';' )*
                    	do 
                    	{
                    	    int alt23 = 2;
                    	    int LA23_0 = input.LA(1);

                    	    if ( (LA23_0 == 67) )
                    	    {
                    	        alt23 = 1;
                    	    }


                    	    switch (alt23) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:239:23: ';'
                    			    {
                    			    	char_literal104=(IToken)Match(input,67,FOLLOW_67_in_exprList1780); if (state.failed) return retval;

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
                case 2 :
                    // MyGrammar.g:240:5: varInit ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varInit_in_exprList1790);
                    	varInit105 = varInit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varInit105.Tree);
                    	// MyGrammar.g:240:13: ( ';' )*
                    	do 
                    	{
                    	    int alt24 = 2;
                    	    int LA24_0 = input.LA(1);

                    	    if ( (LA24_0 == 67) )
                    	    {
                    	        alt24 = 1;
                    	    }


                    	    switch (alt24) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:240:14: ';'
                    			    {
                    			    	char_literal106=(IToken)Match(input,67,FOLLOW_67_in_exprList1793); if (state.failed) return retval;

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
                case 3 :
                    // MyGrammar.g:241:5: oneArray ( ';' )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_oneArray_in_exprList1803);
                    	oneArray107 = oneArray();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, oneArray107.Tree);
                    	// MyGrammar.g:241:14: ( ';' )*
                    	do 
                    	{
                    	    int alt25 = 2;
                    	    int LA25_0 = input.LA(1);

                    	    if ( (LA25_0 == 67) )
                    	    {
                    	        alt25 = 1;
                    	    }


                    	    switch (alt25) 
                    		{
                    			case 1 :
                    			    // MyGrammar.g:241:15: ';'
                    			    {
                    			    	char_literal108=(IToken)Match(input,67,FOLLOW_67_in_exprList1806); if (state.failed) return retval;

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

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // MyGrammar.g:247:1: fullProgramm : ( exprList )* ;
    public MyGrammarParser.fullProgramm_return fullProgramm() // throws RecognitionException [1]
    {   
        MyGrammarParser.fullProgramm_return retval = new MyGrammarParser.fullProgramm_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.exprList_return exprList109 = default(MyGrammarParser.exprList_return);



        try 
    	{
            // MyGrammar.g:247:13: ( ( exprList )* )
            // MyGrammar.g:248:4: ( exprList )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// MyGrammar.g:248:4: ( exprList )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( ((LA27_0 >= INT && LA27_0 <= VOID)) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // MyGrammar.g:0:0: exprList
            			    {
            			    	PushFollow(FOLLOW_exprList_in_fullProgramm1827);
            			    	exprList109 = exprList();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList109.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // MyGrammar.g:251:1: program : fullProgramm -> ^( PROGRAM fullProgramm ) ;
    public MyGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        MyGrammarParser.program_return retval = new MyGrammarParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.fullProgramm_return fullProgramm110 = default(MyGrammarParser.fullProgramm_return);


        RewriteRuleSubtreeStream stream_fullProgramm = new RewriteRuleSubtreeStream(adaptor,"rule fullProgramm");
        try 
    	{
            // MyGrammar.g:251:8: ( fullProgramm -> ^( PROGRAM fullProgramm ) )
            // MyGrammar.g:252:3: fullProgramm
            {
            	PushFollow(FOLLOW_fullProgramm_in_program1841);
            	fullProgramm110 = fullProgramm();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_fullProgramm.Add(fullProgramm110.Tree);


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
            	// 252:16: -> ^( PROGRAM fullProgramm )
            	{
            	    // MyGrammar.g:252:19: ^( PROGRAM fullProgramm )
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
    // MyGrammar.g:255:1: execute : program ;
    public MyGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        MyGrammarParser.execute_return retval = new MyGrammarParser.execute_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        MyGrammarParser.program_return program111 = default(MyGrammarParser.program_return);



        try 
    	{
            // MyGrammar.g:255:8: ( program )
            // MyGrammar.g:256:3: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_execute1859);
            	program111 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program111.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
        "\x05\uffff\x01\x09\x01\uffff\x01\x0a\x04\uffff";
    const string DFA21_minS =
        "\x01\x10\x02\uffff\x01\x32\x01\uffff\x01\x10\x01\uffff\x01\x10"+
        "\x04\uffff";
    const string DFA21_maxS =
        "\x01\x36\x02\uffff\x01\x32\x01\uffff\x01\x43\x01\uffff\x01\x43"+
        "\x04\uffff";
    const string DFA21_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x05\x01\uffff\x01\x08"+
        "\x01\uffff\x01\x07\x01\x06\x01\x03\x01\x04";
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
            "\x01\x0a\x04\uffff\x01\x0a\x03\uffff\x01\x0a\x06\uffff\x05"+
            "\x0a\x08\uffff\x02\x0a\x01\uffff\x03\x0a\x01\uffff\x01\x0b\x01"+
            "\uffff\x01\x0a\x02\uffff\x01\x0a\x09\uffff\x01\x0a",
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
            get { return "226:1: expr : ( add | if_ | varInit | oneArray | cycle | varInitValue | callMethod | print );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_set_in_type0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_typeAssign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_incDec0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_elementarySign0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_in_number751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE__in_number768 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_ident833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_varInit856 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_varInitValue_in_varInit858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_varInitValue888 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_varInitValue891 = new BitSet(new ulong[]{0x0047000000000000UL});
    public static readonly BitSet FOLLOW_initValue_in_varInitValue893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_initValue931 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_initValue939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_initValue947 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_incDec_in_optionsChangeValue960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeAssign_in_optionsChangeValue971 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_add_in_optionsChangeValue974 = new BitSet(new ulong[]{0x0043000000000002UL});
    public static readonly BitSet FOLLOW_type_in_oneArray990 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_ident_in_oneArray992 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_oneArray994 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_number_in_oneArray996 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_oneArray998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_addOperation1030 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_addOperation1045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multOperation1065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multOperation1080 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_group1103 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_add_in_group1106 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_group1108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_group1116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult1131 = new BitSet(new ulong[]{0x0000000000180002UL});
    public static readonly BitSet FOLLOW_multOperation_in_mult1135 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_group_in_mult1138 = new BitSet(new ulong[]{0x0000000000180002UL});
    public static readonly BitSet FOLLOW_mult_in_add1150 = new BitSet(new ulong[]{0x0000000000060002UL});
    public static readonly BitSet FOLLOW_addOperation_in_add1154 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_mult_in_add1157 = new BitSet(new ulong[]{0x0000000000060002UL});
    public static readonly BitSet FOLLOW_PRINT_in_print1168 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_print1170 = new BitSet(new ulong[]{0x0047000000000000UL});
    public static readonly BitSet FOLLOW_printExpr_in_print1172 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_print1174 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_block1196 = new BitSet(new ulong[]{0x0247601F00210000UL});
    public static readonly BitSet FOLLOW_line_in_block1198 = new BitSet(new ulong[]{0x0247601F00210000UL});
    public static readonly BitSet FOLLOW_57_in_block1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_if_1226 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_if_1228 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_if_1230 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_if_1232 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_1234 = new BitSet(new ulong[]{0x0000000000400002UL});
    public static readonly BitSet FOLLOW_ELSE_in_if_1237 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_block_in_if_1239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orOperation_in_logicOperator1279 = new BitSet(new ulong[]{0x0043000000000002UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation1294 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_58_in_orOperation1298 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_andOperation_in_orOperation1301 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation1316 = new BitSet(new ulong[]{0x0800000000000002UL});
    public static readonly BitSet FOLLOW_59_in_andOperation1320 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_equalityOperation_in_andOperation1323 = new BitSet(new ulong[]{0x0800000000000002UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1338 = new BitSet(new ulong[]{0x3000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityOperation1342 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_defaultOperation_in_equalityOperation1351 = new BitSet(new ulong[]{0x3000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1368 = new BitSet(new ulong[]{0xC000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_set_in_defaultOperation1372 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_add_in_defaultOperation1388 = new BitSet(new ulong[]{0xC000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_type_in_methodDef1410 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_ID_in_methodDef1412 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_methodDef1414 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_block_in_methodDef1416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_callMethod1445 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_callMethod1447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_for__in_cycle1475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_while__in_cycle1481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_for_1492 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_for_1507 = new BitSet(new ulong[]{0x0004001F00000000UL});
    public static readonly BitSet FOLLOW_type_in_for_1516 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_ident_in_for_1519 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_for_1521 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_add_in_for_1523 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_for_1525 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_for_1533 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_for_1535 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_varInitValue_in_for_1541 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_for_1546 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_block_in_for_1551 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_while_1627 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_while_1632 = new BitSet(new ulong[]{0x0043000000000000UL});
    public static readonly BitSet FOLLOW_logicOperator_in_while_1637 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_while_1642 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_block_in_while_1647 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_printExpr1678 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_printExpr1685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_printExpr1692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_add_in_expr1706 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_if__in_expr1712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInit_in_expr1718 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_oneArray_in_expr1724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cycle_in_expr1730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varInitValue_in_expr1736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callMethod_in_expr1742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr1748 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_line1759 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_line1762 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_methodDef_in_exprList1776 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_exprList1780 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_varInit_in_exprList1790 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_exprList1793 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_oneArray_in_exprList1803 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_exprList1806 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_exprList_in_fullProgramm1827 = new BitSet(new ulong[]{0x0000001F00000002UL});
    public static readonly BitSet FOLLOW_fullProgramm_in_program1841 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_execute1859 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}