using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Lille.Authorization.Roles;
using Lille.Authorization.Users;
using Lille.MultiTenancy;

namespace Lille.EntityFrameworkCore
{
    public class LilleDbContext : AbpZeroDbContext<Tenant, Role, User, LilleDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LilleDbContext(DbContextOptions<LilleDbContext> options)
            : base(options)
        {
        }
    }
}
