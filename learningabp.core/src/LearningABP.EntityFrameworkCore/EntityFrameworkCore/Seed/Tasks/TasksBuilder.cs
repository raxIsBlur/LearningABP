using System;
using System.Collections.Generic;
using System.Text;

namespace LearningABP.EntityFrameworkCore.Seed.Tasks
{
    public class TasksBuilder
    {
        private readonly LearningABPDbContext _context;

        public TasksBuilder(LearningABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultTasksCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
