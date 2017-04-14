using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    class CNPJService
    {
        public static bool IsValid(string cnpj)
        {
            return cnpj.Length == 14;
        }
    }
}
