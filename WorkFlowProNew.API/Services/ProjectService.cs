using WorkFlowProNew.API.DTOs.Project;
using WorkFlowProNew.API.Interfaces;
using WorkFlowProNew.API.Models;

namespace WorkFlowProNew.API.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _repository;

        public ProjectService(IProjectRepository repository)
        {
            _repository = repository;
        }


        public void Create(
            CreateProjectDto request)
        {
            var project = new Project
            {
                Name = request.Name,
                Description =
                    request.Description
            };

            _repository.Add(project);
        }


        public List<ProjectResponseDto> GetAll()
        {
            return _repository.GetAll().Select(x => new ProjectResponseDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CreatedAt =
                            x.CreatedAt
            }).ToList();
        }


        public ProjectResponseDto? GetById(int id)
        {
            var project = _repository.GetById(id);

            return new ProjectResponseDto
            {
                Id=project.Id,
                Name = project.Name,
                Description =
                    project.Description,

                CreatedAt =
                    project.CreatedAt
            };

        }




    }
}
