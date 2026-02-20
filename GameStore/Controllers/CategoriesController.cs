using GameStore.Interfaces;
using GameStore.Models;
using GameStore.Models.Pages;
using Microsoft.AspNetCore.Mvc;

public class CategoriesController : Controller
{
    private readonly ICategory _categories;

    public CategoriesController(ICategory categories)
    {
        _categories = categories;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View(_categories.GetAllCategories());
    }
    [HttpGet]
    public IActionResult UpdateCategory(int id)
    {
        Category category = id == 0 ? new Category() : _categories.GetCategory(id);
        return View(category);  
    }
    [HttpPost]
    public IActionResult UpdateCategory(Category category)
    {
        if (category.Id == 0)
        {
            _categories.AddCategory(category);
        }
        else
        {
            _categories.UpdateCategory(category);
        }
        return RedirectToAction(nameof(Index));
    }
    [HttpPost]
    public IActionResult DeleteCategory(Category category)
    {
        _categories.DeleteCategory(category);
        return RedirectToAction(nameof(Index));
    }

    //practice 1 code
    [HttpGet]
    public IActionResult UpdateAll()
    {
        ViewBag.UpdateAll = true;
        return View(nameof(Index), _categories.GetAllCategories());
    }

    [HttpPost]
    public IActionResult UpdateAll(Category[] categories)
    {
        _categories.UpdateAll(categories);
        return RedirectToAction(nameof(Index));
    }
}

/*сделать контроллер и представление категорий*/