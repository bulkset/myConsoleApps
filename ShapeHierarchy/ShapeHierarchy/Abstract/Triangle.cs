﻿namespace ShapeHierarchy.Abstract;

public class Triangle : Shape
{
    public double Side1;
    public double Side2;
    public double Side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.Side1 = side1;
        this.Side2 = side2;
        this.Side3 = side3;
    }

    public override double CalculateArea()
    {
        double s = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }

    public override double CalculatePerimeter()
    {
        return (Side1 + Side2 + Side3);
    }
}