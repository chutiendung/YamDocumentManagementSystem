using YamDocumentManagementSystem.Configuration.Data;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    internal interface IDatabaseRepository
    {
        string ConnectionName { get; }
        IDatabaseConnectionInfo DatabaseConnectionInfo { set; }
    }
}