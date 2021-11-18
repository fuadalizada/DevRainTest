using DevRainTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevRainTest.DAL.ModelConfiguration
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TBL_USER");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p=>p.Name).HasColumnName("NAME").HasColumnType("nvarchar(30)");
            builder.Property(p=>p.Surname).HasColumnName("SURNAME").HasColumnType("nvarchar(30)");
            builder.Property(p=>p.Email).HasColumnName("EMAIL").HasColumnType("nvarchar(25)");
        }
    }
}
