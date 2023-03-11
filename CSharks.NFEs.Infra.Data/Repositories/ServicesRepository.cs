using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class ServicesRepository : IServicesRepository
    {
        private readonly MySqlContext _dataContext;
        public ServicesRepository(MySqlContext context)
        {
            _dataContext = context;
        }

        public Task<int> Delete(Service entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Service> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Service> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(Service entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Service entity)
        {
            throw new NotImplementedException();
        }
    }
}
