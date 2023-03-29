using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface IBureauService
    {
        public Bureau AddBureau(BureauDTO bureau);
        public string RemoveBureau(int id);
        public List<Bureau> GetAllBureaus();

        public Bureau updateBureauById(Bureau bureau, int idBur);
    }
}
