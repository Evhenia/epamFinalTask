using System.Collections.Generic;
using System.Web.Http;

namespace PeriodicalsStore.WebApi.Controllers
{
    public class SubscriptionController : ApiController
    {
        // GET: api/Subscription
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET: api/Subscription/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Subscription
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Subscription/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Subscription/5
        public void Delete(int id)
        {
        }
    }
}
