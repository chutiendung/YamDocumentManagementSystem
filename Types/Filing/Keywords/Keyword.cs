using System;

namespace YamDocumentManagementSystem.Types.Filing.Keywords
{
    internal sealed class Keyword : IKeyword
    {
        internal Keyword() : this(Guid.Empty, string.Empty, typeof(string), false)
        {
        }

        internal Keyword(Guid id, string name, Type valueType, bool systemCreated)
        {
            Id = id;
            Name = name;
            ValueType = valueType;
            SystemCreated = systemCreated;
        }

        public Guid Id { get; internal set; }
        public string Name { get; internal set; }
        public Type ValueType { get; internal set; }
        public bool SystemCreated { get; internal set; }
    }
}