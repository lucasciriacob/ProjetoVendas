namespace ProjetoVendas
{
    partial class FormSenha
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEmail = new Button();
            btnSenha = new Button();
            txtUser = new TextBox();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email...";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(41, 120);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Nova senha...";
            txtSenha.Size = new Size(233, 23);
            txtSenha.TabIndex = 1;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(41, 218);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(233, 30);
            btnEmail.TabIndex = 2;
            btnEmail.Text = "Verificar";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // btnSenha
            // 
            btnSenha.Location = new Point(41, 219);
            btnSenha.Name = "btnSenha";
            btnSenha.Size = new Size(233, 29);
            btnSenha.TabIndex = 3;
            btnSenha.Text = "Salvar Senha";
            btnSenha.UseVisualStyleBackColor = true;
            btnSenha.Click += btnSenha_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(41, 91);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario...";
            txtUser.Size = new Size(233, 23);
            txtUser.TabIndex = 4;
            // 
            // FormSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 318);
            Controls.Add(txtUser);
            Controls.Add(btnSenha);
            Controls.Add(btnEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Senha...";
            Load += FormSenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnEmail;
        private Button btnSenha;
        private TextBox txtUser;
    }
}