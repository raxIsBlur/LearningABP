using Abp.Application.Services;
using LearningABP.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningABP.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        GetTasksOutput GetTasks(GetTaskInput input);

        void UpdateTask(UpdateTaskInput input);

        void CreateTask(CreateTaskInput input);
    }
}
