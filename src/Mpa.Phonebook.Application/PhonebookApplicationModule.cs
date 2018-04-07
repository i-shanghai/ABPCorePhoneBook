using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mpa.Phonebook.Authorization;

namespace Mpa.Phonebook
{
    [DependsOn(
        typeof(PhonebookCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhonebookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhonebookAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PhonebookApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
