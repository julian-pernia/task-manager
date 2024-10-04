using Task = TaskManager.Shared.Models.Task;

namespace TaskManager.Client.ModelAdapter
{
    public class SelectableTask : Task
    {
        public SelectableTask(Task task)
        {
            Id = task.Id;
            Title = task.Title;
            Description = task.Description;
            Created = task.Created;
            CreatedBy = task.CreatedBy;
            Priority = task.Priority;
            Status = task.Status;

            IsSelected = false;
        }
        public bool IsSelected { get; set; } = false;

        public static List<SelectableTask> ConvertToSelectable(IEnumerable<Task> tasks)
        {
            return tasks.Select(task => new SelectableTask(task)).ToList();
        }
    }
}
