using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solucion.Data;

namespace Solucion.Controllers
{
    
    public class UsersController : Controller
    {
        /* Conexion con la db */
        public readonly BaseContext _context;
        /* Constructor Usuarios */
        public UsersController(BaseContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){
            return View(await _context.Users.ToListAsync());
        }
    }
}