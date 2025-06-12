using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication3.Migrations;

namespace WebApplication3.Models
{
    public class product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public required string Description { get; set; }

        public string? Image { get; set; }

        public bool Ozel { get; set; }
        public double Price { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public required category? category { get; set; }
    }
}
