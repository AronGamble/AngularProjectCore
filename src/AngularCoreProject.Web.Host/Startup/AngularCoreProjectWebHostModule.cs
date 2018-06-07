using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AngularCoreProject.Configuration;

namespace AngularCoreProject.Web.Host.Startup
{
    [DependsOn(
       typeof(AngularCoreProjectWebCoreModule))]
    public class AngularCoreProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AngularCoreProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AngularCoreProjectWebHostModule).GetAssembly());
        }
    }
}
