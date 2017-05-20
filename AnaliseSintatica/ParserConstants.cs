using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM_Compiler.AnaliseLexica;

namespace MM_Compiler.AnaliseSintatica
{
    public class ParserConstants : ScannerConstants
    {
        public const int START_SYMBOL = 47;

        public const int FIRST_NON_TERMINAL = 47;
        public const int FIRST_SEMANTIC_ACTION = 93;

        public static int[][] PARSER_TABLE =
        new[] {
            new[] { -1, -1, -1, -1, -1,  0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  1,  2, -1, -1, -1, -1, -1, -1,  1, -1, -1, -1, -1, -1, -1,  2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1,  3, -1, -1, -1, -1,  4, -1, -1, -1,  3, -1,  4, -1, -1, -1,  3,  3, -1, -1, -1, -1, -1, -1,  3,  3,  3,  4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1,  5, -1, -1, -1, -1, -1, -1, -1, -1,  7, -1, -1, -1, -1, -1, 10,  6, -1, -1, -1, -1, -1, -1,  9, 11,  8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 14, -1, -1, -1, -1, -1, -1, -1, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 16, -1, -1, -1, -1, -1, -1, -1, 17, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 18, -1, -1, -1, -1, -1, -1, -1, 19, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 21 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 22, -1, -1, -1, -1, -1, -1, -1, -1, 23 },
            new[] { -1, 24, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, 25, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, 28, -1, -1, -1, -1, -1, -1, -1, 30, -1, -1, 29, -1, -1, -1, -1, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 33, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, 34, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, 35, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 36, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 37, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 38, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 39, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, 40, 40, 40, 40, -1, -1, -1, -1, -1, -1, 40, -1, -1, -1, -1, -1, -1, -1, 40, -1, -1, 40, -1, -1, -1, -1, -1, -1, 40, 40, 40, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 40, -1 },
            new[] { -1, 43, 43, 43, 43, -1, -1, -1, -1, -1, -1, 43, -1, -1, -1, -1, -1, -1, -1, 43, -1, -1, 44, -1, -1, -1, -1, -1, -1, 43, 43, 43, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 43, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 45, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 47, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 46, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 48, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 49, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 51, -1 },
            new[] { -1, 52, 52, 52, 52, -1, -1, -1, -1, -1, -1, 52, -1, -1, -1, -1, -1, -1, -1, 52, -1, -1, -1, -1, -1, -1, -1, -1, -1, 52, 52, 52, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 52, 53 },
            new[] { -1, 54, 54, 54, 54, -1, -1, -1, -1, -1, -1, 54, -1, -1, -1, -1, -1, -1, -1, 54, -1, -1, -1, -1, -1, -1, -1, -1, -1, 54, 54, 54, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 54, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 57, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 58, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 26, 27, -1, -1, -1, -1, -1, -1, -1, -1, -1, 27 },
            new[] { -1, 59, 59, 59, 59, -1, -1, -1, -1, -1, -1, 59, -1, -1, -1, -1, -1, -1, -1, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, 59, 59, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 59, -1 },
            new[] { -1, 63, 63, 63, 63, -1, -1, -1, -1, -1, -1, 65, -1, -1, -1, -1, -1, -1, -1, 66, -1, -1, -1, -1, -1, -1, -1, -1, -1, 64, 63, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 63, -1 },
            new[] { -1, 67, 67, 67, 67, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 67, 67, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 67, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 70, 71, 72, 73, 74, 75, -1, -1 },
            new[] { -1, 76, 76, 76, 76, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 76, 76, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 76, -1 },
            new[] { -1, 80, 80, 80, 80, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 80, 80, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 80, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, 79, 79, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 79, -1, -1, -1, -1, -1, -1, -1, -1, -1, 77, 78, -1, -1, 79, -1, 79, -1, 79, 79, 79, 79, 79, 79, -1, 79 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, 92, 92, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 92, -1, -1, -1, -1, -1, -1, -1, -1, -1, 92, 92, 92, 92, 92, -1, 92, -1, 92, 92, 92, 92, 92, 92, 91, 92 },
            new[] { -1, 84, 85, 86, 87, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 89, 90, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 88, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, -1, -1, -1, -1, -1, -1, 13, -1 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 42 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 55, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 56 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, 83, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, 83, 83, 81, 82, 83, -1, 83, -1, 83, 83, 83, 83, 83, 83, -1, 83 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, 61, 62, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 60, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 62, -1, 62, -1, -1, -1, -1, -1, -1, -1, -1, 62 },
            new[] { -1, -1, -1, -1, -1, -1, -1, -1, 69, 69, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 69, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 69, -1, 69, -1, 68, 68, 68, 68, 68, 68, -1, 69 }
        };

        public static int[][] PRODUCTIONS =
            new[] {
            new[] {  6,  5, 48, 59, 15, 49, 13, 51 },
            new[] { 53, 48 },
            new[] {  0 },
            new[] { 50, 37, 49 },
            new[] {  0 },
            new[] {  2, 87 },
            new[] { 63 },
            new[] { 64 },
            new[] { 67 },
            new[] { 69 },
            new[] { 70 },
            new[] { 71 },
            new[] { 62 },
            new[] { 72 },
            new[] { 52, 51 },
            new[] {  0 },
            new[] { 75 },
            new[] { 76 },
            new[] { 14,  2, 45, 54, 46, 36, 58, 37 },
            new[] { 22,  2, 45, 54, 46, 37 },
            new[] { 56, 55 },
            new[] {  0 },
            new[] { 37, 56, 55 },
            new[] {  0 },
            new[] { 57, 36, 58 },
            new[] {  2, 77 },
            new[] { 35, 57 },
            new[] {  0 },
            new[] {  8 },
            new[] { 19 },
            new[] { 16 },
            new[] { 24 },
            new[] { 29, 60 },
            new[] {  0 },
            new[] { 56, 37, 61 },
            new[] { 56, 37, 61 },
            new[] {  0 },
            new[] { 38, 78 },
            new[] { 18, 45, 57, 46 },
            new[] { 11, 45, 65, 46 },
            new[] { 66, 88 },
            new[] { 35, 65 },
            new[] {  0 },
            new[] { 78 },
            new[] { 23 },
            new[] { 27, 78, 10, 49, 68, 13 },
            new[] { 28, 49 },
            new[] {  0 },
            new[] { 25, 49,  7, 78 },
            new[] { 17 },
            new[] { 26, 78 },
            new[] { 45, 73, 46 },
            new[] { 74 },
            new[] {  0 },
            new[] { 78, 89 },
            new[] { 35, 74 },
            new[] {  0 },
            new[] { 14,  2, 45, 54, 46, 36, 58, 37, 59, 15, 49, 13 },
            new[] { 22,  2, 45, 54, 46, 37, 59, 15, 49, 13 },
            new[] { 79, 91 },
            new[] { 21, 79, 91 },
            new[] {  9, 79, 91 },
            new[] {  0 },
            new[] { 80 },
            new[] { 30 },
            new[] { 12 },
            new[] { 20, 79 },
            new[] { 82, 92 },
            new[] { 81, 82 },
            new[] {  0 },
            new[] { 39 },
            new[] { 40 },
            new[] { 41 },
            new[] { 42 },
            new[] { 43 },
            new[] { 44 },
            new[] { 83, 84 },
            new[] { 31, 83, 84 },
            new[] { 32, 83, 84 },
            new[] {  0 },
            new[] { 86, 90 },
            new[] { 33, 86, 90 },
            new[] { 34, 86, 90 },
            new[] {  0 },
            new[] {  2, 85 },
            new[] {  3 },
            new[] {  4 },
            new[] {  5 },
            new[] { 45, 78, 46 },
            new[] { 31, 86 },
            new[] { 32, 86 },
            new[] { 45, 73, 46 },
            new[] {  0 }
        };

        public static String[] PARSER_ERROR =
        {
            "",
            "encontrado {0} esperado fim de programa",//Era esperado fim de programa
            "encontrado {0} esperado identificador",//Era esperado identificador
            "encontrado {0} esperado constante inteira",//Era esperado constante_inteira
            "encontrado {0} esperado constante real",//Era esperado constante_real
            "encontrado {0} esperado constante caractere",//Era esperado constante_caractere
            "encontrado {0} esperado algoritmo",//Era esperado algoritmo
            "encontrado {0} esperado até",//Era esperado ate
            "encontrado {0} esperado caracter",//Era esperado caracter
            "encontrado {0} esperado e",//Era esperado e
            "encontrado {0} esperado então",//Era esperado entao
            "encontrado {0} esperado escreva",//Era esperado escreva
            "encontrado {0} esperado falso",//Era esperado falso
            "encontrado {0} esperado fim",//Era esperado fim
            "enocntrado {0} esperado função",//Era esperado funcao
            "encontrado {0} esperado início",//Era esperado inicio
            "encontrado {0} esperado inteiro",//Era esperado inteiro
            "encontrado {0} esperado interrompa",//Era esperado interrompa
            "encontrado {0} esperado leia",//Era esperado leia
            "encontrado {0} esperado lógico",//Era esperado logico
            "encontrado {0} esperado não",//Era esperado nao
            "encontrado {0} esperado ou",//Era esperado ou
            "encontrado {0} esperado procedimento",//Era esperado procedimento
            "encontrado {0} esperado quebra",//Era esperado quebra
            "encontrado {0} esperado real",//Era esperado real
            "encontrado {0} esperado repita",//Era esperado repita
            "encontrado {0} esperado retorne",//Era esperado retorne
            "encontrado {0} esperado se",//Era esperado se
            "encontrado {0} esperado senão",//Era esperado senao
            "encontrado {0} esperado variáveis",//Era esperado variaveis
            "encontrado {0} esperado verdadeiro",//Era esperado verdadeiro
            "encontrado {0} esperado +",//Era esperado \"+\"
            "encontrado {0} esperado -",//Era esperado \"-\"
            "encontrado {0} esperado *",//Era esperado \"*\"
            "encontrado {0} esperado /",//Era esperado \"/\"
            "encontrado {0} esperado ,",//Era esperado \",\"
            "encontrado {0} esperado :",//Era esperado \":\"
            "encontrado {0} esperado ;",//Era esperado \";\"
            "encontrado {0} esperado <-",//Era esperado \"<-\"
            "encontrado {0} esperado =",//Era esperado \"=\"
            "encontrado {0} esperado <>",//Era esperado \"<>\"
            "encontrado {0} esperado <",//Era esperado \"<\"
            "encontrado {0} esperado <=",//Era esperado \"<=\"
            "encontrado {0} esperado >",//Era esperado \">\"
            "encontrado {0} esperado >=",//Era esperado \">=\"
            "encontrado {0} esperado (",//Era esperado \"(\"
            "encontrado {0} esperado )",//Era esperado \")\"
            "encontrado {0} esperado algoritmo",//<programa> inválido
            "encontrado {0} esperado função  início  procedimento  variáveis",//<cabecalho_modulos> inválido
            "encontrado {0} esperado identificador  até  escreva  fim  interrompa  leia  repita  retorne  se  senão",//<lista_comandos> inválido
            "encontrado {0} esperado identificador  escreva  interrompa  leia  repita  retorne  se",//<comando> inválido
            "encontrado {0} esperado fim de arquivo  função  procedimento",//<lista_modulos> inválido
            "encontrado {0} esperado função  procedimento",//<modulo> inválido
            "encontrado {0} esperado função  procedimento",//<cabecalho> inválido
            "encontrado {0} esperado identificador  )",//<lista_parametros> inválido
            "encontrado {0} esperado ;  )",//<continuacao_lista_parametros> inválido
            "encontrado {0} esperado identificador",//<parametro> inválido
            "encontrado {0} esperado identificador",//<lista_identificadores> inválido
            "encontrado {0} esperado caracter  inteiro  lógico  real",//<tipo> inválido
            "encontrado {0} esperado início  variáveis",//<variaveis> inválido
            "encontrado {0} esperado identificador",//<lista_variaveis> inválido
            "encontrado {0} esperado identificador  início",//<continuacao_lista_variaveis> inválido
            "encontrado {0} esperado <-",//<cmd_atribuicao> inválido
            "encontrado {0} esperado leia",//<cmd_entrada> inválido
            "encontrado {0} esperado escreva",//<cmd_saida> inválido
            "encontrado {0} esperado expressão",//<lista_valores> inválido
            "encontrado {0} esperado expressão  quebra",//<valor> inválido
            "encontrado {0} esperado se",//<cmd_selecao> inválido
            "encontrado {0} esperado fim  senão",//<cmd_selecao_senao> inválido
            "encontrado {0} esperado repita",//<cmd_repeticao> inválido
            "encontrado {0} esperado interrompa",//<interrompa> inválido
            "encontrado {0} esperado retorne",//<retorne> inválido
            "encontrado {0} esperado  (",//<cmd_chamada_modulo> inválido
            "encontrado {0} esperado expressão  )",//<parametros_reais> inválido
            "encontrado {0} esperado expressão",//<lista_expressoes> inválido
            "encontrado {0} esperado função",//<funcao> inválido
            "encontrado {0} esperado procedimento",//<procedimento> inválido
            "encontrado {0} esperado ,  :  )",//<lista_identificadores_cont> inválido
            "encontrado {0} esperado expressão",//<expressao> inválido
            "encontrado {0} esperado expressão",//<elemento> inválido
            "encontrado {0} esperado expressão",//<relacional> inválido
            "encontrado {0} esperado expressão",//<operador_relacional> inválido
            "encontrado {0} esperado expressão",//<aritmetica> inválido
            "encontrado {0} esperado expressão",//<termo> inválido
            "encontrado {0} esperado expressão",//<aritmetica_cont> inválido
            "encontrado {0} esperado expressão",//<fator_identificador> inválido
            "encontrado {0} esperado expressão",//<fator> inválido
            "encontrado {0} esperado expressão",//<comando_identificador> inválido
            "encontrado {0} esperado expressão",//<lista_valores_cont> inválido
            "encontrado {0} esperado expressão",//<lista_expressoes_cont> inválido
            "encontrado {0} esperado expressão",//<termo_cont> inválido
            "encontrado {0} esperado expressão",//<expressao_cont> inválido
            "encontrado {0} esperado expressão"//<relacional_cont> inválido
        };
    }
}
