using Microsoft.AspNetCore.Mvc;
using UdemySiparis.Data.Repository.UnitOfWorks;
using UdemySiparis.Models;

namespace UdemySiparis.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private IUnitOfWork UnitOfWork { get; }

        public CategoryController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var categoryList = UnitOfWork.Category.GetAll();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.Category.Add(category);
                UnitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Edit(int? id)
        {
            if (id is null or <= 0)
                return NotFound();

            var category = UnitOfWork.Category.GetFirstOrDefault(x => x.Id == id);

            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.Category.Update(category);
                UnitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Delete(int id)
        {
            if (id == null || id <= 0)
                return NotFound();

            var category = UnitOfWork.Category.GetFirstOrDefault(x => x.Id == id);

            if (category == null)
                return NotFound();

            UnitOfWork.Category.Remove(category);
            UnitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}