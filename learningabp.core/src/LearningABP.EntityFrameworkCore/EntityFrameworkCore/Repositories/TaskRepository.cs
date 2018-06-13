using Abp.EntityFrameworkCore;
using LearningABP.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningABP.EntityFrameworkCore.Repositories
{
    public class TaskRepository : LearningABPRepositoryBase<Task, long>, ITaskRepository
    {
        public TaskRepository(IDbContextProvider<LearningABPDbContext> dbContextProvider)
            : base(dbContextProvider) { }

        public List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state)
        {
            var query = GetAll();

            if (assignedPersonId.HasValue) {
                query = query.Where(x => x.AssignedPerson.Id == assignedPersonId.Value);
            }

            if (state.HasValue)
            {
                query = query.Where(x => x.State == state);
            }

            return query.OrderByDescending(x => x.CreationTime).Include(x => x.AssignedPerson).ToList();
        }
    }
}
