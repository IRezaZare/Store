using infrastructure.Persistence;
using Infrastructure;
using Infrastructure.Persistence.SeedData;
using Microsoft.EntityFrameworkCore;
using Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddWebServiceCollection();
builder.Services.AddInfrastructureServices(builder.Configuration);
//build
var app = builder.Build();
var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
//get service
var loggerFactory = services.GetRequiredService<ILoggerFactory>();
var context = services.GetRequiredService<ApplicationDbContext>();
//auto migrations
try
{
    await context.Database.MigrateAsync();
    await GenerateFakeData.SeedDataAsync(context ,loggerFactory);
}
catch (Exception e)
{
    var logger = loggerFactory.CreateLogger<Program>();
    logger.LogError(e, "error exception for migrations");
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
