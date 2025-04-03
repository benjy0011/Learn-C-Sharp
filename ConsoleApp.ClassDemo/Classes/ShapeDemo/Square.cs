namespace ConsoleApp.ClassDemo.Classes.ShapeDemo;

public class Square : Polygon 
{
    public Square() { }

    public Square(int w) 
    {
        Width = w;
    }

    public override double Area() // use overribe to implement the abstract method
    {
        // Math.Pow(Width, 2);  // alternative
        return Width * Width;
    }
}
