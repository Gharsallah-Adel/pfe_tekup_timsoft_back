using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie
{
    public class Reclamation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Reclamation_id { get; set; }
        public string? Description { get; set; }
        //public User Users { get; set; }
    }
}
