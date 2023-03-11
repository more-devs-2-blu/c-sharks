using CSharks.NFEs.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharks.NFEs.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required, Column(TypeName = "varchar(55)")]
        public string Name { get; set; } = string.Empty;

        [Required, Column(TypeName = "varchar(16)")]
        public string Login { get; set; } = string.Empty;

        [Required, Column(TypeName = "varchar(18)")]
        public string Password { get; set; } = string.Empty;

        public TypeProfile Profile { get; set; }

        public bool InputValidation(string paramLogin, string paramPassword)
        {
            if (paramLogin.Equals("dev") && paramPassword.Equals("123"))
                return true;
            else return false;
        }
    }
}
