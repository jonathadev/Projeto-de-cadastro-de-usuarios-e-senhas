namespace Info
{
    partial class FrmProduto
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoCategoriaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtvProdutos = new System.Windows.Forms.DataGridView();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.codigoCategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoCategoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(47, 19);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 6;
            descricaoLabel.Text = "Descricao:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(47, 53);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 7;
            valorLabel.Text = "Valor:";
            // 
            // codigoCategoriaLabel
            // 
            codigoCategoriaLabel.AutoSize = true;
            codigoCategoriaLabel.Location = new System.Drawing.Point(47, 86);
            codigoCategoriaLabel.Name = "codigoCategoriaLabel";
            codigoCategoriaLabel.Size = new System.Drawing.Size(91, 13);
            codigoCategoriaLabel.TabIndex = 9;
            codigoCategoriaLabel.Text = "Codigo Categoria:";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(391, 148);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(280, 148);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(156, 148);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 4;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(24, 148);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 5;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Info.DAL.Produto);
            // 
            // DtvProdutos
            // 
            this.DtvProdutos.AllowUserToAddRows = false;
            this.DtvProdutos.AllowUserToDeleteRows = false;
            this.DtvProdutos.AutoGenerateColumns = false;
            this.DtvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.DtvProdutos.DataSource = this.produtoBindingSource;
            this.DtvProdutos.Location = new System.Drawing.Point(24, 201);
            this.DtvProdutos.Name = "DtvProdutos";
            this.DtvProdutos.ReadOnly = true;
            this.DtvProdutos.Size = new System.Drawing.Size(442, 178);
            this.DtvProdutos.TabIndex = 6;
            this.DtvProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.produtoDataGridView_CellFormatting);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(144, 16);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(314, 20);
            this.descricaoTextBox.TabIndex = 7;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(144, 46);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 8;
            // 
            // codigoCategoriaComboBox
            // 
            this.codigoCategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "CodigoCategoria", true));
            this.codigoCategoriaComboBox.DataSource = this.categoriaBindingSource;
            this.codigoCategoriaComboBox.DisplayMember = "Descricao";
            this.codigoCategoriaComboBox.FormattingEnabled = true;
            this.codigoCategoriaComboBox.Location = new System.Drawing.Point(144, 83);
            this.codigoCategoriaComboBox.Name = "codigoCategoriaComboBox";
            this.codigoCategoriaComboBox.Size = new System.Drawing.Size(134, 21);
            this.codigoCategoriaComboBox.TabIndex = 10;
            this.codigoCategoriaComboBox.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Info.DAL.Categoria);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 391);
            this.Controls.Add(codigoCategoriaLabel);
            this.Controls.Add(this.codigoCategoriaComboBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.DtvProdutos);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnNovo);
            this.Name = "FrmProduto";
            this.Text = "Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProduto_FormClosed);
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView DtvProdutos;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox codigoCategoriaComboBox;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}