using CSharks.NFEs.Domain.Interfaces.Repositories.NF_UTILS;
using CSharks.NFEs.Domain.Models.NF;
using CSharks.NFEs.Infra.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Infra.Data.Repositories.NF_UTILS
{
    public class PesquisaRepository : BaseRepository<Pesquisa>, IPesquisaRepository
    {
        private readonly MySqlContext? _dataContext;
        public PesquisaRepository(MySqlContext context) : base(context)
        {
        }
    }
}
