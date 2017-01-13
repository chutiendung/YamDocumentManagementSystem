using System;
using System.Collections.Generic;
using System.Linq;
using YamDocumentManagementSystem.Types.Documents.Keywords;
using YamDocumentManagementSystem.Types.Filing.DocumentTypes;
using YamDocumentManagementSystem.Types.Filing.Tags;
using YamDocumentManagementSystem.Types.General;

namespace YamDocumentManagementSystem.Types.Documents
{
    internal sealed class Document : IDocument
    {
        private ITag[] _documentTags;
        private IKeywordValue[] _keywordValues;
        private ISubDocument[] _subDocuments;

        public Document(Guid id, IDocumentType documentType, IEnumerable<ITag> tags,
            IEnumerable<IKeywordValue> keywordValues, IEnumerable<ISubDocument> subDocuments)
        {
            Id = id;
            DocumentType = documentType;
            Tags = tags;
            KeywordValues = keywordValues;
            SubDocuments = subDocuments;
        }

        public Guid Id { get; }
        public IDocumentType DocumentType { get; }

        public IEnumerable<ITag> Tags
        {
            get
            {
                return _documentTags.UnionWhereIsNotNullWhileDistinct(DocumentType.Tags, TagEqualityComparer.Instance);
            }
            set { _documentTags = value.ToArray(); }
        }

        public IEnumerable<IKeywordValue> KeywordValues
        {
            get { return _keywordValues; }
            set { _keywordValues = value.ToArray(); }
        }

        public IEnumerable<ISubDocument> SubDocuments
        {
            get { return _subDocuments; }
            set { _subDocuments = value.ToArray(); }
        }
    }
}