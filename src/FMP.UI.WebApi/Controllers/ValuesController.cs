using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMP.ApplicationCore.Entities;
using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

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
        [EnableCors("SiteCorsPolicy")]
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
        [EnableCors("SiteCorsPolicy")]
        [ProducesResponseType(typeof(List<Paciente>), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [Route("[action]")]
        public ActionResult<IEnumerable<string>> GetByNameECpf(string nome, string cpf )
        {

            var pacientes = _pacienteService.ObterPorNomeECPF(nome,cpf );
            return Ok(pacientes);

        }

        // GET api/values/5
        [EnableCors("SiteCorsPolicy")]
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var paciente = _pacienteService.ObterPorId(id);
            return Ok(paciente);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [EnableCors("SiteCorsPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Paciente  value)
        {
            var paciente = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
