using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LearningABP.EntityFrameworkCore
{
    public static class LearningABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LearningABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LearningABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
