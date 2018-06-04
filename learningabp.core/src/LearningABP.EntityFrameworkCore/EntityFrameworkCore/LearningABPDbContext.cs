using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LearningABP.Authorization.Roles;
using LearningABP.Authorization.Users;
using LearningABP.MultiTenancy;

namespace LearningABP.EntityFrameworkCore
{
    public class LearningABPDbContext : AbpZeroDbContext<Tenant, Role, User, LearningABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LearningABPDbContext(DbContextOptions<LearningABPDbContext> options)
            : base(options)
        {
        }
    }
}
