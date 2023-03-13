using CSharks.NFEs.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace CSharks.NFEs.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário"), Column(TypeName = "varchar(55)")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite um login para o usuário"), Column(TypeName = "varchar(16)")]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite uma senha para o usuário"), Column(TypeName = "varchar(18)")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Escolha um perfil para o usuário")]
        public TypeProfile Profile { get; set; }

        public bool InputValidation(string paramPassword)
        {
            if (Password.Equals(paramPassword))
                return true;
            else return false;
        }
        
        public Guid? EnterpriseId { get; set; } 

    }
}
