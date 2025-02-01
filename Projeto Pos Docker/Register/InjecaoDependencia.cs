using Projeto_Pos_Docker.Repositories.ClasseComplexa;
using Projeto_Pos_Docker.Repositories.Interfaces;
using Projeto_Pos_Docker.Services.ClassesComplexas;
using Projeto_Pos_Docker.Services.Interfaces;

namespace Projeto_Pos_Docker.Register
{
    public static class InjecaoDependencia
    {
        public static void RegistrarInjecaoDepencia(this IServiceCollection services)
        {
            services.AddSingleton<IUsuarioService, UsuarioService>();
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
