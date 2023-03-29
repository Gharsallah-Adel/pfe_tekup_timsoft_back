using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Api
{
    [Route("Salle")]
    [ApiController]
    public class SalleController : ControllerBase
    {
        private readonly ISalleService _salleService;
        public SalleController(ISalleService salleService)
        {

            _salleService = salleService;

        }

        [HttpPost]
        [Route("AddSalle")]
        public IActionResult AddSalle(SalleDTO salle)
        {
            return Ok(_salleService.AddSalle(salle));
        }



        [HttpPut]
        [Route("UpdateSalleById")]

        public IActionResult UpdateSalleById([FromBody] Salle salle, int id)
        {
            return Ok(_salleService.updateSalleById(salle, id));
        }

        [HttpDelete]
        [Route("DeleteSalleById")]

        public IActionResult RemoveSalle(int id)
        {
            return Ok(_salleService.RemoveSalle(id));

        }
        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetAllSalle")]

        public IActionResult GetAllSalles()
        {
            return Ok(_salleService.GetAllSalles());
        }


    }
}
