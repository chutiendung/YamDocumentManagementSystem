using System.Threading;
using System.Threading.Tasks;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    public interface IGetRepository<TEntity, in TId>
    {
        TEntity Get(TId id);
        Task<TEntity> GetAsync(TId id, CancellationToken cancellationToken = default(CancellationToken));
    }
}