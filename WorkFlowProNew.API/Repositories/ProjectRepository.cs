using WorkFlowProNew.API.Data;
using WorkFlowProNew.API.Interfaces;
using WorkFlowProNew.API.Models;

namespace WorkFlowProNew.API.Repositories
{
    public class ProjectRepository
        : IProjectRepository
    {
        private readonly AppDbContext _context;

        public ProjectRepository(
            AppDbContext context)
        {
            _context = context;
        }

        public void Add(Project project)
        {
            _context.Projects.Add(project);

            _context.SaveChanges();
        }

        public List<Project> GetAll()
        {
            return _context.Projects.ToList();
        }

        public Project? GetById(int id)
        {
            return _context.Projects.Find(id);
                
        }
    }
}