﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class TaskTicket
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public Priority Priority { get; set; } = Priority.Unassigned;
        public Status Status { get; set; } = Status.NotStarted;
    }

    public enum Priority
    {
        Unassigned,
        Low,
        Medium,
        High
    }

    public enum Status
    {
        NotStarted,
        InProgress,
        Done,
        Blocked
    }
}