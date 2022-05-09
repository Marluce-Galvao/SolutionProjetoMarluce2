using Domain.Interfaces.Application;
using Domain.Interfaces.Application.Automacao;
using Domain.Models.Automacoes;
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
    public class AutomacaoController : ControllerBase
    {
        private readonly IConsultaTodasautomacoes _consultaTodasautomacoes;
        private readonly IInseriAutomacao _inseriAutomacao;
        private readonly IConsultaPorId _consultaPorId;
        private readonly IDeletaAutomacao _deletaAutomacao;
        private readonly IAlteraAutomacao _alteraAutomacao;

        public AutomacaoController(IConsultaTodasautomacoes consultaTodasautomacoes, IInseriAutomacao inseriAutomacao,
                                   IConsultaPorId consultaPorId, IDeletaAutomacao deletaAutomacao, IAlteraAutomacao alteraAutomacao)
        {
            _consultaTodasautomacoes = consultaTodasautomacoes ?? throw new ArgumentNullException(nameof(consultaTodasautomacoes));
            _inseriAutomacao = inseriAutomacao ?? throw new ArgumentNullException(nameof(inseriAutomacao));
            _consultaPorId = consultaPorId ?? throw new ArgumentNullException(nameof(consultaPorId));
            _deletaAutomacao = deletaAutomacao ?? throw new ArgumentNullException(nameof(deletaAutomacao));
            _alteraAutomacao = alteraAutomacao ?? throw new ArgumentNullException(nameof(alteraAutomacao));
        }

        [ProducesResponseType(typeof(List<AutomacaoSaida>), StatusCodes.Status200OK)]
        [HttpGet("")]
        public async Task<IActionResult> ConsultarTodasAutomacoes()
        {
            return Ok(await _consultaTodasautomacoes.ConsultarTodos());
        }

        [ProducesResponseType(typeof(AutomacaoSaida), StatusCodes.Status200OK)]
        [HttpGet("id/{id}")]
        public async Task<IActionResult> ConsultarPorId([FromRoute] int id)
        {
            return Ok(await _consultaPorId.ConsultarPorId(id));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost("")]
        public async Task<IActionResult> InserirNovaAutomacao([FromBody] AutomacaoEntrada automacaoEntrada)
        {
            await _inseriAutomacao.InserirNovaAutomacao(automacaoEntrada);
            return Created("", null);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpDelete("id/{id}")]
        public async Task<IActionResult> DeletarAutomacao([FromRoute] int id)
        {
            try
            {
                await _deletaAutomacao.DeletarAutomacao(id);

                return Ok();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPut("Update/Id/{id}")]
        public async Task<IActionResult> UpdateAutomacao([FromRoute] int id, [FromBody] AutomacaoEntrada automacaoEntrada)
        {
            try
            {
                await _alteraAutomacao.UpdateAutomacao(id, automacaoEntrada);
                return Ok();
            }
            catch(Exception ex)
            {
                return  BadRequest(ex.Message);
            }
        }
    }
}
