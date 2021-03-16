using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AC3.EntityFrameworkCore;
using AC3.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AC3.Web.Tests
{
    [DependsOn(
        typeof(AC3WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AC3WebTestModule : AbpModule
    {
        public AC3WebTestModule(AC3EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AC3WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AC3WebMvcModule).Assembly);
        }
    }
}