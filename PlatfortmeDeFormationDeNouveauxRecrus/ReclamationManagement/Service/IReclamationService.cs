using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Service
{
    public interface IReclamationService
    {
        public Reclamation AddReclamation(ReclamationDTO reclamation);
        public string RemoveReclamation(int id);
        public List<Reclamation> GetAllReclamations();

    }
}
