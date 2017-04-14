using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FrmSplash FormSplash = new FrmSplash();
            FormSplash.ShowDialog();

            FrmLogin FormLogin = new FrmLogin();
            FormLogin.ShowDialog();

            if (FormLogin.logado == true)
            {
             
                Application.Run(new frmPrincipal());
            }
        }
    }
}
