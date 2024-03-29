using SinaMN75Api;
using Utilities_aspnet.Utilities;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.SetupUtilities<AppDbContext>(builder.Configuration.GetConnectionString("ServerPostgres")!, UtilitiesDatabaseType.Postgres);
WebApplication app = builder.Build();
app.UseUtilitiesServices();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.Run();
