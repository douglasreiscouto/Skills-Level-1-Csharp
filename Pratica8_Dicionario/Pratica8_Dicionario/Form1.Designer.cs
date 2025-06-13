namespace Pratica8_Dicionario
{
    partial class FormDicionario
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
            groupBoxCadastro = new GroupBox();
            textBoxCadastroNick = new TextBox();
            labelCadastroNick = new Label();
            textBoxCadastroDescricao = new TextBox();
            labelCadastroDescricao = new Label();
            buttonCadastrar = new Button();
            buttonExcluir = new Button();
            groupBoxPesquisar = new GroupBox();
            textBoxPesquisaNick = new TextBox();
            label1 = new Label();
            labelPesquisaDescrica = new Label();
            buttonPesquisar = new Button();
            labelStatus = new Label();
            labelDescricaoStatus = new Label();
            groupBoxCadastro.SuspendLayout();
            groupBoxPesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCadastro
            // 
            groupBoxCadastro.Controls.Add(buttonExcluir);
            groupBoxCadastro.Controls.Add(buttonCadastrar);
            groupBoxCadastro.Controls.Add(labelCadastroDescricao);
            groupBoxCadastro.Controls.Add(textBoxCadastroDescricao);
            groupBoxCadastro.Controls.Add(textBoxCadastroNick);
            groupBoxCadastro.Controls.Add(labelCadastroNick);
            groupBoxCadastro.Location = new Point(12, 21);
            groupBoxCadastro.Name = "groupBoxCadastro";
            groupBoxCadastro.Size = new Size(401, 160);
            groupBoxCadastro.TabIndex = 0;
            groupBoxCadastro.TabStop = false;
            groupBoxCadastro.Text = "Cadastro";
            // 
            // textBoxCadastroNick
            // 
            textBoxCadastroNick.Location = new Point(53, 40);
            textBoxCadastroNick.Name = "textBoxCadastroNick";
            textBoxCadastroNick.Size = new Size(342, 27);
            textBoxCadastroNick.TabIndex = 1;
            textBoxCadastroNick.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCadastroNick
            // 
            labelCadastroNick.AutoSize = true;
            labelCadastroNick.Location = new Point(6, 43);
            labelCadastroNick.Name = "labelCadastroNick";
            labelCadastroNick.Size = new Size(41, 20);
            labelCadastroNick.TabIndex = 1;
            labelCadastroNick.Text = "Nick:";
            // 
            // textBoxCadastroDescricao
            // 
            textBoxCadastroDescricao.Location = new Point(87, 73);
            textBoxCadastroDescricao.Name = "textBoxCadastroDescricao";
            textBoxCadastroDescricao.Size = new Size(308, 27);
            textBoxCadastroDescricao.TabIndex = 2;
            // 
            // labelCadastroDescricao
            // 
            labelCadastroDescricao.AutoSize = true;
            labelCadastroDescricao.Location = new Point(6, 76);
            labelCadastroDescricao.Name = "labelCadastroDescricao";
            labelCadastroDescricao.Size = new Size(77, 20);
            labelCadastroDescricao.TabIndex = 4;
            labelCadastroDescricao.Text = "Descrição:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(301, 121);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(94, 29);
            buttonCadastrar.TabIndex = 3;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(6, 121);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 29);
            buttonExcluir.TabIndex = 4;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBoxPesquisar
            // 
            groupBoxPesquisar.Controls.Add(buttonPesquisar);
            groupBoxPesquisar.Controls.Add(labelPesquisaDescrica);
            groupBoxPesquisar.Controls.Add(label1);
            groupBoxPesquisar.Controls.Add(textBoxPesquisaNick);
            groupBoxPesquisar.Location = new Point(429, 21);
            groupBoxPesquisar.Name = "groupBoxPesquisar";
            groupBoxPesquisar.Size = new Size(401, 160);
            groupBoxPesquisar.TabIndex = 1;
            groupBoxPesquisar.TabStop = false;
            groupBoxPesquisar.Text = "Pesquisar";
            // 
            // textBoxPesquisaNick
            // 
            textBoxPesquisaNick.Location = new Point(54, 26);
            textBoxPesquisaNick.Name = "textBoxPesquisaNick";
            textBoxPesquisaNick.Size = new Size(342, 27);
            textBoxPesquisaNick.TabIndex = 5;
            textBoxPesquisaNick.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 7;
            label1.Text = "Nick:";
            // 
            // labelPesquisaDescrica
            // 
            labelPesquisaDescrica.AutoSize = true;
            labelPesquisaDescrica.Location = new Point(54, 80);
            labelPesquisaDescrica.Name = "labelPesquisaDescrica";
            labelPesquisaDescrica.Size = new Size(107, 20);
            labelPesquisaDescrica.TabIndex = 8;
            labelPesquisaDescrica.Text = "labelDescricao";
            labelPesquisaDescrica.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(301, 121);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(94, 29);
            buttonPesquisar.TabIndex = 6;
            buttonPesquisar.Text = "Pesquisa";
            buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 201);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Status:";
            // 
            // labelDescricaoStatus
            // 
            labelDescricaoStatus.AutoSize = true;
            labelDescricaoStatus.Location = new Point(70, 201);
            labelDescricaoStatus.Name = "labelDescricaoStatus";
            labelDescricaoStatus.Size = new Size(147, 20);
            labelDescricaoStatus.TabIndex = 3;
            labelDescricaoStatus.Text = "labelDescricaoStatus";
            // 
            // FormDicionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 230);
            Controls.Add(labelDescricaoStatus);
            Controls.Add(labelStatus);
            Controls.Add(groupBoxPesquisar);
            Controls.Add(groupBoxCadastro);
            Name = "FormDicionario";
            Text = "Cadastro de Personagem";
            groupBoxCadastro.ResumeLayout(false);
            groupBoxCadastro.PerformLayout();
            groupBoxPesquisar.ResumeLayout(false);
            groupBoxPesquisar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCadastro;
        private TextBox textBoxCadastroNick;
        private Label labelCadastroNick;
        private Button buttonExcluir;
        private Button buttonCadastrar;
        private Label labelCadastroDescricao;
        private TextBox textBoxCadastroDescricao;
        private GroupBox groupBoxPesquisar;
        private Label label1;
        private TextBox textBoxPesquisaNick;
        private Label labelPesquisaDescrica;
        private Button buttonPesquisar;
        private Label labelStatus;
        private Label labelDescricaoStatus;
    }
}
