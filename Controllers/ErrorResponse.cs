namespace AppStore.Controllers
{
  public class ErrorResponse
  {
    public string ?ErrorMsg { get; set; }

    public ErrorResponse(string? errorMsg)
    {
      ErrorMsg = errorMsg;
    }
  }
}
