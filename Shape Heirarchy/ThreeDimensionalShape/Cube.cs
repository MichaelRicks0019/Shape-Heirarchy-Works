using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Heirarchy
{
    class Cube : ThreeDimensionalShape
    {
        private double length;
        private double width;
        private double height;

        public Cube(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
    }
    }
}
