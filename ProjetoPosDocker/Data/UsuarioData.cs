using Projeto_Pos_Docker.Models;

namespace Projeto_Pos_Docker.Data
{
    public static class UsuarioData
    {

        public static ICollection<Usuario> GetListUsuarios()
        {
            return RecuperarListDB();
        }

        private static ICollection<Usuario> RecuperarListDB()
        {
            ICollection<Usuario> listUsuarios = new List<Usuario>()
            {
                new Usuario()
                {
                    Id = 1,
                    Nome = "Lucas Farias",
                    Email = "lucasfarias14@outlook.com"
                },
                 new Usuario()
                {
                    Id = 2,
                    Nome = "Aula pós docker",
                    Email = "aulapos@hotmail.com"
                }
            };

            return listUsuarios;
        }
    }
}
