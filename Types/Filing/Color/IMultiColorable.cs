using System.Collections.Generic;

namespace YamDocumentManagementSystem.Types.Filing.Color
{
    public interface IMultiColorable
    {
        IEnumerable<IColor> Colors { get; }
    }
}