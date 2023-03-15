using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Enums
{
    public enum TypeClient
    {
        [Description("F")]
        PF = 1,
        [Description("J")]
        PJ = 2,
        [Description("E")]
        E = 3
    }
}
