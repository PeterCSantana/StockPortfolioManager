using StockPortfolioManager.Application.Interface;
using StockPortfolioManager.Domain.Entities;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Application
{
  public class NotaCorretagemApp : AppBase<NotaCorretagem>, INotaCorretagemApp
  {
    public NotaCorretagemApp(INotaCorretagemService notaCorretagemService) : base(notaCorretagemService)
    { }
  }
}
