using Projeto_Pos_Docker.Models;

namespace Projeto_Pos_Docker.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        ICollection<Usuario> ObterTodosUsuarios();
    }
}
