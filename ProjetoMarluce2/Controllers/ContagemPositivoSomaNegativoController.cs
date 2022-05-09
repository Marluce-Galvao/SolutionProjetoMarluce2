using Domain.Interfaces.Application.ContagemPositivoSomaNegativo;
using Domain.Models.ContagemPositivoSomaNegativo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMarluce2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContagemPositivoSomaNegativoController : ControllerBase
    {
        private readonly IContagemPositivoSomaNegativo _contagemPositivoSomaNegativo;

        public ContagemPositivoSomaNegativoController(IContagemPositivoSomaNegativo contagemPositivoSomaNegativo)
        {
            _contagemPositivoSomaNegativo = contagemPositivoSomaNegativo;
        }

        [ProducesResponseType(typeof(ContagemPositivoSomaNegativoSaida), StatusCodes.Status200OK)]
        [HttpPost("")]
        public async Task<IActionResult> ContarPositivosESomarNegativos(ContagemPositivoSomaNegativoEntrada contagemPositivoSomaNegativo)
        {
            return Ok(await _contagemPositivoSomaNegativo.ContarPositivosESomarNegativos(contagemPositivoSomaNegativo));
        }




    }
}
