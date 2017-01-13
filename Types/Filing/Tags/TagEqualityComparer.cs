using System.Collections.Generic;

namespace YamDocumentManagementSystem.Types.Filing.Tags
{
    public sealed class TagEqualityComparer : IEqualityComparer<ITag>
    {
        private TagEqualityComparer()
        {
        }

        public static TagEqualityComparer Instance { get; } = new TagEqualityComparer();
        public bool Equals(ITag x, ITag y) => x.Equals(y);

        public int GetHashCode(ITag obj)
            => (obj as Tag ?? new Tag(obj.Id, obj.Name, obj.Color)).GetHashCode();
    }
}