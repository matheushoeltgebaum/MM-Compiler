namespace MM_Compiler
{
    partial class FormCompiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompiler));
            this.ToolBox = new System.Windows.Forms.Panel();
            this.ButtonEquipe = new System.Windows.Forms.Button();
            this.ButtonGerarCodigo = new System.Windows.Forms.Button();
            this.ButtonCompilar = new System.Windows.Forms.Button();
            this.ButtonRecortar = new System.Windows.Forms.Button();
            this.ButtonColar = new System.Windows.Forms.Button();
            this.ButtonCopiar = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonAbrir = new System.Windows.Forms.Button();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.TextEditor = new System.Windows.Forms.RichTextBox();
            this.MessageDisplay = new System.Windows.Forms.RichTextBox();
            this.StatusBar = new System.Windows.Forms.Panel();
            this.LabelPath = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ToolBox.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBox
            // 
            this.ToolBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBox.Controls.Add(this.ButtonEquipe);
            this.ToolBox.Controls.Add(this.ButtonGerarCodigo);
            this.ToolBox.Controls.Add(this.ButtonCompilar);
            this.ToolBox.Controls.Add(this.ButtonRecortar);
            this.ToolBox.Controls.Add(this.ButtonColar);
            this.ToolBox.Controls.Add(this.ButtonCopiar);
            this.ToolBox.Controls.Add(this.ButtonSalvar);
            this.ToolBox.Controls.Add(this.ButtonAbrir);
            this.ToolBox.Controls.Add(this.ButtonNovo);
            this.ToolBox.Location = new System.Drawing.Point(3, 2);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(214, 576);
            this.ToolBox.TabIndex = 0;
            // 
            // ButtonEquipe
            // 
            this.ButtonEquipe.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEquipe.Image")));
            this.ButtonEquipe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonEquipe.Location = new System.Drawing.Point(0, 513);
            this.ButtonEquipe.Name = "ButtonEquipe";
            this.ButtonEquipe.Size = new System.Drawing.Size(144, 63);
            this.ButtonEquipe.TabIndex = 4;
            this.ButtonEquipe.Text = "Equipe [F1]";
            this.ButtonEquipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonEquipe.UseVisualStyleBackColor = true;
            // 
            // ButtonGerarCodigo
            // 
            this.ButtonGerarCodigo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGerarCodigo.Image")));
            this.ButtonGerarCodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonGerarCodigo.Location = new System.Drawing.Point(0, 448);
            this.ButtonGerarCodigo.Name = "ButtonGerarCodigo";
            this.ButtonGerarCodigo.Size = new System.Drawing.Size(144, 63);
            this.ButtonGerarCodigo.TabIndex = 4;
            this.ButtonGerarCodigo.Text = "Gerar Código [F9]";
            this.ButtonGerarCodigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonGerarCodigo.UseVisualStyleBackColor = true;
            // 
            // ButtonCompilar
            // 
            this.ButtonCompilar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCompilar.Image")));
            this.ButtonCompilar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCompilar.Location = new System.Drawing.Point(0, 384);
            this.ButtonCompilar.Name = "ButtonCompilar";
            this.ButtonCompilar.Size = new System.Drawing.Size(144, 63);
            this.ButtonCompilar.TabIndex = 4;
            this.ButtonCompilar.Text = "Compilar [F8]";
            this.ButtonCompilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonCompilar.UseVisualStyleBackColor = true;
            // 
            // ButtonRecortar
            // 
            this.ButtonRecortar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRecortar.Image")));
            this.ButtonRecortar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonRecortar.Location = new System.Drawing.Point(0, 320);
            this.ButtonRecortar.Name = "ButtonRecortar";
            this.ButtonRecortar.Size = new System.Drawing.Size(144, 63);
            this.ButtonRecortar.TabIndex = 4;
            this.ButtonRecortar.Text = "Recortar [Ctrl+X]";
            this.ButtonRecortar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonRecortar.UseVisualStyleBackColor = true;
            // 
            // ButtonColar
            // 
            this.ButtonColar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonColar.Image")));
            this.ButtonColar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonColar.Location = new System.Drawing.Point(0, 256);
            this.ButtonColar.Name = "ButtonColar";
            this.ButtonColar.Size = new System.Drawing.Size(144, 63);
            this.ButtonColar.TabIndex = 4;
            this.ButtonColar.Text = "Colar [Ctrl+V]";
            this.ButtonColar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonColar.UseVisualStyleBackColor = true;
            // 
            // ButtonCopiar
            // 
            this.ButtonCopiar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCopiar.Image")));
            this.ButtonCopiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCopiar.Location = new System.Drawing.Point(0, 192);
            this.ButtonCopiar.Name = "ButtonCopiar";
            this.ButtonCopiar.Size = new System.Drawing.Size(144, 63);
            this.ButtonCopiar.TabIndex = 4;
            this.ButtonCopiar.Text = "Copiar [Ctrl+C]";
            this.ButtonCopiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonCopiar.UseVisualStyleBackColor = true;
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSalvar.Image")));
            this.ButtonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSalvar.Location = new System.Drawing.Point(0, 128);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(144, 63);
            this.ButtonSalvar.TabIndex = 4;
            this.ButtonSalvar.Text = "Salvar [Ctrl+S]";
            this.ButtonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            // 
            // ButtonAbrir
            // 
            this.ButtonAbrir.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAbrir.Image")));
            this.ButtonAbrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonAbrir.Location = new System.Drawing.Point(0, 64);
            this.ButtonAbrir.Name = "ButtonAbrir";
            this.ButtonAbrir.Size = new System.Drawing.Size(144, 63);
            this.ButtonAbrir.TabIndex = 4;
            this.ButtonAbrir.Text = "Abrir [Ctrl+O]";
            this.ButtonAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonAbrir.UseVisualStyleBackColor = true;
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNovo.Image")));
            this.ButtonNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonNovo.Location = new System.Drawing.Point(0, 0);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(144, 63);
            this.ButtonNovo.TabIndex = 2;
            this.ButtonNovo.Text = "Novo [Ctrl+N]";
            this.ButtonNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonNovo.UseVisualStyleBackColor = true;
            // 
            // TextEditor
            // 
            this.TextEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextEditor.Location = new System.Drawing.Point(153, 2);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.TextEditor.Size = new System.Drawing.Size(820, 480);
            this.TextEditor.TabIndex = 1;
            this.TextEditor.Text = "";
            this.TextEditor.WordWrap = false;
            // 
            // MessageDisplay
            // 
            this.MessageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageDisplay.Location = new System.Drawing.Point(153, 488);
            this.MessageDisplay.Name = "MessageDisplay";
            this.MessageDisplay.ReadOnly = true;
            this.MessageDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.MessageDisplay.Size = new System.Drawing.Size(820, 90);
            this.MessageDisplay.TabIndex = 2;
            this.MessageDisplay.Text = "";
            this.MessageDisplay.WordWrap = false;
            // 
            // StatusBar
            // 
            this.StatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBar.Controls.Add(this.LabelPath);
            this.StatusBar.Controls.Add(this.LabelStatus);
            this.StatusBar.Location = new System.Drawing.Point(3, 584);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(970, 42);
            this.StatusBar.TabIndex = 3;
            // 
            // LabelPath
            // 
            this.LabelPath.AutoSize = true;
            this.LabelPath.Location = new System.Drawing.Point(3, 23);
            this.LabelPath.Name = "LabelPath";
            this.LabelPath.Size = new System.Drawing.Size(0, 13);
            this.LabelPath.TabIndex = 1;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(3, 6);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(81, 13);
            this.LabelStatus.TabIndex = 0;
            this.LabelStatus.Text = "Não modificado";
            // 
            // FormCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 629);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MessageDisplay);
            this.Controls.Add(this.TextEditor);
            this.Controls.Add(this.ToolBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(992, 668);
            this.Name = "FormCompiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MM Compiler";
            this.ToolBox.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel ToolBox;
        private System.Windows.Forms.RichTextBox MessageDisplay;
        private System.Windows.Forms.Panel StatusBar;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelPath;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.Button ButtonAbrir;
        private System.Windows.Forms.Button ButtonCopiar;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonEquipe;
        private System.Windows.Forms.Button ButtonGerarCodigo;
        private System.Windows.Forms.Button ButtonCompilar;
        private System.Windows.Forms.Button ButtonRecortar;
        private System.Windows.Forms.Button ButtonColar;
        private System.Windows.Forms.RichTextBox TextEditor;
    }
}

