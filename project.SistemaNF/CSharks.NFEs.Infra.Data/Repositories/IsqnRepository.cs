using CSharks.NFEs.Domain.Models.NF_UTILS;
using CSharks.NFEs.Infra.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class IsqnRepository : BaseRepository<ISQN> , IIsqnRepository
    {
        private readonly MySqlContext? _dataContext;
        public IsqnRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }

        public bool DeleteAll()
        {
            var isqns = _dataContext!.Isqns.ToList();
            _dataContext!.Isqns.RemoveRange(isqns);
            int affectedRows = _dataContext.SaveChanges();
            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> SaveAll(List<ISQN> isqns)
        {
            await _dataContext!.Isqns.AddRangeAsync(isqns);
            int affectedRows = _dataContext.SaveChanges();
            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
