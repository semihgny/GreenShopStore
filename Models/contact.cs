using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class contact
    {
        [Key]
        public int id { get; set; }
        public required string name { get; set; }
        public required string eMail { get; set; }
        public required string mesaj { get; set; }
        public required string telefon { get; set; }
        public DateTime Tarih { get; set; }
    }
}
