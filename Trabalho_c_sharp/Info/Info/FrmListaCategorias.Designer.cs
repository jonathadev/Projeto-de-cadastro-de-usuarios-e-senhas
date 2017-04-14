namespace Info
{
    partial class FrmListaCategorias
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
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnGerarRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CboCategoria
            // 
            this.CboCategoria.DataSource = this.categoriaBindingSource;
            this.CboCategoria.DisplayMember = "Descricao";
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(83, 39);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(220, 21);
            this.CboCategoria.TabIndex = 0;
            this.CboCategoria.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Info.DAL.Categoria);
            // 
            // BtnGerarRelatorio
            // 
            this.BtnGerarRelatorio.Location = new System.Drawing.Point(105, 85);
            this.BtnGerarRelatorio.Name = "BtnGerarRelatorio";
            this.BtnGerarRelatorio.Size = new System.Drawing.Size(163, 23);
            this.BtnGerarRelatorio.TabIndex = 1;
            this.BtnGerarRelatorio.Text = "Gerar Relatório";
            this.BtnGerarRelatorio.UseVisualStyleBackColor = true;
            this.BtnGerarRelatorio.Click += new System.EventHandler(this.BtnGerarRelatorio_Click);
            // 
            // FrmListaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 161);
            this.Controls.Add(this.BtnGerarRelatorio);
            this.Controls.Add(this.CboCategoria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaCategorias";
            this.Text = ".: Categorias :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListaCategorias_FormClosed);
            this.Load += new System.EventHandler(this.FrmListaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Button BtnGerarRelatorio;
    }
}