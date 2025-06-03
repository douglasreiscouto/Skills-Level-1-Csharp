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
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevel).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F);
            labelTitulo.Location = new Point(12, 47);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.RightToLeft = RightToLeft.No;
            labelTitulo.Size = new Size(70, 28);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(88, 51);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(450, 27);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(102, 136);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(94, 29);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Location = new Point(244, 136);
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
            labelRetorno.Location = new Point(88, 81);
            labelRetorno.Name = "labelRetorno";
            labelRetorno.Size = new Size(0, 23);
            labelRetorno.TabIndex = 4;
            // 
            // buttonLimpa
            // 
            buttonLimpa.Location = new Point(389, 136);
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
            labelContador.Location = new Point(515, 81);
            labelContador.Name = "labelContador";
            labelContador.Size = new Size(23, 28);
            labelContador.TabIndex = 6;
            labelContador.Text = "0";
            // 
            // numericUpDownLevel
            // 
            numericUpDownLevel.Location = new Point(88, 19);
            numericUpDownLevel.Name = "numericUpDownLevel";
            numericUpDownLevel.Size = new Size(150, 27);
            numericUpDownLevel.TabIndex = 2;
            numericUpDownLevel.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Font = new Font("Segoe UI", 12F);
            labelLevel.Location = new Point(12, 19);
            labelLevel.Name = "labelLevel";
            labelLevel.RightToLeft = RightToLeft.No;
            labelLevel.Size = new Size(60, 28);
            labelLevel.TabIndex = 8;
            labelLevel.Text = "Level:";
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 174);
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
    }
}
