using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{

    public class NFERepository : BaseRepository<NFE>, INFERepository
    {
        private readonly MySqlContext? _dataContext;
        public NFERepository(MySqlContext context) : base(context)
        {
        }
    }
}