using Microsoft.EntityFrameworkCore;
using Solucion.Models;

namespace Solucion.Data
{
    public class BaseContext :DbContext 
    {

        public BaseContext(DbContextOptions<BaseContext> options) : base(options){}
        
        /* Registro de los modelos que se usan en la db  */
        public DbSet<User> Users {get; set;}
        public DbSet<Product> Products {get; set;}

    }
}