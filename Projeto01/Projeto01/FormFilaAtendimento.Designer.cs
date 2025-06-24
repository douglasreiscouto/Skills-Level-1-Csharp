namespace Projeto01
{
    partial class FormFilaAtendimento
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
            textBoxNome = new TextBox();
            buttonCadastrar = new Button();
            groupBoxCadastrar = new GroupBox();
            buttonVerProximo = new Button();
            buttonChamarProximo = new Button();
            labelNome = new Label();
            groupBoxExibeFila = new GroupBox();
            labelProximoFilaNome = new Label();
            labelProximoFilaTitulo = new Label();
            labelEmAtendimentoTitulo = new Label();
            labelEmAtendimentoNome = new Label();
            labelContadorFilaTitulo = new Label();
            labelContadorFila = new Label();
            labelStatus = new Label();
            labelStatusDescricao = new Label();
            groupBoxCadastrar.SuspendLayout();
            groupBoxExibeFila.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(73, 40);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(274, 27);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(14, 94);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(94, 29);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // groupBoxCadastrar
            // 
            groupBoxCadastrar.Controls.Add(buttonVerProximo);
            groupBoxCadastrar.Controls.Add(buttonChamarProximo);
            groupBoxCadastrar.Controls.Add(labelNome);
            groupBoxCadastrar.Controls.Add(buttonCadastrar);
            groupBoxCadastrar.Controls.Add(textBoxNome);
            groupBoxCadastrar.Location = new Point(12, 12);
            groupBoxCadastrar.Name = "groupBoxCadastrar";
            groupBoxCadastrar.Size = new Size(366, 129);
            groupBoxCadastrar.TabIndex = 2;
            groupBoxCadastrar.TabStop = false;
            groupBoxCadastrar.Text = "Cadastrar";
            // 
            // buttonVerProximo
            // 
            buttonVerProximo.Location = new Point(253, 94);
            buttonVerProximo.Name = "buttonVerProximo";
            buttonVerProximo.Size = new Size(94, 29);
            buttonVerProximo.TabIndex = 4;
            buttonVerProximo.Text = "Próximo";
            buttonVerProximo.UseVisualStyleBackColor = true;
            buttonVerProximo.Click += buttonVerProximo_Click;
            // 
            // buttonChamarProximo
            // 
            buttonChamarProximo.Location = new Point(135, 94);
            buttonChamarProximo.Name = "buttonChamarProximo";
            buttonChamarProximo.Size = new Size(94, 29);
            buttonChamarProximo.TabIndex = 3;
            buttonChamarProximo.Text = "Chamar";
            buttonChamarProximo.UseVisualStyleBackColor = true;
            buttonChamarProximo.Click += buttonChamarProximo_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(14, 43);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 20);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome:";
            // 
            // groupBoxExibeFila
            // 
            groupBoxExibeFila.Controls.Add(labelProximoFilaNome);
            groupBoxExibeFila.Controls.Add(labelProximoFilaTitulo);
            groupBoxExibeFila.Controls.Add(labelEmAtendimentoTitulo);
            groupBoxExibeFila.Controls.Add(labelEmAtendimentoNome);
            groupBoxExibeFila.Location = new Point(398, 12);
            groupBoxExibeFila.Name = "groupBoxExibeFila";
            groupBoxExibeFila.Size = new Size(241, 193);
            groupBoxExibeFila.TabIndex = 3;
            groupBoxExibeFila.TabStop = false;
            groupBoxExibeFila.Text = "Gerência";
            // 
            // labelProximoFilaNome
            // 
            labelProximoFilaNome.AutoSize = true;
            labelProximoFilaNome.Location = new Point(32, 155);
            labelProximoFilaNome.Name = "labelProximoFilaNome";
            labelProximoFilaNome.Size = new Size(180, 20);
            labelProximoFilaNome.TabIndex = 3;
            labelProximoFilaNome.Text = "labelProximoDaFilaNome";
            labelProximoFilaNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProximoFilaTitulo
            // 
            labelProximoFilaTitulo.AutoSize = true;
            labelProximoFilaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelProximoFilaTitulo.Location = new Point(74, 120);
            labelProximoFilaTitulo.Name = "labelProximoFilaTitulo";
            labelProximoFilaTitulo.Size = new Size(96, 28);
            labelProximoFilaTitulo.TabIndex = 2;
            labelProximoFilaTitulo.Text = "Proximo:";
            // 
            // labelEmAtendimentoTitulo
            // 
            labelEmAtendimentoTitulo.AutoSize = true;
            labelEmAtendimentoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelEmAtendimentoTitulo.Location = new Point(34, 39);
            labelEmAtendimentoTitulo.Name = "labelEmAtendimentoTitulo";
            labelEmAtendimentoTitulo.Size = new Size(176, 28);
            labelEmAtendimentoTitulo.TabIndex = 1;
            labelEmAtendimentoTitulo.Text = "Em Atendimento:";
            // 
            // labelEmAtendimentoNome
            // 
            labelEmAtendimentoNome.AutoSize = true;
            labelEmAtendimentoNome.Location = new Point(47, 75);
            labelEmAtendimentoNome.Name = "labelEmAtendimentoNome";
            labelEmAtendimentoNome.Size = new Size(150, 20);
            labelEmAtendimentoNome.TabIndex = 0;
            labelEmAtendimentoNome.Text = "labelEmAtendimento";
            labelEmAtendimentoNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelContadorFilaTitulo
            // 
            labelContadorFilaTitulo.AutoSize = true;
            labelContadorFilaTitulo.Font = new Font("Segoe UI", 10F);
            labelContadorFilaTitulo.Location = new Point(100, 157);
            labelContadorFilaTitulo.Name = "labelContadorFilaTitulo";
            labelContadorFilaTitulo.Size = new Size(156, 23);
            labelContadorFilaTitulo.TabIndex = 4;
            labelContadorFilaTitulo.Text = "Qtd.Pessoas na fila:";
            // 
            // labelContadorFila
            // 
            labelContadorFila.AutoSize = true;
            labelContadorFila.Font = new Font("Segoe UI", 10F);
            labelContadorFila.Location = new Point(262, 157);
            labelContadorFila.Name = "labelContadorFila";
            labelContadorFila.Size = new Size(19, 23);
            labelContadorFila.TabIndex = 5;
            labelContadorFila.Text = "0";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelStatus.Location = new Point(12, 193);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(57, 20);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status:";
            // 
            // labelStatusDescricao
            // 
            labelStatusDescricao.AutoSize = true;
            labelStatusDescricao.ForeColor = Color.Red;
            labelStatusDescricao.Location = new Point(70, 191);
            labelStatusDescricao.Name = "labelStatusDescricao";
            labelStatusDescricao.Size = new Size(163, 25);
            labelStatusDescricao.TabIndex = 9;
            labelStatusDescricao.Text = "Aguardando cadastro...";
            labelStatusDescricao.UseCompatibleTextRendering = true;
            // 
            // FormFilaAtendimento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 222);
            Controls.Add(labelStatusDescricao);
            Controls.Add(labelStatus);
            Controls.Add(labelContadorFila);
            Controls.Add(labelContadorFilaTitulo);
            Controls.Add(groupBoxExibeFila);
            Controls.Add(groupBoxCadastrar);
            Name = "FormFilaAtendimento";
            Text = "Fila de Atendimento";
            groupBoxCadastrar.ResumeLayout(false);
            groupBoxCadastrar.PerformLayout();
            groupBoxExibeFila.ResumeLayout(false);
            groupBoxExibeFila.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Button buttonCadastrar;
        private GroupBox groupBoxCadastrar;
        private Label labelNome;
        private GroupBox groupBoxExibeFila;
        private Label labelEmAtendimentoNome;
        private Label labelProximoFilaNome;
        private Label labelProximoFilaTitulo;
        private Label labelEmAtendimentoTitulo;
        private Label labelContadorFilaTitulo;
        private Label labelContadorFila;
        private Label labelStatus;
        private Label labelStatusDescricao;
        private Button buttonChamarProximo;
        private Button buttonVerProximo;
    }
}
