using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Heirarchy
{
    abstract class ThreeDimensionalShape : Shape
    {
        protected new double surfaceArea;
        protected new double volume;
        public abstract double Area { get; }
        public abstract double Volume { get; }
    }
}
