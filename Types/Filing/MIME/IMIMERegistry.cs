using System;

namespace YamDocumentManagementSystem.Types.Filing.MIME
{
    // ReSharper disable once InconsistentNaming
    public interface IMIMERegistry
    {
        Guid Id { get; }
        string Name { get; }
    }
}