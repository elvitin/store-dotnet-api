namespace AppStore.Models.Product
{
  public class Unity
  {
    public int Id { get; set; }
    public string Description { get; set; }

    public Unity()
    {
      Description = "";
    }
    public Unity(string description)
    {
      Description = description;
    }
    public Unity(int id, string description)
    {
      Id = id;
      Description = description;
    }
  }
}
