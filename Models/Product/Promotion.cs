namespace AppStore.Models.Product
{
  public class Promotion
  {
    public int Id { get; set; }
    public decimal Price { get; set; }
    public Product Product { get; set; }
    public Promotion()
    {
      Product = new Product();
    }
  }
}
