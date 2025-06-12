using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class category
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
