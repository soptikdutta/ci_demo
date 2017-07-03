using System.Collections.Generic;
using System.Web.Http;

namespace Services.Controllers
{
    public class ContentController : ApiController
    {
        // GET api/values 
        [HttpGet]
        [Route("", Name = "Get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        [HttpGet]
        [Route("{id}", Name = "GetById")]
        public string Get(int id)
        {
            return "value";
        }
        
    }
}
