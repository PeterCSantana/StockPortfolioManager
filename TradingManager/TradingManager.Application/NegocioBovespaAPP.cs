using TradingManager.Application.Interface;
using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Application
{
  public class NegocioBovespaAPP : AppBase<NegocioBovespa>, INegocioBovespaAPP
  {
    public NegocioBovespaAPP(INegocioBovespaService negocioBovespaService) : base(negocioBovespaService)
    { }
  }
}
