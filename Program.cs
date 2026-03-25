using Microsoft.EntityFrameworkCore;
using myfinance.Domain.Entities;
using myfinance.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<MyfinanceContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<MyfinanceContext>();
    context.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.MapGet("/myfinance", (MyfinanceContext context) =>
{
    context.Add(new User { Name= "Erik Scarcela Araujo"});

    context.SaveChanges();

    return context.Users.ToList();  
});

app.Run();
