using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM_Compiler.AnaliseLexica;

namespace MM_Compiler.AnaliseSemantica
{
    public class Semantico : Constants
    {
        public void executeAction(int action, Token token)
        {
            Console.WriteLine($"Ação #{action}, Token: {token}");
        }
    }
}
