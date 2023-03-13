using System.ComponentModel.DataAnnotations;

namespace CSharks.NFEs.Domain.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Digite o cnpj do empreesa")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Password { get; set; }
    }
}
