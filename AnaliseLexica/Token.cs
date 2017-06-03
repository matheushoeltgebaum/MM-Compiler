using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Compiler.AnaliseLexica
{
    public class Token
    {
        public int Id { get; private set; }
        public String Lexeme { get; private set; }
        public int Position { get; private set; }

        public Token(int id, String lexeme, int position)
        {
            this.Id = id;
            this.Lexeme = lexeme;
            this.Position = position;
        }

        public override String ToString()
        {
            return Id + " ( " + Lexeme + " ) @ " + Position;
        }
    }
}
