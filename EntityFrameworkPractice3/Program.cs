using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EntityFrameworkPractice3.Data;
using EntityFrameworkPractice3.Controllers;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EntityFrameworkPractice3Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EntityFrameworkPractice3Context") ?? throw new InvalidOperationException("Connection string 'EntityFrameworkPractice3Context' not found.")));

// Add services to the container.

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

app.MapDepartmentEndpoints();

app.Run();
