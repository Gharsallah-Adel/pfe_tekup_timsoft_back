using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise;

namespace PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Api
{
    [Route("PlanFormation")]
    [ApiController]
    public class PlanFormationController : ControllerBase
    {
        private readonly IPlanFormationService _planFormationService;
        public PlanFormationController(IPlanFormationService planFormationService)
        {

            _planFormationService = planFormationService;

        }

        [HttpPost]
        [Route("AddPlanFormation")]
        public IActionResult AddPlanFormation([FromBody] PlanFormationDTO planFormation)
        {
            return Ok(_planFormationService.AddPlanFormation(planFormation));
        }



        [HttpPut]
        [Route("UpdatePlanFormationById")]

        public IActionResult UpdatePlanFormationById([FromBody] PlanFormation planFormation, int id)
        {
            return Ok(_planFormationService.updatePlanFormationById(planFormation, id));
        }

        [HttpDelete]
        [Route("DeletePlanFormationById")]

        public IActionResult RemovePlanFormation(int id)
        {
            return Ok(_planFormationService.RemovePlanFormation(id));


        }


    }
}
