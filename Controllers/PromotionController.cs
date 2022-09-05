using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppStore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PromotionController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetAll()
    {

      return Ok("[%%]");
    }

    [HttpGet]
    public IActionResult GetOne(int id)
    {
      return Ok("");
    }
    
    public IActionResult Create(int ProductId, Object data)
    {
      return Ok("");
    }

    public IActionResult Update(int id, Object data)
    {
      return Ok("");
    }

    public IActionResult Delete(int id)
    {
      return Ok("");
    }
  }
}
