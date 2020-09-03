using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ITours.Solutions.EntityFrameworkCore;
using ITours.Solutions.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ITours.Solutions.Web.Tests
{
    [DependsOn(
        typeof(SolutionsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SolutionsWebTestModule : AbpModule
    {
        public SolutionsWebTestModule(SolutionsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SolutionsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SolutionsWebMvcModule).Assembly);
        }
    }
}