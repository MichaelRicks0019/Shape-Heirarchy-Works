using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Heirarchy
{
    class Square : TwoDimensionalShape
    {
        private readonly double length;
        private readonly double width;

        //Constructor that takes shapes values
        public Square(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        //Area Property that calculates the area based off of constructor info.
        public override double Area
        {
            get
            {
                base.area = length * width;
                return area;
            }
        }
        public override void DisplayShape()
        {
            Console.WriteLine($"Area of square: {Area}");
        }

    }
}
