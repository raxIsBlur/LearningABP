using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.MultiTenancy;
using LearningABP.Editions;
using LearningABP.MultiTenancy;
using LearningABP.People;
using LearningABP.Tasks;

namespace LearningABP.EntityFrameworkCore.Seed.Tenants
{
    public class InitialTasks
    {
        private readonly LearningABPDbContext _context;

        public InitialTasks(LearningABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateInitialTasks();
        }

        private void CreateInitialTasks()
        {
            // Default task

            _context.Tasks.Add(new Task() {
                 Description = "Test Task",
                 State = TaskState.Active
            });

            _context.SaveChanges();
        }
    }
}
