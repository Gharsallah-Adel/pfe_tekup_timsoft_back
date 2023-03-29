using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Repository
{
    public class ReclamationRepository : IReclamationRepository
    {
        private readonly DataBaseContext dataBase;

        public ReclamationRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }
        public List<Reclamation> GetAllReclamations()
        {
            List<Reclamation> reclamations = new List<Reclamation>();
            reclamations = dataBase.Reclamations.ToList();
            return reclamations;
        }

        public Reclamation AddReclamation(ReclamationDTO reclamation)
        {
            Reclamation dbReclamation = new Reclamation();
            dbReclamation.Description = reclamation.Description;

            dataBase.Add(dbReclamation);
            dataBase.SaveChanges();
            return dbReclamation;
        }

      
        public string RemoveReclamation(int id)
        {
            Reclamation delRec = dataBase.Reclamations.Where(r => r.Reclamation_id == id).FirstOrDefault();
            dataBase.Reclamations.Remove(delRec);
            dataBase.SaveChanges();
            return "deleted successfully";
        }

        
    }
}