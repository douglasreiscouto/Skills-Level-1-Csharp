namespace Pratica7_Lista2
{
    partial class FormList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            textBoxNome = new TextBox();
            buttonAdicionar = new Button();
            buttonImprimir = new Button();
            labelRetorno = new Label();
            buttonLimpa = new Button();
            labelContador = new Label();
            numericUpDownLevel = new NumericUpDown();
            labelLevel = new Label();
            labelQtdPersonagem = new Label();
            groupBoxPesquisa = new GroupBox();
            buttonApagar = new Button();
            numericUpDownLevelResultado = new NumericUpDown();
            buttonPesquisar = new Button();
            labelLevelResultado = new Label();
            labelNomeResultado = new Label();
            textBoxNomeResultado = new TextBox();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevel).BeginInit();
            groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevelResultado).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F);
            labelTitulo.Location = new Point(40, 59);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.RightToLeft = RightToLeft.No;
            labelTitulo.Size = new Size(70, 28);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(116, 60);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(181, 27);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(12, 154);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(94, 29);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Location = new Point(116, 154);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(94, 29);
            buttonImprimir.TabIndex = 4;
            buttonImprimir.Text = "Imprimir";
            buttonImprimir.UseVisualStyleBackColor = true;
            buttonImprimir.Click += buttonImprimir_Click;
            // 
            // labelRetorno
            // 
            labelRetorno.AutoSize = true;
            labelRetorno.Font = new Font("Segoe UI", 10F);
            labelRetorno.Location = new Point(87, 204);
            labelRetorno.Name = "labelRetorno";
            labelRetorno.Size = new Size(0, 23);
            labelRetorno.TabIndex = 4;
            // 
            // buttonLimpa
            // 
            buttonLimpa.Location = new Point(216, 154);
            buttonLimpa.Name = "buttonLimpa";
            buttonLimpa.Size = new Size(94, 29);
            buttonLimpa.TabIndex = 5;
            buttonLimpa.Text = "Limpar";
            buttonLimpa.UseVisualStyleBackColor = true;
            buttonLimpa.Click += buttonLimpa_Click;
            // 
            // labelContador
            // 
            labelContador.AutoSize = true;
            labelContador.Font = new Font("Segoe UI", 12F);
            labelContador.Location = new Point(566, 199);
            labelContador.Name = "labelContador";
            labelContador.Size = new Size(23, 28);
            labelContador.TabIndex = 6;
            labelContador.Text = "0";
            // 
            // numericUpDownLevel
            // 
            numericUpDownLevel.Location = new Point(116, 93);
            numericUpDownLevel.Name = "numericUpDownLevel";
            numericUpDownLevel.Size = new Size(181, 27);
            numericUpDownLevel.TabIndex = 2;
            numericUpDownLevel.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Font = new Font("Segoe UI", 12F);
            labelLevel.Location = new Point(50, 92);
            labelLevel.Name = "labelLevel";
            labelLevel.RightToLeft = RightToLeft.No;
            labelLevel.Size = new Size(60, 28);
            labelLevel.TabIndex = 8;
            labelLevel.Text = "Level:";
            // 
            // labelQtdPersonagem
            // 
            labelQtdPersonagem.AutoSize = true;
            labelQtdPersonagem.Font = new Font("Segoe UI", 12F);
            labelQtdPersonagem.Location = new Point(399, 199);
            labelQtdPersonagem.Name = "labelQtdPersonagem";
            labelQtdPersonagem.RightToLeft = RightToLeft.No;
            labelQtdPersonagem.Size = new Size(161, 28);
            labelQtdPersonagem.TabIndex = 9;
            labelQtdPersonagem.Text = "Qtd.Personagem:";
            // 
            // groupBoxPesquisa
            // 
            groupBoxPesquisa.Controls.Add(buttonApagar);
            groupBoxPesquisa.Controls.Add(numericUpDownLevelResultado);
            groupBoxPesquisa.Controls.Add(buttonPesquisar);
            groupBoxPesquisa.Controls.Add(labelLevelResultado);
            groupBoxPesquisa.Controls.Add(labelNomeResultado);
            groupBoxPesquisa.Controls.Add(textBoxNomeResultado);
            groupBoxPesquisa.Location = new Point(316, 14);
            groupBoxPesquisa.Name = "groupBoxPesquisa";
            groupBoxPesquisa.Size = new Size(294, 175);
            groupBoxPesquisa.TabIndex = 10;
            groupBoxPesquisa.TabStop = false;
            groupBoxPesquisa.Text = "Pesquisar/Apagar";
            // 
            // buttonApagar
            // 
            buttonApagar.ImeMode = ImeMode.NoControl;
            buttonApagar.Location = new Point(194, 140);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(94, 29);
            buttonApagar.TabIndex = 13;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // numericUpDownLevelResultado
            // 
            numericUpDownLevelResultado.Location = new Point(92, 80);
            numericUpDownLevelResultado.Name = "numericUpDownLevelResultado";
            numericUpDownLevelResultado.Size = new Size(181, 27);
            numericUpDownLevelResultado.TabIndex = 12;
            numericUpDownLevelResultado.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(16, 140);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(94, 29);
            buttonPesquisar.TabIndex = 11;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // labelLevelResultado
            // 
            labelLevelResultado.AutoSize = true;
            labelLevelResultado.Font = new Font("Segoe UI", 12F);
            labelLevelResultado.Location = new Point(26, 75);
            labelLevelResultado.Name = "labelLevelResultado";
            labelLevelResultado.RightToLeft = RightToLeft.No;
            labelLevelResultado.Size = new Size(60, 28);
            labelLevelResultado.TabIndex = 11;
            labelLevelResultado.Text = "Level:";
            // 
            // labelNomeResultado
            // 
            labelNomeResultado.AutoSize = true;
            labelNomeResultado.Font = new Font("Segoe UI", 12F);
            labelNomeResultado.Location = new Point(16, 46);
            labelNomeResultado.Name = "labelNomeResultado";
            labelNomeResultado.RightToLeft = RightToLeft.No;
            labelNomeResultado.Size = new Size(70, 28);
            labelNomeResultado.TabIndex = 11;
            labelNomeResultado.Text = "Nome:";
            // 
            // textBoxNomeResultado
            // 
            textBoxNomeResultado.Location = new Point(92, 46);
            textBoxNomeResultado.Name = "textBoxNomeResultado";
            textBoxNomeResultado.Size = new Size(181, 27);
            textBoxNomeResultado.TabIndex = 11;
            textBoxNomeResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F);
            labelStatus.ImeMode = ImeMode.NoControl;
            labelStatus.Location = new Point(12, 199);
            labelStatus.Name = "labelStatus";
            labelStatus.RightToLeft = RightToLeft.No;
            labelStatus.Size = new Size(69, 28);
            labelStatus.TabIndex = 11;
            labelStatus.Text = "Status:";
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 236);
            Controls.Add(labelStatus);
            Controls.Add(groupBoxPesquisa);
            Controls.Add(labelQtdPersonagem);
            Controls.Add(labelLevel);
            Controls.Add(numericUpDownLevel);
            Controls.Add(labelContador);
            Controls.Add(buttonLimpa);
            Controls.Add(labelRetorno);
            Controls.Add(buttonImprimir);
            Controls.Add(buttonAdicionar);
            Controls.Add(textBoxNome);
            Controls.Add(labelTitulo);
            Name = "FormList";
            Text = "Adicionar Personagens";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevel).EndInit();
            groupBoxPesquisa.ResumeLayout(false);
            groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevelResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textBoxNome;
        private Button buttonAdicionar;
        private Button buttonImprimir;
        private Label labelRetorno;
        private Button buttonLimpa;
        private Label labelContador;
        private NumericUpDown numericUpDownLevel;
        private Label labelLevel;
        private Label labelQtdPersonagem;
        private GroupBox groupBoxPesquisa;
        private Button buttonPesquisar;
        private Label labelLevelResultado;
        private Label labelNomeResultado;
        private TextBox textBoxNomeResultado;
        private NumericUpDown numericUpDownLevelResultado;
        private Button buttonApagar;
        private Label labelStatus;
    }
}
