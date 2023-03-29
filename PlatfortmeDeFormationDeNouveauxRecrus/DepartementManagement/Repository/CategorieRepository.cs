using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class CategorieRepository : ICategorieRepository
    {

        private readonly DataBaseContext dataBase;

        public CategorieRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Categorie AddCategorie(string CategorieName)
        {
            Categorie dbCategorie = new Categorie();
            dbCategorie.CategorieName = CategorieName;
        
            dataBase.Add(dbCategorie);
            dataBase.SaveChanges();
            return dbCategorie;
        }


        public string RemoveCategorie(int id)
        {
            Categorie cat = dataBase.Categories.Where(c => c.Categorie_id == id).FirstOrDefault();
            dataBase.Categories.Remove(cat);
            dataBase.SaveChanges();
            return "Categorie deleted ";
        }

        public Categorie UpdateCategorieById(Categorie categorie, int catId)
        {

            var updtCat = dataBase.Categories.Where(cat => cat.Categorie_id == catId).FirstOrDefault();
            updtCat.CategorieName = categorie.CategorieName;
            dataBase.Categories.Update(updtCat);
            dataBase.SaveChanges();
            return updtCat;
        }

    }

}
