namespace ApiProjesiCrud.Repository.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();

        Task<List<TEntity>> GetAllWithPage(int page, int pageSize);
        Task<List<TEntity>> GetAllWithPageParameters(int page, int pageSize);

       

    }
}
