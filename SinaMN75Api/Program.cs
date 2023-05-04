using SinaMN75Api.Core;
using SinaMN75Api.Hubs;
using Utilities_aspnet.Hubs;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.SetupUtilities<AppDbContext>(builder.Configuration.GetConnectionString("ServerSQLServer"));

builder.Services.AddSignalR();

WebApplication app = builder.Build();

app.UseUtilitiesServices();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.MapHub<MoveViewHub>("/movehub");


app.Run();