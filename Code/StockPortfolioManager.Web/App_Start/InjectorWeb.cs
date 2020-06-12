[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(StockPortfolioManager.Web.App_Start.InjectorWeb), "Initialize")]

namespace StockPortfolioManager.Web.App_Start
{
  using SimpleInjector;
  using SimpleInjector.Integration.Web;
  using StockPortfolioManager.Data.CrossCutting;
  using SimpleInjector.Integration.Web.Mvc;
  using System.Reflection;
  using System.Web.Mvc;

  public static class InjectorWeb
  {
    public static void Initialize()
    {
      var container = new Container();
      container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

      InitializeContainer(container);

      container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

      container.Verify();

      DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
    }

    private static void InitializeContainer(Container container)
    {
      BootStrapper.Register(ref container);
    }
  }
}