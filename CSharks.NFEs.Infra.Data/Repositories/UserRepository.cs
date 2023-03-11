using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MySqlContext _dataContext;
        public UserRepository(MySqlContext context)
        {
            _dataContext = context;
        }

        public Task<int> Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
