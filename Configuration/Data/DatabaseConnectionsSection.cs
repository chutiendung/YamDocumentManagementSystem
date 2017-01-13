using System.Configuration;

namespace YamDocumentManagementSystem.Configuration.Data
{
    internal sealed class DatabaseConnectionsSection : ConfigurationSection, IDatabaseConnectionsSection
    {
        private static readonly ConfigurationProperty DatabaseConnectionsAsConfigurationProperty;
        private static readonly ConfigurationPropertyCollection PropertiesInstance;

        static DatabaseConnectionsSection()
        {
            DatabaseConnectionsAsConfigurationProperty = new ConfigurationProperty(null,
                typeof(DatabaseConnectionsCollection), null,
                ConfigurationPropertyOptions.IsDefaultCollection);

            PropertiesInstance = new ConfigurationPropertyCollection {DatabaseConnectionsAsConfigurationProperty};
        }

        protected override ConfigurationPropertyCollection Properties => PropertiesInstance;

        public static DatabaseConnectionsSection Instance { get; } = new DatabaseConnectionsSection();

        [ConfigurationProperty(@"", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
        public IDatabaseConnectionsCollection DatabaseConnections
        {
            get { return (IDatabaseConnectionsCollection) base[DatabaseConnectionsAsConfigurationProperty]; }
            set { base[DatabaseConnectionsAsConfigurationProperty] = value; }
        }
    }
}