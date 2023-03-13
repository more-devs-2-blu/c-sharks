using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class ServicesRepository : BaseRepository<Service>, IServicesRepository
    {
        private readonly MySqlContext? _dataContext;
        public ServicesRepository(MySqlContext context) : base(context)
        {
        }
    }
}
