using System.ComponentModel.DataAnnotations;

namespace WorkFlowProNew.API.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
            = string.Empty;

        public string Description { get; set; }
            = string.Empty;

        public string Status { get; set; }
            = "Pending";

        public int ProjectId { get; set; }

        public Project? Project { get; set; }

        public int AssignedUserId { get; set; }

        public User? AssignedUser { get; set; }

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;
    }
}