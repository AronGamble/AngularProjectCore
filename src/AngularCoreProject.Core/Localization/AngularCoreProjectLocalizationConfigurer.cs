using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AngularCoreProject.Localization
{
    public static class AngularCoreProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AngularCoreProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AngularCoreProjectLocalizationConfigurer).GetAssembly(),
                        "AngularCoreProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
