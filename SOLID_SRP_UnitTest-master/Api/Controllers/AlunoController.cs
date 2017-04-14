using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using System.Web.Http.Description;
using Api.Controllers;
using System.EnterpriseServices;

// {EE9D0C9F-12D1-4011-B718-2DC338EBFCB6}

////IMPLEMENT_OLECREATE(<<class>>, <<external_name>>, 
////0xee9d0c9f, 0x12d1, 0x4011, 0xb7, 0x18, 0x2d, 0xc3, 0x38, 0xeb, 0xfc, 0xb6);

//[Guid("8B92766B-825F-409d-BC32-B3723D617A93"), ClassInterface(ClassInterfaceType.None), ProgId("Apollo.WS"), ComVisible(true)]
//public sealed class WS : ServicedComponent, IWSFSAPLProxy { }

[Guid("8B92766B-825F-409d-BC32-B3723D617A93"), ClassInterface(ClassInterfaceType.None), ProgId("Apollo.WS"), ComVisible(true)]
public sealed class WS : ServicedComponent { }

namespace Api.Controllers
{

    [RoutePrefix("api/v1.0/todos")]//versionamento??
    
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

      /// <summary>
      /// Recurso que cadastra alunos .
      /// </summary>
      /// <returns>Retorna o aluno cadastrado</returns>
        public IHttpActionResult Post([FromBody] Aluno aluno)//ALTERAR
        {
            var uuid = Guid.NewGuid().ToString();

            var al = new Aluno
            {
                Id = _alunos.OrderByDescending(x => x.Id).Select(c => c.Id).First() + 1,
                Ra = aluno.Ra,
                DataNascimento = aluno.DataNascimento,
                Email = aluno.Email,
                Nome = aluno.Nome,
                Cpf = aluno.Cpf,
            };
            _alunos.Add(al);

            return Ok(al);
        }

        /// <summary>
        /// Recurso que fornece uma coleção de alunos cadastrados.
        /// </summary>
        /// <returns>Retorna uma coleção de alunos</returns>
    [ResponseType(typeof(ICollection))]//informar o tipo retorno?? para documentacao
        public IHttpActionResult Get()//LISTAR
        {
            
            return Ok(_alunos);
        }

    /// <summary>
    /// Recurso que altera alunos .
    /// </summary>
    /// <returns>Retorna o aluno alterado</returns>
        public IHttpActionResult Put(int id, [FromBody] Aluno aluno)
        {
            var alunoUpdated = _alunos.Find(x => x.Id == id);
            alunoUpdated.Cpf = aluno.Cpf;
            alunoUpdated.DataNascimento = aluno.DataNascimento;
            alunoUpdated.Nome = aluno.Nome;
            alunoUpdated.Email = aluno.Email;
            alunoUpdated.Ra = aluno.Ra;

            return Ok(alunoUpdated);
        }

        /// <summary>
        /// Recurso que deleta alunos .
        /// </summary>
        /// <returns>Retorna o aluno deletado</returns>
        public IHttpActionResult Delete([FromBody] Aluno aluno, int id)
        {
            Aluno alunoFinded = null;
            if (aluno != null)
            {
                alunoFinded = _alunos.Find(x => x.Nome.Equals(aluno.Nome) && x.Ra == aluno.Ra);
            }
            else
            {
                alunoFinded = _alunos.Find(x => x.Id == id);
            }
            _alunos.Remove(alunoFinded);
            return Ok(alunoFinded);
        }

    }
}
