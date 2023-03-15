using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class EmitedNfRepository : BaseRepository<EmitedNF>, IEmitedNfRepository
    {
        private readonly MySqlContext? _dataContext;
        public EmitedNfRepository(MySqlContext context) : base(context)
        {
        }

    }


    
}
