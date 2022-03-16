using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Heirarchy
{
    class Sphere : ThreeDimensionalShape
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                base.surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
                return base.surfaceArea;
            }
        }

        public override double Volume
        {
            get
            {
                base.volume = 4.0 / 3 * Math.PI * Math.Pow(radius, 3);
                return base.volume;
            }
        }

        public override void DisplayShape()
        {
            Console.WriteLine($"Area of sphere: {Area}\nVolume of sphere: {Volume}");
        }

    }
}
