using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public class Departmentservice : IDepartmentService
    {
        private readonly IDepartmentRepository _departementRepository;
        public Departmentservice(IDepartmentRepository departementRepository)
        {
            _departementRepository = departementRepository;
        }

        public Departement AddDepartement(DepartementDTO departement)
        {
            return _departementRepository.AddDepartement(departement);
        }

        public string RemoveDepartement(int id)
        {
            return  _departementRepository.RemoveDepartement(id);
        }
        public List<Departement> GetAllDepartements()
        {
            return _departementRepository.GetAllDepartements();
        }
        public int GetDepartementsCount()
        {
            return _departementRepository.GetDepartementsCount();
        }


        public Departement updateDepartmentById(Departement departement, int idDep)
        {
            return _departementRepository.UpdateDepartementById(departement, idDep);    
        }
    }
}
