using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void EsqueceuSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "Arthur";

            if (boxUsuario.Text == usuario)
            {
                MessageBox.Show("Senha alterada");
                frmInicio paginaInicial = new frmInicio();
                paginaInicial.ShowDialog();
            }

            else
            {
                MessageBox.Show("Senha inválida");
            }
        }

        private void txtEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void txtCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void EsqueceuSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
