using Microsoft.AspNetCore.Mvc;
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
        
    }
}