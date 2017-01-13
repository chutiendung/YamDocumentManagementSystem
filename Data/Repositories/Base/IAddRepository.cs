using System.Threading;
using System.Threading.Tasks;

namespace YamDocumentManagementSystem.Data.Repositories.Base
{
    public interface IAddRepository<TEntity, TId> : IGetRepository<TEntity, TId>
    {
        TId Add(TEntity entity);
        Task<TId> AddAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));
    }
}