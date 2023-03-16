namespace ShapeProject;

public class Circle : IShape
{
    private readonly double _radius;
    private const double Pi = 3.14;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        var area = Pi * _radius * _radius;
        return area;
    }

    public double CalculatePerimeter()
    {
        var perimeter = 2 * Pi * _radius;
        return perimeter;
    }
}