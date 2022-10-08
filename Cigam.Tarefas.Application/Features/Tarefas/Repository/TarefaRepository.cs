using Cigam.Tarefas.Application.Features.Tarefas.Models.AddTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.EditTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.GetAllTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Repository.Interface;
using Cigam.Tarefas.Models;
using Dapper;
using System.Data;

namespace Cigam.Tarefas.Application.Features.Tarefas.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly DapperContext _context;
        public TarefaRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<TarefaAddOutput> AddTarefa(TarefaAddInput tarefa, CancellationToken cancellationToken)
        {
            var query = @"INSERT INTO [dbo].[Tarefas] ([Descricao] , [Status])
                            VALUES (@Descricao , @Status)" +
                         "SELECT CAST(SCOPE_IDENTITY() as int)";

            var parameters = new DynamicParameters();
            parameters.Add("Descricao", tarefa.Descricao, DbType.String);
            parameters.Add("Status", tarefa.Status, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(query, parameters);
                var createdCompany = new TarefaAddOutput
                {
                    Id = id
                };
                return createdCompany;
            }
        }

        public async Task<TarefaEditOutput> EditTarefa(TarefaEditInput tarefa, CancellationToken cancellationToken)
        {
            var query = @"UPDATE [dbo].[Tarefas]
                            SET[Descricao] = @Descricao
                            ,[Status] = @Status
                            WHERE IdTarefa = @IdTarefa";

            var parameters = new DynamicParameters();
            parameters.Add("IdTarefa", tarefa.Id, DbType.Int32);
            parameters.Add("Status", tarefa.Status, DbType.String);
            parameters.Add("Descricao", tarefa.Descricao, DbType.String);
            using var connection = _context.CreateConnection();
            var result = await connection.ExecuteAsync(query, parameters);

            return new TarefaEditOutput { Result = result > 0 };
        }

        public async Task<IEnumerable<GetAllTarefaOutput>> GetAllTarefa(GetAllTarefaInput tarefa, CancellationToken cancellationToken)
        {
            var query = @"SELECT [IdTarefa]
                        ,[Descricao]
                        ,[Status]
                         FROM [Tarefas].[dbo].[Tarefas]";
            using (var connection = _context.CreateConnection())
            {
                var tarefas = await connection.QueryAsync<GetAllTarefaOutput>(query);
                return tarefas.ToList();
            }
        }

        public async Task<GetTarefaByIdOutput> GetTarefaById(GetTarefaByIdInput tarefa, CancellationToken cancellationToken)
        {
            var query = $@"SELECT [IdTarefa]
                            ,[Descricao]
                            ,[Status]
                             FROM [Tarefas].[dbo].[Tarefas]
                            WHERE [IdTarefa] = {tarefa.Id}";

            using (var connection = _context.CreateConnection())
            {
                var tarefas = await connection.QueryFirstAsync<GetTarefaByIdOutput>(query);
                return tarefas;
            }
        }
    }
}
