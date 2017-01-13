using System.Collections.Generic;
using System.Threading;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    public interface IBulkGetRepository<TEntity, in TId> : IGetRepository<TEntity, TId>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}