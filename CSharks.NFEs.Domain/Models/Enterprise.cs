using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class Enterprise
    {   
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string CpfCnpj { get; set; }
        public string City { get; set; }
        
    }
}
