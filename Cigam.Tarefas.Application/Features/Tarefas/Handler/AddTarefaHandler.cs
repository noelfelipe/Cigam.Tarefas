using Cigam.Tarefas.Application.Features.Tarefas.Models.AddTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Repository.Interface;
using MediatR;

namespace Cigam.Tarefas.Application.Features.Tarefas.Handler;

public class AddTarefaHandler : IRequestHandler<TarefaAddInput, TarefaAddOutput>
{

    private readonly ITarefaRepository _tarefaRepository;

    public AddTarefaHandler(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }

    public Task<TarefaAddOutput> Handle(TarefaAddInput request, CancellationToken cancellationToken)
    {
        return _tarefaRepository.AddTarefa(request, cancellationToken);
    }
}
