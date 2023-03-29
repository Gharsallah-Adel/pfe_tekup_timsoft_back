using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface ISousDepartmentRepository
    {
        public SousDepartement AddSousDepartement(string SousDepartementName);
        public SousDepartement UpdateSousDepartementById(SousDepartement sousDepartement, int SDepId);
        public string RemoveSousDepartement(int id);
        public SousDepartement GetSousDepartementById(int id);
    }
}