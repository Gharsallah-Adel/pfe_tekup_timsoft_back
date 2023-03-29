using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{
    [Route("SousDepartement")]
    [ApiController]
    public class SousDepartementController : ControllerBase
    {
        private readonly ISousDepartmentService _sousDepartmentService;
        public SousDepartementController(ISousDepartmentService sousDepartementService)
        {

            _sousDepartmentService = sousDepartementService;

        }

        [HttpPost]
        [Route("AddSousDepartement")]
        public IActionResult AddSousDepartement(string SousDepartementName)
        {
            return Ok(_sousDepartmentService.AddSousDepartement(SousDepartementName));
        }

        [HttpPut]
        [Route("UpdateSousDepartmentById")]

        public IActionResult UpdateSousDepartmentById([FromBody] SousDepartement sousDepartment, int id)
        {
            return Ok(_sousDepartmentService.updateSousDepartmentById(sousDepartment, id));
        }
        [HttpDelete]
        [Route("DeleteSousDepartementById")]

        public IActionResult RemoveSousDepartment(int id)
        {
            return Ok(_sousDepartmentService.RemoveSousDepartement(id));


        }
    }
}
