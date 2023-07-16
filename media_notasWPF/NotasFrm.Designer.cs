namespace media_notasWPF
{
    partial class NotasFrm
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
            nome = new TextBox();
            p1 = new TextBox();
            p2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            enviar = new Button();
            limpar = new Button();
            label4 = new Label();
            status = new Label();
            p1Error = new Label();
            p2Error = new Label();
            nomeError = new Label();
            SuspendLayout();
            // 
            // nome
            // 
            nome.Location = new Point(65, 70);
            nome.Name = "nome";
            nome.Size = new Size(301, 23);
            nome.TabIndex = 0;
            // 
            // p1
            // 
            p1.Location = new Point(65, 160);
            p1.Name = "p1";
            p1.Size = new Size(137, 23);
            p1.TabIndex = 1;
            // 
            // p2
            // 
            p2.Location = new Point(229, 160);
            p2.Name = "p2";
            p2.Size = new Size(137, 23);
            p2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 142);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "Nota do 2º Semestre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 142);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 4;
            label2.Text = "Nota do 1º Semestre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 52);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome do Aluno:";
            // 
            // enviar
            // 
            enviar.Location = new Point(65, 235);
            enviar.Name = "enviar";
            enviar.Size = new Size(165, 26);
            enviar.TabIndex = 6;
            enviar.Text = "Enviar";
            enviar.UseVisualStyleBackColor = true;
            enviar.Click += enviar_Click;
            // 
            // limpar
            // 
            limpar.Location = new Point(236, 235);
            limpar.Name = "limpar";
            limpar.Size = new Size(130, 26);
            limpar.TabIndex = 7;
            limpar.Text = "Limpar Campos";
            limpar.UseVisualStyleBackColor = true;
            limpar.Click += limpar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 320);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 8;
            label4.Text = "Status do Aluno:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.ForeColor = SystemColors.ControlDark;
            status.Location = new Point(165, 320);
            status.Name = "status";
            status.Size = new Size(103, 15);
            status.TabIndex = 9;
            status.Text = "Nota não enviada.";
            // 
            // p1Error
            // 
            p1Error.AutoSize = true;
            p1Error.BackColor = SystemColors.Control;
            p1Error.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            p1Error.ForeColor = Color.FromArgb(192, 0, 0);
            p1Error.Location = new Point(65, 186);
            p1Error.Name = "p1Error";
            p1Error.Size = new Size(137, 13);
            p1Error.TabIndex = 10;
            p1Error.Text = "Esse campo é obrigatório";
            p1Error.Visible = false;
            // 
            // p2Error
            // 
            p2Error.AutoSize = true;
            p2Error.BackColor = SystemColors.Control;
            p2Error.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            p2Error.ForeColor = Color.FromArgb(192, 0, 0);
            p2Error.Location = new Point(229, 186);
            p2Error.Name = "p2Error";
            p2Error.Size = new Size(137, 13);
            p2Error.TabIndex = 11;
            p2Error.Text = "Esse campo é obrigatório";
            p2Error.Visible = false;
            // 
            // nomeError
            // 
            nomeError.AutoSize = true;
            nomeError.BackColor = SystemColors.Control;
            nomeError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            nomeError.ForeColor = Color.FromArgb(192, 0, 0);
            nomeError.Location = new Point(65, 96);
            nomeError.Name = "nomeError";
            nomeError.Size = new Size(137, 13);
            nomeError.TabIndex = 12;
            nomeError.Text = "Esse campo é obrigatório";
            nomeError.Visible = false;
            // 
            // NotasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 410);
            Controls.Add(nomeError);
            Controls.Add(p2Error);
            Controls.Add(p1Error);
            Controls.Add(status);
            Controls.Add(label4);
            Controls.Add(limpar);
            Controls.Add(enviar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(p2);
            Controls.Add(p1);
            Controls.Add(nome);
            Name = "NotasFrm";
            Text = "Lançamento de Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nome;
        private TextBox p1;
        private TextBox p2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button enviar;
        private Button limpar;
        private Label label4;
        private Label status;
        private Label p1Error;
        private Label p2Error;
        private Label nomeError;
    }
}