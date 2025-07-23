using Microsoft.AspNetCore.Mvc;
using UnimedBackend.Models;
using UnimedBackend.Services.Interfaces;

namespace UnimedBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        public TarefasController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpPost("salvar")]
        public async Task<IActionResult> Salvar([FromBody] TarefaModel tarefa)
        {
            await _tarefaService.CreateAsync(tarefa);
            return Ok();
        }

        [HttpGet("listar-por-id")]
        public async Task<IActionResult> ListarPorId(int id)
        {
            var tarefa = await _tarefaService.GetByIdAsync(id);
            return Ok(tarefa);
        }

        [HttpGet("listar-todos")]
        public async Task<IActionResult> ListarTodos()
        {
            var tarefa = await _tarefaService.GetAllAsync();
            return Ok(tarefa);
        }
    }
}
