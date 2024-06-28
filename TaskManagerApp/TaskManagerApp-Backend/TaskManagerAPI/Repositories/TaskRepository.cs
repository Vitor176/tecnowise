using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;
using TaskManagerAPI.Repositories.Interface;

namespace TaskManagerAPI.Repositories
{
	public class TaskRepository : ITaskRepository
    {
        private readonly TaskContext _context;
        private readonly ILogger<TaskRepository> _logger;

        public TaskRepository(TaskContext context, ILogger<TaskRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<TaskModel>> GetTasks()
        {
            _logger.LogInformation("Recuperando tasks do banco de dados");
            return await _context.Tasks.AsNoTracking().ToListAsync();
        }

        public async Task<TaskModel> GetTask(int id)
        {
			_logger.LogInformation($"Recuperando task do banco pelo Id : {id}");
			return await _context.Tasks.AsNoTracking().FirstOrDefaultAsync(X => X.Id == id);
        }

        public async Task<TaskModel> AddTask(TaskModel task)
        {
            _logger.LogInformation("Salvando task no banco de dados");
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskModel> UpdateTask(TaskModel task)
        {

            _logger.LogInformation("Atualizando task existente");
            _context.Entry(task).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task DeleteTask(int id)
        {
            _logger.LogInformation($"Excluindo task do banco pelo id : {id}");
            var task = await _context.Tasks.FindAsync(id);
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
        }
    }
}
