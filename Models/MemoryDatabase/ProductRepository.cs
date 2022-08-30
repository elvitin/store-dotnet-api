using AppStore.Models.Product;

namespace AppStore.Models.MemoryDatabase
{
  static public class ProductRepository
  {
    public readonly static List<AppStore.Models.Product.Product> products = new()
    {
      //public Product(string? description, decimal price, int stock, bool isActive, Unity unity)
      new Models.Product.Product(1, "Milk", 2.40m, 8, true, UnityRepository.units.ElementAt(2)),
      new Models.Product.Product(2, "Beer", 5.20m, 8, true, UnityRepository.units.ElementAt(3)),
      new Models.Product.Product(3, "Chocolate box", 5.20m, 8, true, UnityRepository.units.ElementAt(4))
    };

    public static bool AddProduct(Product.Product product)
    {
      //products.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));
      product.Id = products.Last().Id + 1;
      products.Add(product);
      return true;
    }
  }
}
