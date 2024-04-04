using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ObjectPool;
using Solucion.Data;
using Solucion.Models;

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

        // action para crear vista create
        public  IActionResult Create(){
            return View();
        }

        // action para registrar en la db
        [HttpPost]
        public IActionResult Create(User u){
            //Agregar el usuario al DbSet 
            _context.Users.Add(u);
            //Guardar los cambios en DbSet en la db
            _context.SaveChanges();
            //Redireciona a la lista de usuarios
            return  RedirectToAction("Index");
           
        }

        public async Task<IActionResult> Delete(int id){
            
            var user = await _context.Users.FindAsync(id); //Buscar el user por su id
            _context.Users.Remove(user); //Eliminar el usuario en el Dbset
            _context.SaveChanges(); //Guardar los cambios en el context 

            return RedirectToAction("Index"); //volver a la vista usuarios
        }



    }
}