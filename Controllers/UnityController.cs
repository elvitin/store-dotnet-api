using AppStore.Models.MemoryDatabase;
using AppStore.Models.Product;
using AppStore.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppStore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UnityController : ControllerBase
  {
    
    [HttpGet]
    /// <summary>Obtem todos as unidades </summary>
    public IActionResult GetAll()
    {
      Console.WriteLine("GetAll...");
      return Ok(UnityRepository.units);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOne(int id)
    {
      var unity = UnityRepository.GetUnity(id);
      if (unity != null)
        return Ok(unity);
      return NotFound();
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, UnityViewModel unityVm)
    {
      Console.WriteLine("Update: " + unityVm.Description);
      var obj = UnityRepository.units.Find(item => item.Id == id);
      if(obj != null)
      {
        obj.Description = unityVm.Description;
        return Ok(obj);
      }
      return NotFound();
    }

    [HttpPost]
    public IActionResult Create(UnityViewModel unityVm)
    {
      Unity unity = new(unityVm.Description);
      UnityRepository.AddUnity(unity);
      Console.WriteLine("Unity created!");
      return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
      if (UnityRepository.DeleteUnity(id))
        return NoContent();
      return NotFound();
    }
  }
}
