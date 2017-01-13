using System;
using YamDocumentManagementSystem.Types.General;

namespace YamDocumentManagementSystem.Types.Filing.MIME
{
    // ReSharper disable once InconsistentNaming
    internal sealed class MIMERegistry : IMIMERegistry, IEquatable<IMIMERegistry>
    {
        internal MIMERegistry() : this(Guid.Empty, string.Empty)
        {
        }

        internal MIMERegistry(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public bool Equals(IMIMERegistry other)
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

        public override bool Equals(object obj)
        {
            Guard.ThrowIfNull(obj, nameof(obj));

            var mimeRegistry = obj as IMIMERegistry;
            return mimeRegistry != null && Equals(mimeRegistry);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id.GetHashCode() * 397) ^ (Name?.GetHashCode() ?? 0);
            }
        }
    }
}