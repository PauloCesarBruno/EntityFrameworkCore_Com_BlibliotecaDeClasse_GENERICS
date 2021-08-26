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

        public IActionResult Details(int Id)
        {
            LivroClienteEmprestimo oLceEmprestimo = oEmprestimoService.oRLce.SelecionarPk(Id);
            return View(oLceEmprestimo);
        }

        public IActionResult Edit(int Id)
        {
            LivroClienteEmprestimo oLceEmprestimo = oEmprestimoService.oRLce.SelecionarPk(Id);
            return View(oLceEmprestimo);
        }

        [HttpPost]
        public IActionResult Edit(LivroClienteEmprestimo model)
        {
            LivroClienteEmprestimo oLceEmprestimo = oEmprestimoService.oRLce.Alterar(model);

            // Redirecionamento...
            int Id = oLceEmprestimo.Id;
            return RedirectToAction("Details", new { Id });
        }

        public IActionResult Delete(int Id)
        {
            /* Não vou usar partial View nem retornar nehuma view vou usar 
             * o Botstrap Modal e retornar para Index Mesmo.*/
            oEmprestimoService.oRLce.Excluir(Id);
            return RedirectToAction("Index");
        }

    }
}
