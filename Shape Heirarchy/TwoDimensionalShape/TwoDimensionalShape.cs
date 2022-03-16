using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Heirarchy
{
    abstract class TwoDimensionalShape : Shape
    {
        protected new double area; 
        public abstract double Area { get; }
    }
}
