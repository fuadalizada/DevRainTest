using AutoMapper;
using DevRainTest.Business.MapConfiguration;
using DevRainTest.Business.Services.Abstract;
using DevRainTest.Business.Services.Concrete;
using DevRainTest.DAL.DbContext;
using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.DAL.Repositories.Concrete;
using DevRainTest.DAL.Settings;
using Microsoft.EntityFrameworkCore;

namespace DevRainTest.WebApi.Utils
{
    public class ServiceConfiguration : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DevRainDbContext>(option => {
                option.UseSqlServer(AppSettings.ConnectionString);
            });

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            DependencyInjectionRepositories(services);
            DependencyInjectionServices(services);
        }

        public void DependencyInjectionRepositories(IServiceCollection service)
        {
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUserLoginAttemptRepository, UserLoginAttemptRepository>();
        }

        public void DependencyInjectionServices(IServiceCollection service)
        {
            service.AddScoped<IUserService, UserService>();
        }

        private void DependencyInjectionMappers(IServiceCollection service)
        {
            var mapConfig = new MapperConfiguration(config => { config.AddProfile(new MapperConfig()); });
            IMapper mapper = mapConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
