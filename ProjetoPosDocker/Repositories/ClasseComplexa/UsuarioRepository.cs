using Projeto_Pos_Docker.Data;
using Projeto_Pos_Docker.Models;
using Projeto_Pos_Docker.Repositories.Interfaces;

namespace Projeto_Pos_Docker.Repositories.ClasseComplexa
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioRepository() { }

        public ICollection<Usuario> ObterTodosUsuarios()
        {
            return UsuarioData.GetListUsuarios();
        }
    }
}
