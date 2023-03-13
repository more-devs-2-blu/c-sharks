using System.ComponentModel.DataAnnotations;

namespace CSharks.NFEs.Domain.Models
{
    public class Client
    {
        public Guid Id { get; set; }
		[Required(ErrorMessage = "Digite nome ou razão social do cliente")]
		public string Name { get; set; }
        [Required(ErrorMessage = "Digite o cpf ou cnpj do cliente")]
        public string CpfCnpj { get; set; }

        public string Enrollment { get; set; }
	
		//public virtual List<int>? NFId { get; set; }
    }
}
