using System.Configuration;

namespace YamDocumentManagementSystem.Configuration.Data
{
    internal sealed class DatabaseConnectionInfo : ConfigurationElement, IDatabaseConnectionInfo
    {
        private const string NamePropertyName = @"Name";
        private const string ConnectionStringPropertyName = @"ConnectionString";
        private const string ProviderNamePropertyName = @"ProviderName";

        [ConfigurationProperty(NamePropertyName, DefaultValue = @"", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string) base[NamePropertyName]; }
            set { base[NamePropertyName] = value; }
        }

        [ConfigurationProperty(ConnectionStringPropertyName, DefaultValue = @"", IsKey = false, IsRequired = true)]
        public string ConnectionString
        {
            get { return (string) base[ConnectionStringPropertyName]; }
            set { base[ConnectionStringPropertyName] = value; }
        }

        [ConfigurationProperty(ProviderNamePropertyName, DefaultValue = @"", IsKey = false, IsRequired = true)]
        public string ProviderName
        {
            get { return (string) base[ProviderNamePropertyName]; }
            set { base[ProviderNamePropertyName] = value; }
        }
    }
}