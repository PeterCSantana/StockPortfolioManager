using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Repository;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Domain.Service
{
  public class OrdemService : ServiceBase<Ordem>, IOrdemService
  {
    public OrdemService(IOrdemRepository ordemRepository) : base(ordemRepository)
    {
    }
  }
}
