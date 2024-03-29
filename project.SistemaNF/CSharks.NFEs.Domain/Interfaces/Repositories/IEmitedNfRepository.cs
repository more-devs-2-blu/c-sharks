﻿using CSharks.NFEs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Interfaces.Repositories
{
    public interface IEmitedNfRepository : IBaseRepository<EmitedNF>
    {
        public EmitedNF GetByNoNfse(string noNfse);
    }
}
