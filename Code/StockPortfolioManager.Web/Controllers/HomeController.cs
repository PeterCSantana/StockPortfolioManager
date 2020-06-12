using System.Web.Mvc;

namespace StockPortfolioManager.Web.Controllers
{
  public class HomeController : Controller
  {
    public HomeController()
    {
      ViewBag.Title = "Visão Geral";
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}