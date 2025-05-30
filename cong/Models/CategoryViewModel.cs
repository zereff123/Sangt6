namespace cong.Models
{
    public class CategoryViewModel
    {
        public Category? Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}