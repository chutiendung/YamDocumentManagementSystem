namespace YamDocumentManagementSystem.Configuration.Data
{
    public interface IDatabaseConnectionsSection
    {
        IDatabaseConnectionsCollection DatabaseConnections { get; set; }
    }
}