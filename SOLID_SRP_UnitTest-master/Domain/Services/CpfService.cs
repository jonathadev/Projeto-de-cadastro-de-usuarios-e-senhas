using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CpfService
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
