using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public class BureauService : IBureauService
    {
        private readonly IBureauRepository _bureauRepository;
        public BureauService(IBureauRepository bureauRepository)
        {
            _bureauRepository = bureauRepository;
        }

        public Bureau AddBureau(BureauDTO bureau)
        {
            return _bureauRepository.AddBureau(bureau);
        }

        public string RemoveBureau(int id)
        {
            return _bureauRepository.RemoveBureau(id);
        }
        public List<Bureau> GetAllBureaus()
        {
            return _bureauRepository.GetAllBureaus();
        }

        public Bureau updateBureauById(Bureau bureau, int idBur)
        {
            return _bureauRepository.UpdateBureauById(bureau, idBur);
        }
    }
}
