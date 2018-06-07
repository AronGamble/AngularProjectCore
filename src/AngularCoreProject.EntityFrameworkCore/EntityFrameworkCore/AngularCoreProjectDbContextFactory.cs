using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AngularCoreProject.Configuration;
using AngularCoreProject.Web;

namespace AngularCoreProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AngularCoreProjectDbContextFactory : IDesignTimeDbContextFactory<AngularCoreProjectDbContext>
    {
        public AngularCoreProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AngularCoreProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AngularCoreProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AngularCoreProjectConsts.ConnectionStringName));

            return new AngularCoreProjectDbContext(builder.Options);
        }
    }
}
