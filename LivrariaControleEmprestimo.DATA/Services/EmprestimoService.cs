using LivrariaControleEmprestimo.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class EmprestimoService
    {
        public ReposytoriLivroClienteEmprestimo oRLce { get; set; }

        public EmprestimoService()
        {
            oRLce = new ReposytoriLivroClienteEmprestimo();
        }
    }
}
