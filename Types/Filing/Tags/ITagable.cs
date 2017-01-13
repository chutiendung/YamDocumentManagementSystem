using System.Collections.Generic;

namespace YamDocumentManagementSystem.Types.Filing.Tags
{
    public interface ITagable
    {
        IEnumerable<ITag> Tags { get; }
    }
}