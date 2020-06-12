using StockPortfolioManager.Application.Interface;
using StockPortfolioManager.Domain.Entities;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Application
{
  public class NegocioBovespaAPP : AppBase<NegocioBovespa>, INegocioBovespaAPP
  {
    public NegocioBovespaAPP(INegocioBovespaService negocioBovespaService) : base(negocioBovespaService)
    { }
  }
}
