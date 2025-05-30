using cong.Models;
using System.Collections.Generic;

namespace cong.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category? GetById(int id);
        void AddC(Category category);
        void UpdateC(Category category);
        void DeleteC(int id);
    }
}
