using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly ICategorieRepository _categorieRepository;
        public CategorieService(ICategorieRepository categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }

     

        public Categorie AddCategorie(string CategorieName)
        {
            return _categorieRepository.AddCategorie(CategorieName);
        }

     
        public string RemoveCategorie(int id)
        {
            return _categorieRepository.RemoveCategorie(id);
        }

      

        public Categorie updateCategorieById(Categorie categorie, int idSDep)
        {
            return _categorieRepository.UpdateCategorieById(categorie, idSDep);
        }
    }
}