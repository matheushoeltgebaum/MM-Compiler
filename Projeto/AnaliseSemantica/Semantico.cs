using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using MM_Compiler.AnaliseLexica;

namespace MM_Compiler.AnaliseSemantica
{
    public class Semantico : Constants
    {
        private string Operador { get; set; }
        public string CodigoObjeto { get; private set; }
        private StringBuilder CodigoObjetoAcao { get; set; }
        private Stack<string> PilhaTipos { get; set; }
        private Hashtable TabelaSimbolos { get; set; }
        private string TipoIdentificador { get; set; }
        private List<string> ListaIdentificadores { get; set; }

        public Semantico()
        {
            this.PilhaTipos = new Stack<string>();
            this.CodigoObjeto = string.Empty;
            this.Operador = string.Empty;
            this.TabelaSimbolos = new Hashtable();
            this.TipoIdentificador = string.Empty;
            this.ListaIdentificadores = new List<string>();
        }

        public void ExecuteAction(int action, Token token, string filepath)
        {
            Console.WriteLine($"Ação #{action}, Token: {token}");
            CodigoObjetoAcao = new StringBuilder();

            switch (action)
            {
                case 1:
                    ExecuteAction1();
                    break;
                case 2:
                    ExecuteAction2();
                    break;
                case 3:
                    ExecuteAction3();
                    break;
                case 4:
                    ExecuteAction4();
                    break;
                case 5:
                    ExecuteAction5(token);
                    break;
                case 6:
                    ExecuteAction6(token);
                    break;
                case 7:
                    ExecuteAction7();
                    break;
                case 8:
                    ExecuteAction8();
                    break;
                case 9:
                    ExecuteAction9();
                    break;
                case 10:
                    ExecuteAction10();
                    break;
                case 11:
                    ExecuteAction11(token);
                    break;
                case 12:
                    ExecuteAction12();
                    break;
                case 13:
                    ExecuteAction13();
                    break;
                case 14:
                    ExecuteAction14();
                    break;
                case 15:
                    ExecuteAction15(filepath);
                    break;
                case 16:
                    ExecuteAction16();
                    break;
                case 17:
                    ExecuteAction17();
                    break;
                case 18:
                    ExecuteAction18();
                    break;
                case 19:
                    ExecuteAction19();
                    break;
                case 20:
                    ExecuteAction20();
                    break;
                case 21:
                    ExecuteAction21(token);
                    break;
                case 22:
                    ExecuteAction22(token);
                    break;
                case 23:
                    ExecuteAction23(token);
                    break;
                case 24:
                    ExecuteAction24();
                    break;
                case 25:
                    ExecuteAction25();
                    break;
                case 26:
                    ExecuteAction26(token);
                    break;
                case 27:
                    ExecuteAction27();
                    break;
                case 28:
                    ExecuteAction28();
                    break;
                case 29:
                    ExecuteAction29();
                    break;
                case 30:
                    ExecuteAction30();
                    break;
                case 31:
                    ExecuteAction31();
                    break;
                case 32:
                    ExecuteAction32();
                    break;
                case 33:
                    ExecuteAction33();
                    break;
                case 34:
                    ExecuteAction34();
                    break;
                case 35:
                    ExecuteAction35();
                    break;
                case 36:
                    ExecuteAction36();
                    break;
                case 37:
                    ExecuteAction37();
                    break;
                case 38:
                    ExecuteAction38();
                    break;
                case 39:
                    ExecuteAction39();
                    break;
            }
        }
        
        private void ExecuteAction1()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (tipoOperando1.ToLower().Equals("int64") && tipoOperando2.ToLower().Equals("int64"))
            {
                PilhaTipos.Push("int64");
            }
            else if (tipoOperando1.ToLower().Equals("float64") && (tipoOperando2.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("int64")) ||
                     tipoOperando2.ToLower().Equals("float64") && (tipoOperando1.ToLower().Equals("float64") || tipoOperando1.ToLower().Equals("int64")))
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em expressão aritmética (adição).");
            }

            CodigoObjetoAcao.AppendLine("add");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction2()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (tipoOperando1.ToLower().Equals("int64") && tipoOperando2.ToLower().Equals("int64"))
            {
                PilhaTipos.Push("int64");
            }
            else if (tipoOperando1.ToLower().Equals("float64") && (tipoOperando2.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("int64")) ||
                     tipoOperando2.ToLower().Equals("float64") && (tipoOperando1.ToLower().Equals("float64") || tipoOperando1.ToLower().Equals("int64")))
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em expressão aritmética (adição).");
            }

            CodigoObjetoAcao.AppendLine("sub");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction3()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (tipoOperando1.ToLower().Equals("int64") && tipoOperando2.ToLower().Equals("int64"))
            {
                PilhaTipos.Push("int64");
            }
            else if (tipoOperando1.ToLower().Equals("float64") && (tipoOperando2.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("int64")) ||
                     tipoOperando2.ToLower().Equals("float64") && (tipoOperando1.ToLower().Equals("float64") || tipoOperando1.ToLower().Equals("int64")))
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em expressão aritmética (adição).");
            }

            CodigoObjetoAcao.AppendLine("mul");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction4()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (tipoOperando1.ToLower().Equals("int64") && tipoOperando2.ToLower().Equals("int64"))
            {
                PilhaTipos.Push("int64");
            }
            else if (tipoOperando1.ToLower().Equals("float64") && (tipoOperando2.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("int64")) ||
                     tipoOperando2.ToLower().Equals("float64") && (tipoOperando1.ToLower().Equals("float64") || tipoOperando1.ToLower().Equals("int64")))
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em expressão aritmética (adição).");
            }

            CodigoObjetoAcao.AppendLine("div");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction5(Token token)
        {
            PilhaTipos.Push("int64");
            CodigoObjetoAcao.AppendLine($"ldc.i8 {token.Lexeme}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction6(Token token)
        {
            PilhaTipos.Push("float64");
            CodigoObjetoAcao.AppendLine($"ldc.r8 {token.Lexeme}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction7()
        {
            string tipoSaida = PilhaTipos.Pop();
            CodigoObjetoAcao.AppendLine($"call void [mscorlib]System.Console::Write({tipoSaida})");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction8()
        {
            string tipoOperando = PilhaTipos.Pop();

            if (tipoOperando.ToLower().Equals("int64") || tipoOperando.ToLower().Equals("float64"))
            {
                PilhaTipos.Push(tipoOperando);
            }
            else
            {
                throw new SemanticError("Erro semântico, tipo incompatível em operação unária (adição).");
            }
        }
        
        private void ExecuteAction9()
        {
            string tipoOperando = PilhaTipos.Pop();

            if (tipoOperando.ToLower().Equals("int64") || tipoOperando.ToLower().Equals("float64"))
            {
                PilhaTipos.Push(tipoOperando);
            }
            else
            {
                throw new SemanticError("Erro semântico, tipo incompatível em operação unária (subtração).");
            }

            CodigoObjetoAcao.AppendLine("ldc.i8 -1");
            CodigoObjetoAcao.AppendLine("mul");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction10()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();
            
            if ((tipoOperando1.ToLower().Equals("string") && tipoOperando2.ToLower().Equals("string")) || 
                    ((tipoOperando1.ToLower().Equals("int64") || tipoOperando1.ToLower().Equals("float64")) && 
                    (tipoOperando2.ToLower().Equals("int64") || tipoOperando2.ToLower().Equals("float64"))))
            {
                PilhaTipos.Push("bool");
            }
            else
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em operação relacional.");
            }

            switch (Operador)
            {
                case "=":
                    CodigoObjetoAcao.AppendLine("ceq");
                    break;
                case "<":
                    CodigoObjetoAcao.AppendLine("clt");
                    break;
                case ">":
                    CodigoObjetoAcao.AppendLine("cgt");
                    break;
                case "<>":
                    CodigoObjetoAcao.AppendLine("ceq");
                    CodigoObjetoAcao.AppendLine("ldc.i4 0");
                    CodigoObjetoAcao.AppendLine("ceq");
                    break;
                case "<=":
                    CodigoObjetoAcao.AppendLine("clt");
                    CodigoObjetoAcao.AppendLine("ldc.i4 0");
                    CodigoObjetoAcao.AppendLine("ceq");
                    break;
                case ">=":
                    CodigoObjetoAcao.AppendLine("cgt");
                    CodigoObjetoAcao.AppendLine("ldc.i4 0");
                    CodigoObjetoAcao.AppendLine("ceq");
                    break;
            }

            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction11(Token token)
        {
            Operador = token.Lexeme;
        }
        
        private void ExecuteAction12()
        {
            PilhaTipos.Push("bool");
            CodigoObjetoAcao.AppendLine("ldc.i4.1");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction13()
        {
            PilhaTipos.Push("bool");
            CodigoObjetoAcao.AppendLine("ldc.i4.0");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction14()
        {
            string tipoOperando = PilhaTipos.Pop();

            if (tipoOperando.ToLower().Equals("bool"))
            {
                PilhaTipos.Push(tipoOperando.ToLower());
            }
            else
            {
                throw new SemanticError("Erro semântico, tipo incompatível em operação not");
            }

            CodigoObjetoAcao.AppendLine("ldc.i4.1");
            CodigoObjetoAcao.AppendLine("xor");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction15(string filepath)
        {
            CodigoObjetoAcao.AppendLine(".assembly extern mscorlib {}");
            CodigoObjetoAcao.AppendLine(".assembly " + Path.GetFileNameWithoutExtension(filepath) + "{}");
            CodigoObjetoAcao.AppendLine($".module {Path.GetFileNameWithoutExtension(filepath)}.exe");
            CodigoObjetoAcao.AppendLine("");
            CodigoObjetoAcao.AppendLine(".class public _Principal {");
            CodigoObjetoAcao.AppendLine("");
            CodigoObjetoAcao.AppendLine(".method static public void _principal()");
            CodigoObjetoAcao.AppendLine("{.entrypoint");

            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction16()
        {
            CodigoObjetoAcao.AppendLine("ret");
            CodigoObjetoAcao.AppendLine("}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction17()
        {
            CodigoObjetoAcao.AppendLine("}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction18()
        {
            PilhaTipos.Push("string");
            CodigoObjetoAcao.AppendLine("ldstr \"\\n\"");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction19()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (tipoOperando1.ToLower().Equals("bool") && tipoOperando2.ToLower().Equals("bool"))
            {
                PilhaTipos.Push("bool");
            }
            else
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em operação lógica \"e\".");
            }

            CodigoObjetoAcao.AppendLine("and");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction20()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (tipoOperando1.ToLower().Equals("bool") && tipoOperando2.ToLower().Equals("bool"))
            {
                PilhaTipos.Push("bool");
            }
            else
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em operação lógica \"ou\".");
            }

            CodigoObjetoAcao.AppendLine("or");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction21(Token token)
        {
            PilhaTipos.Push("string");
            CodigoObjetoAcao.AppendLine($"ldstr {token.Lexeme}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction22(Token token)
        {
            TipoIdentificador = token.Lexeme;
        }

        private void ExecuteAction23(Token token)
        {
            ListaIdentificadores.Add(token.Lexeme);
        }

        private void ExecuteAction24()
        {
            switch (TipoIdentificador.ToLower())
            {
                case "int":
                    TipoIdentificador = "int64";
                    break;
                case "real":
                    TipoIdentificador = "float64";
                    break;
            }

            foreach (var id in ListaIdentificadores)
            {
                if (TabelaSimbolos.Contains(id))
                {
                    throw new SemanticError("Id já declarado");
                }
                
                TabelaSimbolos.Add(id, TipoIdentificador);
                CodigoObjetoAcao.AppendLine($".locals({TipoIdentificador} {id})");
            }

            CodigoObjeto += CodigoObjetoAcao.ToString();
            ListaIdentificadores.Clear();
        }

        private void ExecuteAction25()
        {
            foreach (var id in ListaIdentificadores)
            {
                if (!TabelaSimbolos.Contains(id))
                {
                    throw new SemanticError("Id não declarado");
                }

                TipoIdentificador = TabelaSimbolos[id].ToString();
                CodigoObjetoAcao.AppendLine("call string ... ReadLine()");

                switch (TipoIdentificador)
                {
                    case "int64":
                        CodigoObjetoAcao.AppendLine("call int64 ... Int64::Parse(string)");
                        break;
                    case "float64":
                        CodigoObjetoAcao.AppendLine("call float64 ... Double::Parse(string)");
                        break;
                }

                CodigoObjetoAcao.AppendLine($"stloc {id}");
            }

            CodigoObjeto += CodigoObjetoAcao.ToString();
            ListaIdentificadores.Clear();
        }

        private void ExecuteAction26(Token token)
        {
            var id = token.Lexeme;

            if (!TabelaSimbolos.Contains(id))
            {
                throw new SemanticError("Id não declarado");
            }

            TipoIdentificador = TabelaSimbolos[id].ToString();
            PilhaTipos.Push(TipoIdentificador);
            //TODO: Verificar se id é de variável ou parâmetro formal.
            CodigoObjetoAcao.AppendLine($"ldloc {id}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction27()
        {
            var id = ListaIdentificadores.Last();
            ListaIdentificadores.Remove(id);

            if (!TabelaSimbolos.Contains(id))
            {
                throw new SemanticError("Id não declarado");
            }

            var tipoIdentificador = TabelaSimbolos[id].ToString();
            var tipoExpressao = PilhaTipos.Pop();

            if (!tipoIdentificador.ToLower().Equals(tipoExpressao.ToLower()))
            {
                throw new SemanticError("Tipos incompatíveis em atribuição");
            }

            CodigoObjetoAcao.AppendLine($"stloc {id}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction28()
        {

        }

        private void ExecuteAction29()
        {
            
        }

        private void ExecuteAction30()
        {

        }

        private void ExecuteAction31()
        {

        }

        private void ExecuteAction32()
        {

        }

        private void ExecuteAction33()
        {

        }

        private void ExecuteAction34()
        {

        }

        private void ExecuteAction35()
        {

        }

        private void ExecuteAction36()
        {

        }

        private void ExecuteAction37()
        {

        }

        private void ExecuteAction38()
        {

        }

        private void ExecuteAction39()
        {

        }
    }
}
