using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class IdadeService
    {
        public static bool IsValid(DateTime dataNascimento)
        {

            return DateTime.Now.Year - dataNascimento.Year > 18;
        }
    }
}
