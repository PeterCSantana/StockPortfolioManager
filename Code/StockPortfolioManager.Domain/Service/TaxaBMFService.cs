using StockPortfolioManager.Domain.Entities;
using StockPortfolioManager.Domain.Interface.Repository;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Domain.Service
{
  public class TaxaBMFService : ServiceBase<TaxaBMF>, ITaxaBMFService
  {
    public TaxaBMFService(ITaxaBMFRepository taxaBMFRepository) : base(taxaBMFRepository)
    {
    }
  }
}
