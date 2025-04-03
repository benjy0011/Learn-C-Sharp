using ConsoleApp.ClassDemo.Interfaces;

namespace ConsoleApp.ClassDemo.Classes.ShapeDemo;

public class Sphere : ICircularShape, I3DShape
{
    public Sphere(double radius) 
    {
        Radius = radius;
    }

    public double Radius { get; set; }

    public double Circumference()
    {
        return 2 * Math.PI * Radius;
    }

    public double Volume()
    {
        return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
    }
}
