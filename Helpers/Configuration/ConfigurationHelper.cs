using YamDocumentManagementSystem.Configuration.Data;

namespace YamDocumentManagementSystem.Helpers.Configuration
{
    public sealed class ConfigurationHelper : IConfigurationHelper
    {
        public IDatabaseConnectionInfo GetConnectionString(string name)
        {
            var databaseConnections = DatabaseConnectionsSection.Instance.DatabaseConnections;

            return databaseConnections[name];
        }
    }
}