using System;
using Microsoft.EntityFrameworkCore;
using myfinance.Domain.Entities;

namespace myfinance.Infrastructure.Context;

public class MyFinanceContext(DbContextOptions<MyFinanceContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
