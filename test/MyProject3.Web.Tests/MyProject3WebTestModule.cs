using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProject3.EntityFrameworkCore;
using MyProject3.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyProject3.Web.Tests
{
    [DependsOn(
        typeof(MyProject3WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyProject3WebTestModule : AbpModule
    {
        public MyProject3WebTestModule(MyProject3EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject3WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyProject3WebMvcModule).Assembly);
        }
    }
}