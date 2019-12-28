using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Repository;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Domain.Service
{
  public class TaxaBMFService : ServiceBase<TaxaBMF>, ITaxaBMFService
  {
    public TaxaBMFService(ITaxaBMFRepository taxaBMFRepository) : base(taxaBMFRepository)
    {
    }
  }
}
