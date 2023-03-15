using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class EmitedNF
    {
        public Guid Id { get; set; }

        public string EmitDate { get; set; }

        public string ServiceName { get; set; }

        public string ClientName { get; set; }

        public string ValueNF { get; set; }

        public string Situation { get; set; }
        
        //response items 
        public string? LinkPDF { get; set; }
        public string? NoNfse { get; set; }  

        public string?  CodVerify { get; set; }  


 

    }
}
