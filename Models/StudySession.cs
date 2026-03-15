namespace StudySessionAPI.Models
{
    public class StudySession
    {
        public int Id {get; set;}
        public required string Subject {get; set;}
        public DateTime StartTime {get; set;}
        public DateTime EndTime {get; set;}
        public int FocusLevel {get; set;} // 1 - 5
        public string? Notes {get; set;}
    }
}