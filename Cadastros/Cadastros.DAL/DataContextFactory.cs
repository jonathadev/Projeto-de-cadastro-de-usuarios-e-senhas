using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros.DAL
{
    public class DataContextFactory
    {
        private static CadastrosDataContext dataContext;
            public static CadastrosDataContext DataContext
            {
                get
                {
                if(dataContext == null)
                    dataContext = new CadastrosDataContext();

                    return dataContext;
                }

            }

    }
}
