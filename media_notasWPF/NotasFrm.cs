using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using media_notas;

namespace media_notasWPF
{
    public partial class NotasFrm : Form
    {
        public NotasFrm()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            //validacao de campos
            nomeError.Visible = false;
            p1Error.Visible = false;
            p2Error.Visible = false;
            if (string.IsNullOrEmpty(nome.Text))
            {
                nomeError.Visible = true;
            }
            if (string.IsNullOrEmpty(p1.Text))
            {
                p1Error.Visible = true;
            }
            if (string.IsNullOrEmpty(p2.Text))
            {
                p2Error.Visible = true;
            }
            if (nomeError.Visible || p1Error.Visible || p2Error.Visible) { return; }

            //instanciar aluno com os dados preenchidos
            Aluno aluno = new Aluno(nome.Text);
            double nota1;
            double.TryParse(p1.Text, out nota1);
            aluno.AddNota(nota1);
            double nota2;
            double.TryParse(p2.Text, out nota2);
            aluno.AddNota(nota2);

            //mostrar status
            if (aluno.Status == "Aprovado")
            {
                status.ForeColor = Color.Green;
            }
            else
            {
                status.ForeColor = Color.Red;
            }
            status.Text = aluno.Status;
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            nomeError.Visible = false;
            p1Error.Visible = false;
            p2Error.Visible = false;
            nome.Text = string.Empty;
            p1.Text = string.Empty;
            p2.Text = string.Empty;
            status.ForeColor = SystemColors.ControlDark;
            status.Text = "Nota não enviada.";
        }
    }
}
