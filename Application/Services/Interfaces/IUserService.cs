using System;
using myfinance.Domain.DTOS;
using myfinance.Domain.Entities;
using myfinance.Shared.Results;

namespace myfinance.Application.Services.Interfaces;

public interface IUserService
{
    Task<List<User>> GetUsersAsync();
    Task<Result<TokenDTO>> LoginUserAsync(LoginRequestDTO userData);
    Task<Result<TokenDTO>> RegisterUserAsync(RegisterRequestDTO userData);
}
