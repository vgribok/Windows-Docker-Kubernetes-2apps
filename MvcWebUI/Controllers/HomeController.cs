using System;
using System.Threading.Tasks;
using System.Web.Mvc;

using MvcWebUI.BizLogic;
using Color = MvcWebUI.BizLogic.Color;

namespace MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> Color()
        {
            string baseUrl = AppSettingNames.ServiceBaseUrl.Get();

            string colorString;
            try
            {
                using (var svcClient = new ServiceA(new Uri(baseUrl)))
                {
                    var colorResource = new Color(svcClient);
                    colorString = await colorResource.GetAsync();
                }
            }
            catch (Exception e)
            {
                colorString = e.Innermost().Message;
            }

            var color = new Models.Color {Value = colorString};

            return PartialView(color);
        }
    }
}