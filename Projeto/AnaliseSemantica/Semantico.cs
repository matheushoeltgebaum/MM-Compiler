using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MM_Compiler.AnaliseLexica;

namespace MM_Compiler.AnaliseSemantica
{
    public class Semantico : Constants
    {
        private string NomeFuncao { get; set; }
        private string AppModule { get; } = "_Principal";
        private string VariavelAtribuicao { get; set; }
        private List<Tuple<string, string>> ParametrosFuncao { get; set; }
        private string Operador { get; set; }
        public string CodigoObjeto { get; private set; }
        private StringBuilder CodigoObjetoAcao { get; set; }
        private Stack<string> PilhaTipos { get; set; }
        private string TipoIdentificador { get; set; }
        //TODO VARIAVEL NÃO PODE SER USADA DESTA FORMA
        private List<string> ListaTemporariaIdentificadoresMesmoTipo { get; set; }
        private long contadorLabel { get; set; }
        private Stack<string> PilhaLabels { get; set; }

        private Dictionary<string, Method> ListMethod { get; set; }

        private Dictionary<string, string> CurrentScope { get; set; }

        // Empilhar Contexto de variaveis
        private const string DEF_LABEL = "lb";

        public Semantico()
        {
            this.PilhaTipos = new Stack<string>();
            this.CodigoObjeto = string.Empty;
            this.Operador = string.Empty;
            Dictionary<string, string> a;
            //this.ScopeGlobal = new Dictionary<string, string>();
            this.TipoIdentificador = string.Empty;
            this.ListaTemporariaIdentificadoresMesmoTipo = new List<string>();
            PilhaLabels = new Stack<string>();
            contadorLabel = 0;
            CurrentScope = new Dictionary<string, string>();
            ListMethod = new Dictionary<string, Method>();
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
                    ExecuteAction33(token);
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
                    ExecuteAction37(token);
                    break;
                case 38:
                    ExecuteAction38();
                    break;
                case 39:
                    ExecuteAction39();
                    break;
                case 40:
                    ExecuteAction40(token);
                    break;
                case 41:
                    ExecuteAction41(token);
                    break;
                case 42:
                    ExecuteAction42(token);
                    break;
                case 43:
                    ExecuteAction43();
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
                throw new SemanticError("Tipos incompatíveis em expressão aritmética binária (adição).");
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
                throw new SemanticError("Tipos incompatíveis em expressão aritmética binária (subtração).");
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
                throw new SemanticError("Tipos incompatíveis em expressão aritmética binária (multiplicação).");
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
                throw new SemanticError("Tipos incompatíveis em expressão aritmética (divisão).");
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
                throw new SemanticError("Tipo incompatível em operação aritmética unária (adição).");
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
                throw new SemanticError("Tipo incompatível em operação aritmética unária (subtração).");
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
                throw new SemanticError("Tipos incompatíveis em operação relacional.");
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
                throw new SemanticError("Tipo incompatível em operação lógica unária.");
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
                throw new SemanticError("Tipos incompatíveis em operação lógica binária (e).");
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
                throw new SemanticError("Tipos incompatíveis em operação lógica binária (ou).");
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
            // caracter | logico | inteiro | real;
            if (token.Lexeme.ToUpperInvariant().Equals("INTEIRO"))
                TipoIdentificador = "int64";
            else if (token.Lexeme.ToUpperInvariant().Equals("REAL"))
                TipoIdentificador = "float64";
            else if (token.Lexeme.ToUpperInvariant().Equals("LOGICO"))
                TipoIdentificador = "bool";
            else if (token.Lexeme.ToUpperInvariant().Equals("CARACTER"))
                TipoIdentificador = "string";
        }

        private void ExecuteAction23(Token token)
        {
            ListaTemporariaIdentificadoresMesmoTipo.Add(AjustarIdentificadores(token.Lexeme));
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

            foreach (var id in ListaTemporariaIdentificadoresMesmoTipo)
            {
                if (CurrentScope.ContainsKey(id) || ListMethod.ContainsKey(id))
                {
                    throw new SemanticError("Identificador já declarado.");
                }
                
                CurrentScope.Add(id, TipoIdentificador);
                CodigoObjetoAcao.AppendLine($".locals({TipoIdentificador} {id})");
            }

            CodigoObjeto += CodigoObjetoAcao.ToString();
            ListaTemporariaIdentificadoresMesmoTipo.Clear();
        }

        private void ExecuteAction25()
        {
            foreach (var id in ListaTemporariaIdentificadoresMesmoTipo)
            {
                if (!CurrentScope.ContainsKey(id))
                {
                    throw new SemanticError($"{id} não declarado.");
                }

                TipoIdentificador = CurrentScope[id];
                CodigoObjetoAcao.AppendLine("call string [mscorlib]System.Console::ReadLine()");

                switch (TipoIdentificador)
                {
                    case "int64":
                        CodigoObjetoAcao.AppendLine("call int64 [mscorlib]System.Int64::Parse(string)");
                        break;
                    case "float64":
                        CodigoObjetoAcao.AppendLine("call float64 [mscorlib]System.Double::Parse(string)");
                        break;
                    case "bool":
                        CodigoObjetoAcao.AppendLine("call bool [mscorlib]System.Boolean::Parse(string)");
                        break;
                }

                CodigoObjetoAcao.AppendLine($"stloc {id}");
            }

            CodigoObjeto += CodigoObjetoAcao.ToString();
            ListaTemporariaIdentificadoresMesmoTipo.Clear();
        }

        private void ExecuteAction26(Token token)
        {
            var id = AjustarIdentificadores(token.Lexeme);
            if (!CurrentScope.ContainsKey(id) && !ListMethod.ContainsKey(id) && (NomeFuncao == null || !ListMethod[NomeFuncao].parametros.Exists(p => p.Item1.Equals(id))))
            {
                throw new SemanticError($"{token.Lexeme} não declarado.");
            }

            TipoIdentificador = CurrentScope.ContainsKey(id)
                ? CurrentScope[id]
                : ListMethod[NomeFuncao].parametros.First(p => p.Item1.Equals(id)).Item2;
            PilhaTipos.Push(TipoIdentificador);
            CodigoObjetoAcao.AppendLine(CurrentScope.ContainsKey(id) ? $"ldloc {id}" : $"ldarg {id}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction27()
        {
            var id = VariavelAtribuicao;
            VariavelAtribuicao = null;
            if (!CurrentScope.ContainsKey(id) && (NomeFuncao == null || !ListMethod[NomeFuncao].parametros.Exists(p => p.Item1.Equals(id))))
            {
                throw new SemanticError($"{id} não declarado.");
            }

            var tipoIdentificador = CurrentScope.ContainsKey(id)
                ? CurrentScope[id]
                : ListMethod[NomeFuncao].parametros.First(p => p.Item1.Equals(id)).Item2;
            var tipoExpressao = PilhaTipos.Pop();

            if (!tipoIdentificador.ToLower().Equals(tipoExpressao.ToLower()))
            {
                throw new SemanticError("Tipos incompatíveis em comando de atribuição.");
            }

            CodigoObjetoAcao.AppendLine($"stloc {id}");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction28()
        {
            contadorLabel++;
            var label = DEF_LABEL + contadorLabel.ToString().PadRight(15, '0');
            PilhaLabels.Push(label);
            CodigoObjetoAcao.AppendLine("brfalse "+ label);
            CodigoObjeto += CodigoObjetoAcao.ToString();

        }

        private void ExecuteAction29()
        {
            var label = PilhaLabels.Pop();
            CodigoObjetoAcao.AppendLine(label+ ":");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction30()
        {
            contadorLabel++;
            var labelElse = DEF_LABEL + contadorLabel.ToString().PadRight(15, '0');
            var labelSe = PilhaLabels.Pop();
            PilhaLabels.Push(labelElse);
            CodigoObjetoAcao.AppendLine("br " + labelElse);
            CodigoObjetoAcao.AppendLine(labelSe + ":");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction31()
        {
            contadorLabel++;
            var label = DEF_LABEL + contadorLabel.ToString().PadRight(15, '0');
            PilhaLabels.Push(label);
            CodigoObjetoAcao.AppendLine(label + ":");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction32()
        {
            CodigoObjetoAcao.AppendLine("brfalse " + PilhaLabels.Pop());
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction33(Token token)
        {
            NomeFuncao = AjustarIdentificadores(token.Lexeme);
            ParametrosFuncao = new List<Tuple<string, string>>();
            ListaTemporariaIdentificadoresMesmoTipo.Clear();
        }

        private void ExecuteAction34()
        {
            ListMethod.Add(NomeFuncao, new Method() {parametros = ParametrosFuncao, tipoRetorno = TipoIdentificador});

            ParametrosFuncao = new List<Tuple<string, string>>();
            NomeFuncao = null;
        }

        private void ExecuteAction35()
        {
            ListMethod.Add(NomeFuncao, new Method() { parametros = ParametrosFuncao, tipoRetorno = "void" });

            ParametrosFuncao = new List<Tuple<string, string>>();
            NomeFuncao = null;
        }

        private void ExecuteAction36()
        {
            foreach (var identificador in ListaTemporariaIdentificadoresMesmoTipo)
            {
                ParametrosFuncao.Add(new Tuple<string, string>(identificador, TipoIdentificador));
            }
            ListaTemporariaIdentificadoresMesmoTipo.Clear();
        }

        private void ExecuteAction37(Token token)
        {
            NomeFuncao = AjustarIdentificadores(token.Lexeme);
            CurrentScope = new Dictionary<string, string>();
            var listaParam = "";
            foreach (var param in ListMethod[NomeFuncao].parametros)
            {
                if (string.IsNullOrEmpty(listaParam))
                    listaParam += $"{param.Item2} {param.Item1}";
                else
                    listaParam += $", {param.Item2} {param.Item1}";
                
                //CurrentScope.Add(param.Item1, param.Item2);
            }
            var result = $".method public static {ListMethod[NomeFuncao].tipoRetorno} {NomeFuncao}({listaParam})";
            CodigoObjetoAcao.AppendLine(result);
            CodigoObjetoAcao.AppendLine("{");

            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction38()
        {
            var funcao = ListMethod[NomeFuncao];

            var listaParam = "";
            foreach (var param in funcao.parametros)
            {
                if (string.IsNullOrEmpty(listaParam))
                    listaParam += $"{param.Item2}";
                else
                    listaParam += $", {param.Item2}";
                
            }
            var chamada = $"call {funcao.tipoRetorno} {AppModule}::{NomeFuncao}({listaParam})";
            CodigoObjetoAcao.AppendLine(chamada);

            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        private void ExecuteAction39()
        {
            ExecuteAction38();
            //TODO Adicionar resultado para pilha
        }

        private void ExecuteAction40(Token token)
        {
            ListaTemporariaIdentificadoresMesmoTipo.Clear();
            VariavelAtribuicao = AjustarIdentificadores(token.Lexeme);
        }

        private void ExecuteAction41(Token token)
        {
            ListaTemporariaIdentificadoresMesmoTipo.Clear();
            NomeFuncao = AjustarIdentificadores(token.Lexeme);
        }

        private void ExecuteAction42(Token token)
        {
            ListaTemporariaIdentificadoresMesmoTipo.Clear();
        }

        private void ExecuteAction43()
        {
            CodigoObjetoAcao.AppendLine("ret");
            CodigoObjeto += CodigoObjetoAcao.ToString();
        }

        public static string AjustarIdentificadores(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return "_"+sbReturn.ToString().ToUpper();
        }
    }

    

    public class Method
    {
        public string tipoRetorno { get; set; }
        public List<Tuple<string, string>> parametros { get; set; }
    }
}
