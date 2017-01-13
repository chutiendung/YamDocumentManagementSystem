using YamDocumentManagementSystem.Configuration.Data;

namespace YamDocumentManagementSystem.Helpers.Configuration
{
    public interface IConfigurationHelper
    {
        IDatabaseConnectionInfo GetConnectionString(string name);
    }
}