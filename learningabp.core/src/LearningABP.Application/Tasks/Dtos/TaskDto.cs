using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningABP.Tasks.Dtos
{
    public class TaskDto : EntityDto<long>
    {
        public int? AssignedPersonId { get; set; }
        public string AssignedPersonName { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public byte State { get; set; }

        public override string ToString()
        {
            return string.Format(
                "[Task Id={0}, Description={1}, CreationTime={2}, AssignedPersonName={3}, State={4}]",
                Id,
                Description,
                CreationTime,
                AssignedPersonId,
                (TaskState)State
            );
        }
    }
}
