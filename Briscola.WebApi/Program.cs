using Briscola.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

var builder = WebApplication.CreateBuilder(args);
//ModelBuilder modelBuilder = new ModelBuilder();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register StudentsRepository as singleton in DI container
//builder.Services.AddSingleton(_ => new StudentsRepository(1000));

//modelBuilder.Entity<GameResult>().ToTable("GameResult");

builder.Services.AddSingleton(_=> new UserRepository());
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

app.MapControllers();

app.Run();