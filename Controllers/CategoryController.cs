using Microsoft.AspNetCore.Http;
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

      return Ok("");
    }

    [HttpGet]
    public IActionResult GetOne(int it)
    {
      return Ok("");
    }

    [HttpPost]
    public IActionResult Create()
    {
      return Ok("");
    }

    [HttpPut]
    public IActionResult Update(int id)
    {
      return Ok("");
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
      return Ok("");
    }
  }
}
