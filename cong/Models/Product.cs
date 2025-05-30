using System.ComponentModel.DataAnnotations;

namespace cong.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public required string Name { get; set; } // Added 'required' modifier
        [Range(0.01, 10000.00)] 
        public decimal Price { get; set; }
        public required string Description { get; set; } // Added 'required' modifier
        public int CategoryId { get; set; }
    }
}
