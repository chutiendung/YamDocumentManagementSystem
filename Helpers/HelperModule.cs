using DryIoc;
using YamDocumentManagementSystem.Helpers.Configuration;
using YamDocumentManagementSystem.Helpers.DependencyInjection;

namespace YamDocumentManagementSystem.Helpers
{
    public sealed class HelperModule : IModule
    {
        private HelperModule()
        {
        }

        public static HelperModule Instance { get; } = new HelperModule();

        public void Load(IRegistrator registrator)
        {
            registrator
                .Register<IConfigurationHelper, ConfigurationHelper>(Reuse.Singleton);
        }
    }
}