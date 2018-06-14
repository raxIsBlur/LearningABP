using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using LearningABP.People;
using LearningABP.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningABP.Tasks
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IRepository<Person> _personRepository;

        public TaskAppService(ITaskRepository taskRepository, IRepository<Person> personRepository)
        {
            _taskRepository = taskRepository;
            _personRepository = personRepository;
        }

        public GetTasksOutput GetTasks(GetTaskInput input)
        {
            var tasks = _taskRepository.GetAllWithPeople(input.AssignedPersonId, input.State);

            return new GetTasksOutput
            {
                Tasks = Mapper.Map<List<TaskDto>>(tasks)
            };
        }

        public void CreateTask(CreateTaskInput input)
        {
            Logger.Info("Creating a task for input: " + input);

            var task = new Task { Description = input.Description };

            if (input.AssignedPersonId.HasValue)
                task.AssignedPersonId = input.AssignedPersonId;

            _taskRepository.Insert(task);
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            Logger.Info("Updating a task for input: " + input);

            var task = _taskRepository.Get(input.TaskId);

            if (input.State.HasValue)
                task.State = input.State.Value;

            if (input.AssignedPersonId.HasValue)
                task.AssignedPerson = _personRepository.Load(input.AssignedPersonId.Value);
        }
    }
}
