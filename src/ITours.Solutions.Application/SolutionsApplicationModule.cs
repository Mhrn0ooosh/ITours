using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ITours.Solutions.Authorization;

namespace ITours.Solutions
{
    [DependsOn(
        typeof(SolutionsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SolutionsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SolutionsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SolutionsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
