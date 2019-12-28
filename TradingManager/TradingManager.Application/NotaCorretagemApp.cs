using TradingManager.Application.Interface;
using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Application
{
  public class NotaCorretagemApp : AppBase<NotaCorretagem>, INotaCorretagemApp
  {
    public NotaCorretagemApp(INotaCorretagemService notaCorretagemService) : base(notaCorretagemService)
    { }
  }
}
