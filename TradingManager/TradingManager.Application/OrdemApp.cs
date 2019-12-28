using TradingManager.Application.Interface;
using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Application
{
  public class OrdemApp : AppBase<Ordem>, IOrdemApp
  {
    public OrdemApp(IOrdemService ordemService) : base(ordemService)
    { }
  }
}