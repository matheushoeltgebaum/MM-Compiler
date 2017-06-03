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
            this.MessageDisplay = new System.Windows.Forms.RichTextBox();
            this.StatusBar = new System.Windows.Forms.Panel();
            this.LabelPath = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.TextEditor = new System.Windows.Forms.RichTextBox();
            this.RichLineNumbers = new LineNumbers.LineNumbers_For_RichTextBox();
            this.ToolBox.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.PanelCenter.SuspendLayout();
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
            this.ButtonEquipe.Click += ButtonEquipe_Click;
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
            this.ButtonGerarCodigo.Click += ButtonGerarCodigo_Click;
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
            this.ButtonCompilar.Click += ButtonCompilar_Click;
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
            this.ButtonRecortar.Click += ButtonRecortar_Click;
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
            this.ButtonColar.Click += ButtonColar_Click;
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
            this.ButtonCopiar.Click += ButtonCopiar_Click;
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
            this.ButtonSalvar.Click += ButtonSalvar_Click;
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
            this.ButtonAbrir.Click += ButtonAbrir_Click;
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
            this.ButtonNovo.Click += ButtonNovo_Click;
            // 
            // MessageDisplay
            // 
            this.MessageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // PanelCenter
            // 
            this.PanelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCenter.BackColor = System.Drawing.Color.White;
            this.PanelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCenter.Controls.Add(this.TextEditor);
            this.PanelCenter.Controls.Add(this.RichLineNumbers);
            this.PanelCenter.Location = new System.Drawing.Point(153, 2);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(820, 480);
            this.PanelCenter.TabIndex = 1;
            // 
            // TextEditor
            // 
            this.TextEditor.AcceptsTab = true;
            this.TextEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditor.Location = new System.Drawing.Point(28, 0);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.TextEditor.Size = new System.Drawing.Size(790, 478);
            this.TextEditor.TabIndex = 5;
            this.TextEditor.Text = "";
            this.TextEditor.WordWrap = false;
            this.TextEditor.TextChanged += TextEditor_TextChanged;
            // 
            // RichLineNumbers
            // 
            this.RichLineNumbers._SeeThroughMode_ = false;
            this.RichLineNumbers.AutoSizing = true;
            this.RichLineNumbers.BackgroundGradient_AlphaColor = System.Drawing.Color.Gainsboro;
            this.RichLineNumbers.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.RichLineNumbers.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.RichLineNumbers.BorderLines_Color = System.Drawing.Color.LightGray;
            this.RichLineNumbers.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.RichLineNumbers.BorderLines_Thickness = 1F;
            this.RichLineNumbers.Dock = System.Windows.Forms.DockStyle.Left;
            this.RichLineNumbers.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.RichLineNumbers.GridLines_Color = System.Drawing.Color.Transparent;
            this.RichLineNumbers.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.RichLineNumbers.GridLines_Thickness = 1F;
            this.RichLineNumbers.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.RichLineNumbers.LineNrs_AntiAlias = true;
            this.RichLineNumbers.LineNrs_AsHexadecimal = false;
            this.RichLineNumbers.LineNrs_ClippedByItemRectangle = true;
            this.RichLineNumbers.LineNrs_LeadingZeroes = true;
            this.RichLineNumbers.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.RichLineNumbers.Location = new System.Drawing.Point(0, 0);
            this.RichLineNumbers.Margin = new System.Windows.Forms.Padding(0);
            this.RichLineNumbers.MarginLines_Color = System.Drawing.Color.Transparent;
            this.RichLineNumbers.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.RichLineNumbers.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.RichLineNumbers.MarginLines_Thickness = 1F;
            this.RichLineNumbers.Name = "RichLineNumbers";
            this.RichLineNumbers.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.RichLineNumbers.ParentRichTextBox = this.TextEditor;
            this.RichLineNumbers.Show_BackgroundGradient = false;
            this.RichLineNumbers.Show_BorderLines = true;
            this.RichLineNumbers.Show_GridLines = true;
            this.RichLineNumbers.Show_LineNrs = true;
            this.RichLineNumbers.Show_MarginLines = true;
            this.RichLineNumbers.Size = new System.Drawing.Size(28, 478);
            this.RichLineNumbers.TabIndex = 7;
            // 
            // FormCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 629);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MessageDisplay);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.ToolBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(992, 668);
            this.Name = "FormCompiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MM Compiler";
            this.ToolBox.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.PanelCenter.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PanelCenter;
        private LineNumbers.LineNumbers_For_RichTextBox RichLineNumbers;
        private System.Windows.Forms.RichTextBox TextEditor;
    }
}
