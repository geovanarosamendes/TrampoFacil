

using Domain.Models;

namespace TrampoFacil.Domain.Interfaces
{
    public interface IAutenticacaoRepository
    {
        Task<Usuario?>ObterPorLoginAsync(string Login);
        Task AtualizarSenhaAsync(Usuario usuario);
    }


    
}