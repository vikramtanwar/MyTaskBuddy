using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTaskBuddy.Models;

public class Ticket
{
    [Key] 
    public int TaskId { get; set; }
    
    [Required]
    [DisplayName("Task Name")]
    public string TaskName { get; set; }
    [Required]
    [DisplayName("Description")]
    public string TaskDescription { get; set; }
    [Required]
    [DisplayName("Status")]
    public string TaskStatusId { get; set; }
    [Required]
    [DisplayName("Task Type")]
    public string TaskType { get; set; }
    [Required]
    [DisplayName("Priority")]
    public string TaskPriority { get; set; }
    
    public string TaskUserId { get; set; }
    [Required]
    [DisplayName("Assigned To")]
    public string TaskAssignedUserId { get; set; }
    
    public bool TaskIsActive { get; set; }

    public DateTime TaskStartDate { get; set; }
    public DateTime TaskEndDate { get; set; }
}