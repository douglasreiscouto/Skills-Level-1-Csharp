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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
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
            groupBoxResultado = new GroupBox();
            numericUpDownLevelResultado = new NumericUpDown();
            buttonPesquisar = new Button();
            labelLevelResultado = new Label();
            labelNomeResultado = new Label();
            textBoxNomeResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevel).BeginInit();
            groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevelResultado).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            resources.ApplyResources(labelTitulo, "labelTitulo");
            labelTitulo.Name = "labelTitulo";
            // 
            // textBoxNome
            // 
            resources.ApplyResources(textBoxNome, "textBoxNome");
            textBoxNome.Name = "textBoxNome";
            // 
            // buttonAdicionar
            // 
            resources.ApplyResources(buttonAdicionar, "buttonAdicionar");
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonImprimir
            // 
            resources.ApplyResources(buttonImprimir, "buttonImprimir");
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.UseVisualStyleBackColor = true;
            buttonImprimir.Click += buttonImprimir_Click;
            // 
            // labelRetorno
            // 
            resources.ApplyResources(labelRetorno, "labelRetorno");
            labelRetorno.Name = "labelRetorno";
            // 
            // buttonLimpa
            // 
            resources.ApplyResources(buttonLimpa, "buttonLimpa");
            buttonLimpa.Name = "buttonLimpa";
            buttonLimpa.UseVisualStyleBackColor = true;
            buttonLimpa.Click += buttonLimpa_Click;
            // 
            // labelContador
            // 
            resources.ApplyResources(labelContador, "labelContador");
            labelContador.Name = "labelContador";
            // 
            // numericUpDownLevel
            // 
            resources.ApplyResources(numericUpDownLevel, "numericUpDownLevel");
            numericUpDownLevel.Name = "numericUpDownLevel";
            numericUpDownLevel.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelLevel
            // 
            resources.ApplyResources(labelLevel, "labelLevel");
            labelLevel.Name = "labelLevel";
            // 
            // labelQtdPersonagem
            // 
            resources.ApplyResources(labelQtdPersonagem, "labelQtdPersonagem");
            labelQtdPersonagem.Name = "labelQtdPersonagem";
            // 
            // groupBoxResultado
            // 
            groupBoxResultado.Controls.Add(numericUpDownLevelResultado);
            groupBoxResultado.Controls.Add(buttonPesquisar);
            groupBoxResultado.Controls.Add(labelLevelResultado);
            groupBoxResultado.Controls.Add(labelNomeResultado);
            groupBoxResultado.Controls.Add(textBoxNomeResultado);
            resources.ApplyResources(groupBoxResultado, "groupBoxResultado");
            groupBoxResultado.Name = "groupBoxResultado";
            groupBoxResultado.TabStop = false;
            // 
            // numericUpDownLevelResultado
            // 
            resources.ApplyResources(numericUpDownLevelResultado, "numericUpDownLevelResultado");
            numericUpDownLevelResultado.Name = "numericUpDownLevelResultado";
            numericUpDownLevelResultado.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // buttonPesquisar
            // 
            resources.ApplyResources(buttonPesquisar, "buttonPesquisar");
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // labelLevelResultado
            // 
            resources.ApplyResources(labelLevelResultado, "labelLevelResultado");
            labelLevelResultado.Name = "labelLevelResultado";
            // 
            // labelNomeResultado
            // 
            resources.ApplyResources(labelNomeResultado, "labelNomeResultado");
            labelNomeResultado.Name = "labelNomeResultado";
            // 
            // textBoxNomeResultado
            // 
            resources.ApplyResources(textBoxNomeResultado, "textBoxNomeResultado");
            textBoxNomeResultado.Name = "textBoxNomeResultado";
            // 
            // FormList
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxResultado);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownLevel).EndInit();
            groupBoxResultado.ResumeLayout(false);
            groupBoxResultado.PerformLayout();
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
        private GroupBox groupBoxResultado;
        private Button buttonPesquisar;
        private Label labelLevelResultado;
        private Label labelNomeResultado;
        private TextBox textBoxNomeResultado;
        private NumericUpDown numericUpDownLevelResultado;
    }
}
