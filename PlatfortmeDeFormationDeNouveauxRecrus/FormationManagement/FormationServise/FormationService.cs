using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise
{
    public class FormationService : IFormationService
    {

        private readonly IFormationRepository _formationRepository;
        public FormationService(IFormationRepository documentRepository)
        {
            _formationRepository = documentRepository;
        }
        public Formation AddFormation(FormationDTO formation)
        {
            return _formationRepository.AddFormation(formation);
        }
        public string RemoveFormation(int id)
        {
            return _formationRepository.RemoveFormation(id);
        }

        public Formation updateFormationById(Formation formation, int idDep)
        {
            return _formationRepository.UpdateFormation(formation, idDep);
        }
        public List<Formation> GetAllFormations()
        {
            return _formationRepository.GetAllFormations();
        }
        public int GetFormationsCount()
        {
            return _formationRepository.GetFormationsCount();
        }
    }
}
