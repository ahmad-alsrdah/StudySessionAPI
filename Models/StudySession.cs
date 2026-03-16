using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace StudySessionAPI.Models
{
    public class StudySession
    {
        public int Id {get; set;}
        [Required]
        [MinLength(3)]
        public required string Subject {get; set;}
        public DateTime StartTime {get; set;}
        public DateTime EndTime {get; set;}
        [Required]
        [Range(1,5)]
        public int FocusLevel {get; set;}
        [AllowNull]
        public string Notes {get; set;} = "No Thing.";
    }
}