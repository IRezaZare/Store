using Application;
using Infrastructure;
using Microsoft.AspNetCore.Diagnostics;
using Web;
using Web.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.AddWebConfigureServices();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
//build
var app = builder.Build();
app.UseMiddleware<MiddlewareExceptionHandler>();
app.UseStaticFiles();

await app.AddWebAppService().ConfigureAwait(false);
