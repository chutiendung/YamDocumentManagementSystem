using System;
using System.Collections.Generic;
using YamDocumentManagementSystem.Types.Documents.Keywords;
using YamDocumentManagementSystem.Types.Filing.DocumentTypes;
using YamDocumentManagementSystem.Types.Filing.Tags;

namespace YamDocumentManagementSystem.Types.Documents
{
    public interface IDocument : ITagable
    {
        Guid Id { get; }
        IDocumentType DocumentType { get; }
        IEnumerable<IKeywordValue> KeywordValues { get; }
        IEnumerable<ISubDocument> SubDocuments { get; }
    }
}