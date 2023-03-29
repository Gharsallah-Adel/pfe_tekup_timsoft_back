using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface IBureauRepository
    {
        public Bureau AddBureau(BureauDTO bureau);
        public Bureau UpdateBureauById(Bureau bureau, int BurId);
        public string RemoveBureau(int id);
      
        public List<Bureau> GetAllBureaus();
    }
}
