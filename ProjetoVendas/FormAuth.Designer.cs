namespace ProjetoVendas
{
    partial class FormAuth
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            lblSenha = new Label();
            chkSenha = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email...";
            txtEmail.Size = new Size(299, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(40, 155);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha...";
            txtSenha.Size = new Size(299, 23);
            txtSenha.TabIndex = 1;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(105, 211);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(134, 248);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(117, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Esqueceu sua senha?";
            lblSenha.Click += lblSenha_Click;
            // 
            // chkSenha
            // 
            chkSenha.AutoSize = true;
            chkSenha.Location = new Point(321, 160);
            chkSenha.Name = "chkSenha";
            chkSenha.Size = new Size(15, 14);
            chkSenha.TabIndex = 4;
            chkSenha.UseVisualStyleBackColor = true;
            chkSenha.CheckedChanged += chkSenha_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 250);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 5;
            label1.Text = "_______________________";
            // 
            // FormAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 307);
            Controls.Add(lblSenha);
            Controls.Add(label1);
            Controls.Add(chkSenha);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAuth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnLogin;
        private Label lblSenha;
        private CheckBox chkSenha;
        private Label label1;
    }
}
