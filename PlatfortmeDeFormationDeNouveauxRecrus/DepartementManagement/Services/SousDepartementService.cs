using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public class SousDepartementService : ISousDepartmentService
    {
        private readonly ISousDepartmentRepository _sousDepartementRepository;
        public SousDepartementService(ISousDepartmentRepository sousDepartementRepository)
        {
            _sousDepartementRepository = sousDepartementRepository;
        }

        public SousDepartement AddSousDepartement(string SousDepartementName)
        {
            return _sousDepartementRepository.AddSousDepartement(SousDepartementName);
        }

        public string RemoveSousDepartement(int id)
        {
            return _sousDepartementRepository.RemoveSousDepartement(id);
        }

        public SousDepartement updateSousDepartmentById(SousDepartement sousDepartement, int idSDep)
        {
            return _sousDepartementRepository.UpdateSousDepartementById(sousDepartement, idSDep);
        }
    }
}
