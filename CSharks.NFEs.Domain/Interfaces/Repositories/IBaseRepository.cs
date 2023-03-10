using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        Task<T> GetById(int id);
        Task<int> Save (T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
