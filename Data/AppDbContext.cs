using Microsoft.EntityFrameworkCore;
using StudySessionAPI.Models;

namespace StudySessionAPI.Data{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}
        public DbSet<StudySession>StudySessions {get; set;}
    }
}