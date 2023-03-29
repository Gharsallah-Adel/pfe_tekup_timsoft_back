using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise
{
    public interface IFormationService
    {
        public Formation AddFormation(FormationDTO formation);
        public string RemoveFormation(int id);
        public Formation updateFormationById(Formation formation, int idDep);
        public List<Formation> GetAllFormations();
        public int GetFormationsCount();
    }
}
