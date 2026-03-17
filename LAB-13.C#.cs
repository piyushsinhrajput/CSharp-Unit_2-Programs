/*Create a class “Rectangle” that would contain length and
width as an instance variable, define constructors
[constructor overloading(default, parameterized)] to
initialize variables of objects.Define methods to find area
and to display variables’
value of objects which are created. */

using System;

class Rectangle
{
    double length;
    double width;

    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double Area()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + Area());
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Rectangle r1 = new Rectangle();
        Console.WriteLine("Rectangle using Default Constructor:");
        r1.Display();

        Rectangle r2 = new Rectangle(10, 5);
        Console.WriteLine("Rectangle using Parameterized Constructor:");
        r2.Display();
    }
}
