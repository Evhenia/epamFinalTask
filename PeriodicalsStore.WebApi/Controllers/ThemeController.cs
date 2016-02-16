using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeriodicalsStore.WebApi.Controllers
{
    public class ThemeController : ApiController
    {
        // GET: api/Theme
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Theme/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Theme
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Theme/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Theme/5
        public void Delete(int id)
        {
        }
    }
}
