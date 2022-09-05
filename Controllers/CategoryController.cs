
using AppStore.Models.MemoryDatabase;
using AppStore.Models.Product;
using AppStore.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AppStore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CategoryController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetAll()
    {
      Console.WriteLine("Get Categories...");
      return Ok(CategoryRepository.categories);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOne(int id)
    {
      Console.WriteLine("Get category by id...");
      var category = CategoryRepository.GetById(id);
      if (category != null)
        return Ok(category);
      return NotFound();
    }

    [HttpPost]
    public IActionResult Create(CategoryViewModel categoryVm)
    {
      Console.WriteLine("Create category...");
      Category category = new()
      {
        Description = categoryVm.Description
      };
      CategoryRepository.Insert(category);
      return Ok(category);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, CategoryViewModel categoryVm)
    {
      Console.WriteLine("Update category...");
      var category = CategoryRepository.categories.Find(item => item.Id == id);
      if(category != null)
      {
        category.Description = categoryVm.Description;
        return Ok(category);
      }
      return NotFound();
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
      if(CategoryRepository.DeleteCategory(id))
        return NoContent();
      return NotFound();
    }
  }
}
