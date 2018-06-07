using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AngularCoreProject.EntityFrameworkCore
{
    public static class AngularCoreProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AngularCoreProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AngularCoreProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
