using DevRainTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevRainTest.DAL.ModelConfiguration
{
    public class UserLoginAttemptConfigurations : IEntityTypeConfiguration<UserLoginAttempt>
    {
        public void Configure(EntityTypeBuilder<UserLoginAttempt> builder)
        {
            builder.ToTable("TBL_USER_LOGIN_ATTEMPT");
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.IsSuccess).HasColumnName("ISSUCCESS").HasColumnType("bit");
            builder.Property(p => p.UserId).HasColumnName("USER_ID").IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.UserLoginAttempts).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
