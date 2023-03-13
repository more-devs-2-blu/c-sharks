using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class EnterpriseRepository : BaseRepository<Enterprise>, IEnterpriseRepository
    {
        private readonly MySqlContext? _dataContext;
        public EnterpriseRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }

        public Enterprise GetByCnpj(string cnpj)
        {
            return _dataContext!.Enterprises.FirstOrDefault(enterprise => enterprise.CpfCnpj == cnpj)!;
        }

    }
}
