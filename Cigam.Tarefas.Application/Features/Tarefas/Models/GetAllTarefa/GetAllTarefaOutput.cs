
using System.Text.Json.Serialization;

namespace Cigam.Tarefas.Application.Features.Tarefas.Models.GetAllTarefa
{
    public class GetAllTarefaOutput
    {
        public int IdTarefa { get; set; }
        public string Descricao { get; set; }
        [JsonIgnore]
        public string Status { get; set; }
        public string DescricaoStatus => Status == "C" ? "Concluido" : "Pendente";
    }
}
