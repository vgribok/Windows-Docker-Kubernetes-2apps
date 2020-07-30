using System.Web.Mvc;

namespace ServiceA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.RedirectPermanent("~/swagger");
        }
    }
}
