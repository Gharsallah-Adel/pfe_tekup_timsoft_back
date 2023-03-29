using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Entitie.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Service;

namespace PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Api
{
    [Route("Reclamation")]
    [ApiController]
    public class ReclamationController : ControllerBase
    {
        private readonly IReclamationService reclamationService;

        public ReclamationController(IReclamationService reclamationService)
        {
            this.reclamationService = reclamationService;
        }

        [HttpPost]
        [Route("AddReclamation")]
        public IActionResult AddReclamation(ReclamationDTO reclamation)
        {
            return Ok(reclamationService.AddReclamation(reclamation));
        }



        [HttpDelete]
        [Route("DeleteReclamationById")]
        public IActionResult RemoveReclamation(int id)
        {
            return Ok(reclamationService.RemoveReclamation(id));
        }


        



        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetAllReclamations")]

        public IActionResult GetAllReclamations()
        {
            return Ok(reclamationService.GetAllReclamations());
        }



    }
}

