using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace TrampoFacil.API.Helpers
{
    public static class UsuarioHelper
    {
        public static Guid ObterIdUsuarioLogado(HttpContext httpContext)
        {
            var idUsuario = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(idUsuario))
                throw new UnauthorizedAccessException("Usuário não autenticado ou token inválido.");

            return Guid.Parse(idUsuario);
        }
    }
}