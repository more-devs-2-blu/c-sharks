using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly MySqlContext _dataContext;
        public ClientRepository(MySqlContext context)
        {
            _dataContext = context;
        }

        public Task<int> Delete(Client entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(Client entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
