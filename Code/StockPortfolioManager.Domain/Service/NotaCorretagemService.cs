using StockPortfolioManager.Domain.Entities;
using StockPortfolioManager.Domain.Interface.Repository;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Domain.Service
{
  public class NotaCorretagemService : ServiceBase<NotaCorretagem>, INotaCorretagemService
  {
    public NotaCorretagemService(INotaCorretagemRepository notaCorretagemRepository) : base(notaCorretagemRepository  )
    {
    }
  }
}
