using System;
using Microsoft.EntityFrameworkCore;
using myfinance.Domain.Entities;
using myfinance.Infrastructure.Context;
using myfinance.Infrastructure.Repositories.Interfaces;

namespace myfinance.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private MyFinanceContext _myfinanceContext;

    public UserRepository(MyFinanceContext myFinanceContext)
    {
        _myfinanceContext = myFinanceContext;
    }

    public Task<List<User>> GetUsers()
    {
        return _myfinanceContext.Users.ToListAsync();
    }
}
