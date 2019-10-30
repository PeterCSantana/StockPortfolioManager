using Microsoft.EntityFrameworkCore;
using TradingManager.Data.Context.Interface;

namespace TradingManager.Data.Context
{
  public class TradingManagerContext : DbContext, ITradingManagerContext
  {
    public TradingManagerContext() : base(MySQLDbContextOptionsExtensions.UseMySQL(new DbContextOptionsBuilder(), "").Options) { }
  }
}
