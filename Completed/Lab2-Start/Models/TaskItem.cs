using System.ComponentModel.DataAnnotations;

namespace CopilotDemo.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Task Title")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [StringLength(300)]
        public string? Description { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
