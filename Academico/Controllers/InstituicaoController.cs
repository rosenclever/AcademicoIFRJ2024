using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao()
            {
                InstituicaoID = 1,
                Nome = "Hogwarts",
                Endereco = "Escócia"
            },
            new Instituicao()
            {
                InstituicaoID = 2,
                Nome = "Mansão X",
                Endereco = "New York"
            }
        };
        public IActionResult Index()
        {
            return View(instituicoes);
        }
    }
}
