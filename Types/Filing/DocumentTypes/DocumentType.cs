using System;
using System.Collections.Generic;
using System.Linq;
using YamDocumentManagementSystem.Types.Filing.Color;
using YamDocumentManagementSystem.Types.Filing.Keywords;
using YamDocumentManagementSystem.Types.Filing.Tags;
using YamDocumentManagementSystem.Types.General;

namespace YamDocumentManagementSystem.Types.Filing.DocumentTypes
{
    internal sealed class DocumentType : IDocumentType, IEquatable<IDocumentType>
    {
        private readonly MultiColorableHelper _multiColorableHelper;
        private IKeyword[] _keywords;
        private ITag[] _tags;

        internal DocumentType() : this(Guid.Empty, string.Empty, null, new ITag[0], new IKeyword[0])
        {
        }

        internal DocumentType(Guid id, string name, IColor color, IEnumerable<ITag> tags, IEnumerable<IKeyword> keywords)
        {
            Id = id;
            Name = name;
            Tags = tags;
            Keywords = keywords;
            Color = color;

            _multiColorableHelper = new MultiColorableHelper(this);
        }

        public Guid Id { get; internal set; }
        public string Name { get; internal set; }

        public IEnumerable<ITag> Tags
        {
            get { return _tags; }
            internal set { _tags = value.ToArray(); }
        }

        public IEnumerable<IKeyword> Keywords
        {
            get { return _keywords; }
            internal set { _keywords = value.ToArray(); }
        }

        public bool HasColor => Color != null;
        public IColor Color { get; internal set; }
        public IEnumerable<IColor> Colors => _multiColorableHelper.Colors;

        public bool Equals(IDocumentType other)
        {
            Guard.ThrowIfNull(other, nameof(other));

            // ReSharper disable once PossibleNullReferenceException
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            Guard.ThrowIfNull(obj, nameof(obj));

            var documentType = obj as IDocumentType;
            return documentType != null && Equals(documentType);
        }

        // ReSharper disable once NonReadonlyMemberInGetHashCode
        public override int GetHashCode() => Id.GetHashCode();
    }
}