using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solucion.Data;

namespace Solucion.Controllers
{
    public class ProductsController : Controller
    {
        /* Conexion con la db */
        public readonly BaseContext _context;

        /* Constructor de productos */
        public ProductsController(BaseContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){
            return View(await _context.Products.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id){
            return View(await _context.Products.FirstOrDefaultAsync(product => product.Id == id));
        }
        
    }
}