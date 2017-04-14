namespace Info
{
    partial class FrmLogin
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
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLogar = new System.Windows.Forms.Button();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(67, 51);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(77, 13);
            nomeUsuarioLabel.TabIndex = 1;
            nomeUsuarioLabel.Text = "Nome Usuario:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(103, 99);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "Senha:";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Info.DAL.Usuario);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.TxtUsuario.Location = new System.Drawing.Point(150, 48);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // TxtSenha
            // 
            this.TxtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.TxtSenha.Location = new System.Drawing.Point(150, 96);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 4;
            this.TxtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(198, 150);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLogar
            // 
            this.BtnLogar.Location = new System.Drawing.Point(54, 150);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(113, 23);
            this.BtnLogar.TabIndex = 5;
            this.BtnLogar.Text = "Entrar no Sistema";
            this.BtnLogar.UseVisualStyleBackColor = true;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 226);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.TxtUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Sistema Automação Comercial V0.113 :.";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLogar;
    }
}