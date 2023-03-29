using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities
{
    public class Formation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Formation_id { get; set; }
        public string Description { get; set; }
        public string Niveau { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public int NombreParticipant { get; set; }
        public int Duree { get; set; }
        public string statut { get; set; }
        public string EnPresence { get; set; }
        
    }
}
