using System;
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

        public Semantico()
        {
            this.PilhaTipos = new Stack<string>();
            this.CodigoObjeto = string.Empty;
            this.Operador = string.Empty;
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
            }
        }
        
        private void ExecuteAction1()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();
            
            if (!((tipoOperando1.ToLower().Equals("float64") || tipoOperando1.ToLower().Equals("int64")) &&
                  (tipoOperando2.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("int64"))))
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em expressão aritmética (adição).");
            }

            if (tipoOperando1.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("float64"))
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                PilhaTipos.Push("int64");
            }

            CodigoObjetoAcao.AppendLine("add");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction2()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (!((tipoOperando1.ToLower().Equals("float64") || tipoOperando1.ToLower().Equals("int64")) &&
                  (tipoOperando2.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("int64"))))
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em expressão aritmética (subtração).");
            }

            if (tipoOperando1.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("float64"))
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                PilhaTipos.Push("int64");
            }

            CodigoObjetoAcao.AppendLine("sub");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction3()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (!((tipoOperando1.ToLower().Equals("float64") || tipoOperando1.ToLower().Equals("int64")) &&
                  (tipoOperando2.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("int64"))))
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em expressão aritmética (multiplicação).");
            }

            if (tipoOperando1.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("float64"))
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                PilhaTipos.Push("int64");
            }

            CodigoObjetoAcao.AppendLine("mul");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction4()
        {
            string tipoOperando1 = PilhaTipos.Pop();
            string tipoOperando2 = PilhaTipos.Pop();

            if (!((tipoOperando1.ToLower().Equals("float64") || tipoOperando1.ToLower().Equals("int64")) &&
                  (tipoOperando2.ToLower().Equals("float64") || tipoOperando2.ToLower().Equals("int64"))))
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em expressão aritmética (divisão).");
            }

            if (tipoOperando1.ToLower().Equals(tipoOperando2.ToLower()))
            {
                PilhaTipos.Push(tipoOperando1);
            }
            else
            {
                throw new SemanticError("Erro semântico, tipos incompatíveis em operação de divisão");
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
                    CodigoObjetoAcao.AppendLine("ldc.i4.1");
                    CodigoObjetoAcao.AppendLine("xor");
                    break;
                case "<=":
                    CodigoObjetoAcao.AppendLine("clt");
                    CodigoObjetoAcao.AppendLine("ceq");
                    CodigoObjetoAcao.AppendLine("or");
                    break;
                case ">=":
                    CodigoObjetoAcao.AppendLine("cgt");
                    CodigoObjetoAcao.AppendLine("ceq");
                    CodigoObjetoAcao.AppendLine("or");
                    break;
            }

            CodigoObjeto += CodigoObjetoAcao.ToString();
        }
        
        private void ExecuteAction11(Token token)
        {
            if (token.Lexeme.Equals("=") || token.Lexeme.Equals("<>") || token.Lexeme.Equals("<") ||
                token.Lexeme.Equals("<=") || token.Lexeme.Equals(">") || token.Lexeme.Equals(">="))
            {
                Operador = token.Lexeme;
            }
            else
            {
                throw new SemanticError("Erro semântico, operador relacional inexistente na linguagem");
            }
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
    }
}
