using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository
{
    public class SalleRepository : ISalleRepository
    {
        private readonly DataBaseContext dataBase;

        public SalleRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Salle AddSalle(SalleDTO salle)
        {
            Salle dbSalle = new Salle();
            dbSalle.NameSalle = salle.NameSalle;
            dbSalle.BureauName = salle.BureauName;

            dataBase.Add(dbSalle);
            dataBase.SaveChanges();
            return dbSalle;
        }



        public List<Salle> GetAllSalles()
        {
            List<Salle> salles = new List<Salle>();
            salles = dataBase.Salles.ToList();
            return salles;
        }





        public string RemoveSalle(int id)
        {
            Salle delSal = dataBase.Salles.Where(sd => sd.Salle_id == id).FirstOrDefault();
            dataBase.Salles.Remove(delSal);
            dataBase.SaveChanges();
            return "deleted successfully";
        }

          

        public Salle UpdateSalle(Salle salle, int idSal)
        {
            Salle updtSal = dataBase.Salles.Where(s => s.Salle_id == idSal).FirstOrDefault();
            updtSal.NameSalle = salle.NameSalle;
            dataBase.Salles.Update(updtSal);
            dataBase.SaveChanges();
            return updtSal;

        }
    }
}


