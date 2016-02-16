using System.Collections.Generic;
using System.Web.Http;
using BusinessServices.DomainLogic.Interfaces.Services;
using PeriodicalsStore.WebApi.Models;
using PeriodicalsStore.WebApi.Services;

namespace PeriodicalsStore.WebApi.Controllers
{
    public class PeriodicalController : ApiController
    {
        private readonly IPeriodicalService _periodicalService;

        public PeriodicalController(IPeriodicalService periodicalService)
        {
            _periodicalService = periodicalService;
        }

        // GET: api/Periodical
        [Route("periodicals")]
        public IEnumerable<PeriodicalDto> Get()
        {

            return _periodicalService.GetAll().ToDto();
        }

        // GET: api/Periodical/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Periodical
        public void Post([FromBody] PeriodicalDto periodical)
        {
            _periodicalService.Create(periodical.ToModel());
        }

        // PUT: api/Periodical/5
        public void Put([FromBody] PeriodicalDto periodical)
        {
            _periodicalService.Edit(periodical.ToModel());
        }

        // DELETE: api/Periodical/5
        public void Delete(int id)
        {
            //_periodicalService.Delete(id);
        }
    }
}
