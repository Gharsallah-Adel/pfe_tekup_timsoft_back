using System.ComponentModel.DataAnnotations;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities
{
    public class UserForm
    {
        [MinLength(4)]
        public string? FirstName { get; set; }
        [MinLength(4)]
        public string? LastName { get; set; }
        [MinLength(4)]
        public string? UserName { get; set; }
        [MinLength(4)]
        public string? Password { get; set; }
        public  string Department { get; set; } 
    }
}
