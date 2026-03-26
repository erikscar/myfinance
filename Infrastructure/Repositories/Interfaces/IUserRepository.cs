using System;
using myfinance.Domain.Entities;

namespace myfinance.Infrastructure.Repositories.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetUsers();
}
