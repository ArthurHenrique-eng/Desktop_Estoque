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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void txtEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenha esqueceuSenha = new EsqueceuSenha();
            esqueceuSenha.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "Arthur";
            string senha = "123";

            if (boxUsuario.Text == usuario && boxSenha.Text == senha)
            {
                MessageBox.Show("Logado com sucesso");
                frmInicio paginaInicial = new frmInicio();
                paginaInicial.ShowDialog();
            }

            else
            {
                MessageBox.Show("Tente novamente.");
            }
        }

        private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
