using System.Threading;
using System.Threading.Tasks;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    public interface IDeleteRepository<TEntity, in TId> : IGetRepository<TEntity, TId>
    {
        void Delete(TId id);
        Task DeleteAsync(TId id, CancellationToken cancellationToken = default(CancellationToken));
    }
}