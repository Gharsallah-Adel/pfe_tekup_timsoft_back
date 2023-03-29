using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface IDepartmentService
    {
        public Departement AddDepartement(DepartementDTO departement);
        public string RemoveDepartement(int id);
        public List<Departement> GetAllDepartements();

        public Departement updateDepartmentById(Departement departement, int idDep);
        public int GetDepartementsCount();
    }
}
