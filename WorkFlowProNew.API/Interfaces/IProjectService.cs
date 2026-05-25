using WorkFlowProNew.API.DTOs.Project;

namespace WorkFlowProNew.API.Interfaces
{
    public interface IProjectService
    {
        void Create(CreateProjectDto request);

        List<ProjectResponseDto> GetAll();

        ProjectResponseDto? GetById(int id);
    }
}