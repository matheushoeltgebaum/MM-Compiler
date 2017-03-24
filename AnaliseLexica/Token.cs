using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Compiler.AnaliseLexica
{
    public class Token
    {
        public int id { get; private set; }
        public String lexeme { get; private set; }
        public int position { get; private set; }

        public Token(int id, String lexeme, int position)
        {
            this.id = id;
            this.lexeme = lexeme;
            this.position = position;
        }

        public override String ToString()
        {
            return id + " ( " + lexeme + " ) @ " + position;
        }
    }
}
