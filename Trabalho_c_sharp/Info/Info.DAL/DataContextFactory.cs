using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.DAL
{
    public class DataContextFactory
    {
        private static InfoDataContext dataContext; 
        public static InfoDataContext DataContext
        {
            get
            {
                if (dataContext == null) // se for nulo ira crialo nova conexxao banco
                    dataContext = new InfoDataContext();
              
                return dataContext; // se nao for nulo retorna  a conecxao
            }




        }
    }
}
