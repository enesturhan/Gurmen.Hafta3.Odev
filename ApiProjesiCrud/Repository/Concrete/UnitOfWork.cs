using ApiProjesiCrud.Repository.Abstract;
using System.Data;

namespace ApiProjesiCrud.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbTransaction _transaction;

        public UnitOfWork(IDbTransaction transaction)
        {
            _transaction = transaction;
        }

        public void Commit()
        { 
            _transaction.Commit(); 
        }

        public void RollBack()
        {
            _transaction.Rollback();
        }
    }
}
