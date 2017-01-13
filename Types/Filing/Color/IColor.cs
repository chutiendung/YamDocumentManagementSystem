using System;

namespace YamDocumentManagementSystem.Types.Filing.Color
{
    public interface IColor
    {
        Guid Id { get; }
        byte Red { get; }
        byte Green { get; }
        byte Blue { get; }
    }
}