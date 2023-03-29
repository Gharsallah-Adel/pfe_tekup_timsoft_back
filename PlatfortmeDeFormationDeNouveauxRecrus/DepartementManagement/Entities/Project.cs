
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Project_id { get; set; }
        public string Description { get; set; }

        public string NameD { get; set; }
       //   [NotMapped]
      //  [JsonIgnore]
        //public List<Document> Documents { get; set; }
        //public Departement Departement { get; set; }
    }

}

