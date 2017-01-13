using System.Collections.Generic;

namespace YamDocumentManagementSystem.Types.Filing.Color
{
    public sealed class ColorEqualityComparer : IEqualityComparer<IColor>
    {
        private ColorEqualityComparer()
        {
        }

        public static ColorEqualityComparer Instance { get; } = new ColorEqualityComparer();
        public bool Equals(IColor x, IColor y) => x.Equals(y);

        public int GetHashCode(IColor obj)
            => (obj as Color ?? new Color(obj.Id, obj.Red, obj.Green, obj.Blue)).GetHashCode();
    }
}