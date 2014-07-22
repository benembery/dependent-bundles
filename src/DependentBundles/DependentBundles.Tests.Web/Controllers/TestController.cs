using System.Web.Mvc;

namespace DependentBundles.Tests.Web.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}