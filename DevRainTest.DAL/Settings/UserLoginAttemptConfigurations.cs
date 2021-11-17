using DevRainTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevRainTest.DAL.Settings
{
    public class UserLoginAttemptConfigurations : IEntityTypeConfiguration<UserLoginAttempt>
    {
        public void Configure(EntityTypeBuilder<UserLoginAttempt> builder)
        {
            throw new NotImplementedException();
        }
    }
}
