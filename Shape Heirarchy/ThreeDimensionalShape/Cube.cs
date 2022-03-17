using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Heirarchy
{
    class Cube : ThreeDimensionalShape
    {
        private double cubeSide;


        public Cube(double cubeSide)
        {
            this.cubeSide = cubeSide;
        }
        public override double Volume
        {
            get
            {
                base.volume = Math.Pow(cubeSide, 3);
                return base.volume;
            }
        }
        public override double Area
        {
            get
            {
                base.area = 6 * Math.Pow(cubeSide, 2);
                return base.area;
            }
        }
        public override void DisplayShape()
        {
            Console.WriteLine($"Area of cube: {Area} \nVolume of cube: {Volume}");
        }
    }
}
