using Application;
using Infrastructure;
using Web;

var builder = WebApplication.CreateBuilder(args);
builder.AddWebConfigureServices();
builder.Services.AddAplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
//build
var app = builder.Build();
await app.AddWebAppService().ConfigureAwait(false);
