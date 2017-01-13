using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    public interface IBulkDeleteRepository<TEntity, in TId> : IDeleteRepository<TEntity, TId>
    {
        void DeleteAll(IEnumerable<TId> ids);
        Task DeleteAllAsync(IEnumerable<TId> ids, CancellationToken cancellationToken = default(CancellationToken));
    }
}