using TaskManager.Models;

namespace TaskManager.Components.ModelAdapter
{
    public class SelectableTask : TaskTicket
    {
        public SelectableTask(TaskTicket task)
        {
            Id = task.Id;
            Title = task.Title;
            Description = task.Description;
            CreatedOn = task.CreatedOn;
            CreatedBy = task.CreatedBy;
            Priority = task.Priority;
            Status = task.Status;

            IsSelected = false;
        }
        public bool IsSelected { get; set; } = false;

        public static List<SelectableTask> ConvertToSelectable(IEnumerable<TaskTicket> tasks)
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

        public string CreatedOnString
        {
            get => CreatedOn.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}