using Microsoft.AspNetCore.Mvc.RazorPages;
using Projeto_Pos_Docker.Models;

namespace Projeto_Pos_Docker.ViewModel
{
    public class UsuarioViewModel
    {       
        public UsuarioViewModel()
        {            
        }

        public ICollection<Usuario> Usuarios { get; set; } =  new List<Usuario>();        
    }
}
