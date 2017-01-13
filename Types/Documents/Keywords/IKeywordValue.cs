using System;
using YamDocumentManagementSystem.Types.Filing.Keywords;

namespace YamDocumentManagementSystem.Types.Documents.Keywords
{
    public interface IKeywordValue
    {
        Guid Id { get; }
        IKeyword Keyword { get; }
        string Value { get; }
    }

    public interface IKeywordValue<out T> : IKeywordValue where T : struct
    {
        new T Value { get; }
    }
}