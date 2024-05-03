namespace ShapeHierarchy.Abstract;

public class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2*(Width * Height);
    }
}