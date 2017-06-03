using System;

namespace MM_Compiler.AnaliseLexica
{
    public class AnalysisError : Exception
    {
        public int Position { get; private set; }

        public Token Token { get; private set; }

        public AnalysisError(string msg, Token token) : base(msg)
        {
            Position = token.Position;
            Token = token;
        }

        public AnalysisError(string msg, int position) : base(msg)
        {
            Position = position;
        }

        public AnalysisError(string msg) : base(msg)
        {
            this.Position = -1;
        }

        public override string ToString()
        {
            return base.ToString() + ", @ " + Position;
        }
    }
}
