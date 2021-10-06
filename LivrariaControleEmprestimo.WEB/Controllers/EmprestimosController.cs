using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private LivroClienteEmprestimoService _service = new LivroClienteEmprestimoService();

        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListVwLivroClienteEmprestimo = _service.oReposytoriVwLivroClienteEmprestimo.SelecionarTodos();
            return View(oListVwLivroClienteEmprestimo);
        }

        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
            List<Livro> oListLivro = _service.oRepositoryLivro.SelecionarTodos();
            List<Cliente> oListCliente = _service.oRepositoryCliente.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = oListCliente;
            oEmprestimoViewModel.oListLivro = oListLivro;

            oEmprestimoViewModel.dataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.dataEntrega = DateTime.Now.AddDays(7); // 7 Dias p/ entrega.


            return View(oEmprestimoViewModel);
        }   
        
        [HttpPost]
        public IActionResult Create(EmprestimoViewModel oEmprestimoViewModel)
        {
            LivroClienteEmprestimo oLivroClienteEmprestimo = new LivroClienteEmprestimo();
            oLivroClienteEmprestimo.LceDataEmprestimo = oEmprestimoViewModel.dataEmprestimo;
            oLivroClienteEmprestimo.LceDataEntrega = oEmprestimoViewModel.dataEntrega;
            oLivroClienteEmprestimo.LceEntregue = false;
            oLivroClienteEmprestimo.LceIdCliente = oEmprestimoViewModel.idCliente;
            oLivroClienteEmprestimo.LceIdLivro = oEmprestimoViewModel.idLivro;

            if (!ModelState.IsValid)
            {
                return View();
            }

            _service.oReposytoriLivroClienteEmprestimo.Incluir(oLivroClienteEmprestimo);
            return RedirectToAction("Index");
        }
    }
}
