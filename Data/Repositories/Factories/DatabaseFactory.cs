using System.Data;
using PetaPoco;
using YamDocumentManagementSystem.Configuration.Data;
using YamDocumentManagementSystem.Types.General;

namespace YamDocumentManagementSystem.Data.Repositories.Factories
{
    internal sealed class DatabaseFactory : IDatabaseFactory
    {
        public IDatabase CreateForReadOnly(IDatabaseConnectionInfo databaseConnectionInfo)
            => GetDatabase(databaseConnectionInfo, IsolationLevel.ReadUncommitted);

        public IDatabase CreateForReadWrite(IDatabaseConnectionInfo databaseConnectionInfo)
            => GetDatabase(databaseConnectionInfo, IsolationLevel.ReadCommitted);

        private static IDatabase GetDatabase(IDatabaseConnectionInfo databaseConnectionInfo,
            IsolationLevel isolationLevel)
        {
            Guard.ThrowIfNull(databaseConnectionInfo, nameof(databaseConnectionInfo));
            Guard.ThrowIfNullOrWhitespace(databaseConnectionInfo.ConnectionString,
                nameof(databaseConnectionInfo.ConnectionString));

            var givenProviderName = databaseConnectionInfo.ProviderName;

            var providerName = string.IsNullOrWhiteSpace(givenProviderName)
                ? null
                : givenProviderName;

            return new Database(databaseConnectionInfo.ConnectionString, providerName)
            {
                IsolationLevel = isolationLevel
            };
        }
    }
}