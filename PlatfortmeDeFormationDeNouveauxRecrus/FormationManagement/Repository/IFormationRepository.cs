using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository
{
    public interface IFormationRepository
    {
        public Formation AddFormation(FormationDTO documentForm);
        public Formation UpdateFormation(Formation formation, int idDep);
    
        public string RemoveFormation(int id);
        public List<Formation> GetAllFormations();
        public int GetFormationsCount();
    }
}
