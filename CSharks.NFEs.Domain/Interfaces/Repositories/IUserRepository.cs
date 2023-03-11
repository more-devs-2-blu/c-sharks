using CSharks.NFEs.Domain.Models;

namespace CSharks.NFEs.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public User GetByLogin(string login);
    }
}
