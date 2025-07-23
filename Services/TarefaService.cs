using Microsoft.EntityFrameworkCore;
using UnimedBackend.Data;
using UnimedBackend.Models;
using UnimedBackend.Services.Interfaces;

namespace UnimedBackend.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly BancoContext _context;

        public TarefaService(BancoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TarefaModel>> GetAllAsync()
        {
           return await _context.Tarefas.ToListAsync();
        }
        public async Task<TarefaModel?> GetByIdAsync(int id)
        {
            return await _context.Tarefas.FirstOrDefaultAsync(t => t.ID == id);
        }
        public async Task<TarefaModel> CreateAsync(TarefaModel tarefa)
        {
            await _context.Tarefas.AddAsync(tarefa);
            await _context.SaveChangesAsync();

            return tarefa;
        }
    }

}
