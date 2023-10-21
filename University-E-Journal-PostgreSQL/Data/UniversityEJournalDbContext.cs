using Microsoft.EntityFrameworkCore;
using System.Reflection;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data
{
    public sealed class UniversityEJournalDbContext : DbContext
    {
        public UniversityEJournalDbContext(DbContextOptions<UniversityEJournalDbContext> options)
        : base(options)
        {
        }
        public DbSet<TeacherEntity> Teachers { get; set; }
        public DbSet<SubjectEntity> Subjects { get; set; }
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<GradeEntity> Grades { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<AttendanceEntity> Attendances { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
