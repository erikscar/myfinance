using System;
using Microsoft.EntityFrameworkCore;
using myfinance.Domain.Entities;

namespace myfinance.Infrastructure.Context;

public class MyfinanceContext(DbContextOptions<MyfinanceContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
