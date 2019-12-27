using Microsoft.EntityFrameworkCore;
using TradingManager.Data.Context.Interface;
using TradingManager.Domain.Entities;

namespace TradingManager.Data.Context
{
  public class TradingManagerContext : DbContext, ITradingManagerContext
  {
    public TradingManagerContext() : base(MySQLDbContextOptionsExtensions.UseMySQL(new DbContextOptionsBuilder(), "").Options) { }

    public DbSet<FinanceiroBovespa> FinanceiroBovespa { get; set; }
    public DbSet<NegocioBovespa> NegocioBovespa { get; set; }
    public DbSet<NotaCorretagem> NotaCorretagem { get; set; }
    public DbSet<Ordem> Ordem { get; set; }
    public DbSet<TaxaBMF> TaxaBMF { get; set; }

  }
}
