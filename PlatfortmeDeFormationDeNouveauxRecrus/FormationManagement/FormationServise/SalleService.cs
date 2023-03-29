using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise
{
    public class SalleService : ISalleService
    {

        private readonly ISalleRepository _salleRepository;
        public SalleService(ISalleRepository salleRepository)
        {
            _salleRepository = salleRepository;
        }
        public Salle AddSalle(SalleDTO salle)
        {
            return _salleRepository.AddSalle(salle);
        }
        public string RemoveSalle(int id)
        {
            return _salleRepository.RemoveSalle(id);
        }

        public Salle updateSalleById(Salle salle, int idSal)
        {
            return _salleRepository.UpdateSalle(salle, idSal);
        }
        public List<Salle> GetAllSalles()
        {
            return _salleRepository.GetAllSalles();
        }

       
    }
}
