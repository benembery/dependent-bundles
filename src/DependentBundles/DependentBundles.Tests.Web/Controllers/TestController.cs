using System.Web.Mvc;

namespace DependentBundles.Tests.Web.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InView()
        {
            return View();
        }

        public ActionResult Partial()
        {
            return View();
        }

        public ActionResult EditorFor()
        {
            return View(model: "Editor for test model");
        }

        public ActionResult DisplayFor()
        {
            return View(model: "Display for test model");
        }
    }
}