using System;
using System.Collections.Generic;
using System.Text;

namespace LearningABP.EntityFrameworkCore.Seed.People
{
    public class PeopleBuilder
    {
        private readonly LearningABPDbContext _context;

        public PeopleBuilder(LearningABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultPeopleCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
