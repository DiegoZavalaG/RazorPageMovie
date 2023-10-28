using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Timers;

namespace RazorPageMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; }
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
    }
}
