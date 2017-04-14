using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            FrmLogin FormLogin = new FrmLogin();
            FormLogin.ShowDialog();

            if (FormLogin.logado == true)
            {
             
                Application.Run(new FrmPrincipal());
            }

            
        }
    }
}
