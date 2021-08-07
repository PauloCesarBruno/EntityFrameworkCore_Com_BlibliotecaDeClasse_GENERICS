using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repository
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanches = true) : base(SaveChanches)
        {

        }
    }
}
