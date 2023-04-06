using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ShapeService.ShapeImpl
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Square))]
    [XmlInclude(typeof(Triangle))]
    [Serializable]
    public abstract class Shape
    {
        public string Name;
        public double Description;  

        public abstract double ComputePerimeter(string length1, string length2, string length3);

    }
}