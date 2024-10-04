using Task = TaskManager.Shared.Models.Task;
using Status = TaskManager.Shared.Models.Status;
using Priority = TaskManager.Shared.Models.Priority;

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

        public string StatusName
        {
            get => Status switch
            {
                Status.NotStarted => "Not Started",
                Status.InProgress => "In Progress",
                Status.Done => "Done",
                Status.Blocked => "Blocked",
                _ => "Error"
            };
        }

        public string PriorityName
        {
            get => Priority.ToString();
        }
    }
}
