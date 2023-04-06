using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeService.ShapeImpl
{
    public class Circle : Shape 
    {

        public override double ComputePerimeter(string length1, string length2, string length3)
        {

            double pi = Math.PI;
            return Convert.ToDouble(length1) * 2 * pi;
        }
    }
}