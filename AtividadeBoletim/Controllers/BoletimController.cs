using Microsoft.AspNetCore.Mvc;
using AtividadeBoletim.Models;
using System.Collections.Generic;

namespace AtividadeBoletim.Controllers
{
    public class BoletimController : Controller
    {
        public IActionResult Index()
        {
            var listaNotas = new List<Boletim>
            {
                new Boletim { Id = 1, NomeAluno = "Ana Silva", Materia = "Desenvolvimento Web", Nota1 = 8.5m, Nota2 = 7.0m },
                new Boletim { Id = 2, NomeAluno = "Carlos Souza", Materia = "Banco de Dados", Nota1 = 5.0m, Nota2 = 4.5m },
                new Boletim { Id = 3, NomeAluno = "Bruna Oliveira", Materia = "Estrutura de Dados", Nota1 = 9.5m, Nota2 = 9.0m },
                new Boletim { Id = 4, NomeAluno = "Daniel Santos", Materia = "Engenharia de Software", Nota1 = 6.0m, Nota2 = 5.5m },
                new Boletim { Id = 5, NomeAluno = "Elena Rodrigues", Materia = "Desenvolvimento Web", Nota1 = 4.0m, Nota2 = 7.5m }
            };

            return View(listaNotas);
        }
    }
}