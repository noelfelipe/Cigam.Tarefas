using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Cigam.Tarefas.Application.Features.Tarefas.Models.EditTarefa
{
    public class TarefaEditInput : IRequest<TarefaEditOutput>
    {
        [Required(ErrorMessage = "ID é obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Descricao é obrigatório")]
        public string Descricao { get; set; }
        public string Status = "C";
    }
}
