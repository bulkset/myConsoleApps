namespace ShapeHierarchy.Abstract;

public class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

