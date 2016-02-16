using System.Collections.Generic;
using System.Web.Http;
using PeriodicalsStore.WebApi.Models;

namespace PeriodicalsStore.WebApi.Controllers
{
    public class ThemeController : ApiController
    {
        // GET: api/Theme
        public IEnumerable<ThemeDto> Get()
        {
            var themes = new List<ThemeDto>
            {
                new ThemeDto {Id= 1, Name = "Name1"},
                new ThemeDto {Id= 2, Name = "Name2"},
                new ThemeDto {Id= 3, Name = "Name3"},
                new ThemeDto {Id= 4, Name = "Name4"},
                new ThemeDto {Id= 5, Name = "Name5"}
            };
            return themes;
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
