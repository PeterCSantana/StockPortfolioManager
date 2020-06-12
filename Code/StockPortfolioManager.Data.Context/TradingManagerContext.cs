using StockPortfolioManager.Data.Context.Interface;
using StockPortfolioManager.Domain.Entities;
using System.Data.Entity;

namespace StockPortfolioManager.Data.Context
{
  public class StockPortfolioManagerContext : DbContext, IStockPortfolioManagerContext
  {
    public StockPortfolioManagerContext() : base(nameOrConnectionString: "StockPortfolioManager") { }

    public DbSet<FinanceiroBovespa> FinanceiroBovespa { get; set; }
    public DbSet<NegocioBovespa> NegocioBovespa { get; set; }
    public DbSet<NotaCorretagem> NotaCorretagem { get; set; }
    public DbSet<Ordem> Ordem { get; set; }
    public DbSet<TaxaBMF> TaxaBMF { get; set; }

  }
}
