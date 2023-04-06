using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ShapeService.ShapeImpl;

namespace ShapeService
{
    /// <summary>
    /// Summary description for ShapeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ShapeService : System.Web.Services.WebService
    {
        [WebMethod]
        public double ComputePerimeter(string type,string length1, string length2, string length3)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Shape shape = shapeFactory.SelectShape(type);
            return shape.ComputePerimeter(length1, length2, length3);
        }

    }
}
