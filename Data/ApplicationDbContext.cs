using Microsoft.EntityFrameworkCore;
using UniversityExam.Models.Entities;

namespace UniversityExam.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Student> Students { get; set; } 
    }
}
