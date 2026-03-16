using StudySessionAPI.Models;

namespace StudySessionAPI.Data{
    public class StudySessionStore
    {
        public static List<StudySession> Sessions {get; set;} = new List<StudySession>
        {
            new StudySession {Id = 1, Subject = "Networking", FocusLevel = 4},
            new StudySession {Id = 2, Subject = "Database", FocusLevel = 5},
            new StudySession {Id = 3, Subject = "AI", FocusLevel = 3},
            new StudySession {Id = 4, Subject = "Algorithm", FocusLevel = 2}
        };
    }
}