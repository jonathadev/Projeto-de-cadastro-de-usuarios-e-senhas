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
    public partial class FrmRelatorioProdutos : Form
    {
        public FrmRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void FrmRelatorioProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatorioProdutos = null;
        }

        private void FrmRelatorioProdutos_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\ADM\Desktop\TRABALHO_C_SHARP\Trabalho_c_sharp\Info\Info\RPT\Produtos.rpt");
            CrvProdutos.ReportSource = rd;
        }

        private void CrvProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
