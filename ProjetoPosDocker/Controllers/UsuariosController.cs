using Microsoft.AspNetCore.Mvc;
using Projeto_Pos_Docker.Services.Interfaces;
using Projeto_Pos_Docker.ViewModel;

namespace Projeto_Pos_Docker.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: UsuariosController
        public ActionResult Index()
        {
            var listusuarios = _usuarioService.ObterUsuarios();

            var usuarioViewmodel = new UsuarioViewModel()
            {
                Usuarios = listusuarios
            };

            return View(usuarioViewmodel);
        }
    }
}
