using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AngularCoreProject.Authorization;

namespace AngularCoreProject
{
    [DependsOn(
        typeof(AngularCoreProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AngularCoreProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AngularCoreProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AngularCoreProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
