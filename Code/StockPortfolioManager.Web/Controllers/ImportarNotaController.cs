using System.Web.Mvc;

namespace StockPortfolioManager.Web.Controllers
{
  public class ImportarNotaController : Controller
  {
    public ImportarNotaController()
    {
      ViewBag.Title = "Importar Nota de Corretagem";
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}