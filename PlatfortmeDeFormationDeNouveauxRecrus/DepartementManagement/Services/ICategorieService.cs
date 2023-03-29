using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface ICategorieService
    {

        public Categorie AddCategorie(string CategorieName);
        public string RemoveCategorie(int id);

        public Categorie updateCategorieById(Categorie categorie, int idSDep);
    }
}