using StockPortfolioManager.Application.Interface;
using StockPortfolioManager.Domain.Entities;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Application
{
  public class FinanceiroBovespaAPP : AppBase<FinanceiroBovespa>, IFinanceiroBovespaAPP
  {
    public FinanceiroBovespaAPP(IFinanceiroBovespaService financeiroBovespaService) : base(financeiroBovespaService)
    { }
  }
}
