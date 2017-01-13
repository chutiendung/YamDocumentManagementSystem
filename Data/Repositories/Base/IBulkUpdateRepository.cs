using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    public interface IBulkUpdateRepository<TEntity, TId> : IUpdateRepository<TEntity, TId>
    {
        void UpdateAll(IReadOnlyDictionary<TId, TEntity> entities);

        Task UpdateAllAsync(IReadOnlyDictionary<TId, TEntity> entities,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}