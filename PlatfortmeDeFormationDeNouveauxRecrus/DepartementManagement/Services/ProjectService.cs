using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public Project AddProject(ProjectDTO project)
        {
            return _projectRepository.AddProject(project);
        }

        public string RemoveProject(int id)
        {
            return _projectRepository.RemoveProject(id);
        }
        public List<Project> GetAllProjects()
        {
            return _projectRepository.GetAllProjects();
        }

        public Project updateProjectById(Project project, int idPro)
        {
            return _projectRepository.UpdateProjectById(project, idPro);
        }
    }
}
