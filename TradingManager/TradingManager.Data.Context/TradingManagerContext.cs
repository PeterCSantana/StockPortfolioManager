using MySql.Data.MySqlClient;
using System.Data;
using TradingManager.Data.Context.Interface;

namespace TradingManager.Data.Context
{
  public class TradingManagerContext : ITradingManagerContext
  {
    private readonly string _connectionString;
    private IDbConnection _connection;

    public TradingManagerContext(string connectionString)
    {
      _connectionString = connectionString;
    }

    public IDbConnection Connection
    {
      get
      {
        if (_connection == null)
        {
          _connection = new MySqlConnection(_connectionString);

        }
        if (_connection.State != ConnectionState.Open)
        {
          _connection.Open();
        }
        return _connection;
      }
    }

    public void Dispose()
    {
      if (_connection != null && _connection.State == ConnectionState.Open)
      {
        _connection.Close();
      }
    }
  }
}
