using Application;
using Infrastructure;
using Web;

var builder = WebApplication.CreateBuilder(args);
builder.AddWebConfigureServices();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
//build
var app = builder.Build();
app.UseStaticFiles();

await app.AddWebAppService().ConfigureAwait(false);
