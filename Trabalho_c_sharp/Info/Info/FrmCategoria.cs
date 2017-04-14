using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Info.DAL;
 
namespace Info
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCategoria = null;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria armazenada com sucesso!");
            }
                
            }

        private bool Valida()
        {
            if(TxtCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria é obrigatorio!");
                TxtCategoria.Focus();
                return false;
            }
            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.CategoriaPossuiProduto(this.CategoriaCorrente))
                {
                    MessageBox.Show("Voce nao pode excluir uma categoria que possui produtos!");

                }
                else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com sucesso!");
                }
            }

        }

        public Categoria CategoriaCorrente
        { 
        get
            {

                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProduto(Categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == categoria.Codigo); // faz listagem de todos produtos que o cogigo da consulta for igual que foi a busca
            if(produtos.Count() > 0)
                return true;
            else 
                return  false;
        }
    }
}
