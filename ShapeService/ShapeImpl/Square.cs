using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShapeService.ShapeImpl
{
    public class Square : Shape 
    {
        public override double ComputePerimeter(string length1, string length2, string length3)
        {
            return Convert.ToDouble(length1) * 4;
        }
    }
}