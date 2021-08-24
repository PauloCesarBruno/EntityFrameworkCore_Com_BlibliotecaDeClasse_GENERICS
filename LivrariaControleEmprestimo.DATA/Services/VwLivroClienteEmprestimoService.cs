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
        public ReposytoriVwLivroClienteEmprestimo oReposytoriEmprestimo{ get; set; }

        public VwLivroClienteEmprestimoService()
        {
            oReposytoriEmprestimo = new ReposytoriVwLivroClienteEmprestimo();
        }
        
    }
}
