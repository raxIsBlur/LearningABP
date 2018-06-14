using System;
using System.Collections.Generic;
using System.Text;

namespace LearningABP.Tasks.Dtos
{
    public class GetTaskInput
    {
        public TaskState? State { get; set; }
        public int? AssignedPersonId { get; set; }
    }
}
