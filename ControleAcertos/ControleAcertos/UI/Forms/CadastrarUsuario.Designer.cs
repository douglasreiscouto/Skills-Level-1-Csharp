namespace ControleAcertos.UI.Forms
{
    partial class CadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarUsuario));
            labelCadastroNome = new Label();
            labelCadatroUsuario = new Label();
            labelCadastroSenha = new Label();
            textBoxCadastroNome = new TextBox();
            textBoxCadastroLogin = new TextBox();
            textBoxCadastroSenha = new TextBox();
            labelTituloCadastroUsuario = new Label();
            buttonCadastrarUsuario = new Button();
            buttonCadastroRetornar = new Button();
            SuspendLayout();
            // 
            // labelCadastroNome
            // 
            labelCadastroNome.AutoSize = true;
            labelCadastroNome.Location = new Point(34, 67);
            labelCadastroNome.Name = "labelCadastroNome";
            labelCadastroNome.Size = new Size(164, 24);
            labelCadastroNome.TabIndex = 0;
            labelCadastroNome.Text = "Nome Completo:";
            // 
            // labelCadatroUsuario
            // 
            labelCadatroUsuario.AutoSize = true;
            labelCadatroUsuario.Location = new Point(34, 110);
            labelCadatroUsuario.Name = "labelCadatroUsuario";
            labelCadatroUsuario.Size = new Size(88, 24);
            labelCadatroUsuario.TabIndex = 1;
            labelCadatroUsuario.Text = "Usuário:";
            // 
            // labelCadastroSenha
            // 
            labelCadastroSenha.AutoSize = true;
            labelCadastroSenha.Location = new Point(34, 155);
            labelCadastroSenha.Name = "labelCadastroSenha";
            labelCadastroSenha.Size = new Size(74, 29);
            labelCadastroSenha.TabIndex = 2;
            labelCadastroSenha.Text = "Senha:";
            labelCadastroSenha.UseCompatibleTextRendering = true;
            // 
            // textBoxCadastroNome
            // 
            textBoxCadastroNome.Location = new Point(204, 64);
            textBoxCadastroNome.Name = "textBoxCadastroNome";
            textBoxCadastroNome.Size = new Size(284, 31);
            textBoxCadastroNome.TabIndex = 3;
            // 
            // textBoxCadastroLogin
            // 
            textBoxCadastroLogin.Location = new Point(117, 110);
            textBoxCadastroLogin.Name = "textBoxCadastroLogin";
            textBoxCadastroLogin.Size = new Size(371, 31);
            textBoxCadastroLogin.TabIndex = 4;
            textBoxCadastroLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCadastroSenha
            // 
            textBoxCadastroSenha.Location = new Point(117, 153);
            textBoxCadastroSenha.Name = "textBoxCadastroSenha";
            textBoxCadastroSenha.Size = new Size(371, 31);
            textBoxCadastroSenha.TabIndex = 5;
            textBoxCadastroSenha.TextAlign = HorizontalAlignment.Center;
            textBoxCadastroSenha.UseSystemPasswordChar = true;
            // 
            // labelTituloCadastroUsuario
            // 
            labelTituloCadastroUsuario.AutoSize = true;
            labelTituloCadastroUsuario.Location = new Point(173, 9);
            labelTituloCadastroUsuario.Name = "labelTituloCadastroUsuario";
            labelTituloCadastroUsuario.Size = new Size(178, 24);
            labelTituloCadastroUsuario.TabIndex = 6;
            labelTituloCadastroUsuario.Text = "Cadastrar usuário";
            // 
            // buttonCadastrarUsuario
            // 
            buttonCadastrarUsuario.Location = new Point(340, 211);
            buttonCadastrarUsuario.Name = "buttonCadastrarUsuario";
            buttonCadastrarUsuario.Size = new Size(148, 38);
            buttonCadastrarUsuario.TabIndex = 7;
            buttonCadastrarUsuario.Text = "Cadastrar";
            buttonCadastrarUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonCadastroRetornar
            // 
            buttonCadastroRetornar.Location = new Point(44, 211);
            buttonCadastroRetornar.Name = "buttonCadastroRetornar";
            buttonCadastroRetornar.Size = new Size(148, 38);
            buttonCadastroRetornar.TabIndex = 9;
            buttonCadastroRetornar.Text = "Retornar";
            buttonCadastroRetornar.UseVisualStyleBackColor = true;
            buttonCadastroRetornar.Click += buttonCadastroRetornar_Click;
            // 
            // CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 261);
            Controls.Add(buttonCadastroRetornar);
            Controls.Add(buttonCadastrarUsuario);
            Controls.Add(labelTituloCadastroUsuario);
            Controls.Add(textBoxCadastroSenha);
            Controls.Add(textBoxCadastroLogin);
            Controls.Add(textBoxCadastroNome);
            Controls.Add(labelCadastroSenha);
            Controls.Add(labelCadatroUsuario);
            Controls.Add(labelCadastroNome);
            Font = new Font("Arial", 12.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastrarUsuario";
            Text = "Acerto - Cadastro";
            Load += CadastrarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCadastroNome;
        private Label labelCadatroUsuario;
        private Label labelCadastroSenha;
        private TextBox textBoxCadastroNome;
        private TextBox textBoxCadastroLogin;
        private TextBox textBoxCadastroSenha;
        private Label labelTituloCadastroUsuario;
        private Button buttonCadastrarUsuario;
        private Button buttonCadastroRetornar;
    }
}