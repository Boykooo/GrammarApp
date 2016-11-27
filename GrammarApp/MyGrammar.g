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





		
logicOperator		:	orOperation+ -> ^(LogicOp<LogicOperation> orOperation+)
					;

orOperation			:	andOperation ( OR<OrOperationNode>^ andOperation)* 
					;

andOperation		:	eqOp (AND<AndOperationNode>^ eqOp)* 
					;

eqOp				:	nonEqOp (EQ<EqualityOperationNode>^ nonEqOp)*
					;

nonEqOp				:	moreOp (NONEQ<NonEqualityOperationNode>^ moreOp)* 
					;

moreOp				:	 moreEqOp (MORE<LogicOperationMoreNode>^ moreEqOp)* 
					;

moreEqOp			:	lessOp (MOREEQ<LogicOperationMoreEqNode>^ lessOp)*
					;

lessOp				:	lessEqOp (LESS<LogicOperationLessNode>^ lessEqOp)*
					;

lessEqOp			:	add (LESSEQ<LogicOperationLessEqNode>^ add)* 
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

expr	: add
		| if_
		| varInit
		| oneArray
		| cycle
		| varInitValue
		| callMethod
		| print
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