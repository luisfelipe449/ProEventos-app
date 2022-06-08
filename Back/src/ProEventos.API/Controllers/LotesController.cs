using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Application.Contracts;
using ProEventos.Application.DTO;
using ProEventos.Domain;
using ProEventos.Persistence.Context;

namespace ProLotes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LotesController : ControllerBase
    {
        private readonly ILotesService _lotesService;

        public LotesController(ILotesService lotesService)
        {
            _lotesService = lotesService;
        }

        [HttpGet("{eventoId}")]
        public async Task<IActionResult> Get(int eventoId)
        {
            try
            {
                var lotes = await _lotesService.GetEventoById(true);
                if (lotes == null)
                    return NoContent();

                return Ok(lotes);
            }
            catch (Exception ex)
            {
                return this.StatusCode(
                    StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar lotes. Erro: {ex.Message}"
                );
            }
        }

        [HttpPut("{eventoId}")]
        public async Task<IActionResult> Put(LoteDto[] model, int eventoId)
        {
            try
            {
                var lote = await _lotesService.UpdateLote(eventoId, model);
                if (lote == null)
                    return BadRequest("Erro ao tentar atualizar lote.");

                return Ok(lote);
            }
            catch (Exception ex)
            {
                return this.StatusCode(
                    StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar recuperar lotes. Erro: {ex.Message}"
                );
            }
        }

        [HttpDelete("{eventoId}/{loteId}")]
        public async Task<IActionResult> DeleteHttpDelete(int eventoId, int loteId)
        {
            try
            {
                var evento = await _eventoService.GetEventoByIdAsync(eventoId, true);
                if (await _lotesService.DeleteLote(eventoId))
                {
                    return Ok("Deletado.");
                }
                else
                {
                    return BadRequest("Lote não encontrado.");
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(
                    StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar deletar lotes. Erro: {ex.Message}"
                );
            }
        }
    }
}
