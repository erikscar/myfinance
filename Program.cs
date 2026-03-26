using Microsoft.EntityFrameworkCore;
using myfinance.Application.Services;
using myfinance.Application.Services.Interfaces;
using myfinance.Domain.Entities;
using myfinance.Infrastructure.Context;
using myfinance.Infrastructure.Repositories;
using myfinance.Infrastructure.Repositories.Interfaces;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<MyFinanceContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyFinanceDatabase"));
});

builder.Services.AddControllers();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();
