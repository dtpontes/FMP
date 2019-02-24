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
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;


        public PacienteController(IPacienteService pacienteService)
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
            var pacientes = _pacienteService.ObterTodos().Select(x=> new { pacienteId = x.PacienteId, Nome= x.Nome,
                                                            cidadeId = x.CidadeId, endereco =  x.Endereco,
                                                            complemento =x.Complemento,cep=x.CEP, cpf = x.CPF,
                                                            telCelular = x.TelCelular, telResidencial = x.TelResidencial,
                                                            email = x.Email, dataCadastro = x.DataCadastro,
                                                            creditos = x.Creditos,rg = x.RG, foto = x.Foto });
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
        [EnableCors("SiteCorsPolicy")]
        [HttpPost]
        public void Post([FromBody]Paciente paciente)
        {
            
            _pacienteService.Adicionar(paciente);
        }

        // PUT api/values/5
        [EnableCors("SiteCorsPolicy")]
        [Route("[action]/{id}")]
        [HttpPut("{id}")]
        public void AtualizarPaciente(int id, [FromBody]Paciente  value)
        {
            _pacienteService.Atualizar(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/values
        [HttpGet]
        [EnableCors("SiteCorsPolicy")]
        [ProducesResponseType(typeof(List<Paciente>), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [Route("[action]")]
        public ActionResult<IEnumerable<string>> ObterEstados()
        {

            var estados = _pacienteService.ObterTodosEstados();
            return Ok(estados);

        }

        // GET api/values/5
        [EnableCors("SiteCorsPolicy")]
        [Route("[action]/{id}")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> ObterCidadesPorIdEstado(int id)
        {
            var cidades = _pacienteService.ObterCidadesPorIdEstado(id);
            return Ok(cidades);
        }

        // PUT api/values/5
        [EnableCors("SiteCorsPolicy")]
        [Route("[action]/{id}")]
        [HttpPut("{id}")]
        public void UtilizarCredito(int id, [FromBody]Paciente value)
        {
            _pacienteService.UtilizarCredito(value);
        }

        // POST api/values
        [EnableCors("SiteCorsPolicy")]
        [HttpPost]
        [Route("[action]")]
        public void AdicionarCredito([FromBody]PacienteCredito pacienteCredito)
        {

            _pacienteService.AdicionarCredito(pacienteCredito);
        }

        // GET api/values/5
        [EnableCors("SiteCorsPolicy")]
        [Route("[action]/{data}")]
        [HttpGet]
        public ActionResult<IEnumerable<PacienteDebito>> ObterAtendimentosPorData(string data)
        {
            DateTime dataInicial = Convert.ToDateTime(data);
            var pacientes = _pacienteService.ObterAtendimentosPorData(dataInicial).Select(x => new {
                pacienteId = x.PacienteId,
                Nome = x.Paciente.Nome,                
                cpf = x.Paciente.CPF,
                telCelular = x.Paciente.TelCelular,
                telResidencial = x.Paciente.TelResidencial,
                email = x.Paciente.Email,
                dataAtendimento = x.Data
            });
            return Ok(pacientes);

        }
    }
}
