public class Rectangle : Shape
{
    private double _baseSide;
    private double _heightSide;

    public Rectangle(string color, double baseSide, double heightSide) : base (color)
    {
        _baseSide = baseSide;
        _heightSide = heightSide;
    }

    public override double GetArea()
    {
        return _baseSide * _heightSide;
    }
}