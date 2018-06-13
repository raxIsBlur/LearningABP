using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LearningABP.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LearningABP.Tasks
{
    public class Task : Entity<long>, IHasCreationTime
    {
        [ForeignKey("AssignedPersonId")]
        public virtual Person AssignedPerson { get; set; }
        public virtual int? AssignedPersonId { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual TaskState State { get; set; }

        public Task()
        {
            CreationTime = DateTime.Now;
            State = TaskState.Active;
        }
    }
}
