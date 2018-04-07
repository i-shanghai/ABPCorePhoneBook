using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Mpa.Phonebook.Localization
{
    public static class PhonebookLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PhonebookConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PhonebookLocalizationConfigurer).GetAssembly(),
                        "Mpa.Phonebook.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
