using Domain.Interfaces.Application.BuscaEndereco;
using Domain.Models.Endereco;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoMarluce2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BuscaEnderecoController : ControllerBase
    {
        private readonly IBuscaEndereco _buscaEndereco;
        public BuscaEnderecoController(IBuscaEndereco buscaEndereco)
        {
            _buscaEndereco = buscaEndereco ?? throw new ArgumentNullException(nameof(buscaEndereco));
        }

        [ProducesResponseType(typeof(IEnumerable<EnderecoSaida>), StatusCodes.Status200OK)]
        [HttpGet("")]
        public async Task<IActionResult> ConsultarEndereco([FromQuery] EnderecoEntrada enderecoEntrada)
        {
          return Ok (await _buscaEndereco.ConsultarEndereco(enderecoEntrada));
        }
    }
}
