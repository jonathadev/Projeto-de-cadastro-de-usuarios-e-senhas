using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null)
                MeusFormularios.FormCategoria = new FrmCategorias();
            MeusFormularios.FormCategoria.Show();
            MeusFormularios.FormCategoria.Focus();
        }

        private void cadastrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCadastros == null)
                MeusFormularios.FormCadastros = new FrmCadastros();
            MeusFormularios.FormCadastros.Show();
            MeusFormularios.FormCadastros.Focus();
        }

        private void cadastroDePessoasFisicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormPessoaFisica == null)
                MeusFormularios.FormPessoaFisica = new FrmPessoaFisica();

            MeusFormularios.FormPessoaFisica.Show();
            MeusFormularios.FormPessoaFisica.Focus();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
