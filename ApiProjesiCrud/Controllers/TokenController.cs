using ApiProjesiCrud.Dtos;
using ApiProjesiCrud.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiProjesiCrud.Controllers
{






    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public TokenController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }



        [HttpPost]
        public async Task<IActionResult> Token([FromBody] AuthDto model)
        {


            if ((model.UserName == "enes" || model.UserName == "furkan") && model.Password == "1234" && model.GrantType == GrantTypes.Password)
            {
                // access token da saklanacak bilgiler.
                var claims = new List<Claim>
                {
                    new Claim("id",model.UserName == "enes" ? "1":"2"),
                    new Claim(ClaimTypes.Name,model.UserName),
                    new Claim("username",model.UserName),
                      new Claim("role","admin,manager")
                };

                var response = await _tokenService.GenerateToken(claims);

                RefreshTokenStore.Tokens.Add(response.RefreshToken);

                return Ok(response);
            }

            // eğer sistemde kayıtlı bir kullanıcı değilsek 401 hatası döndür.
            return Unauthorized();
        }


        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenDto model)
        {
            if (RefreshTokenStore.Tokens.Any(x => x == model.RefreshToken))
            {
                // refresh token sistemde varsa access token
                // fakat acess token biz mi oluşturduk kontrol etmeliyiz.

                var principle = TokenHelper.ValidateAccessToken(model.AccessToken);

                // veritabanına gitmeden adamın oturum açarken kullandığı claim bilgilerini tekrar validateaccesstoken ile aldık. zaten eğer yanlış bir bilgiyse principle null gelicektir. jwt bu kodu çözemeyecektir.

                if (principle != null)
                {
                    var response = await _tokenService.GenerateToken(principle.Claims);

                    return Ok(response);
                }
                return Unauthorized();

            }

            // eğer sistemde kayıtlı bir kullanıcı değilsek 401 hatası döndür.
            return Unauthorized();
        }
    }
}
