using Projeto_Pos_Docker.Models;
using Projeto_Pos_Docker.Repositories.Interfaces;
using Projeto_Pos_Docker.Services.Interfaces;

namespace Projeto_Pos_Docker.Services.ClassesComplexas
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
        }


        public ICollection<Usuario> ObterUsuarios()
        {
            return _usuarioRepository.ObterTodosUsuarios();
        }
    }
}
