namespace AppStore.ViewModel
{
  public class ProductViewModel
  {
    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public bool IsActive { get; set; }

    public int UnityId { get; set; }

    public List<int> CategoryIds { get; set; }
  }
}
