using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Cigam.Tarefas.Application.Features.Tarefas.Models.AddTarefa
{
    public class TarefaAddInput : IRequest<TarefaAddOutput>
    {
        [Required(ErrorMessage = "Descricao é obrigatório")]
        public string Descricao { get; set; }
        public string Status = "P";
    }
}
