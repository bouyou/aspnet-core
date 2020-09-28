using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Lille.EntityFrameworkCore;
using Lille.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Lille.Web.Tests
{
    [DependsOn(
        typeof(LilleWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LilleWebTestModule : AbpModule
    {
        public LilleWebTestModule(LilleEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LilleWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LilleWebMvcModule).Assembly);
        }
    }
}