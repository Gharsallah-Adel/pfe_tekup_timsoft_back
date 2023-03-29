using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface IProjectService
    {
        public Project AddProject(ProjectDTO project);
        public string RemoveProject(int id);
        public List<Project> GetAllProjects();

        public Project updateProjectById(Project project, int idPro);
    }
}