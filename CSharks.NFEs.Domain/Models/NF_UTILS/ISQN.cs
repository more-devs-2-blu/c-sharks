using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models.NF_UTILS
{
    public class ISQN
    {
        public Guid ID { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }

        public string Aliquot { get; set; }

    }
}
