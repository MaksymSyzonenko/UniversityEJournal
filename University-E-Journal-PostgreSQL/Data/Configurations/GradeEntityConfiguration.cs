using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Configurations
{
    public sealed class GradeEntityConfiguration : IEntityTypeConfiguration<GradeEntity>
    {
        public void Configure(EntityTypeBuilder<GradeEntity> builder)
        {
            builder.ToTable("Grades");
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Value).IsRequired();
            builder.Property(g => g.Date).IsRequired();

            builder.HasOne(g => g.Student)
                .WithMany(st => st.Grades)
                .HasForeignKey(g => g.StudentID);

            builder.HasOne(g => g.Subject)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.SubjectID);

            builder.HasOne(g => g.Teacher)
                .WithMany(t => t.Grades)
                .HasForeignKey(g => g.TeacherID);
        }
    }
}
