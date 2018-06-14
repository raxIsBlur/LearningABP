using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.MultiTenancy;
using LearningABP.Editions;
using LearningABP.MultiTenancy;
using LearningABP.People;

namespace LearningABP.EntityFrameworkCore.Seed.Tenants
{
    public class DefaultPeople
    {
        private readonly LearningABPDbContext _context;

        public DefaultPeople(LearningABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultPeople();
        }

        private void CreateDefaultPeople()
        {
            // Default people

            _context.People.Add(new Person() { Name = "Meow" });
            _context.People.Add(new Person() { Name = "Meow1" });
            _context.People.Add(new Person() { Name = "Meow2" });

            _context.SaveChanges();
        }
    }
}
