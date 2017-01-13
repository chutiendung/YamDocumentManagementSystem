using System;
using YamDocumentManagementSystem.Types.Filing.Color;

namespace YamDocumentManagementSystem.Types.Filing.Tags
{
    public interface ITag : IColorable
    {
        Guid Id { get; }
        string Name { get; }
    }
}