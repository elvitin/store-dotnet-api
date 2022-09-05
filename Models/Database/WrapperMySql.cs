using MySql.Data.MySqlClient;

namespace AppStore.Models.Database
{
  public class WrapperMySql
  {
    public MySqlConnection Connection { get; set; }
    public MySqlCommand Command { get; set; }

    public WrapperMySql()
    {
      string strCon = "Server=mysql05-farm88.kinghost.net; Database=vartechs15; Uid=vartechs15; Pwd=A123456789a1;";

      Connection = new MySqlConnection(strCon);
      Command = Connection.CreateCommand();
    }

    public void Open()
    {
      if (Connection.State != System.Data.ConnectionState.Open)
        Connection.Open();
    }

    public void Close()
    {
      if (Connection.State != System.Data.ConnectionState.Closed)
        Connection.Close();
    }
  }
}
