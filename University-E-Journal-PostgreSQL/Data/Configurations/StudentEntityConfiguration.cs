using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Configurations
{
    public sealed class StudentEntityConfiguration : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(st => st.Id);

            builder.Property(st => st.FirstName).IsRequired();
            builder.Property(st => st.LastName).IsRequired();
            builder.Property(st => st.YearStudyStart).IsRequired();

            builder.HasMany(st => st.Grades)
                .WithOne(g => g.Student)
                .HasForeignKey(g => g.StudentId);

            builder.HasMany(st => st.Subjects)
                .WithMany(s => s.Students)
                .UsingEntity(j => j.ToTable("StudentSubjects"));
        }
    }
}
