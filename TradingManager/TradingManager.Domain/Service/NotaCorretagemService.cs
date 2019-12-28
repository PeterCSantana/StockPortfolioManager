using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Repository;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Domain.Service
{
  public class NotaCorretagemService : ServiceBase<NotaCorretagem>, INotaCorretagemService
  {
    public NotaCorretagemService(INotaCorretagemRepository notaCorretagemRepository) : base(notaCorretagemRepository  )
    {
    }
  }
}
