using ShapeHierarchy.Abstract;

namespace ShapeHierarchy
{
    class Program
    {
        static void Main()
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Shape triangle = new Triangle(3, 4, 5);

            Console.WriteLine($"Area of circle: {circle.CalculateArea()}");
            Console.WriteLine($"Perimeter of rectangle: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Area of triangle: {triangle.CalculateArea()}");


        }
    }
}