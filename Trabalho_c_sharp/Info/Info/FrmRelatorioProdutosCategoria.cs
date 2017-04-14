using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Info
{
    public partial class FrmRelatorioProdutosCategoria : Form
    {
        public int CodigoCategoria { get; set; }

        public FrmRelatorioProdutosCategoria()
        {
            InitializeComponent();
        }

        private void FrmRelatorioProdutosCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatorioProdutosCategoria = null;
        }

        private void FrmRelatorioProdutosCategoria_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\ADM\Desktop\TRABALHO_C_SHARP\Trabalho_c_sharp\Info\Info\RPT\ProdutosPorCategoria.rpt");
            ParameterField parametro = rd.ParameterFields["codigoCategoria"];
            parametro.CurrentValues.AddValue(this.CodigoCategoria);

            CrvProdutosCategoria.ReportSource = rd;

        }

        private void CrvProdutosCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
