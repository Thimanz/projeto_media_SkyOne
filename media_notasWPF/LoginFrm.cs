namespace media_notasWPF
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            loginError.Visible = false;
            senhaError.Visible = false;

            if (string.IsNullOrEmpty(login.Text))
            {
                loginError.Visible = true;
            }
            if (string.IsNullOrEmpty(senha.Text))
            {
                senhaError.Visible = true;
            }
            if (senhaError.Visible || loginError.Visible) { return; }
            var n = new NotasFrm();
            n.Show();
        }
    }
}