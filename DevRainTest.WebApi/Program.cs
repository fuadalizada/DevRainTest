using DevRainTest.DAL.Settings;
using DevRainTest.WebApi.Middleware;
using DevRainTest.WebApi.Utils;

var builder = WebApplication.CreateBuilder(args);

AppSettings.ConnectionString = builder.Configuration.GetSection("ConnectionStrings")["DevRainConString"];

// Add services to the container.
builder.Services.InstallServicesInAssemblies(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ApiKeyMiddleware>();
app.MapControllers();

app.Run();
