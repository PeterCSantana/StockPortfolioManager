using TradingManager.Application.Interface;
using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Application
{
  public class FinanceiroBovespaAPP : AppBase<FinanceiroBovespa>, IFinanceiroBovespaAPP
  {
    public FinanceiroBovespaAPP(IFinanceiroBovespaService financeiroBovespaService) : base(financeiroBovespaService)
    { }
  }
}
