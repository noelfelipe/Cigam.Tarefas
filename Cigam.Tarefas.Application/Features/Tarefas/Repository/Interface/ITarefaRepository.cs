using Cigam.Tarefas.Application.Features.Tarefas.Models.AddTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.EditTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.GetAllTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cigam.Tarefas.Application.Features.Tarefas.Repository.Interface
{
    public interface ITarefaRepository
    {
        Task<TarefaAddOutput> AddTarefa(TarefaAddInput tarefa, CancellationToken cancellationToken);
        Task<TarefaEditOutput> EditTarefa(TarefaEditInput tarefa, CancellationToken cancellationToken);
        Task<IEnumerable<GetAllTarefaOutput>> GetAllTarefa(GetAllTarefaInput tarefa, CancellationToken cancellationToken);
        Task<GetTarefaByIdOutput> GetTarefaById(GetTarefaByIdInput tarefa, CancellationToken cancellationToken);
    }
}
