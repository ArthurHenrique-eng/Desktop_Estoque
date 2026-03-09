namespace Estoque
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "Arthur";
            string senha = "123";

            if (boxUsuario.Text == usuario && boxSenha.Text == senha)
            {
                this.Visible = false;
                MessageBox.Show("Logado com sucesso");
                frmInicio paginaInicial = new frmInicio();
                paginaInicial.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente");
            }
        }

        private void txtEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenha esqueceuSenha = new EsqueceuSenha();
            esqueceuSenha.ShowDialog();
        }

        private void txtCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void sairLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
