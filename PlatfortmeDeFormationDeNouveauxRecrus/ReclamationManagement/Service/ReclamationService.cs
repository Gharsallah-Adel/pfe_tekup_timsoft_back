using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Service
{
    public class ReclamationService : IReclamationService
    {

        private readonly IReclamationRepository _reclamationRepository;
        public ReclamationService(IReclamationRepository reclamationRepository)
        {
            _reclamationRepository = reclamationRepository;
        }
        public Reclamation AddReclamation(ReclamationDTO reclamation)
        {
            return _reclamationRepository.AddReclamation(reclamation);
        }


        public string RemoveReclamation(int id)
        {
            return _reclamationRepository.RemoveReclamation(id);
        }
        public List<Reclamation> GetAllReclamations()
        {
            return _reclamationRepository.GetAllReclamations();
        }



    }
}

