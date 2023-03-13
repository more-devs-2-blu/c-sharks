using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Interfaces.Repositories.NF_UTILS;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Models.NF;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories.NF_UTILS
{
    public class NFRepository : BaseRepository<NF>, INFRepository
    {
        private readonly MySqlContext? _dataContext;
        public NFRepository(MySqlContext context) : base(context)
        {
        }
    }
}
