using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ITours.Solutions.Configuration;
using ITours.Solutions.Web;

namespace ITours.Solutions.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SolutionsDbContextFactory : IDesignTimeDbContextFactory<SolutionsDbContext>
    {
        public SolutionsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SolutionsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SolutionsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SolutionsConsts.ConnectionStringName));

            return new SolutionsDbContext(builder.Options);
        }
    }
}
