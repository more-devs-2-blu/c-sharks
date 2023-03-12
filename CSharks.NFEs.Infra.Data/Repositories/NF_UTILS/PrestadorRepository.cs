using CSharks.NFEs.Domain.Interfaces.Repositories.NF_UTILS;
using CSharks.NFEs.Domain.Models.NF;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories.NF_UTILS
{
    public class PrestadorRepository : BaseRepository<Prestador>, IPrestadorRepository
    {
        private readonly MySqlContext? _dataContext;
        public PrestadorRepository(MySqlContext context) : base(context)
        {
        }

    }
}
