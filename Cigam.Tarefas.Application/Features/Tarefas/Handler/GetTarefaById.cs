using Cigam.Tarefas.Application.Features.Tarefas.Models.AddTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.GetAllTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Repository.Interface;
using MediatR;

namespace Cigam.Tarefas.Application.Features.Tarefas.Handler;

public class GetTarefaById : IRequestHandler<GetTarefaByIdInput, GetTarefaByIdOutput>
{
    private readonly ITarefaRepository _tarefaRepository;

    public GetTarefaById(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }

    public Task<GetTarefaByIdOutput> Handle(GetTarefaByIdInput request, CancellationToken cancellationToken)
    {
        return _tarefaRepository.GetTarefaById(request, cancellationToken);
    }
}
