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

	PROGRAM							;
	PRINT			= 'print'		;

	PLUS			= '+'			;
	MINUS			= '-'			;
	MULTIPLY		= '*'			;
	DIVIDE			= '/'			;
	IF				= 'if'			;
	ELSE			= 'else'		;
	BLOCK			= 'BLOCK'		;
	CONDITION		= 'CONDITION'	;

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

	AND = '&&'						;
	OR = '||'						;
	EQ = '=='						;
	NONEQ = '!='					;
	MORE = '>'						;
	LESS = '<'						;
	MOREEQ = '>='					;
	LESSEQ = '<='					;
}

@parser::namespace { GrammarApp }
@lexer::namespace  { GrammarApp }


/* ==============================================	 MAIN	 =============================================================== */

type	:	INT
		|	FLOAT
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


ID		:	 ('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* 
		;

ident		:	ID -> ^(Id<IDNode> ID)
			;

varInit	:	type varInitValue
				-> ^(VarInit<VarInitNode> type varInitValue)
		;


varInitValue	:  ident (ASSIGN initValue)?
						-> ^(Assign<AssignNode> ident (initValue)?)
				;

initValue		: add
				| callMethod
				| ident
				| inc
				| dec
				;

oneArray	:	type ident '[' number ']'
				-> ^(ONEARRAY ^(ident ^(COUNT number)))
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

print	:	PRINT '(' printExpr ')'
			-> ^(PRINT printExpr)
		;

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


orOperation			:	add OR add -> ^(OrOp<OrOperationNode> add add)
					;

andOperation		:	add AND add -> ^(AndOp<AndOperationNode> add add)
					;

eqOp				:	add EQ add -> ^(EqOp<EqualityOperationNode> add add)
					;

nonEqOp				:	add NONEQ add -> ^(NonEqOp<NonEqualityOperationNode> add add)
					;

moreOp				:	 add MORE add -> ^(MoreOp<LogicOperationMoreNode> add add)
					;

moreEqOp			:	add MOREEQ add -> ^(MoreEqOp<LogicOperationMoreEqNode> add add)
					;

lessOp				:	add LESS add -> ^(LessOp<LogicOperationLessNode> add add)
					;

lessEqOp			:	add LESSEQ add -> ^(LessEqOp<LogicOperationLessEqNode> add add)
					;


for_	:	FOR 
            '('	
		    varInit ';'
			logicOperator ';'
		    varInitValue
			')'
			block
			-> ^(For<ForNode> varInit logicOperator varInitValue block)
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

cycle	:	for_
		|	while_
		;



printExpr	:	add
			|	ident
			|	callMethod
			;		

changeValue	:	ident ASSIGN initValue
						-> ^(Assign<AssignNode> ident initValue)
				;
expr	: add
		| if_
		| varInit
		| oneArray
		| cycle
		| varInitValue
		| callMethod
		| print
		| changeValue
		;

line	:	expr (';'!)* 
		;

exprList:	methodDef  (';'!)* 
		|	varInit (';'!)* 
		|	oneArray (';'!)* 
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