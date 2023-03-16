using ShapeProject;

namespace TestShapeProject;

public class TestSquare
{
    [Test]
    public void TestArea()
    {
        var squareArea = Math.Round(new Square(3).CalculateArea());
        Assert.That(squareArea, Is.EqualTo(9), "Square area doesn't valid");
    }

    [Test]
    public void TestPerimeter()
    {
        var trianglePerimeter = Math.Round(new Square( 4).CalculatePerimeter());
        Assert.That(trianglePerimeter, Is.EqualTo(16), "Square perimeter doesn't valid");
    }
}