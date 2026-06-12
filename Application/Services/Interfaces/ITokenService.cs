using myfinance.Domain.DTOS;

namespace myfinance.Application.Services.Interfaces;

public interface ITokenService
{
    Task<TokenDTO> GenerateJWT(int userId);
}
