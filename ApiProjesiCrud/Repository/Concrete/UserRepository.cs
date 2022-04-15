using ApiProjesiCrud.Models;
using ApiProjesiCrud.Repository.Abstract;

namespace ApiProjesiCrud.Repository.Concrete
{
    public class UserRepository:  IUserRepository
    {
        public Task<bool> Delete(UserApp productDeleteCommand)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserApp>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserApp>> GetAllWithPage(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserApp>> GetAllWithPageParameters(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(UserApp productInsertCommand)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Transfer(UserApp accountTransferCommand)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TransferByStoreProcedure(UserApp accountTransferCommand)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UserApp updateCommmand)
        {
            throw new NotImplementedException();
        }
    }
}
