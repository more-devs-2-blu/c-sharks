using CSharks.NFEs.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Password { get; set; }
        public TypeProfile Profile { get; set; }

        public bool InputValidation(string paramLogin, string paramPassword)
        {
            if (paramLogin.Equals("dev") && paramPassword.Equals("123"))
                return true;
            else return false;
        }

    }
}
