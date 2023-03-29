

using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface ISousDepartmentService
    {
        public SousDepartement AddSousDepartement(string SousDepartementName);
        public string RemoveSousDepartement(int id);

        public SousDepartement updateSousDepartmentById(SousDepartement sousDepartement, int idSDep);
    }
}