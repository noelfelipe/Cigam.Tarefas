using Cigam.Tarefas.Application.Features.Tarefas.Models.GetAllTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Repository.Interface;
using MediatR;

namespace Cigam.Tarefas.Application.Features.Tarefas.Handler;

public class GetAllTarefasHandler : IRequestHandler<GetAllTarefaInput, IEnumerable<GetAllTarefaOutput>>
{
    private readonly ITarefaRepository _tarefaRepository;

    public GetAllTarefasHandler(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }
    public Task<IEnumerable<GetAllTarefaOutput>> Handle(GetAllTarefaInput request, CancellationToken cancellationToken)
    {
        return _tarefaRepository.GetAllTarefa(request, cancellationToken);
    }
}
