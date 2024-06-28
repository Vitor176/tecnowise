using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Services.Interface;

namespace TaskManagerAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TasksController : ControllerBase
	{
		private readonly ITaskService _taskService;
		private readonly ILogger<TasksController> _logger;

		public TasksController(ITaskService taskService, ILogger<TasksController> logger)
		{
			_taskService = taskService ?? throw new
				ArgumentNullException(nameof(taskService));
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<TaskModel>>> GetTasks()
		{
			try
			{
				_logger.LogInformation("Iniciando Consulta das Tasks");
				var tasks = await _taskService.GetTasks();

				if (tasks.Count() > 0)
				{
					_logger.LogInformation($"Tasks encontrada");
					return Ok(tasks);
				}

				else
				{
					_logger.LogInformation("Tasks nao encontrada");
					return NotFound("Não Existem Task´s.");
				}
			}
			catch (Exception ex)
			{
				_logger.LogInformation($"Erro interno no servidor {ex.Message}");
				return StatusCode(500, new { error = "Erro interno no servidor.", details = ex.Message });
			}
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<TaskModel>> GetTask(int id)
		{
			try
			{
				var task = await _taskService.GetTask(id);

				if (task == null)
				{
					_logger.LogInformation($"Nenhuma task para o ID {id}");
					return NotFound("Nenhuma Task para o Id Informado");
				}

				else
				{
					_logger.LogInformation("Task encontrada");
					return Ok(task);
				}

			}
			catch (Exception ex)
			{
				_logger.LogInformation($"Erro interno no servidor {ex.Message}");
				return StatusCode(500, new { error = "Erro interno no servidor.", details = ex.Message });
			}
		}

		[HttpPost]
		public async Task<ActionResult<TaskModel>> PostTask(TaskModel task)
		{
			try
			{
				var createdTask = await _taskService.AddTask(task);
				_logger.LogInformation($"Task Criada: {createdTask}");
				return CreatedAtAction(nameof(GetTask), new { id = createdTask.Id }, createdTask);

			}
			catch (Exception ex)
			{
				_logger.LogInformation($"Erro interno no servidor {ex.Message}");
				return StatusCode(500, new { error = "Erro interno no servidor.", details = ex.Message });
			}
		}

		[HttpPut]
		public async Task<ActionResult<TaskModel>> UpdateTask(TaskModel task)
		{
			try
			{
				var updateTask = await _taskService.UpdateTask(task);
				if (updateTask == null) return BadRequest("Não Foi possível atualizar a task");
				else return Ok(updateTask);
			}
			catch (Exception ex)
			{
				_logger.LogInformation($"Erro interno no servidor {ex.Message}");
				return StatusCode(500, new { error = "Erro interno no servidor.", details = ex.Message });
			}
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTask(int id)
		{
			try
			{
				await _taskService.DeleteTask(id);
				return NoContent();
			}
			catch (Exception ex)
			{
				_logger.LogInformation($"Erro interno no servidor {ex.Message}");
				return StatusCode(500, new { error = "Erro interno no servidor.", details = ex.Message });
			}
		}
	}
}
