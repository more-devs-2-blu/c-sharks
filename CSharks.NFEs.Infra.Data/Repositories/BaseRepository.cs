using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Infra.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SqlServerContext _sqlContext;
        public BaseRepository(SqlServerContext context) 
        {
            _sqlContext = context;
        }

        public List<T> GetAll()
        {
            List<T> list = _sqlContext.Set<T>();
            return list;
        }

        public Task<T> GetById(int id)
        {
            return await _sqlContext.set<T>().findAsync(id);
        }

        public Task<int> Save(T entity)
        {
            _sqlContext.set<T>().Add(entity);
            return _sqlContext.SaveChangesAsync();
        }

        public Task<int> Update(T entity)
        {
            _sqlContext.Set<T>().Update(entity);
            return _sqlContext.SaveChangesAsync();
        }
        public Task<int> Delete(T entity)
        {
            _sqlContext.Set<T>.Remove(entity);
            return _sqlContext.SaveChangesAsync();
        }
    }
}
