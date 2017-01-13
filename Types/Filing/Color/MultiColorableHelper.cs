using System.Collections.Generic;
using System.Linq;
using YamDocumentManagementSystem.Types.Filing.Tags;
using YamDocumentManagementSystem.Types.General;

namespace YamDocumentManagementSystem.Types.Filing.Color
{
    internal sealed class MultiColorableHelper : IMultiColorable
    {
        private readonly IMultiColorable _multiColorableInstance;

        internal MultiColorableHelper(IMultiColorable multiColorableInstance)
        {
            Guard.ThrowIfNull(multiColorableInstance, nameof(multiColorableInstance));

            _multiColorableInstance = multiColorableInstance;
        }

        public IEnumerable<IColor> Colors
        {
            get
            {
                var myColor = new[] {(_multiColorableInstance as IColorable)?.Color};

                var tagsColors = ((_multiColorableInstance as ITagable)?.Tags ?? new ITag[0])
                    .Select(tag => tag.Color);

                return myColor.UnionWhereIsNotNullWhileDistinct(tagsColors, ColorEqualityComparer.Instance);
            }
        }
    }
}