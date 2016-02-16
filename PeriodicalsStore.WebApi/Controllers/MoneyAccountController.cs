using System.Collections.Generic;
using System.Web.Http;

namespace PeriodicalsStore.WebApi.Controllers
{
    public class MoneyAccountController : ApiController
    {
        // GET: api/MoneyAccount
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET: api/MoneyAccount/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MoneyAccount
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MoneyAccount/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MoneyAccount/5
        public void Delete(int id)
        {
        }
    }
}
