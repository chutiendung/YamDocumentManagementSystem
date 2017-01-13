using System;
using YamDocumentManagementSystem.Types.Filing.Keywords;

namespace YamDocumentManagementSystem.Types.Documents.Keywords
{
    internal sealed class KeywordValue<T> : IKeywordValue<T> where T : struct
    {
        internal KeywordValue() : this(Guid.Empty, null, default(T))
        {
        }

        internal KeywordValue(Guid id, IKeyword keyword, T value)
        {
            Id = id;
            Keyword = keyword;
            Value = value;
        }

        public Guid Id { get; internal set; }
        public IKeyword Keyword { get; internal set; }
        string IKeywordValue.Value => Value.ToString();
        public T Value { get; internal set; }
    }
}