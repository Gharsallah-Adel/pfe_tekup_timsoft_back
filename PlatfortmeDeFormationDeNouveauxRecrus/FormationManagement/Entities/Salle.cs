using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities
{
    public class Salle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Salle_id { get; set; }
        public string NameSalle { get; set; }
        public string BureauName { get; set; }

    }
}
