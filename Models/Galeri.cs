using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Galeri
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }
    }
}
