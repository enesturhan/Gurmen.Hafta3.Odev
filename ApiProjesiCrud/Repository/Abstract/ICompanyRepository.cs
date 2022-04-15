using ApiProjesiCrud.Commands.CompanyDelete;
using ApiProjesiCrud.Commands.CompanyInsert;
using ApiProjesiCrud.Commands.CompanyUpdate;
using ApiProjesiCrud.Models;

namespace ApiProjesiCrud.Repository.Abstract
{
    public interface ICompanyRepository:IGenericRepository<Company>
    {
        Task<int> Save(CompanyInsertCommand insertCommand);

        Task<bool> Update(CompanyUpdateCommand updateCommmand);

        Task<bool> Delete(CompanyDeleteCommand deleteCommand);

    }
}
