using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM_Compiler.AnaliseLexica;

namespace MM_Compiler.AnaliseSemantica
{
    public class SemanticError : AnalysisError
    {
        public SemanticError(String msg, int position) : base(msg, position)
        {
        }

        public SemanticError(String msg) : base(msg)
        {
        }
    }
}
