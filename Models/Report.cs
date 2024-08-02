namespace TaskManagementSystem.Api.Models
{
    public class Report
    {
        public int Reportid { get; set; }
        public string TeamName { get; set; }
        public int TaskCount { get; set; }
        public int CompletedTasks { get; set; }
        public int PendingTasks { get; set; }
        public string Period { get; set; } // Weekly or Monthly
    }
}
