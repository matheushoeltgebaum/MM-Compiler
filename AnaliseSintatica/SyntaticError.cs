using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM_Compiler.AnaliseLexica;

namespace MM_Compiler.AnaliseSintatica
{
    public class SyntaticError : AnalysisError
    {
        public SyntaticError(String msg, int position) : base(msg, position)
        {
        }

        public SyntaticError(String msg) : base(msg)
        {
        }
    }
}
