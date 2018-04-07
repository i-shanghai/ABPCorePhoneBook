using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mpa.Phonebook.Configuration;

namespace Mpa.Phonebook.Web.Host.Startup
{
    [DependsOn(
       typeof(PhonebookWebCoreModule))]
    public class PhonebookWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhonebookWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhonebookWebHostModule).GetAssembly());
        }
    }
}
