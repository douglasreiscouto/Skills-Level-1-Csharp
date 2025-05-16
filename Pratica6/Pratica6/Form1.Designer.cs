namespace Pratica6
{
    partial class Form1
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
            button1 = new Button();
            labelNota1 = new Label();
            textBoxNota1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(482, 347);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Location = new Point(40, 45);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(54, 20);
            labelNota1.TabIndex = 1;
            labelNota1.Text = "Nota 1";
            labelNota1.Click += label1_Click;
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new Point(284, 12);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new Size(125, 27);
            textBoxNota1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 85);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Nota 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 125);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Nota 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 165);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Nota 4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 205);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Nota 5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 245);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 7;
            label5.Text = "Nota 6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 285);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 8;
            label6.Text = "Nota 7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 325);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 9;
            label7.Text = "Nota 8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNota1);
            Controls.Add(labelNota1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelNota1;
        private TextBox textBoxNota1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
