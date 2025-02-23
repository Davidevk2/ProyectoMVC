
using System.ComponentModel.DataAnnotations;

namespace Solucion.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }
}