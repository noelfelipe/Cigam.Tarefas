using Cigam.Tarefas.Application.Features.Tarefas.Models.EditTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Repository.Interface;
using MediatR;

namespace Cigam.Tarefas.Application.Features.Tarefas.Handler;

public class EditTarefaHandler : IRequestHandler<TarefaEditInput, TarefaEditOutput>
{
    private readonly ITarefaRepository _tarefaRepository;

    public EditTarefaHandler(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }
    public Task<TarefaEditOutput> Handle(TarefaEditInput request, CancellationToken cancellationToken)
    {
       return _tarefaRepository.EditTarefa(request, cancellationToken);
    }
}
