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

incDec	:	INCREMENT
		|	DECREMENT
		;

elementarySign	:	PLUS
				|	MINUS
				|	MULTIPLY
				|	DIVIDE
				;


/* ==============================================	 RULES	 =============================================================== */


INTEGER	: ('0'..'9')+
		;

REAL	: INTEGER '.' INTEGER
		;

number	: INTEGER 
		| REAL
		;

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;


varInit	:	type varInitValue
				-> ^(VarInit<VarInitNode> type varInitValue)
		;


varInitValue	:  ID (ASSIGN add)?
						-> ^(Assign<AssignNode> ID (add)?)
				;


optionsChangeValue	: incDec 
					| (typeAssign^ add+)
					;

oneArray	:	type ID '[' number ']'
				-> ^(ONEARRAY ^(ID ^(COUNT number)))
			;

addOperation	:	PLUS -> Plus<PlusNode>
				|	MINUS -> Minus<MinusNode>
				;

multOperation	:	MULTIPLY -> MULT<MultNode>
				|	DIVIDE -> DIVIDE<DivideNode>			
				;

group	:	'('! add ')'! 
		|	number
		;
    
mult	:	group ( multOperation^ group)* ;

add		:	mult ( addOperation^ mult)* ;

print	:	PRINT '(' printExpr ')'
			-> ^(PRINT printExpr)
		;

block	:	'{' line* '}' -> ^(BLOCK<CodeBlockNode> line*)
		;


if_		:	IF	'(' logicOperator ')' block (ELSE block)?
			-> ^(IF ^(CONDITION logicOperator) block ^(ELSE block)? )
		;
		
logicOperator	:	orOperation+
				;

orOperation		:	andOperation ( '||'^ andOperation)*
				;

andOperation	:	equalityOperation ( '&&'^ equalityOperation)*
				;

equalityOperation	:	defaultOperation ( ('==' | '!=')^ defaultOperation)*
					;

defaultOperation	:	 add ( ('>' | '<' |'>=' | '<=')^ add)*
					;







methodDef	: type ID '()' block -> ^(Method<MethodDefNode> ^(ID type? block))
		;

callMethod	:	ID '()' 
				-> ^(CALLMETHOD ID)
			;

cycle	:	for_
		|	while_
		;

for_	:	FOR 
            '('	
		    type? ID ASSIGN add ';'
		    logicOperator ';' 
			varInitValue
			')'
			block
			-> ^(FOR<ForNode> ^(VAR type? ^(ID ^(ASSIGN add))) 
			   ^(CONDITION logicOperator)
			   varInitValue
			    block
			   )
		;
while_	:	WHILE
			'('
			logicOperator
			')'
			block
			-> ^(WHILE ^(CONDITION logicOperator) block)		
		;


printExpr	:	add
			|	ID
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