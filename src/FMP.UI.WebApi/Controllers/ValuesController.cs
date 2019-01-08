using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace FMP.UI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;

        public ValuesController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var teste = _pacienteService.ObterTodos();
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
