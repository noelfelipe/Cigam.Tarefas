using MediatR;

namespace Cigam.Tarefas.Application.Features.Tarefas.Models.GetAllTarefa
{
    public class GetAllTarefaInput : IRequest<IEnumerable<GetAllTarefaOutput>>
    {
    }
}
