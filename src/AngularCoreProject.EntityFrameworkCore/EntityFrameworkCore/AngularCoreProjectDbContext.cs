using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AngularCoreProject.Authorization.Roles;
using AngularCoreProject.Authorization.Users;
using AngularCoreProject.MultiTenancy;

namespace AngularCoreProject.EntityFrameworkCore
{
    public class AngularCoreProjectDbContext : AbpZeroDbContext<Tenant, Role, User, AngularCoreProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AngularCoreProjectDbContext(DbContextOptions<AngularCoreProjectDbContext> options)
            : base(options)
        {
        }
    }
}
