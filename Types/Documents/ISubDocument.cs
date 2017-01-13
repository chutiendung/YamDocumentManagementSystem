using System;
using System.Collections.Generic;
using YamDocumentManagementSystem.Types.Filing.MIME;

namespace YamDocumentManagementSystem.Types.Documents
{
    public interface ISubDocument
    {
        Guid Id { get; }
        int Order { get; }
        IMIMEType MimeType { get; }
        IEnumerable<byte> Bytes { get; }
    }
}