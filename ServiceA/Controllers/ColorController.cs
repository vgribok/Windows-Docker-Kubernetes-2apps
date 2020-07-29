using System;
using System.Web.Http;

namespace ServiceA.Controllers
{
    [RoutePrefix("colors")]
    public class ColorController : ApiController
    {
        [Route]
        public string Get()
        {
            string envColor = Environment.GetEnvironmentVariable("COLOR");
            return string.IsNullOrWhiteSpace(envColor) ? "Green" : envColor;
        }

        // GET api/color/Red
        [Route("{color}")]
        public string Get(string color)
        {
            return color;
        }
    }
}
