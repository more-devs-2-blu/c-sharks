using CSharks.NFEs.Domain.Enums;

namespace CSharks.NFEs.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Login { get; set; }

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
