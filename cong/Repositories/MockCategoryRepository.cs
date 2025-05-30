using cong.Models;

namespace cong.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categoryList;

        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
            {
                new Category { IdC = 1, NameC = "Laptop" },
                new Category { IdC = 2, NameC = "Desktop" },
                // Thêm các category khác
            };
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }

        public Category? GetById(int id)
        {
            return _categoryList.FirstOrDefault(c => c.IdC == id); // Fixed: Changed 'Id' to 'IdC'
        }

        public void Add(Category category)
        {
            // Assign a unique Id to the new category
            category.IdC = _categoryList.Any() ? _categoryList.Max(c => c.IdC) + 1 : 1; // Fixed: Changed 'Id' to 'IdC'
            _categoryList.Add(category);
        }

        public void Update(Category category)
        {
            var existingCategory = _categoryList.FirstOrDefault(c => c.IdC == category.IdC); // Fixed: Changed 'Id' to 'IdC'
            if (existingCategory != null)
            {
                existingCategory.NameC = category.NameC; // Fixed: Changed 'Name' to 'NameC'
            }
        }

        public void Delete(int id)
        {
            var categoryToDelete = _categoryList.FirstOrDefault(c => c.IdC == id); // Fixed: Changed 'Id' to 'IdC'
            if (categoryToDelete != null)
            {
                _categoryList.Remove(categoryToDelete);
            }
        }

        // Ensure your repository implements the correct interface methods
        public void AddC(Category category)
        {
            Add(category);
        }

        public void UpdateC(Category category)
        {
            Update(category);
        }

        public void DeleteC(int id)
        {
            Delete(id);
        }
    }
}
