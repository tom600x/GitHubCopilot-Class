using System.ComponentModel.DataAnnotations;

namespace CopilotDemo.Models
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High,
        Urgent
    }

    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Task Title")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [StringLength(300)]
        public string? Description { get; set; }

        [Display(Name = "Category")]
        [StringLength(50)]
        public string Category { get; set; } = "General";

        [Display(Name = "Priority")]
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
