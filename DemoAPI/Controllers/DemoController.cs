using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : Controller
    {
        [HttpGet]
        public POSSetting Get()
        {
            var mockPosReq = HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "cnx-mockpos").Value.ToString();
            var mockPosSettings = JsonConvert.DeserializeObject<Dictionary<string, string>>(mockPosReq);
            var response = DataModificationService.GetModifiedData(mockPosSettings);
            return response;
        }
    }
}
