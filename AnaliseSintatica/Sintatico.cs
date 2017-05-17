using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM_Compiler.AnaliseLexica;
using MM_Compiler.AnaliseSemantica;

namespace MM_Compiler.AnaliseSintatica
{
    public class Sintatico : Constants
    {
        private Stack stack = new Stack();
        private Token currentToken;
        private Token previousToken;
        private Lexico scanner;
        private Semantico semanticAnalyser;

        private static bool isTerminal(int x)
        {
            return x < FIRST_NON_TERMINAL;
        }

        private static bool isNonTerminal(int x)
        {
            return x >= FIRST_NON_TERMINAL && x < FIRST_SEMANTIC_ACTION;
        }

        private static bool isSemanticAction(int x)
        {
            return x >= FIRST_SEMANTIC_ACTION;
        }

        private bool step()
        {
            if (currentToken == null)
            {
                int pos = 0;
                if (previousToken != null)
                    pos = previousToken.Position+previousToken.Lexeme.Length;

                currentToken = new Token(DOLLAR, "$", pos);
            }

            int x = ((int)stack.Pop());
            int a = currentToken.Id;

            if (x == EPSILON)
            {
                return false;
            }
            else if (isTerminal(x))
            {
                if (x == a)
                {
                    if (stack.Count == 0)
                        return true;
                    else
                    {
                        previousToken = currentToken;
                        currentToken = scanner.NextToken();
                        return false;
                    }
                }
                else
                {
                    throw new SyntaticError(PARSER_ERROR[x], currentToken.Position);
                }
            }
            else if (isNonTerminal(x))
            {
                if (pushProduction(x, a))
                    return false;
                else
                    throw new SyntaticError(PARSER_ERROR[x], currentToken.Position);
            }
            else // isSemanticAction(x)
            {
                semanticAnalyser.executeAction(x-FIRST_SEMANTIC_ACTION, previousToken);
                return false;
            }
        }

        private bool pushProduction(int topStack, int tokenInput)
        {
            int p = PARSER_TABLE[topStack - FIRST_NON_TERMINAL][tokenInput - 1];
            if (p >= 0)
            {
                int[] production = PRODUCTIONS[p];
                //empilha a produção em ordem reversa
                for (int i = production.Length - 1; i >= 0; i--)
                {
                    stack.Push(Convert.ToInt32(production[i]));
                }
                return true;
            }
            else
                return false;
        }

        public void parse(Lexico scanner, Semantico semanticAnalyser)
        {
            this.scanner = scanner;
            this.semanticAnalyser = semanticAnalyser;

            stack.Clear();
            stack.Push(Convert.ToInt32(DOLLAR));
            stack.Push(Convert.ToInt32(START_SYMBOL));

            currentToken = scanner.NextToken();

            while (!step()) ;
        }
    }
}
