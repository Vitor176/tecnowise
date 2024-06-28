using TaskManagerAPI.Repositories.Interface;
using TaskManagerAPI.Services.Interface;

namespace TaskManagerAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ILogger<TaskService> _logger;

        public TaskService(ITaskRepository taskRepository, ILogger<TaskService> logger)
        {
            _taskRepository = taskRepository ?? throw new ArgumentNullException(nameof(taskRepository));
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
		}

        public async Task<IEnumerable<TaskModel>> GetTasks()
        {
            _logger.LogInformation("Service chamando o repositório para retornar todas as Tasks");
            return await _taskRepository.GetTasks();
        }

        public async Task<TaskModel> GetTask(int id)
        {
			_logger.LogInformation($"Service chamando o repositório para retornar task pelo Id {id}");
			return await _taskRepository.GetTask(id);
        }

        public async Task<TaskModel> AddTask(TaskModel task)
        {
			_logger.LogInformation("Service chamando o repositório para criar nova task.");
			if (string.IsNullOrEmpty(task.Title)) 
                throw new ArgumentException("Title cannot be null or empty");

            return await _taskRepository.AddTask(task);
        }

        public async Task DeleteTask(int id)
        {
			_logger.LogInformation($"Service chamando o repositório para deletar pelo id {id}");
			await _taskRepository.DeleteTask(id);
        }
		public async Task<TaskModel> UpdateTask(TaskModel task)
		{
			_logger.LogInformation("Service chamando o repositório para atualizar");
			return await _taskRepository.UpdateTask(task);
		}
	}
}
