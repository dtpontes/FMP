using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMP.ApplicationCore.Entities;
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
        [ProducesResponseType(typeof(List<Paciente>), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult<IEnumerable<string>> Get()
        {
            var pacientes = _pacienteService.ObterTodos();
            return Ok(pacientes);
            
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(List<Paciente>), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult<IEnumerable<string>> Get(string nome, string cpf )
        {

            var pacientes = _pacienteService.ObterPorNomeECPF(nome,cpf );
            return Ok(pacientes);

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
