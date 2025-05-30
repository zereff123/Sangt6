namespace cong.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using cong.Models;
    using cong.Repositories;

    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult IndexC()
        {
            var categories = _categoryRepository.GetAllCategories();
            return View(categories);
        }

        public IActionResult AddC()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddC(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.AddC(category); // Fixed method name
                return RedirectToAction("IndexC");
            }
            return View(category);
        }

        public IActionResult UpdateC(int id)
        {
            var category = _categoryRepository.GetById(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        public IActionResult UpdateC(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.UpdateC(category);
                return RedirectToAction("IndexC");
            }
            return View(category);
        }

        public IActionResult DeleteC(int id)
        {
            var category = _categoryRepository.GetById(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost, ActionName("DeleteC")]
        public IActionResult DeleteConfirmed(int id)
        {
            _categoryRepository.DeleteC(id);
            return RedirectToAction("IndexC");
        }
    }
}