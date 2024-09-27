using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace common.jwt
{
  public class JwtService : IJwtService
  {
    private readonly JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();
    private readonly SigningCredentials credentials;

    public JwtService(IConfiguration config)
    {
      var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:SigningKey"]));
      this.credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
    }

    // jwt token 
    // https://medium.com/@siva.veeravarapu/jwt-token-authentication-in-c-a-beginners-guide-with-code-snippets-7545f4c7c597
    /// <summary>
    /// 토큰을 생성한다.
    /// </summary>
    /// <param name="claims">JWT에 포함할 custom claim 목록</param>
    /// <param name="expireDate">JWT가 만료되는 시간</param>
    /// <returns>문자열로 변환된 JWT 토큰</returns>
    public string generateToken(Dictionary<string, string> claims, DateTime expireDate)
    {
      var _claims = claims.Select(it => new Claim(it.Key, it.Value)).ToList();

      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(_claims),
        Expires = expireDate,
        SigningCredentials = this.credentials,
      };
      var token = jwtHandler.CreateToken(tokenDescriptor);

      return jwtHandler.WriteToken(token);
    }
  }
}