namespace AppStore.Models.Product
{
  public class Category
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public Category()
    {
      Description = "";
    }
  }
}
