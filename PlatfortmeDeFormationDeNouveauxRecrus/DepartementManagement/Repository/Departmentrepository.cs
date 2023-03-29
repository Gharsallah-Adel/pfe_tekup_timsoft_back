using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class Departmentrepository : IDepartmentRepository 
    {
        private readonly DataBaseContext dataBase;

        public Departmentrepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Departement AddDepartement(DepartementDTO departement)
        {
            Departement dbDepartement = new Departement();
            dbDepartement.DepartementName = departement. DepartementName;
            dbDepartement.Users = new List<User> { };
            dataBase.Add(dbDepartement);
            dataBase.SaveChanges();
            return dbDepartement;
        }
        public int GetDepartementsCount()
        {
            return dataBase.Departements.Count();
        }




        public Departement GetDepartementById(int id)
        {
            throw new NotImplementedException();
        }

      

      

        public Departement UpdateDepartementById(Departement departement, int DepId)
        {

            Departement updtDep = dataBase.Departements.Where(d => d.Departement_id == DepId).FirstOrDefault() ;
            updtDep.DepartementName = departement.DepartementName ;
            dataBase.Departements.Update(updtDep);
            dataBase.SaveChanges();
            return updtDep;
        }
        public string RemoveDepartement(int id)
        {
            Departement delDep = dataBase.Departements.Where(d => d.Departement_id == id).FirstOrDefault();
            dataBase.Departements.Remove(delDep);
            dataBase.SaveChanges();
            return "deleted successfully";
        }
        public List<Departement> GetAllDepartements()
        {
            List<Departement> departements = new List<Departement>();
            departements = dataBase.Departements.ToList();
            return departements;
        }

    }
}
