using System.Threading;
using System.Threading.Tasks;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    public interface IUpdateRepository<TEntity, in TId> : IGetRepository<TEntity, TId>
    {
        void Update(TId id, TEntity entity);
        Task UpdateAsync(TId id, TEntity entity, CancellationToken cancellationToken = default(CancellationToken));
    }
}