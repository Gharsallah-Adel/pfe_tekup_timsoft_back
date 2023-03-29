using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Repository
{
    public interface IReclamationRepository
    {
        public Reclamation AddReclamation(ReclamationDTO reclamation);
        public string RemoveReclamation(int id);
        public List<Reclamation> GetAllReclamations();

    }
}