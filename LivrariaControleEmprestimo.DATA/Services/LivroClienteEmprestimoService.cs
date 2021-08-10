using LivrariaControleEmprestimo.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public RepositoryLivroClienteEmprestimo oRepositoryLivroClienteEmprestimo { get; set; }

        public LivroClienteEmprestimoService()
        {
            oRepositoryLivroClienteEmprestimo = new RepositoryLivroClienteEmprestimo();
        }
    }
}
