using System;
using myfinance.Domain.Entities;

namespace myfinance.Application.Services.Interfaces;

public interface IUserService
{
    Task<List<User>> GetUsersAsync();
}
