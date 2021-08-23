using LivrariaControleEmprestimo.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class VwLivroClienteEmprestimoService
    {
        public ReposytoriVwLivroClienteEmprestimo objrepoServiceView { get; set; }

        public VwLivroClienteEmprestimoService()
        {
            objrepoServiceView = new ReposytoriVwLivroClienteEmprestimo();
        }
        
    }
}
