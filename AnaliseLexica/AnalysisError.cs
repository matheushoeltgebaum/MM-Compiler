using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Compiler.AnaliseLexica
{
    public class AnalysisError : Exception
    {
        public int position { get; private set; }

        public AnalysisError(String msg, int position) : base(msg)
        {
            this.position = position;
        }

        public AnalysisError(String msg) : base(msg)
        {
            this.position = -1;
        }

        public override String ToString()
        {
            return base.ToString() + ", @ " + position;
        }
    }
}
