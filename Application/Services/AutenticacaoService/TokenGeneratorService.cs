using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TrampoFacil.API.Settings;

namespace TrampoFacil.Application.Services
{
    public class TokenGeneratorService
    {
        private readonly IConfiguration _configuration;
        private readonly JwtSettings _jwtSettings;


        public TokenGeneratorService(IConfiguration configuration, IOptions<JwtSettings> jwtOptions)
        {
            _configuration = configuration;
             _jwtSettings = jwtOptions.Value;
        }

        public string GerarToken(Usuario usuario)
        {
            var chaveSecreta = _jwtSettings.SecretKey;
            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(chaveSecreta));
            var credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, usuario.IdUsuario.ToString()),
                new Claim(ClaimTypes.Name, usuario.Login)
            };

            var token = new JwtSecurityToken
            (
                issuer:"TrampoFacilAPI",
                audience: "TrampoFacilClientApp",
                claims: claims,
                expires: DateTime.UtcNow.AddDays(_jwtSettings.ExpireDays),
                signingCredentials: credenciais
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}