using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyProject3.Authorization.Roles;
using MyProject3.Authorization.Users;
using MyProject3.MultiTenancy;

namespace MyProject3.EntityFrameworkCore
{
    public class MyProject3DbContext : AbpZeroDbContext<Tenant, Role, User, MyProject3DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyProject3DbContext(DbContextOptions<MyProject3DbContext> options)
            : base(options)
        {
        }
    }
}
