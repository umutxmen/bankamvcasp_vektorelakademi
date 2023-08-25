﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Utilities.Security.JWT
{
  public class JwtGenerator
  {
    private readonly IConfiguration _configuration;
    private Tokenoptions _tokenoptions;
    private DateTime _tokenExpiration;

    public JwtGenerator(IConfiguration configuration)
    {
      _configuration = configuration;
      _tokenoptions = _configuration.GetSection("Tokenoptions").Get<Tokenoptions>();
    }

    public AccessToken CreateAccessToken()
    {
      _tokenExpiration = DateTime.Now.AddMinutes(_tokenoptions.TokenExpiration);

      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenoptions.SecurityKey));
      var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

      
      var jwt = CreateJwtSecurityToken(_tokenoptions, signingCredentials);

      var jwtHandler = new JwtSecurityTokenHandler();
      var token = jwtHandler.WriteToken(jwt);

      return new AccessToken()
      {
        Token = token,
        Expiration = _tokenExpiration,
        Claims = new List<string> { "CLAIM1", "CLAIM2", "CLAIM3" }
      };
    }

    // Asıl Token'ı üretecek olan metodu çağırıyoruz. Bu token signingCredentials ile imzalanacak ve _tokenoptions içindeki değerleri payload a yerleştirecek
    private JwtSecurityToken CreateJwtSecurityToken(Tokenoptions tokenoptions, SigningCredentials signingCredentials)
    {
      var jwtSecurityToken = new JwtSecurityToken
        (
         issuer:tokenoptions.Issuer,
         audience : tokenoptions.Audience,
         expires: _tokenExpiration,
         notBefore:DateTime.Now,
         claims: new List<Claim> { new Claim("KEY1","VALUE1"),new Claim("KEY2", "VALUE2"), new Claim("KEY3", "VALUE3") },
         signingCredentials: signingCredentials
        );
      

      return jwtSecurityToken;
    }

  }
}
