using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Domain.Models.NF;

namespace CSharks.NFEs.Domain.Interfaces.Repositories
{
    public interface IEnterpriseRepository : IBaseRepository<Enterprise> {
        public Enterprise GetByCnpj(string cnpj);
    }

}
