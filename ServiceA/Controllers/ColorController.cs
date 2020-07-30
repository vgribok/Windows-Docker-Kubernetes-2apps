using System.Web.Http;
using ServiceA.BizLogic;

namespace ServiceA.Controllers
{
    [RoutePrefix("colors")]
    public class ColorController : ApiController
    {
        [Route]
        public string Get()
        {
            return AppSettingNames.Color.Get() ?? "Yellow";
        }

        // GET api/color/Red
        [Route("{color}")]
        public string Get(string color)
        {
            return color;
        }
    }
}
