using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Cigam.Tarefas.Application.Features.Tarefas.Models.AddTarefa
{
    public class GetTarefaByIdInput : IRequest<GetTarefaByIdOutput>
    {
        [Required(ErrorMessage = "ID é obrigatório")]
        public int Id { get; set; }
    }
}
