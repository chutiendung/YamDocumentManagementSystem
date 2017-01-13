using PetaPoco;
using YamDocumentManagementSystem.Configuration.Data;

namespace YamDocumentManagementSystem.Data.Repositories.Factories
{
    internal interface IDatabaseFactory
    {
        IDatabase CreateForReadOnly(IDatabaseConnectionInfo databaseConnectionInfo);
        IDatabase CreateForReadWrite(IDatabaseConnectionInfo databaseConnectionInfo);
    }
}