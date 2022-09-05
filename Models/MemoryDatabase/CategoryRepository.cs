using AppStore.Models.Product;

namespace AppStore.Models.MemoryDatabase
{
  public class CategoryRepository
  {
    public readonly static List<Category> categories = new()
    {
      new Category(1, "Drinks"),
      new Category(2, "Candy")
    };

    public static bool Insert(Category category)
    {
      category.Id = categories.Last().Id + 1;
      categories.Add(category);
      return true;
    }

    public static Category GetById(int id) => categories.Find(item => item.Id == id);

    public static bool DeleteCategory(int id)
    {
      var category = GetById(id);
      if(category != null)
      {
        categories.Remove(category);
        return true;
      }
      return false;
    }
  }
}
