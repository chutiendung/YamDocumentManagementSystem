using System;
using YamDocumentManagementSystem.Data.Repositories.Base;

namespace YamDocumentManagementSystem.Data.Repositories.Filing.Color
{
    public interface IColorRepository : IAddRepository<Entities.Filing.Color.Color, Guid>,
        IDeleteRepository<Entities.Filing.Color.Color, Guid>
    {
    }
}