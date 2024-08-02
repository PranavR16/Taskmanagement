using System;

namespace TaskManagementSystem.Api.Models
{
    public class Taskss
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string AttachmentUrl { get; set; }
        public int AssignedToEmployeeId { get; set; }
    }
}
