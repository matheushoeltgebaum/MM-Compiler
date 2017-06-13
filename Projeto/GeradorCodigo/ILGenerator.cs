using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Compiler.GeradorCodigo
{
    public class ILGenerator
    {
        private string Content { get; set; }
        private string FilePath { get; set; }

        public ILGenerator(string content, string filepath)
        {
            Content = content;
            FilePath = String.Concat(filepath.Replace(Path.GetExtension(filepath), string.Empty), ".il");
        }

        public void GenerateILFile()
        {
            using (FileStream fileObject = File.Create(FilePath))
            {
                byte[] conteudo = Encoding.GetEncoding("ISO-8859-1").GetBytes(Content);
                fileObject.Write(conteudo, 0, conteudo.Length);
            }
        }
    }
}
