﻿using System.Windows.Forms;
using System;
using System.IO;
using System.Text;
using MM_Compiler.AnaliseLexica;

namespace MM_Compiler
{
    public partial class FormCompiler : Form
    {
        public FormCompiler()
        {
            InitializeComponent();

        }

        #region Métodos sobre a View
        private void ButtonEquipe_Click(object sender, EventArgs e)
        {
            this.MessageDisplay.Text = Environment.NewLine + "Equipe: Matheus Adriano Pereira e Matheus Eduardo Hoeltgebaum Pereira.";
        }

        private void ButtonGerarCodigo_Click(object sender, EventArgs e)
        {
            this.MessageDisplay.Text = Environment.NewLine + "Geração de código ainda não foi implementada.";
        }

        private void ButtonCompilar_Click(object sender, EventArgs e)
        {
            Lexico lex = new Lexico();
            lex.SetInput(TextEditor.Text);

            try
            {
                Token t = null;
                this.MessageDisplay.Text = $"\r\n{"linha".PadRight(7)}{"classe".PadRight(20)}{"lexema"}";
                while ((t = lex.NextToken()) != null)
                {
                    var lexema = t.lexeme;
                    var linha = this.TextEditor.GetLineFromCharIndex(t.position);
                    var classe = GetClass(t.id);
                    this.MessageDisplay.Text += $"\r\n{linha.ToString().PadRight(7)}{classe.PadRight(20)}{lexema}";
                }
                this.MessageDisplay.Text += "\r\n    programa compilado com sucesso";
            }
            catch (LexicalError le)
            {
                if (le.Message.Equals("%CARACTERENAOESPERADO%"))
                {
                    MessageDisplay.Text = $"Erro na linha {TextEditor.GetLineFromCharIndex(le.position)} – {TextEditor.Text.Substring(le.position,1)} símbolo inválido";
                }
                else
                    MessageDisplay.Text = $"Erro na linha {TextEditor.GetLineFromCharIndex(le.position)} – {le.Message}";
            }
        }

        private string GetClass(int idToken)
        {
            if (idToken == 2) return "identificador";
            if (idToken == 3) return "constante inteira";
            if (idToken == 4) return "constante real";
            if (idToken == 5) return "constante caractere";
            if (idToken >= 6 && idToken <= 32) return "palavra reservada";
            if (idToken >= 33 && idToken <= 49) return "símbolo especial";
            return "Token não reconhecido!";
        }

        private void ButtonRecortar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextEditor.SelectedText))
                TextEditor.Cut();
        }

        private void ButtonColar_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                TextEditor.Paste();
            }
        }

        private void ButtonCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextEditor.SelectedText))
                TextEditor.Copy();
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Arquivos de texto|*.txt";
                saveDialog.Title = "Selecione um local para salvar o arquivo";

                if (!File.Exists(LabelPath.Text))
                {
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        CriarArquivo(saveDialog.FileName);
                        this.MessageDisplay.Clear();
                        this.LabelPath.Text = saveDialog.FileName;
                        this.LabelStatus.Text = "Não modificado";
                    }
                }
                else
                {
                    SalvarArquivo();
                    this.MessageDisplay.Clear();
                    this.LabelStatus.Text = "Não modificado";
                }
            }
        }

        private void CriarArquivo(string path)
        {
            try
            {
                using (FileStream fileObject = File.Create(path))
                {
                    byte[] conteudo = Encoding.GetEncoding("ISO-8859-1").GetBytes(TextEditor.Text);
                    fileObject.Write(conteudo, 0, conteudo.Length);
                }
            }
            catch
            {
                MessageDisplay.Text += "\n Não foi possível salvar o arquivo";
            }
        }

        private void SalvarArquivo()
        {
            try
            {
                using (FileStream fileObject = File.Open(LabelPath.Text, FileMode.Open))
                {
                    byte[] conteudo = Encoding.GetEncoding("ISO-8859-1").GetBytes(TextEditor.Text);
                    fileObject.Write(conteudo, 0, conteudo.Length);
                }
            }
            catch
            {
                MessageDisplay.Text += "\n Não foi possível salvar as alterações realizadas no arquivo.";
            }
        }

        private void ButtonAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Arquivos de texto|*.txt";
                openDialog.Title = "Selecione um arquivo";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    CarregarConteudoArquivo(openDialog.OpenFile());
                    this.MessageDisplay.Clear();
                    this.LabelPath.Text = openDialog.FileName;
                    this.LabelStatus.Text = "Não modificado";
                }
            }
        }

        private void CarregarConteudoArquivo(Stream fileObject)
        {
            try
            {
                byte[] tamanhoBytesFile = new byte[fileObject.Length];
                fileObject.Read(tamanhoBytesFile, 0, Convert.ToInt32(fileObject.Length));
                fileObject.Flush();
                fileObject.Close();
                this.TextEditor.Text = Encoding.GetEncoding("ISO-8859-1").GetString(tamanhoBytesFile);
            }
            catch
            {
                this.MessageDisplay.Text += "\n Não foi possível carregar o arquivo selecionado.";
            }
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            this.TextEditor.Clear();
            this.MessageDisplay.Clear();
            this.LabelPath.Text = "";
            this.LabelStatus.Text = "Não modificado";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);

            if (e.Control && e.KeyCode == Keys.C)
            {
                this.ButtonCopiar.PerformClick();
                return true;
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                this.ButtonNovo.PerformClick();
                return true;
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                this.ButtonAbrir.PerformClick();
                return true;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                this.ButtonSalvar.PerformClick();
                return true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                this.ButtonColar.PerformClick();
                return true;
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                this.ButtonRecortar.PerformClick();
                return true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                this.ButtonEquipe.PerformClick();
            }
            else if (e.KeyCode == Keys.F8)
            {
                this.ButtonCompilar.PerformClick();
            }
            else if (e.KeyCode == Keys.F9)
            {
                this.ButtonGerarCodigo.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            if (!LabelStatus.Text.Equals("Modificado"))
                this.LabelStatus.Text = "Modificado";
        }
        #endregion
    }
}
