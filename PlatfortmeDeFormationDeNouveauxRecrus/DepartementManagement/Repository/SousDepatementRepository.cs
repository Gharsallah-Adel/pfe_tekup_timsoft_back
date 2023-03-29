using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class SousDepartmentrepository : ISousDepartmentRepository
    {
        private readonly DataBaseContext dataBase;

        public SousDepartmentrepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public SousDepartement AddSousDepartement(string SousDepartementName)
        {
            SousDepartement dbSousDepartement = new SousDepartement();
            dbSousDepartement.SousDepartementName = SousDepartementName;
         
            dataBase.Add(dbSousDepartement);
            dataBase.SaveChanges();
            return dbSousDepartement;
        }

        public SousDepartement GetSousDepartementById(int id)
        {
            throw new NotImplementedException();
        }


        public SousDepartement UpdateSousDepartementById(SousDepartement sousDepartement, int SDepId)
        {

            SousDepartement updtSDep = dataBase.SousDepartements.Where(sd => sd.SousDepartement_id == SDepId).FirstOrDefault();
            updtSDep.SousDepartementName = sousDepartement.SousDepartementName;
            dataBase.SousDepartements.Update(updtSDep);
            dataBase.SaveChanges();
            return updtSDep;
        }
        public string RemoveSousDepartement(int id)
        {
            SousDepartement delSDep = dataBase.SousDepartements.Where(sd => sd.SousDepartement_id == id).FirstOrDefault();
            dataBase.SousDepartements.Remove(delSDep);
            dataBase.SaveChanges();
            return "deleted successfully";
        }
    }
}
