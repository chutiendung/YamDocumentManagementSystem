using DryIoc;

namespace YamDocumentManagementSystem.Helpers.DependencyInjection
{
    public interface IModule
    {
        void Load(IRegistrator registrator);
    }
}