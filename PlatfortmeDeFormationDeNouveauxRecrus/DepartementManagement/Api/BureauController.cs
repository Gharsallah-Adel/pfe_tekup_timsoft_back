
using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{
    [Route("Bureau")]
    [ApiController]
    public class BureauController : ControllerBase
    {
        private readonly IBureauService _bureauService;
        public BureauController(IBureauService bureauService)
        {

            _bureauService = bureauService;

        }

        [HttpPost]
        [Route("AddBureau")]
        public IActionResult AddProject(BureauDTO bureau)
        {

            Bureau dbbureau = new Bureau();
            dbbureau = _bureauService.AddBureau(bureau);
            return Ok(dbbureau);
        }
        [HttpPut]
        [Route("UpdateBureauById")]

        public IActionResult UpdateBureauById([FromBody] Bureau bureau, int id)
        {
            return Ok(_bureauService.updateBureauById(bureau, id));
        }
        [HttpDelete]
        [Route("DeleteBureau")]

        public IActionResult RemoveBureau(int id)
        {
            return Ok(_bureauService.RemoveBureau(id));


        }
        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetAllBureaus")]

        public IActionResult GetAllBureaus()
        {
            return Ok(_bureauService.GetAllBureaus());
        }

    }
}
