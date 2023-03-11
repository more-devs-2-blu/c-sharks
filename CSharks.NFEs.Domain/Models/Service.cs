using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class Service
    {
        public Guid Id { get; set; }

		[Required(ErrorMessage = "Digite o nome do serviço")]
		public string Name { get; set; }


        [Required(ErrorMessage = "Digite o valor do serviço")]
        public double Aliquot { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria")]
        public int CategoryId { get; set; }
		public virtual Category? Category { get; set; }
    }
}
