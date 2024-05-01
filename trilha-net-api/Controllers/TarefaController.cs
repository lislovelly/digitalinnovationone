using Microsoft.AspNetCore.Mvc;
using trilha_net_api.Context;
using trilha_net_api.Entities;

namespace trilha_net_api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TarefaController(TarefaContext context) : ControllerBase
    {

        private readonly TarefaContext _context = context;
        private readonly string titulo;

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var tarefas = _context.Tarefas.ToList();
            return Ok(tarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var tarefas = _context.Tarefas.Where(x => x.Titulo.Contains(titulo));
            return Ok(tarefas);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefas = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(tarefas);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            var tarefas = _context.Tarefas.Where(x => x.Status == status);
            return Ok(tarefas);
        }

        [HttpGet("{Id}")]
        public IActionResult ObterPorId (int Id)
        {
            var tarefa = _context.Tarefas.Find(Id);
            if (tarefa == null)
                return NotFound();
            
            return Ok(tarefa);        
        }

        [HttpPut("{Id}")]
        public IActionResult Atualizar(int Id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(Id);

            if (tarefaBanco == null)
                return NotFound();
            
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;

            _context.SaveChanges();
            return Ok(tarefaBanco);
           
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();
            return NoContent();
        }


    }
}