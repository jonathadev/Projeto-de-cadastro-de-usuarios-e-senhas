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
    public partial class FrmListaCategorias : Form
    {
      

        public FrmListaCategorias()
        {
            InitializeComponent();
        }

        private void FrmListaCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormListaCategorias = null;
        }

        private void FrmListaCategorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatorioProdutosCategoria == null)
            {
                MeusFormularios.FormRelatorioProdutosCategoria = new FrmRelatorioProdutosCategoria();

                MeusFormularios.FormRelatorioProdutosCategoria.CodigoCategoria = (int)CboCategoria.SelectedValue;
                MeusFormularios.FormRelatorioProdutosCategoria.Show();
                MeusFormularios.FormRelatorioProdutosCategoria.Focus();
            }
        }
    }
}
