using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class Service
    {
        public int Id { get; set; }
	public string Name { get; set; }
	public double Aliquot { get; set; }
	
	public int CategoryId { get; set; }
	public virtual Category? Category { get; set; }
    }
}
