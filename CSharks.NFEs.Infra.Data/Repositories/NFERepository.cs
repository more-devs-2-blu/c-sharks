using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{

    public class NFERepository : INFERepository
    {
        private readonly MySqlContext _dataContext;
        public NFERepository(MySqlContext context)
        {
            _dataContext = context;
        }

        public Task<int> Delete(NFE entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NFE> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<NFE> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NFE entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(NFE entity)
        {
            throw new NotImplementedException();
        }
    }
}