using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities
{
    public class PlanFormation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlanFormation_id { get; set; }
        public string Module { get; set; }
        public DateTime Debut { get; set; }
        public DateTime Fin { get; set; }
        public string Chapitre { get; set; }

    }
}
