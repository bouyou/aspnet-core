using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Lille.Authorization;

namespace Lille
{
    [DependsOn(
        typeof(LilleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LilleApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LilleAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LilleApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
