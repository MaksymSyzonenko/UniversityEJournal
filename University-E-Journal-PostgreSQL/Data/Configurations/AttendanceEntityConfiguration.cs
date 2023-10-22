using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Configurations
{
    public sealed class AttendanceEntityConfiguration : IEntityTypeConfiguration<AttendanceEntity>
    {
        public void Configure(EntityTypeBuilder<AttendanceEntity> builder)
        {
            builder.ToTable("Attendances");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.AttendDate).IsRequired();
            builder.Property(a => a.Attended).IsRequired();

            builder.HasOne(a => a.Student)
                .WithMany(st => st.Attendances)
                .HasForeignKey(a => a.StudentId);

            builder.HasOne(a => a.Subject)
                .WithMany(s => s.Attendances)
                .HasForeignKey(a => a.SubjectId);
        }
    }
}
