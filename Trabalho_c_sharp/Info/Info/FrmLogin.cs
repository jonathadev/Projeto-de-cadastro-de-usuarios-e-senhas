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
    public partial class FrmLogin : Form
    {
        public bool logado = false;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.Usuarios.Count(
                x => x.NomeUsuario == TxtUsuario.Text && x.Senha == TxtSenha.Text);

        if(user >0)
        {
             this.logado = true;
            this.Dispose();
        }
        else
        {
            MessageBox.Show("Usuário ou senha inválidos!", "Erro!");
        }

        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            EfetuarLogin();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TxtSenha.Focus();
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                EfetuarLogin();
            }

        }
    }
}
