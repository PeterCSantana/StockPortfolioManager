using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Repository;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Domain.Service
{
  public class NegocioBovespaService : ServiceBase<NegocioBovespa>, INegocioBovespaService
  {
    public NegocioBovespaService(INegocioBovespaRepository negocioBovespaRepository) : base(negocioBovespaRepository)
    {
    }
  }
}
