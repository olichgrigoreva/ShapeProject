using ShapeProject;

namespace TestShapeProject;

public class TestTriangle
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestArea()
    {
        var triangleArea = Math.Round(new Triangle(3, 3, 4).CalculateArea());
        Assert.That(triangleArea, Is.EqualTo(4), "Triangle area doesn't valid");
    }

    [Test]
    public void TestPerimeter()
    {
        var trianglePerimeter = Math.Round(new Triangle(3, 3, 4).CalculatePerimeter());
        Assert.That(trianglePerimeter, Is.EqualTo(10), "Triangle perimeter doesn't valid");
    }
}