using System;
using YamDocumentManagementSystem.Types.General;

namespace YamDocumentManagementSystem.Types.Filing.Color
{
    internal class Color : IColor, IEquatable<IColor>
    {
        internal static readonly Color Biack = new Color(Guid.Empty, byte.MinValue, byte.MinValue, byte.MinValue);
        internal static readonly Color White = new Color(Guid.Empty, byte.MaxValue, byte.MaxValue, byte.MaxValue);

        internal Color() : this(Guid.Empty, byte.MinValue, byte.MinValue, byte.MinValue)
        {
        }

        internal Color(Guid id, byte red, byte green, byte blue)
        {
            Id = id;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public Guid Id { get; internal set; }
        public byte Red { get; internal set; }
        public byte Green { get; internal set; }
        public byte Blue { get; internal set; }

        public bool Equals(IColor other)
        {
            Guard.ThrowIfNull(other);

            // ReSharper disable once PossibleNullReferenceException
            return Red == other.Red && Green == other.Green && Blue == other.Blue;
        }

        public override bool Equals(object obj)
        {
            Guard.ThrowIfNull(obj);

            var color = obj as IColor;
            return color != null && Equals(color);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Red.GetHashCode();

                hashCode = (hashCode * 397) ^ Green.GetHashCode();
                hashCode = (hashCode * 397) ^ Blue.GetHashCode();

                return hashCode;
            }
        }
    }
}