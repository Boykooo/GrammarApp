grammar MyGrammar;

options
{
	language=CSharp2;
	output=AST;
	backtrack=true;
}

tokens
{
	VarInit							;
	Method							;
	Add								;
	MULT							;
	Assign							;
	Plus							;
	Minus							;
	Integer							;
	Double							;
	CallMethod						;
	Id								;
	AndOp							;
	OrOp							;
	EqOp							;
	NonEqOp							;
	DefOp							;
	MoreOp							;
	MoreEqOp						;
	LessOp							;
	LessEqOp						;
	For								;
	LogicOp							;
	If								;
	Inc								;
	While_							;
	ArrayDecl						;
	ArrayInit						;
	Print							;
	Println							;
	NextLine						;
	String							;

	PROGRAM							;
	PRINT			= 'print'		;
	PRINTLN			= 'println'		;
	NEXTLINE		= 'nextLine()'	;

	PLUS			= '+'			;
	MINUS			= '-'			;
	MULTIPLY		= '*'			;
	DIVIDE			= '/'			;
	IF				= 'if'			;
	ELSE			= 'else'		;
	BLOCK			= 'BLOCK'		;
	CONDITION		= 'CONDITION'	;
	NEW				= 'new'			;

	ASSIGN			= '='			;
	PLUSASSIGN		= '+='			;
	MINUSASSIGN		= '-='			;
	MULTASSIGN		= '*='			;
	DIVIDEASSIGN	= '/='			;
	INCREMENT		= '++'			;
	DECREMENT		= '--'			;

	INT				= 'int'			;
	FLOAT			= 'float'		;
	DOUBLE			= 'double'		;
	CHAR			= 'char'		;
	VOID			= 'void'		;
	STRING			= 'string'		;
	VAR								;
	ONEARRAY						;
	COUNT							;

	PRIVATE			= 'private'		;
	PUBLIC			= 'public'		;
	TYPE							;
	MOD								;
	CALLMETHOD		= 'CallMethod'	;

	FOR				= 'for'			;
	WHILE			= 'while'		;
	INCREMENT_		= 'INCREMENT'	;

	AND				= '&&'			;
	OR				= '||'			;
	EQ				= '=='			;
	NONEQ			= '!='			;
	MORE			= '>'			;
	LESS			= '<'			;
	MOREEQ			= '>='			;
	LESSEQ			= '<='			;
	QUOTES			= '"'			;
}

@parser::namespace { GrammarApp }
@lexer::namespace  { GrammarApp }


/* ==============================================	 MAIN	 =============================================================== */

type	:	INT
		|	FLOAT
		|	STRING
		|	DOUBLE
		|	CHAR
		|	VOID
		;	


typeAssign	:	ASSIGN
			|	PLUSASSIGN	
			|	MINUSASSIGN
			|	MULTASSIGN
			|	DIVIDEASSIGN
			;


incDec	:	inc
		|	dec
		;


inc		:	INCREMENT -> ^(Inc<IncNode> INCREMENT)
		;

dec		:	DECREMENT -> DECREMENT<DecNode>
		;

elementarySign	:	PLUS
				|	MINUS
				|	MULTIPLY
				|	DIVIDE
				;

/* ==============================================	 RULES	 =============================================================== */



INTEGER	: ('0'..'9')+
		;

DOUBLE_	: INTEGER '.' INTEGER
		;



number	: INTEGER -> ^(Integer<IntegerNode> INTEGER)
		| DOUBLE_ -> ^(Double<DoubleNode> DOUBLE_)
		;



string_		:	'"' ID '"' -> ^(String<StringNode> ID)
			;

ID		:	 ('a'..'z'|'A'..'Z'| '_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* 
		;

ident		:	ID -> ^(Id<IDNode> ID)
			;



init	:	arrayInit 
		|	varInit
		;

arrayInit	:	type '[]' ident ('=' NEW type '[' add ']')?
					->^(ArrayDecl<ArrayDeclNode> type ident (add)? )
			;

varInit	:	type fieldInitValue
				-> ^(VarInit<VarInitNode> type fieldInitValue)
		;


fieldInitValue	:  ident  (ASSIGN initValue)?
						-> ^(Assign<AssignNode> ident (initValue)?)
				;


stringInit		:	ident  (ASSIGN initValue)?
						-> ^(Assign<AssignNode> ident (initValue)?)
				;


initValue		: addOrArray
				| callMethod
				| ident
				| inc
				| dec
				| string_
				;


addOperation	:	PLUS -> Plus<PlusNode>
				|	MINUS -> Minus<MinusNode>
				;

multOperation	:	MULTIPLY -> MULT<MultNode>
				|	DIVIDE -> DIVIDE<DivideNode>			
				;

group	:	'('! add ')'! 
		|	number
		|	ident
		;
    
mult	:	group ( multOperation^ group)* ;

add		:	mult ( addOperation^ mult)* ;


block	:	'{' line* '}' -> ^(BLOCK<CodeBlockNode> line*)
		;


if_		:	IF	'(' logicOperator ')' block (ELSE block)?
			-> ^(If<IfNode> logicOperator block ^(ELSE block)? )
		;




operations			:	orOperation -> ^(OrOp<OrOperationNode> orOperation)
					|	andOperation -> ^(AndOp<AndOperationNode> andOperation)
					|	eqOp -> ^(EqOp<EqualityOperationNode> eqOp)
					|	nonEqOp -> ^(NonEqOp<NonEqualityOperationNode> nonEqOp)
					|	moreOp -> ^(MoreOp<LogicOperationMoreNode> moreOp)
					|	moreEqOp -> ^(MoreEqOp<LogicOperationMoreEqNode> moreEqOp)
					|	lessOp	-> ^(LessOp<LogicOperationLessNode> lessOp)
					|	lessEqOp -> ^(LessEqOp<LogicOperationLessEqNode> lessEqOp)
					;
		
logicOperator		:	orOperation
					|	andOperation
					|	eqOp
					|	nonEqOp
					|	moreOp
					|	moreEqOp
					|	lessOp
					|	lessEqOp
					;


orOperation			:	addOrArray OR addOrArray -> ^(OrOp<OrOperationNode> addOrArray addOrArray)
					;

andOperation		:	addOrArray AND addOrArray -> ^(AndOp<AndOperationNode> addOrArray addOrArray)
					;

eqOp				:	addOrArray EQ addOrArray -> ^(EqOp<EqualityOperationNode> addOrArray addOrArray)
					;

nonEqOp				:	addOrArray NONEQ addOrArray -> ^(NonEqOp<NonEqualityOperationNode> addOrArray addOrArray)
					;

moreOp				:	 addOrArray MORE addOrArray -> ^(MoreOp<LogicOperationMoreNode> addOrArray addOrArray)
					;

moreEqOp			:	addOrArray MOREEQ addOrArray -> ^(MoreEqOp<LogicOperationMoreEqNode> addOrArray addOrArray)
					;

lessOp				:	addOrArray LESS addOrArray -> ^(LessOp<LogicOperationLessNode> addOrArray addOrArray)
					;

lessEqOp			:	addOrArray LESSEQ addOrArray -> ^(LessEqOp<LogicOperationLessEqNode> addOrArray addOrArray)
					;



cycle	:	for_
		|	while_
		;


for_	:	FOR 
            '('	
		    varInitOrChangeValue ';'
			logicOperator ';'
		    fieldInitValue
			')'
			block
			-> ^(For<ForNode> varInitOrChangeValue logicOperator fieldInitValue block)
		;

varInitOrChangeValue	:	varChangeValue
						|	varInit
						;

while_	:	WHILE
			'('
			logicOperator
			')'
			block
			-> ^(While_<WhileNode> logicOperator block)		
		;




methodDef	: type ID '()' block -> ^(Method<MethodDefNode> ^(ID type? block))
		;


callMethod	:	ID '()' 
				-> ^(CallMethod<CallMethodNode> ID)
			;



printExpr	:	add
			|	ident
			|	callMethod
			;		

changeValue		:	varChangeValue
				|	arrayChangeValue
				;

varChangeValue	:	ident ASSIGN initValue
						-> ^(Assign<AssignNode> ident initValue)
				;

arrayChangeValue	:	ident '[' add ']' (ASSIGN  initValue)?
							-> ^(ArrayInit<ArrayInitNode> ident add (initValue)?)
					;

addOrArray		:	string_
				|	add
				|	arrayChangeValue
				;

print		:	PRINT addOrArray
					->	^(Print<PrintNode> addOrArray)
			;

println		:	PRINTLN addOrArray
					->	^(Println<PrintlnNode> addOrArray)
			;

nextLine	:	NEXTLINE
					-> NextLine<NextLineNode>
			;

expr	: add
		| if_
		| init
		| arrayInit
		| cycle
		| fieldInitValue
		| callMethod
		| print
		| println
		| nextLine
		| changeValue
		;

line	:	expr (';'!)* 
		;

exprList:	methodDef  (';'!)* 
		|	varInit (';'!)* 
		|	arrayInit (';'!)* 
		;


/* ==============================================	OUTPUT	 ===============================================================*/

fullProgramm:
			exprList*
			;

program:
  fullProgramm -> ^(PROGRAM fullProgramm)
;

execute:
  program
;

/* ==============================================	 OTHER	 =============================================================== */

WS:
  ( ' ' | '\t' | '\f' | '\r' | '\n' )+ {
    $channel=HIDDEN;
  }
;














/*
logicOperator		:	orOperation+ -> ^(LogicOp<LogicOperation> orOperation+)
					;

orOperation			:	andOperation (OR andOperation)* -> ^(OrOp<OrOperationNode> andOperation (andOperation)*)
					;

andOperation		:	eqOp (AND eqOp)* -> ^(AndOp<AndOperationNode> eqOp (eqOp)*)
					;

eqOp				:	nonEqOp (EQ nonEqOp)* -> ^(EqOp<EqualityOperationNode> nonEqOp (nonEqOp)*)
					;

nonEqOp				:	moreOp (NONEQ moreOp)* -> ^(NonEqOp<NonEqualityOperationNode> moreOp (moreOp)*)
					;

moreOp				:	 moreEqOp (MORE moreEqOp)* -> ^(MoreOp<LogicOperationMoreNode> moreEqOp (moreEqOp)*)
					;

moreEqOp			:	lessOp (MOREEQ lessOp)* -> ^(MoreEqOp<LogicOperationMoreEqNode> lessOp (lessOp)*)
					;

lessOp				:	lessEqOp (LESS lessEqOp)* -> ^(LessOp<LogicOperationLessNode> lessEqOp (lessEqOp)*)
					;

lessEqOp			:	add (LESSEQ add)* -> ^(LessEqOp<LogicOperationLessEqNode> add (add)*)
					;

*/