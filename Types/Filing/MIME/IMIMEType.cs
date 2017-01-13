using System;

namespace YamDocumentManagementSystem.Types.Filing.MIME
{
    // ReSharper disable once InconsistentNaming
    public interface IMIMEType
    {
        Guid Id { get; }
        IMIMERegistry Registry { get; }
        string Name { get; }
        string FileExtension { get; }
        string DisplayString { get; }
    }
}