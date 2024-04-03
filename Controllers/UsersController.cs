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

        /* Actions para las vistas  */
        public async Task<IActionResult> Index(){
            return View(await _context.Users.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id){
            return View(await _context.Users.FirstOrDefaultAsync(user => user.Id == id));
            /* SELECT * from Users WHERE Id = id */
        }

        public IActionResult Create(){
            return View();
        }
    }
}