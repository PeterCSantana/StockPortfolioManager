using SimpleInjector;
using StockPortfolioManager.Application;
using StockPortfolioManager.Application.Interface;
using StockPortfolioManager.Data.Repository;
using StockPortfolioManager.Domain.Interface.Repository;
using StockPortfolioManager.Domain.Interface.Service;
using StockPortfolioManager.Domain.Service;

namespace StockPortfolioManager.Data.CrossCutting
{
  public static class BootStrapper
  {
    public static void Register(ref Container container)
    {
      //Application
      container.Register(typeof(IAppBase<>), typeof(AppBase<>));
      container.Register<IFinanceiroBovespaAPP, FinanceiroBovespaAPP>(Lifestyle.Scoped);
      container.Register<INegocioBovespaAPP, NegocioBovespaAPP>(Lifestyle.Scoped);
      container.Register<INotaCorretagemApp, NotaCorretagemApp>(Lifestyle.Scoped);
      container.Register<IOrdemApp, OrdemApp>(Lifestyle.Scoped);
      container.Register<ITaxaBMFApp, TaxaBMFApp>(Lifestyle.Scoped);

      //Service
      container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
      container.Register<IFinanceiroBovespaService, FinanceiroBovespaService>(Lifestyle.Scoped);
      container.Register<INegocioBovespaService, NegocioBovespaService>(Lifestyle.Scoped);
      container.Register<INotaCorretagemService, NotaCorretagemService>(Lifestyle.Scoped);
      container.Register<IOrdemService, OrdemService>(Lifestyle.Scoped);
      container.Register<ITaxaBMFService, TaxaBMFService>(Lifestyle.Scoped);

      //Repository
      container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
      container.Register<IFinanceiroBovespaRepository, FinanceiroBovespaRepository>(Lifestyle.Scoped);
      container.Register<INegocioBovespaRepository, NegocioBovespaRepository>(Lifestyle.Scoped);
      container.Register<INotaCorretagemRepository, NotaCorretagemRepository>(Lifestyle.Scoped);
      container.Register<IOrdemRepository, OrdemRepository>(Lifestyle.Scoped);
      container.Register<ITaxaBMFRepository, TaxaBMFRepository>(Lifestyle.Scoped);
    }
  }
}
