using f1DotnetTeste.API.Entities;
using f1DotnetTeste.API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("Dbconection");
builder.Services.AddDbContext<MEUDBContext>(o => o.UseSqlServer(connectionString));
//builder.Services.AddDbContext<MEUDBContext>(o => o.UseInMemoryDatabase("DBlocal"));

//builder.Services.AddSingleton<DBContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
