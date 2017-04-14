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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProduto = null;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Produto armazenado com sucesso!");
            DtvProdutos.Refresh();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Produto excluido com sucesso!");
        }

        private void produtoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;
        }
    }
}
