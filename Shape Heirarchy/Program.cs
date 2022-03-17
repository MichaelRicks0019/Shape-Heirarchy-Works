using System;
using System.Linq;
using System.Collections.Generic;

namespace Shape_Heirarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(4, 4);
            Circle circle = new Circle(3.2);
            Sphere sphere = new Sphere(5.8);
            Cube cube = new Cube(8);

            Circle circle1 = new Circle(9);
            Sphere sphere1 = new Sphere(6.345);
            Square square1 = new Square(7, 7);
            Cube cube1 = new Cube(1.2);
            
            Shape[] shapes = new Shape[] { square, circle, sphere, cube, circle1, sphere1, square1, cube1 };

            foreach(Shape x in shapes)
            {
                x.DisplayShape();
                Console.WriteLine("\n");
            }


    }
    }
}
