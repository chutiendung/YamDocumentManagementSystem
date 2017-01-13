using System;
using System.Collections.Generic;
using System.Linq;
using YamDocumentManagementSystem.Types.Filing.MIME;

namespace YamDocumentManagementSystem.Types.Documents
{
    internal sealed class SubDocument : ISubDocument
    {
        private byte[] _bytes;

        internal SubDocument() : this(Guid.Empty, 0, null, new byte[0])
        {
        }

        internal SubDocument(Guid id, int order, IMIMEType mimeType, IEnumerable<byte> bytes)
        {
            Id = id;
            Order = order;
            MimeType = mimeType;
            Bytes = bytes;
        }

        public Guid Id { get; internal set; }
        public int Order { get; internal set; }
        public IMIMEType MimeType { get; internal set; }

        public IEnumerable<byte> Bytes
        {
            get { return _bytes; }
            set { _bytes = value.ToArray(); }
        }
    }
}