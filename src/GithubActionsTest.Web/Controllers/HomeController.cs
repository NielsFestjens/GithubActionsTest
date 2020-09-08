using System.Web.Mvc;
using GithubActions.Core;

namespace GithubActionsTest.Controllers
{
    public class HomeIndexModel
    {
        public string Name { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(new HomeIndexModel { Name = new Data().GetName() });
        }
    }
}
