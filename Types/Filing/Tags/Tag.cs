using System;
using YamDocumentManagementSystem.Types.Filing.Color;
using YamDocumentManagementSystem.Types.General;

namespace YamDocumentManagementSystem.Types.Filing.Tags
{
    internal sealed class Tag : ITag, IEquatable<ITag>
    {
        internal Tag() : this(Guid.Empty, string.Empty, null)
        {
        }

        internal Tag(Guid id, string name, IColor color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public bool Equals(ITag other)
        {
            Guard.ThrowIfNull(other, nameof(other));

            // ReSharper disable PossibleNullReferenceException
            if (Id != Guid.Empty && other.Id != Guid.Empty)
            {
                return Id.Equals(other.Id);
            }

            return Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);
            // ReSharper restore PossibleNullReferenceException
        }

        public Guid Id { get; internal set; }
        public string Name { get; internal set; }
        public bool HasColor => Color != null;
        public IColor Color { get; internal set; }

        public override bool Equals(object obj)
        {
            Guard.ThrowIfNull(obj, nameof(obj));

            var tag = obj as ITag;
            return tag != null && Equals(tag);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();

                hashCode = (hashCode * 397) ^ (Name?.GetHashCode() ?? 0);

                return hashCode;
            }
        }
    }
}