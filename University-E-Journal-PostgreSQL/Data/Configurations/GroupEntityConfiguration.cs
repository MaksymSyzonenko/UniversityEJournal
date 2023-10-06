using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_E_Journal_PostgreSQL.Data.Entities;

namespace University_E_Journal_PostgreSQL.Data.Configurations
{
    public sealed class GroupEntityConfiguration : IEntityTypeConfiguration<GroupEntity>
    {
        public void Configure(EntityTypeBuilder<GroupEntity> builder)
        {
            builder.ToTable("Groups");
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name).IsRequired();
            builder.Property(g => g.Departmant).IsRequired();

            builder.HasMany(g => g.Students)
                .WithOne(st => st.Group)
                .HasForeignKey(st => st.GroupId);
        }
    }
}
