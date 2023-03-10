using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class Client
    {
        public Guid Id { get; set; }
	public string Name { get; set; }
	public string CPFCNPJ { get; set; }
	public string Enrollment { get; set; }
	
	public virtual List<int>? NFId { get; set; }
    }
}
