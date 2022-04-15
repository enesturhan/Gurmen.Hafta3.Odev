using ApiProjesiCrud.Dtos;
using System.Security.Claims;

namespace ApiProjesiCrud.Services
{
    public interface ITokenService
    {
        Task<TokenDto> GenerateToken(IEnumerable<Claim> Claims);
    }
}
