using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Api
{
    [Route("Formation")]
    [ApiController]
    public class FormationController : ControllerBase
    {
        private readonly IFormationService _formationService;
        public FormationController(IFormationService formationService)
        {

            _formationService = formationService;

        }

        [HttpPost]
        [Route("AddFormation")]
        public IActionResult AddFormation(FormationDTO formation)
        {
            return Ok(_formationService.AddFormation(formation));
        }

       

        [HttpPut]
        [Route("UpdateFormationById")]

        public IActionResult UpdateFormationById([FromBody] Formation formation, int id)
        {
            return Ok(_formationService.updateFormationById(formation, id));
        }

        [HttpDelete]
        [Route("DeleteFormationById")]

        public IActionResult RemoveFormation(int id)
        {
            return Ok(_formationService.RemoveFormation(id));

        }
        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetAllFormations")]

        public IActionResult GetAllFormations()
        {
            return Ok(_formationService.GetAllFormations());
        }

        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetFormationCount")]

        public IActionResult GetUsersCount()
        {
            return Ok(_formationService.GetFormationsCount());
        }



    }
}

