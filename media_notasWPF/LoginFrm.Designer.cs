namespace media_notasWPF
{
    partial class LoginFrm
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
            entrarBtn = new Button();
            senha = new TextBox();
            login = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginError = new Label();
            senhaError = new Label();
            SuspendLayout();
            // 
            // entrarBtn
            // 
            entrarBtn.Location = new Point(396, 86);
            entrarBtn.Name = "entrarBtn";
            entrarBtn.Size = new Size(137, 23);
            entrarBtn.TabIndex = 0;
            entrarBtn.Text = "Entrar";
            entrarBtn.UseVisualStyleBackColor = true;
            entrarBtn.Click += entrarBtn_Click;
            // 
            // senha
            // 
            senha.Location = new Point(212, 86);
            senha.Name = "senha";
            senha.Size = new Size(155, 23);
            senha.TabIndex = 1;
            // 
            // login
            // 
            login.Location = new Point(51, 86);
            login.Name = "login";
            login.Size = new Size(155, 23);
            login.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 68);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Login: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 68);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // loginError
            // 
            loginError.AutoSize = true;
            loginError.ForeColor = Color.FromArgb(192, 0, 0);
            loginError.Location = new Point(51, 112);
            loginError.Name = "loginError";
            loginError.Size = new Size(120, 15);
            loginError.TabIndex = 5;
            loginError.Text = "O login é obrigatório.";
            loginError.Visible = false;
            // 
            // senhaError
            // 
            senhaError.AutoSize = true;
            senhaError.ForeColor = Color.FromArgb(192, 0, 0);
            senhaError.Location = new Point(212, 112);
            senhaError.Name = "senhaError";
            senhaError.Size = new Size(122, 15);
            senhaError.TabIndex = 6;
            senhaError.Text = "A senha é obrigatória.";
            senhaError.Visible = false;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 206);
            Controls.Add(senhaError);
            Controls.Add(loginError);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(login);
            Controls.Add(senha);
            Controls.Add(entrarBtn);
            Name = "LoginFrm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button entrarBtn;
        private TextBox senha;
        private TextBox login;
        private Label label1;
        private Label label2;
        private Label loginError;
        private Label senhaError;
    }
}