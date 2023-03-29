using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{
    [Route("Categorie")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly ICategorieService _categorieService;
        public CategorieController(ICategorieService categorieService)
        {

            _categorieService = categorieService;

        }

        [HttpPost]
        [Route("AddCategorie")]
        public IActionResult AddCategorie(string CategorieName)
        {
            return Ok(_categorieService.AddCategorie(CategorieName));
        }

        [HttpPut]
        [Route("UpdateCategorieById")]

        public IActionResult UpdateCategorieById([FromBody] Categorie categorie, int id)
        {
            return Ok(_categorieService.updateCategorieById(categorie, id));
        }
        [HttpDelete]
        [Route("DeleteCategorieById")]

        public IActionResult RemoveCategorie(int id)
        {
            return Ok(_categorieService.RemoveCategorie(id));


        }
    }
}
