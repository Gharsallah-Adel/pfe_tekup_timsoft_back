using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DataBaseContext dataBase;

        public ProjectRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Project AddProject(ProjectDTO project)
        {
            Project dbProject = new Project(); 
           dbProject.Description = project.Description;
            dbProject.NameD = project.NameD;
            dataBase.Add(dbProject);
            dataBase.SaveChanges();
            return dbProject;
        }



       



        public Project UpdateProjectById(Project project, int ProId)
        {

            Project updtPro = dataBase.Projects.Where(d => d.Project_id == ProId).FirstOrDefault();
            updtPro.Description = project.Description;
            updtPro.NameD = project.NameD;
            dataBase.Projects.Update(updtPro);
            dataBase.SaveChanges();
            return updtPro;
        }
        public string RemoveProject(int id)
        {
            Project delPro = dataBase.Projects.Where(p => p.Project_id == id).FirstOrDefault();
            dataBase.Projects.Remove(delPro);
            dataBase.SaveChanges();
            return "deleted successfully";
        }
        public List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();
            projects = dataBase.Projects.ToList();
            return projects;
        }

    }
}
