using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeService.ShapeImpl
{
    public class Triangle : Shape
    {
        public override double ComputePerimeter(string length1, string length2, string length3)
        {
            return Convert.ToDouble(length1) + Convert.ToDouble(length2) + Convert.ToDouble(length3);
        }
    }
}