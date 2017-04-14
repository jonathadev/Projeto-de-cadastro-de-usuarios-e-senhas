using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null) // se o formulario for nulo 
                MeusFormularios.FormCategoria = new FrmCategoria();// cria categoria

            MeusFormularios.FormCategoria.Show(); // mostra a janela
            MeusFormularios.FormCategoria.Focus();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null) // se o produto for nulo 
                MeusFormularios.FormProduto = new FrmProduto();// cria Produto

            MeusFormularios.FormProduto.Show(); // mostra a janela
            MeusFormularios.FormProduto.Focus();

        }

        private void produtoPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProdutosPorCategoria == null)
                MeusFormularios.FormProdutosPorCategoria = new FrmProdutosPorCategoria();

            MeusFormularios.FormProdutosPorCategoria.Show();
            MeusFormularios.FormProdutosPorCategoria.Focus();
        }

        private void cadastroDePessoasFisicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormPessoaFisica == null)
                MeusFormularios.FormPessoaFisica = new FrmPessoaFisica();

            MeusFormularios.FormPessoaFisica.Show();
            MeusFormularios.FormPessoaFisica.Focus();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormVenda == null)
                MeusFormularios.FormVenda = new FrmVenda();

            MeusFormularios.FormVenda.Show();
            MeusFormularios.FormVenda.Focus();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatorioProdutos == null)
            {
                MeusFormularios.FormRelatorioProdutos = new FrmRelatorioProdutos();

                MeusFormularios.FormRelatorioProdutos.Show();
                MeusFormularios.FormRelatorioProdutos.Focus();
            }

        }

        private void produtosPorCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormListaCategorias == null)
            {
                MeusFormularios.FormListaCategorias = new FrmListaCategorias();

                MeusFormularios.FormListaCategorias.Show();
                MeusFormularios.FormListaCategorias.Focus();
            }
        }
    }
}
