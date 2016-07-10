/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

grammar VKScript;

// ==================  PARSER  =======================
vk_script : (statement | NEWLINE)*;

literal : primitive | list | pair;
list : LCBRACKET (expr (COMMA expr)*)? RCBRACKET;
pair : ID COLON expr;
expr :
  expr DOT ID LBRACKET list? RBRACKET #exprMethodCall
| ID LBRACKET list? RBRACKET #exprFuncCall
| pair #exprPair | ID #exprId | literal #exprLiteral
| expr MOD expr #exprOperatorMod
| expr MUL expr #exprOperatorMul
| expr DIV expr #exprOperatorDiv
| expr PLUS expr #exprOperatorPlus
| expr MINUS expr #exprOperatorMinus
| expr EQ expr #exprOperatorEq
| expr NOTEQ expr #exprOperatorNotEq
| expr LESS_THAN expr #exprOperatorLessThen
| expr LESS_EQ_THAN expr #exprOperatorLessEqThen
| expr GREATER_THAN expr #exprOperatorGreaterThen
| expr GREATER_EQ_THAN expr #exprOperatorGreaterEqThen
| expr AND expr #exprOperatorAnd
| expr OR expr #exprOperatorOr
| LBRACKET expr RBRACKET #exprBrackets;
primitive : MINUS? INT | STRING | BOOL;

assign : ID ASSIGN expr;

if_else_statement : IF LBRACKET expr RBRACKET NEWLINE* LCBRACKET vk_script RCBRACKET (NEWLINE* ELSE NEWLINE* LCBRACKET vk_script RCBRACKET)?;
while_statement : WHILE LBRACKET expr RBRACKET NEWLINE* LCBRACKET vk_script RCBRACKET;
statement : assign | output | if_else_statement | while_statement;

output : expr;

// ==================  LEXER  =======================
INT : [0-9]+;
STRING : '"' .*? '"';
BOOL : 'true' | 'false';

COLON : ':';
DOT : '.';
COMMA : ',';

ASSIGN : '=';

EQ : '==';
NOTEQ : '!=';
AND : '&&';
OR : '||';

PLUS : '+';
MINUS : '-';
MUL : '*';
DIV : '/';
MOD : '%';

LESS_THAN : '<';
LESS_EQ_THAN : '<=';
GREATER_THAN : '>';
GREATER_EQ_THAN : '>=';

LBRACKET : '(';
RBRACKET : ')';
LCBRACKET : '{';
RCBRACKET : '}';

IF : 'if';
ELSE : 'else';
WHILE : 'while';
COMMENT : '//' .*? NEWLINE -> skip;

NEWLINE : '\r' '\n' | '\r\n' | '\n' | '\r';
WS : [ \n\r\t]+ -> skip;
ID : [a-zA-Z_][a-zA-Z0-9_]*;