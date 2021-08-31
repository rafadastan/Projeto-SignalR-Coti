using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        //gerenciamento das transações
        void BeginTransaction();
        void Commit();
        void Rollback();

        //gerenciamento dos repositorios
        IContaRepository ContaRepository { get; }
    }
}
