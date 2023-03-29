using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface ICategorieRepository
    {
        public Categorie AddCategorie(string CategorieName);
        public Categorie UpdateCategorieById(Categorie categorie, int catId);
        public string RemoveCategorie(int id);
       
    }
}
