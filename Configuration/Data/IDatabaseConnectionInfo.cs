namespace YamDocumentManagementSystem.Configuration.Data
{
    public interface IDatabaseConnectionInfo
    {
        string Name { get; set; }
        string ConnectionString { get; set; }
        string ProviderName { get; set; }
    }
}