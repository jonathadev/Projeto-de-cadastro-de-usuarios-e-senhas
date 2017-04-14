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
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource =
                DataContextFactory.DataContext.Pessoas;

            this.vendaBindingSource.DataSource =
                DataContextFactory.DataContext.Vendas;

            this.produtoBindingSource.DataSource =
                DataContextFactory.DataContext.Produtos;

            this.vendaBindingSource.AddNew();

          this.contaAReceberBindingSource.DataSource =    
            DataContextFactory.DataContext.ContaARecebers;

            this.statusDePagamentoBindingSource.DataSource = 
                DataContextFactory.DataContext.StatusDePagamentos;

        }

        private void FrmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormVenda = null;
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;

            }
        }


        public ItemVenda ItemCorrente
        {
            get
            {
                return (ItemVenda)this.itemVendaBindingSource.Current;

            }
        }

        public ContaAReceber ContaCorrente
        {
            get
            {
                return (ContaAReceber)this.contaAReceberBindingSource.Current;
            }
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            CboPessoa.Enabled = false;
            GroupBox.Visible = true;

            BtnNovaVenda.Enabled = false;

            this.itemVendaBindingSource.DataSource =
                DataContextFactory.DataContext.ItemVendas.Where(x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);
            NovoItem();

        }

        private void NovoItem()
        {
            this.itemVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;

        }

        //private void itemVendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
       // {

       // }

        private void BtnNovoItem_Click(object sender, EventArgs e)
        {
            this.itemVendaBindingSource.EndEdit();
            DtvItens.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostrarSomaValores();
            NovoItem();
        }

        private void DtvItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Descricao;
        }

        private void codigoProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CboProduto.SelectedItem != null)
            {
                var pro = (Produto)CboProduto.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int)pro.Codigo;
                this.ItemCorrente.Valor = (decimal)pro.Valor;

            }
        }

        private void MostrarSomaValores()
        {
            decimal total = 0;
            foreach(DataGridViewRow dg in DtvItens.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value=subtotal;
                total = total + subtotal;
            }
            this.VendaCorrente.Valor = total;
        }

        private void BtnFDP_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja finalizar está venda? \n Não será possivel adicionar um novo item!", "Comfirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.itemVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();

                this.VendaCorrente.Desconto = 0;
                
                BtnNovoItem.Enabled = false;
                //CboProduto.Enabled = false;
                TxtValor.Enabled = false;
                TxtCodigoVenda.Enabled = false;
                TxtQuantidade.Enabled = false;
                TxtDesconto.ReadOnly = false;
                TxtDesconto.Focus();
                BtnFDP.Enabled = false;
                BtnFV.Enabled = true;

            }
            }

        private void BtnFV_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(TxtDesconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor) - (this.VendaCorrente.Desconto);
            DataContextFactory.DataContext.SubmitChanges();
            TxtDesconto.Enabled = false;
            BtnFV.Enabled = false;
          //  BtnImprimir.Enabled = true;

            // Contas a receber

            this.contaAReceberBindingSource.AddNew();
            CboStatus.Enabled = true;
            this.ContaCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;//se pagamento a vista

        }

        private void CboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CboStatus.SelectedItem != null)
            {
                var status = (StatusDePagamento)CboStatus.SelectedItem;
                if(status.CodigoStatus == 1)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    BtnFinalizar.Enabled = true;
                    TxtDataVencimento.Enabled = false;
                }
                else
                    if(status.CodigoStatus ==2)
                    {
                        this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                        this.ContaCorrente.DataVencimento = DateTime.Now;
                        this.ContaCorrente.DataPagamento = null;
                        TxtDataVencimento.Enabled = true;
                        BtnFinalizar.Enabled = true;

                    }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            this.contaAReceberBindingSource.EndEdit();
            TxtDataVencimento.Enabled = false;
            CboStatus.Enabled = false;
            DataContextFactory.DataContext.SubmitChanges();
            BtnImprimir.Enabled = true;
            BtnFinalizar.Enabled = false;
            MessageBox.Show("Venda finalizada com sucesso!\n Imprima o cupom da venda!", "Venda finalizada!");
        }

        private void DtvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
