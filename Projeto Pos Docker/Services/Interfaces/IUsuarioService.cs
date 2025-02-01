using Projeto_Pos_Docker.Models;

namespace Projeto_Pos_Docker.Services.Interfaces
{
    public interface IUsuarioService
    {
        ICollection<Usuario> ObterUsuarios();
    }
}
