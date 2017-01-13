namespace YamDocumentManagementSystem.Types.Filing.Color
{
    public interface IColorable
    {
        bool HasColor { get; }
        IColor Color { get; }
    }
}