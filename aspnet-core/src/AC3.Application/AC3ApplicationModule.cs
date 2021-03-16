using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AC3.Authorization;

namespace AC3
{
    [DependsOn(
        typeof(AC3CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AC3ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AC3AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AC3ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
