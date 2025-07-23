using UnimedBackend.Models;

namespace UnimedBackend.Services.Interfaces
{
    public interface ITarefaService
    {
        Task<IEnumerable<TarefaModel>> GetAllAsync();
        Task<TarefaModel?> GetByIdAsync(int id);
        Task<TarefaModel> CreateAsync(TarefaModel tarefa);
    }
}
