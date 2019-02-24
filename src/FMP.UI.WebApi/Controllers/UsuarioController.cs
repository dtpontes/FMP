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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
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
            var usuarios = _usuarioService.ObterTodos();
            return Ok(usuarios);
            
        }

        // PUT api/values/5
        [EnableCors("SiteCorsPolicy")]
        [Route("[action]")]
        [HttpGet]
        public ActionResult<string> getLoginSenha(string login, string senha)
        {
            var usuario = _usuarioService.ObterPorLoginESenha(login, senha);
            return Ok(usuario);

            
        }
        
    }
}
