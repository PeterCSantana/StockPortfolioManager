using StockPortfolioManager.Application.Interface;
using StockPortfolioManager.Domain.Entities;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Application
{
  public class TaxaBMFApp : AppBase<TaxaBMF>, ITaxaBMFApp
  {
    public TaxaBMFApp(ITaxaBMFService taxaBMFService) : base(taxaBMFService)
    { }
  }
}