using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastros.DAL;

namespace Cadastros
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCategoria = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Categoria armazenada com sucesso!");
        }

        private bool Valida()
        {

            if (TxtCategoria.Text.Trim() == String.Empty)
            { 
            MessageBox.Show("O campo categoria é obrigatório");
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
                 if (this.CategoriaPossuiCadastros(this.CategoriaCorrente))
                {
                    MessageBox.Show("Voce nao pode excluir uma categoria que possui cadastros!");

                }
                 else
                 {

            this.categoriaBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Categoria excluída com sucesso!");
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

        private bool CategoriaPossuiCadastros(Categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.Cadastros.Where(x => x.CodigoCategoria == categoria.Codigo); // faz listagem de todos produtos que o cogigo da consulta for igual que foi a busca
            if(produtos.Count() > 0)
                return true;
            else 
                return  false;
        }

        private void categoriaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
