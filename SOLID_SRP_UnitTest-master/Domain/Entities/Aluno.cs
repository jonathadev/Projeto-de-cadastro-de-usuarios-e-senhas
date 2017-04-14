using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Services;

namespace Domain.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Ra { get; set; }
        public string Cpf { get; set; }

        public bool IsValid()
        {
            return EmailService.IsValid(Email) && CpfService.IsValid(Cpf) && IdadeService.IsValid(DataNascimento);
        }

    }
}
