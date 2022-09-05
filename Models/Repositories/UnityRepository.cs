using AppStore.Models.Product;
using AppStore.Models.Database;
using MySql.Data.MySqlClient;

namespace AppStore.Models.Repositories
{
  static public class UnityRepository
  {

    public static bool AddOrUpdate(Unity unity)
    {
      MySqlConnection con = ConnectionFactory.GetConnection();

      try
      {
        MySqlCommand cmd = con.CreateCommand();

        if (unity.Id == 0)
        {
          cmd.CommandText = $@"INSERT INTO `vartechs15`.`unity` (`description`) VALUES (@description);";
        }
        else
        {
          cmd.CommandText = $@"UPDATE vartechs15.unity SET description = @description WHERE id = @id";
          cmd.Parameters.AddWithValue("@id", unity.Id);
        }
        cmd.Parameters.AddWithValue("@description", unity.Description);
        con.Open();

        bool op = cmd.ExecuteNonQuery() > 0;
        unity.Id = unity.Id == 0 ? (int)cmd.LastInsertedId : unity.Id;
        return op;
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        con.Close();
      }
    }

    public static bool DeleteUnity(int id)
    {
      MySqlConnection con = ConnectionFactory.GetConnection();
      try
      {
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = $@"DELETE FROM vartechs15.unity WHERE id = @id;";
        cmd.Parameters.AddWithValue("@id", id);
        con.Open();
        return cmd.ExecuteNonQuery() > 0;
      }
      catch (Exception) { throw; }
      finally
      {
        con.Close();
      }
    }

    public static Unity GetUnity(int id)
    {
      MySqlConnection con = ConnectionFactory.GetConnection();
      try
      {
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = $@"SELECT `unity`.`id`, `unity`.`description` FROM `vartechs15`.`unity` WHERE `unity`.`id` = @id;";
        cmd.Parameters.AddWithValue("@id", id);
        con.Open();
        MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
        if (mySqlDataReader.Read())
          return new Unity(Convert.ToInt32(mySqlDataReader["id"]), mySqlDataReader["description"].ToString());
        return null;
      }
      catch (Exception) { throw; }
      finally
      {
        con.Close();
      }
    }

    public static List<Unity> GetUnits()
    {
      MySqlConnection con = ConnectionFactory.GetConnection();
      try
      {
        List<Unity> units = new();
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = "SELECT `unity`.`id`, `unity`.`description` FROM `vartechs15`.`unity`;";
        con.Open();
        MySqlDataReader data_reader = cmd.ExecuteReader();
        while (data_reader.Read())
        {
          units.Add(new Unity()
          {
            Id = Convert.ToInt32(data_reader["id"]),
            Description = data_reader["description"].ToString()
          });
        }
        return units;
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
