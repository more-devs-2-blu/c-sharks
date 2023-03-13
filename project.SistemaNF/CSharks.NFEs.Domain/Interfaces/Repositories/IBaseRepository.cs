namespace CSharks.NFEs.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task<int> Save (T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
