using AutoMapper;
using DevRainTest.Business.MapConfiguration;
using DevRainTest.Business.Services.Abstract;
using DevRainTest.Business.Services.Concrete;
using DevRainTest.DAL.DbContext;
using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.DAL.Repositories.Concrete;
using DevRainTest.DAL.Settings;
using DevRainTest.WebApi.MapConfiguration;
using DevRainTest.WebApi.ServiceFacades;
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

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddAutoMapper(typeof(MapperConfig), typeof(MapConfig));

            DependencyInjectionRepositories(services);
            DependencyInjectionServices(services);
            DependencyInjectionFacades(services);
            //DependencyInjectionMappers(services);
        }

        public void DependencyInjectionRepositories(IServiceCollection service)
        {
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUserLoginAttemptRepository, UserLoginAttemptRepository>();
        }

        public void DependencyInjectionServices(IServiceCollection service)
        {
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IUserLoginAttemptService, UserLoginAttemptService>();
        }
        public void DependencyInjectionFacades(IServiceCollection service)
        {
            service.AddScoped<UserServiceFacade>();
            service.AddScoped<UserLoginAttemptServiceFacade>();
        }

        //private void DependencyInjectionMappers(IServiceCollection service)
        //{
        //    var mapConfig = new MapperConfiguration(config => { config.AddProfile(new MapperConfig()); });
        //    var mapConfg = new MapperConfiguration(config => { config.AddProfile(new MapConfig()); });
        //    IMapper mapper = mapConfig.CreateMapper();
        //    IMapper mapp = mapConfg.CreateMapper();
        //    service.AddSingleton(mapper);
        //    service.AddSingleton(mapp);
        //}
    }
}
