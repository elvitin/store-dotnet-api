using AppStore.Models.MemoryDatabase;
using AppStore.Models.Product;
using AppStore.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AppStore.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class ProductController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetAll()
    {
      Console.WriteLine("Get All Products!");
      return Ok(ProductRepository.products);
    }

    [HttpPost]
    public IActionResult CreateProduct(ProductViewModel productVm)
    {
      Console.WriteLine("New Product");
      Product newProduct = new()
      {
        Description = productVm.Description,
        Price = productVm.Price,
        Stock = productVm.Stock,
        IsActive = true
      };
      ProductRepository.AddProduct(newProduct);
      return Ok("Created!!");
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOne()
    {
      Console.WriteLine("Get one Product!");
      return Ok("one");
    }



    [HttpDelete("{id:int}")]
    public IActionResult DeleteProduct(int id)
    {
      Console.WriteLine("Delete one product id: " + id);
      return Ok("Deleted!!");
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateProduct(int id)
    {
      Console.WriteLine("Update product id: " + id);
      return Ok("Updated!!");
    }
  }
}
