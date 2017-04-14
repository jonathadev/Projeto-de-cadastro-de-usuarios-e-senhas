using System;
using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSolid
{
    [TestClass]
    public class UnitTestAluno
    {
        [TestMethod]
        public void TestSeAlunoEstaValido()
        {
            var aluno = new Aluno
            {
                Id = 123,
                Ra = 445566,
                Nome = "Raul",
                Email = "teste@teste.com",
                Cpf = "22111777800",
                DataNascimento = new DateTime(1998, 06, 01)
            };

            Assert.IsTrue(aluno.IsValid());

        }
    }
}
