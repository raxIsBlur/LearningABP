using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LearningABP.Authorization.Roles;
using LearningABP.Authorization.Users;
using LearningABP.MultiTenancy;
using LearningABP.Tasks;
using LearningABP.People;

namespace LearningABP.EntityFrameworkCore
{
    public class LearningABPDbContext : AbpZeroDbContext<Tenant, Role, User, LearningABPDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Person> People { get; set; }

        public LearningABPDbContext(DbContextOptions<LearningABPDbContext> options)
            : base(options)
        {
        }
    }
}
