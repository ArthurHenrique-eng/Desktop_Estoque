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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            frmControleInventario controleInventario = new frmControleInventario();
            controleInventario.ShowDialog();
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReabastecimento_Click(object sender, EventArgs e)
        {
            frmReabastecimento reabastecimento = new frmReabastecimento();
            reabastecimento.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmCdastrarProdutos cadastrarProdutos = new frmCdastrarProdutos();
            cadastrarProdutos.ShowDialog();
        }
    }
}
