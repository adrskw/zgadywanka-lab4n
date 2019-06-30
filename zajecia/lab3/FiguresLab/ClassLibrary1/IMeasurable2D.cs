namespace FiguresLib
{
    public interface IMeasurable2D : IMeasurable1D
    {
        double Surface { get; }
        double Circumference { get; }
    }
}
