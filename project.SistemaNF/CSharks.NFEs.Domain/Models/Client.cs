using System.ComponentModel.DataAnnotations;

namespace CSharks.NFEs.Domain.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string? Enrollment { get; set; }
        public string? InformedAdress { get; set; }

        [Required(ErrorMessage = "Digite o cpf ou cnpj do cliente")]
        public string CpfCnpj { get; set; }

        //nome ou razão estadual
        [Required(ErrorMessage = "Digite nome ou razão social do cliente")]
		public string Name { get; set; }

        //inscrição estadual
        public string? Ie { get; set; }
        
        //logradouro
        public string? Address { get; set; }

        //bairro
        public string? District { get; set; }

        //cidade
        public string? City { get; set; }

        //numero pode ser pj ou pf
        public string? ResidentialNumber { get; set; }

        //email
        public string? Email { get; set; }

        // utilizado pra buscar o cliente
        public string? CEP { get; set; }








        //public virtual List<int>? NFId { get; set; }
    }
}
