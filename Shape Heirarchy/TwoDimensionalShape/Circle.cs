using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Heirarchy
{
    class Circle : TwoDimensionalShape
    {
        private double radius;

        //Constructor for Circle
        public Circle (double radius)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                base.area = (Math.PI * Math.Pow(radius, 2));
                return base.area;
            }
        }
        public override void DisplayShape()
        {
            Console.WriteLine($"Area of circle: {area}");
        }
    }
}
