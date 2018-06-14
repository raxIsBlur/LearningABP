using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LearningABP.Tasks.Dtos
{
    public class UpdateTaskInput : ICustomValidate
    {
        public long TaskId { get; set; }

        public int? AssignedPersonId { get; set; }

        public TaskState? State { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            if (AssignedPersonId == null && State == null) {
                context.Results.Add(new ValidationResult("Both of AssignedPersonId and State cannot be null in order to update a Task!", new[] {  "AssignedPersonId", "State"}));
            }
        }

        public override string ToString()
        {
            return string.Format("[UpdateTaskInput > TaskId = {0}, AssignedPersonId = {1}, State = {2}]", TaskId, AssignedPersonId, State);
        }
    }
}
