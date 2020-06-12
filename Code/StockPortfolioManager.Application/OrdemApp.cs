using StockPortfolioManager.Application.Interface;
using StockPortfolioManager.Domain.Entities;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Application
{
  public class OrdemApp : AppBase<Ordem>, IOrdemApp
  {
    public OrdemApp(IOrdemService ordemService) : base(ordemService)
    { }
  }
}