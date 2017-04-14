using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class AlunoController : ApiController
    {
        static List<Aluno> _alunos = new List<Aluno> {
            new Aluno {Id = 1, Cpf = "12345678901",
                DataNascimento = new DateTime(1998,01,05),
                Email = "teste1@teste.com", Nome = "Asdrubal",
                Ra = 123456},

            new Aluno {Id = 2, Cpf = "111222333444",
                DataNascimento = new DateTime(2005,10,04),
                Email = "teste2@teste.com", Nome = "Ascleidson",
                Ra = 111222},

            new Aluno {Id = 3, Cpf = "147258369",
                DataNascimento = new DateTime(1979,06,04),
                Email = "teste3@teste.com", Nome = "Joedson",
                Ra = 333555}
        };
        
        public IHttpActionResult Get()
        {
            return Ok(_alunos);
        }
    }
}
