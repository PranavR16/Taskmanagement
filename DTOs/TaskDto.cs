using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Api.DTOs
{
    public class TaskDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public string Notes { get; set; }

        public string AttachmentUrl { get; set; }

        [Required]
        public int AssignedToEmployeeId { get; set; }
    }
}
