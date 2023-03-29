using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;
using System.Reflection.Metadata.Ecma335;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{
    [Route("Project")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {

            _projectService = projectService;

        }

        [HttpPost]
        [Route("AddProject")]
        public IActionResult AddProject(ProjectDTO project)
        {

            Project dbproject = new Project();
            dbproject = _projectService.AddProject(project);
            return Ok(dbproject);
        }

        [HttpPut]
        [Route("UpdateProjectById")]

        public IActionResult UpdateProjectById([FromBody] Project project, int id)
        {
            return Ok(_projectService.updateProjectById(project, id));
        }
        [HttpDelete]
        [Route("DeleteProject")]

        public IActionResult RemoveProject(int id)
        {
            return Ok(_projectService.RemoveProject(id));


        }
        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetAllProjects")]

        public IActionResult GetAllProjects()
        {
            return Ok(_projectService.GetAllProjects());
        }

    }
}

