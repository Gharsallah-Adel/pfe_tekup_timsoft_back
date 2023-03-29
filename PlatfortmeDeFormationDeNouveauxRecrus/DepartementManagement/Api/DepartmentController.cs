using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{
    [Route("Departement")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departementService)
        {

            _departmentService = departementService;

        }

        [HttpPost]
        [Route("AddDepartement")]
        public IActionResult AddDepartement(DepartementDTO departement)
        {

            Departement dbdepartement = new Departement();
            dbdepartement = _departmentService.AddDepartement(departement);
            return Ok(dbdepartement);
        }

        [HttpPut]
        [Route("UpdateDepartmentById")]

        public IActionResult UpdateDepartementById([FromBody] Departement department, int id)
        {
            return Ok(_departmentService.updateDepartmentById(department, id));
        }
        [HttpDelete]
        [Route("DeleteDepartement")]

        public IActionResult RemoveDepartment(int id)
        {
            return Ok(_departmentService.RemoveDepartement(id));


        }
        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetAllDepartements")]

        public IActionResult GetAllDepartements()
        {
            return Ok(_departmentService.GetAllDepartements());
        }

        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetDepartementCount")]

        public IActionResult GetDepartementsCount()
        {
            return Ok(_departmentService.GetDepartementsCount());
        }

    }
}

