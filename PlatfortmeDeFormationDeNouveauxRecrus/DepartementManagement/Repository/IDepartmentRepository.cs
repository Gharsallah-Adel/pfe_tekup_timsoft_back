using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface IDepartmentRepository
    {
        public Departement AddDepartement( DepartementDTO depatement);
        public Departement UpdateDepartementById(Departement departement ,int DepId);
        public string RemoveDepartement(int id);
        public Departement GetDepartementById(int id);
        public List<Departement> GetAllDepartements();
        public int GetDepartementsCount();
    }
}
