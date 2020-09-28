using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Lille.Configuration;
using Lille.Web;

namespace Lille.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LilleDbContextFactory : IDesignTimeDbContextFactory<LilleDbContext>
    {
        public LilleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LilleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LilleDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LilleConsts.ConnectionStringName));

            return new LilleDbContext(builder.Options);
        }
    }
}
