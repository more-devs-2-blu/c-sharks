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

        public string? Email { get; set; }

        public string? Ie { get; set; }

        public string? Enrollment { get; set; }

        // Endereço cliente estrangeiro

        public string? Country { get; set; }

        public string? State { get; set; }

        // Endereço

        public string? CEP { get; set; }

        public string? City { get; set; }

        public string? District { get; set; }

        public string? Address { get; set; }

        public string? ResidentialNumber { get; set; }


        //public virtual List<int>? NFId { get; set; }
    }
}
