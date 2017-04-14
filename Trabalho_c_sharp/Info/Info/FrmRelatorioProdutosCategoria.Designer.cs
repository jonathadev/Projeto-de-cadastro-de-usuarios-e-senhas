namespace Info
{
    partial class FrmRelatorioProdutosCategoria
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
            this.CrvProdutosCategoria = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvProdutosCategoria
            // 
            this.CrvProdutosCategoria.ActiveViewIndex = -1;
            this.CrvProdutosCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvProdutosCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvProdutosCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvProdutosCategoria.Location = new System.Drawing.Point(0, 0);
            this.CrvProdutosCategoria.Name = "CrvProdutosCategoria";
            this.CrvProdutosCategoria.Size = new System.Drawing.Size(698, 262);
            this.CrvProdutosCategoria.TabIndex = 0;
            this.CrvProdutosCategoria.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CrvProdutosCategoria.Load += new System.EventHandler(this.CrvProdutosCategoria_Load);
            // 
            // FrmRelatorioProdutosCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 262);
            this.Controls.Add(this.CrvProdutosCategoria);
            this.Name = "FrmRelatorioProdutosCategoria";
            this.Text = ".: Relatório de Produtos por Categoria :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRelatorioProdutosCategoria_FormClosed);
            this.Load += new System.EventHandler(this.FrmRelatorioProdutosCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvProdutosCategoria;
    }
}