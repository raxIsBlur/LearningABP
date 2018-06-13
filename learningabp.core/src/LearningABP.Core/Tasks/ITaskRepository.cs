using System;
using System.Collections.Generic;
using System.Text;

namespace LearningABP.Tasks
{
    public interface ITaskRepository
    {
        List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state);
    }
}
