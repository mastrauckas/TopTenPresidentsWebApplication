using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using TopTenPresidents.Data.DbContexts;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TopTenPresidentsDbContext>(db => db.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.MapGet("/GetPresidents", async () => await Task.FromResult(Results.StatusCode(501)));

app.Run();