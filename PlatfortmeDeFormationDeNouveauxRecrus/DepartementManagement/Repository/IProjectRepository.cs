using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface IProjectRepository
    {
        public Project AddProject(ProjectDTO project);
        public Project UpdateProjectById(Project project, int ProId);
        public string RemoveProject(int id);
       
        public List<Project> GetAllProjects();
    }
}
