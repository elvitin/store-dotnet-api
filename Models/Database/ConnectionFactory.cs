using MySql.Data.MySqlClient;

namespace AppStore.Models.Database
{
  public class ConnectionFactory
  {
    private static readonly string strCon = "Server=mysql05-farm88.kinghost.net; Database=vartechs15; Uid=vartechs15; Pwd=A123456789a1;";
    public static MySqlConnection GetConnection()
    {
      return new MySqlConnection(strCon);
    }
  }
}
