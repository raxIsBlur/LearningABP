using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LearningABP.Configuration;
using LearningABP.Web;

namespace LearningABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LearningABPDbContextFactory : IDesignTimeDbContextFactory<LearningABPDbContext>
    {
        public LearningABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LearningABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LearningABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LearningABPConsts.ConnectionStringName));

            return new LearningABPDbContext(builder.Options);
        }
    }
}
