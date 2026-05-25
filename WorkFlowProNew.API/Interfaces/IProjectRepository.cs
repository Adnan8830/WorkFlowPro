using WorkFlowProNew.API.Models;

namespace WorkFlowProNew.API.Interfaces
{
    public interface IProjectRepository
    {
        void Add(Project project);

        List<Project> GetAll();

        Project? GetById(int id);
    }
}