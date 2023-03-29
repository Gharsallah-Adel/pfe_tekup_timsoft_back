using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class BureauRepository : IBureauRepository
    {
        private readonly DataBaseContext dataBase;

        public BureauRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Bureau AddBureau(BureauDTO bureau)
        {
            Bureau dbBureau = new Bureau();
            dbBureau.BureauName = bureau.BureauName;
            dbBureau.Address = bureau.Address;

            dataBase.Add(dbBureau);
            dataBase.SaveChanges();
            return dbBureau;
        }





        public Bureau UpdateBureauById(Bureau bureau, int BurId)
        {

            Bureau updtBur = dataBase.Bureaus.Where(b => b.Bureau_id == BurId).FirstOrDefault();
            updtBur.BureauName = bureau.BureauName;
            updtBur.Address = bureau.Address;
            dataBase.Bureaus.Update(updtBur);
            dataBase.SaveChanges();
            return updtBur;
        }
        public string RemoveBureau(int id)
        {
            Bureau delBur = dataBase.Bureaus.Where(b => b.Bureau_id == id).FirstOrDefault();
            dataBase.Bureaus.Remove(delBur);
            dataBase.SaveChanges();
            return "deleted successfully";
        }
        public List<Bureau> GetAllBureaus()
        {
            List<Bureau> bureaus = new List<Bureau>();
            bureaus = dataBase.Bureaus.ToList();
            return bureaus;
        }

    }
}