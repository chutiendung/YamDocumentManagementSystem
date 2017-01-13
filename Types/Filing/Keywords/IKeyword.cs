using System;

namespace YamDocumentManagementSystem.Types.Filing.Keywords
{
    public interface IKeyword
    {
        Guid Id { get; }
        string Name { get; }
        Type ValueType { get; }
        bool SystemCreated { get; }
    }
}