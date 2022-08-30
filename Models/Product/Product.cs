namespace AppStore.Models.Product
{
  public class Product
  {
    public int Id { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public bool IsActive { get; set; }

    public Unity Unity { get; set; }

    public List<Category> Categories { get; set; }
    public Product() { }
    public Product(int id, string description, decimal price, int stock, bool isActive, Unity unity)
    {
      Id = id;
      Description = description;
      Price = price;
      Stock = stock;
      IsActive = isActive;
      Unity = unity;
      Categories = new List<Category>();
    }
  }
}
