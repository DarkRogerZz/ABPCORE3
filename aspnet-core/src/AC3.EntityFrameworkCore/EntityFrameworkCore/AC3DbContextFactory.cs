using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AC3.Configuration;
using AC3.Web;

namespace AC3.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AC3DbContextFactory : IDesignTimeDbContextFactory<AC3DbContext>
    {
        public AC3DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AC3DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AC3DbContextConfigurer.Configure(builder, configuration.GetConnectionString(AC3Consts.ConnectionStringName));

            return new AC3DbContext(builder.Options);
        }
    }
}
