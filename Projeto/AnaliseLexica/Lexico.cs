using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Compiler.AnaliseLexica
{
    public class Lexico : Constants
    {
        private int position;
        private String input;

        public Lexico() : this("")
        {
        }

        public Lexico(String input) : base()
        {
            SetInput(input);
        }

        public void SetInput(String input)
        {
            this.input = input;
            SetPosition(0);
        }

        public void SetPosition(int pos)
        {
            position = pos;
        }

        public Token NextToken()
        {
            if (!HasInput())
                return null;

            int start = position;

            int state = 0;
            int lastState = 0;
            int endState = -1;
            int end = -1;

            while (HasInput())
            {
                lastState = state;
                state = NextState(NextChar(), state);

                if (state < 0)
                    break;

                else
                {
                    if (TokenForState(state) >= 0)
                    {
                        endState = state;
                        end = position;
                    }
                }
            }
            if (endState < 0 || (endState != state && TokenForState(lastState) == -2))
                throw new LexicalError(SCANNER_ERROR[lastState], start);

            position = end;

            int token = TokenForState(endState);

            if (token == 0)
                return NextToken();
            else
            {
                String lexeme = input.Substring(start, end - start);
                token = LookupToken(token, lexeme);
                return new Token(token, lexeme, start);
            }
        }

        private int NextState(char c, int state)
        {
            int start = SCANNER_TABLE_INDEXES[state];
            int end = SCANNER_TABLE_INDEXES[state + 1] - 1;

            while (start <= end)
            {
                int half = (start + end) / 2;

                if (SCANNER_TABLE[half][0] == c)
                    return SCANNER_TABLE[half][1];
                else if (SCANNER_TABLE[half][0] < c)
                    start = half + 1;
                else  //(SCANNER_TABLE[half][0] > c)
                    end = half - 1;
            }

            return -1;
        }

        private int TokenForState(int state)
        {
            if (state < 0 || state >= TOKEN_STATE.Length)
                return -1;

            return TOKEN_STATE[state];
        }
        
        public int LookupToken(int tokenBase, String key)
        {
            int start = SPECIAL_CASES_INDEXES[tokenBase];
            int end = SPECIAL_CASES_INDEXES[tokenBase + 1] - 1;

            key = key.ToUpper();

            while (start <= end)
            {
                int half = (start + end) / 2;
                int comp = SPECIAL_CASES_KEYS[half].CompareTo(key);

                if (comp == 0)
                    return SPECIAL_CASES_VALUES[half];
                else if (comp < 0)
                    start = half + 1;
                else  //(comp > 0)
                    end = half - 1;
            }

            return tokenBase;
        }

        private bool HasInput()
        {
            return position < input.Length;
        }

        private char NextChar()
        {
            return (HasInput()) ? input.ElementAt(position++) : Convert.ToChar(-1);
        }
    }
}
