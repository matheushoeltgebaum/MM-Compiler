using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Compiler.AnaliseLexica
{
    public class LexicalError : AnalysisError
    {
        public LexicalError(string msg, int position) : base(msg, position)
        {
        }

        public LexicalError(string msg) : base(msg)
        {
        }
    }
}
