using AppStore.Models.Product;

namespace AppStore.Models.MemoryDatabase
{
  static public class UnityRepository
  {
    public readonly static List<Unity> units = new()
    { 
      new Unity(1, "Pack"),
      new Unity(2, "Kilogram"),
      new Unity(3, "Liter"),
      new Unity(4, "Milliliter"),
      new Unity(5, "Box")
    };

    public static bool AddUnity(Unity unity)
    {
      unity.Id = units.Last().Id + 1;
      units.Add(unity);
      return true;
    }

    public static bool DeleteUnity(int id)
    {
      var unity = GetUnity(id);
      if (unity != null)
      {
        units.Remove(unity);
        return true;
      }
      return false;
    }

    public static Unity GetUnity(int id) => units.SingleOrDefault(item => item.Id == id);

    public static Unity UpdateUnity(int id)
    {
      return null;
    }
  }
}
