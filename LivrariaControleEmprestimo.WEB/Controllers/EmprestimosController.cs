using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private VwLivroClienteEmprestimoService oVWEmprestimoService = new VwLivroClienteEmprestimoService();

        private EmprestimoService oEmprestimoService = new EmprestimoService();

        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListCliente = oVWEmprestimoService.oReposytoriEmprestimo.SelecionarTodos();
            return View(oListCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LivroClienteEmprestimo model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oEmprestimoService.oRLce.Incluir(model);
            return RedirectToAction("Index");
        }

    }
}
