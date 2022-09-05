using AppStore.Models.Repositories;
using AppStore.Models.Product;
using AppStore.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;



namespace AppStore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UnityController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetAll()
    {
      try
      {
        List<Unity> units = UnityRepository.GetUnits();
        return Ok(units);
      }
      catch (Exception e)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse(e.Message));
      }
    }

    [HttpPost]
    public IActionResult Create(UnityViewModel unityVm)
    {
      try
      {
        Unity unity = new(unityVm.Description);
        if (UnityRepository.AddOrUpdate(unity))
          return Ok(unityVm);
        return BadRequest();
      }
      catch (Exception e)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse(e.Message));
      }
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOne(int id)
    {
      try
      {
        Unity unity = UnityRepository.GetUnity(id);
        if (unity != null)
          return Ok(unity);
        return NotFound();
      }
      catch (Exception e)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse(e.Message));
      }
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, UnityViewModel unityVm)
    {
      Unity unity = new(id, unityVm.Description);
      try
      {
        if (UnityRepository.AddOrUpdate(unity))
          return Ok(unity);
        return NotFound();
      }
      catch (Exception e)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse(e.Message));
      }
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
      try
      {
        if (UnityRepository.DeleteUnity(id))
          return NoContent();
        return NotFound();
      }
      catch (Exception e)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse(e.Message));
      }
    }
  }
}
