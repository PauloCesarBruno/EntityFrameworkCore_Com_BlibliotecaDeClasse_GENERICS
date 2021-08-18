using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroClienteController : Controller
    {
        private LivroClienteEmprestimoService oClienteService = new LivroClienteEmprestimoService();

        public IActionResult Index()
        {
            List<LivroClienteEmprestimo> objLCE = oClienteService.oRepositoryLivroClienteEmprestimo.SelecionarTodos();
            return View(objLCE);
        }
    }
}
