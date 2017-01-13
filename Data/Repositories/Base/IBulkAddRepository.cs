using System.Collections.Generic;
using System.Threading;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    public interface IBulkAddRepository<TEntity, TId> : IAddRepository<TEntity, TId>
    {
        void AddAll(IEnumerable<TEntity> entities);
        void AddAllAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default(CancellationToken));
    }
}