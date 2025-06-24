namespace ControleAcertos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labeLogin = new Label();
            labelSenha = new Label();
            labelTitulo = new Label();
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            buttonEntrar = new Button();
            linkLabelCadastro = new LinkLabel();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // labeLogin
            // 
            labeLogin.AutoSize = true;
            labeLogin.Font = new Font("Arial", 12.2F);
            labeLogin.Location = new Point(58, 63);
            labeLogin.Margin = new Padding(4, 0, 4, 0);
            labeLogin.Name = "labeLogin";
            labeLogin.Size = new Size(88, 24);
            labeLogin.TabIndex = 0;
            labeLogin.Text = "Usuário:";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Arial", 12.2F);
            labelSenha.Location = new Point(58, 117);
            labelSenha.Margin = new Padding(4, 0, 4, 0);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(76, 24);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Senha:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial", 15.2F);
            labelTitulo.Location = new Point(166, 10);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(204, 31);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Controle Acertos";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(142, 59);
            textBoxLogin.Margin = new Padding(2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(316, 29);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(142, 110);
            textBoxSenha.Margin = new Padding(2);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(317, 29);
            textBoxSenha.TabIndex = 2;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(58, 203);
            buttonEntrar.Margin = new Padding(2);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(148, 36);
            buttonEntrar.TabIndex = 3;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            // 
            // linkLabelCadastro
            // 
            linkLabelCadastro.AutoSize = true;
            linkLabelCadastro.Location = new Point(335, 142);
            linkLabelCadastro.Margin = new Padding(2, 0, 2, 0);
            linkLabelCadastro.Name = "linkLabelCadastro";
            linkLabelCadastro.Size = new Size(119, 22);
            linkLabelCadastro.TabIndex = 5;
            linkLabelCadastro.TabStop = true;
            linkLabelCadastro.Text = "Cadastrar-se";
            linkLabelCadastro.LinkClicked += linkLabelCadastro_LinkClicked;
            // 
            // buttonSair
            // 
            buttonSair.Location = new Point(311, 203);
            buttonSair.Margin = new Padding(2);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(148, 36);
            buttonSair.TabIndex = 6;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 250);
            Controls.Add(buttonSair);
            Controls.Add(linkLabelCadastro);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxLogin);
            Controls.Add(labelTitulo);
            Controls.Add(labelSenha);
            Controls.Add(labeLogin);
            Font = new Font("Arial", 11.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Acertos - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeLogin;
        private Label labelSenha;
        private Label labelTitulo;
        private TextBox textBoxLogin;
        private TextBox textBoxSenha;
        private Button buttonEntrar;
        private LinkLabel linkLabelCadastro;
        private Button buttonSair;
    }
}
