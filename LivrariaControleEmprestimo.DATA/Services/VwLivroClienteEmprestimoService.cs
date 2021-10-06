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
        public ReposytoriVwLivroClienteEmprestimo oReposytoriVwLivroClienteEmprestimo{ get; set; }

        public VwLivroClienteEmprestimoService()
        {
            oReposytoriVwLivroClienteEmprestimo = new ReposytoriVwLivroClienteEmprestimo();
        }
        
    }
}
