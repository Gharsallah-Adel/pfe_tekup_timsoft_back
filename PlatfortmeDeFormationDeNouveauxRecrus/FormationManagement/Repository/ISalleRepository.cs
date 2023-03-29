using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository
{
    public interface ISalleRepository
    {
        public Salle AddSalle( SalleDTO salle);
        public Salle UpdateSalle(Salle salle, int idsal);

        public string RemoveSalle(int id);
        public List<Salle> GetAllSalles();
    }
}
