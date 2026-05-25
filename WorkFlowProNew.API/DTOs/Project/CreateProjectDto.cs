using System.ComponentModel.DataAnnotations;

namespace WorkFlowProNew.API.DTOs.Project
{
    public class CreateProjectDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
            = string.Empty;

        public string Description { get; set; }
            = string.Empty;
    }
}