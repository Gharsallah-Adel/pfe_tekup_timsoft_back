using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise
{
    public interface ISalleService
    {
        public Salle AddSalle(SalleDTO salle);
        public string RemoveSalle(int id);
        public Salle updateSalleById(Salle salle, int idSal);
        public List<Salle> GetAllSalles();
    }
}
