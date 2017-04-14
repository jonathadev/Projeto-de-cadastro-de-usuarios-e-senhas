using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks
namespace Domain.Entities
{
    class Client
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
       // public int Ra { get; set; }
        public string Cnpj { get; set; }

        public bool IsValid()
        {
            return EmailService.IsValid(Email) && CNPJService.IsValid(Cnpj) && IdadeService.IsValid(DataNascimento);
        }
    }
}
