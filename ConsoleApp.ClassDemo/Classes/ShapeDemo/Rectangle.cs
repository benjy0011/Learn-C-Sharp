using ConsoleApp.ClassDemo.Interfaces;

namespace ConsoleApp.ClassDemo.Classes.ShapeDemo;

public class Rectangle : Polygon, I2DShape
{
    public Rectangle(int width, int length)
    {
        Width = width;
        Length = length;
    }

    public int Length { get; set; }
    public override double Area()
    {
        return Length * Width;
    }

    // cannot change the interface, as it is a contract
    public double Perimeter()
    {
        return 2 * Length + 2 * Width;
    }

    public override string GetShapeName()
    {
        return base.GetShapeName();
    }
}
