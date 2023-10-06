using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Configurations
{
    public sealed class SubjectEntityConfiguration : IEntityTypeConfiguration<SubjectEntity>
    {
        public void Configure(EntityTypeBuilder<SubjectEntity> builder)
        {
            builder.ToTable("Subjects");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name).IsRequired();

            builder.HasOne(s => s.Teacher)
                .WithMany(t => t.Subjects)
                .HasForeignKey(s => s.TeacherId);

            builder.HasMany(s => s.Grades)
                .WithOne(g => g.Subject)
                .HasForeignKey(g => g.SubjectId);

            builder.HasMany(s => s.Students)
                .WithMany(st => st.Subjects)
                .UsingEntity(j => j.ToTable("StudentSubjects"));
        }
    }
}
