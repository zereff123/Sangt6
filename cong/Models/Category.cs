using System.ComponentModel.DataAnnotations;

namespace cong.Models
{
    public class Category
    {
        public int IdC { get; set; }
        public string NameC { get; set; } = string.Empty; // Initialize with a default value
    }
}
