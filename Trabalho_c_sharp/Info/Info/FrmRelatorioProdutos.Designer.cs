namespace Info
{
    partial class FrmRelatorioProdutos
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
            this.CrvProdutos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvProdutos
            // 
            this.CrvProdutos.ActiveViewIndex = -1;
            this.CrvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvProdutos.Location = new System.Drawing.Point(0, 0);
            this.CrvProdutos.Name = "CrvProdutos";
            this.CrvProdutos.Size = new System.Drawing.Size(817, 390);
            this.CrvProdutos.TabIndex = 0;
            this.CrvProdutos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CrvProdutos.Load += new System.EventHandler(this.CrvProdutos_Load);
            // 
            // FrmRelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 390);
            this.Controls.Add(this.CrvProdutos);
            this.Name = "FrmRelatorioProdutos";
            this.Text = ".: Relatório de Produtos :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRelatorioProdutos_FormClosed);
            this.Load += new System.EventHandler(this.FrmRelatorioProdutos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvProdutos;
    }
}