using ShapeProject;

namespace TestShapeProject;

public class TestCircle
{
    [Test]
    public void TestArea()
    {
        var circleArea = new Circle(5).CalculateArea();
        Assert.That(circleArea, Is.EqualTo(78.5), "Circle area doesn't valid");
    }

    [Test]
    public void TestPerimeter()
    {
        var circlePerimeter = new Circle(5).CalculateArea();
        Assert.That(circlePerimeter, Is.EqualTo(78.5), "Circle perimeter doesn't valid");
    }
}