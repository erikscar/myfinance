using myfinance.Application.Services.Interfaces;
using myfinance.Domain.Entities;
using myfinance.Infrastructure.Repositories.Interfaces;

namespace myfinance.Application.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<List<User>> GetUsersAsync()
    {
        var users = await _userRepository.GetUsers();
        
        return users;
    }

}
