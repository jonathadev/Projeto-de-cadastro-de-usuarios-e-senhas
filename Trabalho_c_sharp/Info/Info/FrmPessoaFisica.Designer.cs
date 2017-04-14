namespace Info
{
    partial class FrmPessoaFisica
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label nomeMaeLabel;
            System.Windows.Forms.Label nomePaiLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label telefoneLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomeMaeTextBox = new System.Windows.Forms.TextBox();
            this.nomePaiTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.DtvPessoaFisica = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            nomeMaeLabel = new System.Windows.Forms.Label();
            nomePaiLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtvPessoaFisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(6, 23);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 57);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(164, 90);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 5;
            cPFLabel.Text = "CPF:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(6, 120);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(107, 13);
            dataNascimentoLabel.TabIndex = 7;
            dataNascimentoLabel.Text = "Data de Nascimento:";
            dataNascimentoLabel.Click += new System.EventHandler(this.dataNascimentoLabel_Click);
            // 
            // nomeMaeLabel
            // 
            nomeMaeLabel.AutoSize = true;
            nomeMaeLabel.Location = new System.Drawing.Point(6, 151);
            nomeMaeLabel.Name = "nomeMaeLabel";
            nomeMaeLabel.Size = new System.Drawing.Size(77, 13);
            nomeMaeLabel.TabIndex = 9;
            nomeMaeLabel.Text = "Nome da Mãe:";
            // 
            // nomePaiLabel
            // 
            nomePaiLabel.AutoSize = true;
            nomePaiLabel.Location = new System.Drawing.Point(6, 183);
            nomePaiLabel.Name = "nomePaiLabel";
            nomePaiLabel.Size = new System.Drawing.Size(71, 13);
            nomePaiLabel.TabIndex = 11;
            nomePaiLabel.Text = "Nome do Pai:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(362, 90);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 13;
            rGLabel.Text = "RG:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(50, 20);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(598, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(50, 54);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(598, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "PessoaFisica.CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(208, 87);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(142, 20);
            this.cPFTextBox.TabIndex = 4;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoaBindingSource, "PessoaFisica.DataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(120, 114);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 6;
            // 
            // nomeMaeTextBox
            // 
            this.nomeMaeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "PessoaFisica.NomeMae", true));
            this.nomeMaeTextBox.Location = new System.Drawing.Point(83, 151);
            this.nomeMaeTextBox.Name = "nomeMaeTextBox";
            this.nomeMaeTextBox.Size = new System.Drawing.Size(580, 20);
            this.nomeMaeTextBox.TabIndex = 7;
            // 
            // nomePaiTextBox
            // 
            this.nomePaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "PessoaFisica.NomePai", true));
            this.nomePaiTextBox.Location = new System.Drawing.Point(83, 183);
            this.nomePaiTextBox.Name = "nomePaiTextBox";
            this.nomePaiTextBox.Size = new System.Drawing.Size(580, 20);
            this.nomePaiTextBox.TabIndex = 8;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "PessoaFisica.RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(394, 87);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(148, 20);
            this.rGTextBox.TabIndex = 5;
            // 
            // DtvPessoaFisica
            // 
            this.DtvPessoaFisica.AllowUserToAddRows = false;
            this.DtvPessoaFisica.AllowUserToDeleteRows = false;
            this.DtvPessoaFisica.AutoGenerateColumns = false;
            this.DtvPessoaFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvPessoaFisica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.PessoaFisica});
            this.DtvPessoaFisica.DataSource = this.pessoaBindingSource;
            this.DtvPessoaFisica.Location = new System.Drawing.Point(4, 264);
            this.DtvPessoaFisica.Name = "DtvPessoaFisica";
            this.DtvPessoaFisica.ReadOnly = true;
            this.DtvPessoaFisica.Size = new System.Drawing.Size(644, 102);
            this.DtvPessoaFisica.TabIndex = 14;
            this.DtvPessoaFisica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pessoaDataGridView_CellContentClick);
            this.DtvPessoaFisica.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pessoaDataGridView_CellFormatting);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(573, 223);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 12;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(414, 223);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(208, 223);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 10;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(4, 223);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 9;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PessoaFisica";
            this.dataGridViewTextBoxColumn5.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // PessoaFisica
            // 
            this.PessoaFisica.DataPropertyName = "PessoaFisica";
            this.PessoaFisica.HeaderText = "RG";
            this.PessoaFisica.Name = "PessoaFisica";
            this.PessoaFisica.ReadOnly = true;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Info.DAL.Pessoa);
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(6, 87);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 19;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(64, 84);
            this.telefoneMaskedTextBox.Mask = "(99) 0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(95, 20);
            this.telefoneMaskedTextBox.TabIndex = 20;
            // 
            // FrmPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 386);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.DtvPessoaFisica);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(nomePaiLabel);
            this.Controls.Add(this.nomePaiTextBox);
            this.Controls.Add(nomeMaeLabel);
            this.Controls.Add(this.nomeMaeTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Name = "FrmPessoaFisica";
            this.Text = ".: Cadastro de Pessoas Fisicas :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCliente_FormClosed);
            this.Load += new System.EventHandler(this.FrmPessoaFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtvPessoaFisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox nomeMaeTextBox;
        private System.Windows.Forms.TextBox nomePaiTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.DataGridView DtvPessoaFisica;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaFisica;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
    }
}