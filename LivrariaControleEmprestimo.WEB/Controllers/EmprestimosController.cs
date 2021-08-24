using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private VwLivroClienteEmprestimoService oEmprestimoService = new VwLivroClienteEmprestimoService();

        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListCliente = oEmprestimoService.oReposytoriEmprestimo.SelecionarTodos();
            return View(oListCliente);
        }
       
    }
}
