using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ITours.Solutions.EntityFrameworkCore
{
    public static class SolutionsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SolutionsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SolutionsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
