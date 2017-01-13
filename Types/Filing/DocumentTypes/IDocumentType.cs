using System;
using System.Collections.Generic;
using YamDocumentManagementSystem.Types.Filing.Color;
using YamDocumentManagementSystem.Types.Filing.Keywords;
using YamDocumentManagementSystem.Types.Filing.Tags;

namespace YamDocumentManagementSystem.Types.Filing.DocumentTypes
{
    public interface IDocumentType : ITagable, IColorable, IMultiColorable
    {
        Guid Id { get; }
        string Name { get; }
        IEnumerable<IKeyword> Keywords { get; }
    }
}