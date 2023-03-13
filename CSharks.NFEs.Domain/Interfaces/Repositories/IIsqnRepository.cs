using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models.NF_UTILS;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public interface IIsqnRepository : IBaseRepository<ISQN>
    {
        public Task<bool> SaveAll(List<ISQN> isqns);
        public bool DeleteAll(); //deleterange method does not accept await
    }
}
