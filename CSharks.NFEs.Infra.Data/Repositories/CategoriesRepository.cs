using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly MySqlContext _dataContext;
        public CategoriesRepository(MySqlContext context)
        {
            _dataContext = context;
        }

        public Task<int> Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
