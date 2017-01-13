using System;
using YamDocumentManagementSystem.Types.General;

namespace YamDocumentManagementSystem.Types.Filing.MIME
{
    // ReSharper disable once InconsistentNaming
    internal sealed class MIMEType : IMIMEType, IEquatable<IMIMEType>
    {
        internal MIMEType() : this(Guid.Empty, null, string.Empty, string.Empty)
        {
        }

        internal MIMEType(Guid id, IMIMERegistry registry, string name, string fileExtension)
        {
            Id = id;
            Registry = registry;
            Name = name;
            FileExtension = fileExtension;
        }

        public bool Equals(IMIMEType other)
        {
            Guard.ThrowIfNull(other, nameof(other));

            // ReSharper disable PossibleNullReferenceException
            if (Id != Guid.Empty && other.Id != Guid.Empty)
            {
                return Id.Equals(other.Id);
            }

            var hasRegistry = Registry != null;
            var otherHasRegistry = other.Registry != null;

            if (hasRegistry != otherHasRegistry)
            {
                return false;
            }

            var neitherHasRegistryOrAreMatching = !hasRegistry || Registry.Equals(other.Registry);

            return neitherHasRegistryOrAreMatching && Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);
            // ReSharper restore PossibleNullReferenceException
        }

        public Guid Id { get; }
        public IMIMERegistry Registry { get; }
        public string Name { get; }
        public string FileExtension { get; }
        public string DisplayString => $"{Registry?.Name}/{Name}";

        public override bool Equals(object obj)
        {
            Guard.ThrowIfNull(obj, nameof(obj));

            var mimeType = obj as IMIMEType;
            return mimeType != null && Equals(mimeType);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (Registry?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Name?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}