# MM-Compiler
Work done for the Compiler discipline in FURB (Fundação Universidade Regional de Blumenau), which consists of creating a compiler for a given language.

## Sample programs
### Hello World
```
algoritmo "Hello World"
início
    escreva ("Hello World!");
fim
```
### Program to calculate the area of a square
```
algoritmo "Area Square" 
variáveis lado, área: inteiro; 
início 
  área <- 0; 
  escreva ("digite um valor para lado: "); 
  leia (lado); 
  se lado > 0 então 
    área <- lado * lado; 
  senão 
    escreva ("valor inválido para lado - "); 
  fim; 
  escreva ("área: ", área); 
fim 
```

## Build
### Prerequisites
- .NET 4.5

## Running programs
### Prerequisites
- [ILASM](https://msdn.microsoft.com/pt-br/library/496e4ekx(v=vs.110).aspx)

## Language Specifications

### Regular Definitions

```
letra: [A-Za-z]
digito: [0-9]
letraacentuada: [áÁâÂãÃàÀéÉêÊíÍîÎóÓôÔõÕúÚûÛçÇ]
qualquerletra:{letra}|{letraacentuada}
underline: _
alfanumerico: {qualquerletra} | {digito}
nozero: [1-9]
negacaocaractere: [^\"\\\n]
ncb: [^\*/]
```

### Tokens

```
identificador:{qualquerletra}({alfanumerico}*|{underline} {alfanumerico}+)* {underline}?
constante_inteira:0|{nozero} {digito}*
constante_real:(0|{nozero} {digito}*)\.{digito}+
constante_caractere:\"{negacaocaractere}*((\\\"|\\\\)*{negacaocaractere}*)* \"
```

### Keywords
```
algoritmo
até
caracter
e
então
escreva
falso
fim
função
início
inteiro
interrompa
leia
lógico
não
ou
procedimento
quebra
real
repita
retorne
se
senão
variáveis
verdadeiro
```

### Special characters
```
+
-
*
/
,
:
;
<-
=
<>
<
<=
>
>=
(
)
```
### Non-Terminals
```
<programa>
<cabecalho_modulos>
<lista_comandos>
<comando>
<lista_modulos>
<modulo>
<cabecalho>
<lista_parametros>
<continuacao_lista_parametros>
<parametro>
<lista_identificadores>
<tipo>
<variaveis>
<lista_variaveis>
<continuacao_lista_variaveis>
<cmd_atribuicao>
<cmd_entrada>
<cmd_saida>
<lista_valores>
<valor>
<cmd_selecao>
<cmd_selecao_senao>
<cmd_repeticao>
<interrompa>
<retorne>
<cmd_chamada_modulo>
<parametros_reais>
<lista_expressoes>
<funcao>
<procedimento>
<lista_identificadores_cont>
<expressao> 
<elemento>
<relacional> 
<operador_relacional> 
<aritmetica> 
<termo> 
<aritmetica_cont>
<fator_identificador>
<fator> 
<comando_identificador>
<lista_valores_cont>
<lista_expressoes_cont>
<termo_cont>
<expressao_cont>
<relacional_cont>
```

### Grammar
```
<programa>::= #15 algoritmo constante_caractere #42 <cabecalho_modulos> <variaveis> inicio <lista_comandos> fim #16 <lista_modulos> #17;
<cabecalho_modulos>::=<cabecalho> <cabecalho_modulos>| î;
<lista_comandos>::= <comando> ";" <lista_comandos>| î;
<comando>::= identificador #23 <comando_identificador> | <cmd_entrada> | <cmd_saida> | <cmd_selecao> | <cmd_repeticao> | <interrompa> | <retorne>;
<comando_identificador> ::= <cmd_atribuicao> |  <cmd_chamada_modulo> ;
<lista_modulos>::= <modulo> <lista_modulos> | î;
<modulo>::= <funcao> | <procedimento>;
<cabecalho>::= funcao identificador #33 "("<lista_parametros>")"  ":" <tipo> #22 #34 ";" | procedimento identificador #33 "("<lista_parametros>")" #35 ";";
<lista_parametros>::= <parametro> #36 <continuacao_lista_parametros> | î;
<continuacao_lista_parametros>::= ";" <parametro> #36 <continuacao_lista_parametros> | î;
<parametro>::= <lista_identificadores> ":" <tipo> #22 ;
<lista_identificadores>::= identificador #23 <lista_identificadores_cont>;
<lista_identificadores_cont> ::= "," <lista_identificadores> | î;
<tipo>::= caracter | logico | inteiro | real;
<variaveis>::= variaveis <lista_variaveis> | î;
<lista_variaveis>::= <parametro> #24 ";"<continuacao_lista_variaveis>;
<continuacao_lista_variaveis>::= <parametro> #24 ";"<continuacao_lista_variaveis> | î;
<cmd_atribuicao>::= #40 "<-" <expressao> #27;
<cmd_entrada>::=leia"("<lista_identificadores> #25 ")" ;
<cmd_saida>::=escreva"("<lista_valores>")";
<lista_valores>::= <valor> #7 <lista_valores_cont>;
<lista_valores_cont> ::= "," <lista_valores> |î;
<valor>::= <expressao> | quebra #18;
<cmd_selecao>::=se <expressao> #28 entao <lista_comandos> <cmd_selecao_senao> fim #29;
<cmd_selecao_senao>::=senao #30 <lista_comandos> | î;
<cmd_repeticao>::=repita #31 <lista_comandos> ate <expressao> #32;
<interrompa>::=interrompa;
<retorne>::=retorne <expressao> #43;
<cmd_chamada_modulo>::= #41 "("<parametros_reais>")" #38;
<parametros_reais>::= <lista_expressoes> | î;
<lista_expressoes>::= <expressao>  <lista_expressoes_cont>;
<lista_expressoes_cont> ::= "," <lista_expressoes> | î;
<funcao>::=funcao identificador #37 ";" <variaveis> inicio <lista_comandos> fim #16;
<procedimento>::= procedimento identificador #37 ";" <variaveis> inicio <lista_comandos> fim #16;

<expressao> ::= <elemento> <expressao_cont>;
<expressao_cont> ::= ou <elemento> #20 <expressao_cont> | e <elemento> #19 <expressao_cont> | î;
<elemento> ::= <relacional> | verdadeiro #12 | falso #13 | nao <elemento> #14;
<relacional> ::= <aritmetica> <relacional_cont>;
<relacional_cont> ::= <operador_relacional> #11 <aritmetica> #10 | î;
<operador_relacional> ::= "=" | "<>" | "<" | "<=" | ">" | ">=";
<aritmetica> ::= <termo> <aritmetica_cont>;
<aritmetica_cont> ::= "+" <termo> #1 <aritmetica_cont> | "-" <termo> #2 <aritmetica_cont> | î;
<termo> ::= <fator> <termo_cont>;
<termo_cont> ::= "*" <fator> #3 <termo_cont> | "/" <fator> #4 <termo_cont> | î ;
<fator> ::= identificador #23 <fator_identificador> | constante_inteira #5 | constante_real #6 | constante_caractere #21 | "(" <expressao> ")" | "+" <fator> #8 | "-" <fator> #9;
<fator_identificador> ::= #41 "(" <parametros_reais> ")" #39 | î #40 #26;
```
