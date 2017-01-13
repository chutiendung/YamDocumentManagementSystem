using System.Configuration;

namespace YamDocumentManagementSystem.Configuration.Data
{
    [ConfigurationCollection(typeof(DatabaseConnectionInfo),
        CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    internal sealed class DatabaseConnectionsCollection : ConfigurationElementCollection, IDatabaseConnectionsCollection
    {
        protected override string ElementName => @"DatabaseConnection";

        public new IDatabaseConnectionInfo this[string connectionString]
        {
            get { return (IDatabaseConnectionInfo) BaseGet(connectionString); }
            set
            {
                if (BaseGet(connectionString) != null)
                {
                    BaseRemove(connectionString);
                }

                BaseAdd((DatabaseConnectionInfo) value);
            }
        }

        protected override ConfigurationElement CreateNewElement() => new DatabaseConnectionInfo();

        protected override object GetElementKey(ConfigurationElement element)
            => ((IDatabaseConnectionInfo) element).Name;
    }
}