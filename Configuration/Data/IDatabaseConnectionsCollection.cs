namespace YamDocumentManagementSystem.Configuration.Data
{
    public interface IDatabaseConnectionsCollection
    {
        IDatabaseConnectionInfo this[string connectionString] { get; set; }
    }
}