using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class appUser
    {
        [Key]
        public int id { get; set; }
        public required string name { get; set; }
        public required string surname { get; set; }
    }
}
