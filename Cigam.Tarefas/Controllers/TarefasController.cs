using Cigam.Tarefas.Application.Features.Tarefas.Models.GetAllTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.EditTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.AddTarefa;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Cigam.Tarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TarefasController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<ActionResult> AddTarefa(TarefaAddInput command)
        {
            try
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    ex.Message
                });
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdateTarefa(TarefaEditInput command)
        {
            try
            {
                var result = await _mediator.Send(command);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    ex.Message
                });
            }
        }

        [HttpGet, Route("GetAllTarefas")]
        public async Task<ActionResult<IEnumerable<GetAllTarefaOutput>>> GetAllTarefas()
        {
            try
            {
                var query = new GetAllTarefaInput
                {
                };
                var result = await _mediator.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    ex.Message
                });
            }
        }

        [HttpGet, Route("GetTarefaById")]
        public async Task<ActionResult<GetTarefaByIdOutput>> GetTarefaById(int command)
        {
            try
            {
                var query = new GetTarefaByIdInput
                {
                    Id = command
                };

                var result = await _mediator.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    ex.Message
                });
            }
        }

    }
}
