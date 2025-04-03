using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassDemo.Classes.ShapeDemo;

// absract = required to implement by child class themselves
public abstract class Polygon
{
    // shortcut = "prop"
    public double Width { get; set; }

    public abstract double Area(); // use also a blueprint method, force child to implement this method

    // anyone who inherit this class can override this method
    // use 'override' to override
    // 'sealed' prevent others to inherit it
    // 'readonly' means only can give value in constructor 
    // 'required' means must assign a value during creation
    public virtual string GetShapeName()
    {
        throw new NotImplementedException();
    }
}
