using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AC3.Authorization.Roles;
using AC3.Authorization.Users;
using AC3.MultiTenancy;

namespace AC3.EntityFrameworkCore
{
    public class AC3DbContext : AbpZeroDbContext<Tenant, Role, User, AC3DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AC3DbContext(DbContextOptions<AC3DbContext> options)
            : base(options)
        {
        }
    }
}
