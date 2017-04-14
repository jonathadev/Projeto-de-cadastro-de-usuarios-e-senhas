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
    public partial class FrmCadastros : Form
    {
        public FrmCadastros()
        {
            InitializeComponent();
        }

        private void FrmCadastros_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCadastros = null;
        }

        private void FrmCadastros_Load(object sender, EventArgs e)
        {
            this.cadastroBindingSource.DataSource = DataContextFactory.DataContext.Cadastros;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void cadastroDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descricaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastroDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.cadastroBindingSource.AddNew();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            this.cadastroBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            DtvCadastros.Refresh();
            MessageBox.Show("Cadastro armazenado com sucesso!");
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.cadastroBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.cadastroBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Cadastro excluído com sucesso!");
        }

        private void cadastroDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 5)
                e.Value = ((Categoria)e.Value).Descricao;
        }
    }
}
