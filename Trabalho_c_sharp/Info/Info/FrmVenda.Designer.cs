namespace Info
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label dataVencimentoLabel;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboPessoa = new System.Windows.Forms.ComboBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.contaAReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusDePagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.TxtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnFV = new System.Windows.Forms.Button();
            this.BtnFDP = new System.Windows.Forms.Button();
            this.TxtValorPago = new System.Windows.Forms.TextBox();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.TxtValorItens = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnNovoItem = new System.Windows.Forms.Button();
            this.DtvItens = new System.Windows.Forms.DataGridView();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.CboProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCodigoVenda = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            dataVencimentoLabel = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaAReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDePagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(23, 24);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(42, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente:";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(61, 29);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(91, 55);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 2;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(113, 124);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(82, 86);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 9;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(211, 268);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 10;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(189, 294);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 12;
            descontoLabel.Text = "Desconto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(183, 328);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(62, 13);
            valorPagoLabel.TabIndex = 14;
            valorPagoLabel.Text = "Valor Pago:";
            // 
            // dataVencimentoLabel
            // 
            dataVencimentoLabel.AutoSize = true;
            dataVencimentoLabel.Location = new System.Drawing.Point(364, 301);
            dataVencimentoLabel.Name = "dataVencimentoLabel";
            dataVencimentoLabel.Size = new System.Drawing.Size(107, 13);
            dataVencimentoLabel.TabIndex = 21;
            dataVencimentoLabel.Text = "Data de Vencimento:";
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(357, 268);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(111, 13);
            codigoStatusLabel.TabIndex = 23;
            codigoStatusLabel.Text = "Forma de Pagamento:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Info.DAL.Venda);
            // 
            // CboPessoa
            // 
            this.CboPessoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CboPessoa.DataSource = this.pessoaBindingSource;
            this.CboPessoa.DisplayMember = "Nome";
            this.CboPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPessoa.FormattingEnabled = true;
            this.CboPessoa.Location = new System.Drawing.Point(71, 16);
            this.CboPessoa.Name = "CboPessoa";
            this.CboPessoa.Size = new System.Drawing.Size(233, 21);
            this.CboPessoa.TabIndex = 2;
            this.CboPessoa.ValueMember = "Codigo";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Info.DAL.Pessoa);
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(326, 14);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(75, 23);
            this.BtnNovaVenda.TabIndex = 3;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            this.BtnNovaVenda.Click += new System.EventHandler(this.BtnNovaVenda_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(codigoStatusLabel);
            this.GroupBox.Controls.Add(this.CboStatus);
            this.GroupBox.Controls.Add(this.BtnFinalizar);
            this.GroupBox.Controls.Add(dataVencimentoLabel);
            this.GroupBox.Controls.Add(this.TxtDataVencimento);
            this.GroupBox.Controls.Add(this.BtnImprimir);
            this.GroupBox.Controls.Add(this.BtnFV);
            this.GroupBox.Controls.Add(this.BtnFDP);
            this.GroupBox.Controls.Add(valorPagoLabel);
            this.GroupBox.Controls.Add(this.TxtValorPago);
            this.GroupBox.Controls.Add(descontoLabel);
            this.GroupBox.Controls.Add(this.TxtDesconto);
            this.GroupBox.Controls.Add(valorLabel1);
            this.GroupBox.Controls.Add(this.TxtValorItens);
            this.GroupBox.Controls.Add(quantidadeLabel);
            this.GroupBox.Controls.Add(this.TxtQuantidade);
            this.GroupBox.Controls.Add(this.BtnNovoItem);
            this.GroupBox.Controls.Add(this.DtvItens);
            this.GroupBox.Controls.Add(valorLabel);
            this.GroupBox.Controls.Add(this.TxtValor);
            this.GroupBox.Controls.Add(codigoProdutoLabel);
            this.GroupBox.Controls.Add(this.CboProduto);
            this.GroupBox.Controls.Add(codigoVendaLabel);
            this.GroupBox.Controls.Add(this.TxtCodigoVenda);
            this.GroupBox.Location = new System.Drawing.Point(12, 55);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(682, 371);
            this.GroupBox.TabIndex = 4;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Nova Venda";
            this.GroupBox.Visible = false;
            // 
            // CboStatus
            // 
            this.CboStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contaAReceberBindingSource, "CodigoStatus", true));
            this.CboStatus.DataSource = this.statusDePagamentoBindingSource;
            this.CboStatus.DisplayMember = "Status";
            this.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStatus.Enabled = false;
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Location = new System.Drawing.Point(468, 263);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(121, 21);
            this.CboStatus.TabIndex = 24;
            this.CboStatus.ValueMember = "CodigoStatus";
            this.CboStatus.SelectedIndexChanged += new System.EventHandler(this.CboStatus_SelectedIndexChanged);
            // 
            // contaAReceberBindingSource
            // 
            this.contaAReceberBindingSource.DataSource = typeof(Info.DAL.ContaAReceber);
            // 
            // statusDePagamentoBindingSource
            // 
            this.statusDePagamentoBindingSource.DataSource = typeof(Info.DAL.StatusDePagamento);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Enabled = false;
            this.BtnFinalizar.Location = new System.Drawing.Point(476, 328);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.BtnFinalizar.TabIndex = 23;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // TxtDataVencimento
            // 
            this.TxtDataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contaAReceberBindingSource, "DataVencimento", true));
            this.TxtDataVencimento.Enabled = false;
            this.TxtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDataVencimento.Location = new System.Drawing.Point(477, 295);
            this.TxtDataVencimento.Name = "TxtDataVencimento";
            this.TxtDataVencimento.Size = new System.Drawing.Size(120, 20);
            this.TxtDataVencimento.TabIndex = 22;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Enabled = false;
            this.BtnImprimir.Location = new System.Drawing.Point(23, 325);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(115, 23);
            this.BtnImprimir.TabIndex = 16;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnFV
            // 
            this.BtnFV.Enabled = false;
            this.BtnFV.Location = new System.Drawing.Point(23, 289);
            this.BtnFV.Name = "BtnFV";
            this.BtnFV.Size = new System.Drawing.Size(115, 23);
            this.BtnFV.TabIndex = 16;
            this.BtnFV.Text = "Finalizar Venda";
            this.BtnFV.UseVisualStyleBackColor = true;
            this.BtnFV.Click += new System.EventHandler(this.BtnFV_Click);
            // 
            // BtnFDP
            // 
            this.BtnFDP.Location = new System.Drawing.Point(23, 256);
            this.BtnFDP.Name = "BtnFDP";
            this.BtnFDP.Size = new System.Drawing.Size(115, 23);
            this.BtnFDP.TabIndex = 16;
            this.BtnFDP.Text = "Finalizar Pedido";
            this.BtnFDP.UseVisualStyleBackColor = true;
            this.BtnFDP.Click += new System.EventHandler(this.BtnFDP_Click);
            // 
            // TxtValorPago
            // 
            this.TxtValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.TxtValorPago.Location = new System.Drawing.Point(251, 325);
            this.TxtValorPago.Name = "TxtValorPago";
            this.TxtValorPago.ReadOnly = true;
            this.TxtValorPago.Size = new System.Drawing.Size(100, 20);
            this.TxtValorPago.TabIndex = 15;
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.TxtDesconto.Location = new System.Drawing.Point(251, 291);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.ReadOnly = true;
            this.TxtDesconto.Size = new System.Drawing.Size(100, 20);
            this.TxtDesconto.TabIndex = 13;
            // 
            // TxtValorItens
            // 
            this.TxtValorItens.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.TxtValorItens.Location = new System.Drawing.Point(251, 265);
            this.TxtValorItens.Name = "TxtValorItens";
            this.TxtValorItens.ReadOnly = true;
            this.TxtValorItens.Size = new System.Drawing.Size(100, 20);
            this.TxtValorItens.TabIndex = 11;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Quantidade", true));
            this.TxtQuantidade.Location = new System.Drawing.Point(153, 83);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantidade.TabIndex = 10;
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataSource = typeof(Info.DAL.ItemVenda);
            // 
            // BtnNovoItem
            // 
            this.BtnNovoItem.Location = new System.Drawing.Point(351, 124);
            this.BtnNovoItem.Name = "BtnNovoItem";
            this.BtnNovoItem.Size = new System.Drawing.Size(75, 23);
            this.BtnNovoItem.TabIndex = 9;
            this.BtnNovoItem.Text = "Novo Item";
            this.BtnNovoItem.UseVisualStyleBackColor = true;
            this.BtnNovoItem.Click += new System.EventHandler(this.BtnNovoItem_Click);
            // 
            // DtvItens
            // 
            this.DtvItens.AllowUserToAddRows = false;
            this.DtvItens.AllowUserToDeleteRows = false;
            this.DtvItens.AutoGenerateColumns = false;
            this.DtvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.DtvItens.DataSource = this.itemVendaBindingSource;
            this.DtvItens.Location = new System.Drawing.Point(14, 153);
            this.DtvItens.Name = "DtvItens";
            this.DtvItens.ReadOnly = true;
            this.DtvItens.Size = new System.Drawing.Size(587, 100);
            this.DtvItens.TabIndex = 8;
            this.DtvItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtvItens_CellContentClick);
            this.DtvItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtvItens_CellFormatting);
            // 
            // TxtValor
            // 
            this.TxtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Valor", true));
            this.TxtValor.Location = new System.Drawing.Point(153, 121);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 7;
            // 
            // CboProduto
            // 
            this.CboProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemVendaBindingSource, "CodigoProduto", true));
            this.CboProduto.DataSource = this.produtoBindingSource;
            this.CboProduto.DisplayMember = "Descricao";
            this.CboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProduto.FormattingEnabled = true;
            this.CboProduto.Location = new System.Drawing.Point(144, 52);
            this.CboProduto.Name = "CboProduto";
            this.CboProduto.Size = new System.Drawing.Size(282, 21);
            this.CboProduto.TabIndex = 3;
            this.CboProduto.ValueMember = "Codigo";
            this.CboProduto.SelectedIndexChanged += new System.EventHandler(this.codigoProdutoComboBox_SelectedIndexChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Info.DAL.Produto);
            // 
            // TxtCodigoVenda
            // 
            this.TxtCodigoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.TxtCodigoVenda.Location = new System.Drawing.Point(144, 26);
            this.TxtCodigoVenda.Name = "TxtCodigoVenda";
            this.TxtCodigoVenda.ReadOnly = true;
            this.TxtCodigoVenda.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoVenda.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 426);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.BtnNovaVenda);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.CboPessoa);
            this.Name = "FrmVenda";
            this.Text = ".: Vendas :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVenda_FormClosed);
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaAReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDePagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CboPessoa;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.DataGridView DtvItens;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.ComboBox CboProduto;
        private System.Windows.Forms.TextBox TxtCodigoVenda;
        private System.Windows.Forms.Button BtnNovoItem;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnFV;
        private System.Windows.Forms.Button BtnFDP;
        private System.Windows.Forms.TextBox TxtValorPago;
        private System.Windows.Forms.TextBox TxtDesconto;
        private System.Windows.Forms.TextBox TxtValorItens;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.BindingSource contaAReceberBindingSource;
        private System.Windows.Forms.BindingSource statusDePagamentoBindingSource;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.DateTimePicker TxtDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}