using TradingManager.Application.Interface;
using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Application
{
  public class TaxaBMFApp : AppBase<TaxaBMF>, ITaxaBMFApp
  {
    public TaxaBMFApp(ITaxaBMFService taxaBMFService) : base(taxaBMFService)
    { }
  }
}