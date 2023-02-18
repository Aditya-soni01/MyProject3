using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProject3.Authorization;

namespace MyProject3
{
    [DependsOn(
        typeof(MyProject3CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyProject3ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyProject3AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyProject3ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
