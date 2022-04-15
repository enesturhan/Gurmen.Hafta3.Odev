namespace ApiProjesiCrud.Repository.Abstract
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}
