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
        public string Type { get; set; }
        public string Address { get; set; }
        public string Identifier { get; set; }
        public string Ie { get; set; }
        public string Patio { get; set; }
        public string Email { get; set; }
        public string ResidentialNumber { get; set; }
        public string Complement { get; set; }

        public string Enrollment { get; set; }
	
		//public virtual List<int>? NFId { get; set; }
    }
}
