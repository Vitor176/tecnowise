namespace TaskManagerAPI.Repositories.Interface
{
	public interface ITaskRepository
	{
		public Task<IEnumerable<TaskModel>> GetTasks();
		public Task<TaskModel> GetTask(int id);
		public Task<TaskModel> AddTask(TaskModel task);
		public Task<TaskModel> UpdateTask(TaskModel task);
		public Task DeleteTask(int id);
	}
}
