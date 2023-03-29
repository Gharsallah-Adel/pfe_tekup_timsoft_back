using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities
{
    public class Departement
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Departement_id { get; set; }
        public string DepartementName { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<User> Users { get; set; }
        [NotMapped]
        [JsonIgnore]
        public List<SousDepartement> SousDepartements { get; set; }
        //[NotMapped]
       // [JsonIgnore]
       // public List<Project> Projects { get; set; }


    }
}
