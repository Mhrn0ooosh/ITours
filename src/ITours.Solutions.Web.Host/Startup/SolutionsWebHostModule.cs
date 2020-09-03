using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ITours.Solutions.Configuration;

namespace ITours.Solutions.Web.Host.Startup
{
    [DependsOn(
       typeof(SolutionsWebCoreModule))]
    public class SolutionsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SolutionsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SolutionsWebHostModule).GetAssembly());
        }
    }
}
