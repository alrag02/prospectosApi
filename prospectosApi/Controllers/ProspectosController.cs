using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prospectosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProspectosController : ControllerBase
    {
        // GET: api/<ProspectosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProspectosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProspectosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProspectosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProspectosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
