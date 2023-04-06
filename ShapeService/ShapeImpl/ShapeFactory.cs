namespace ShapeService.ShapeImpl
{
    public class ShapeFactory
    {
        public Shape SelectShape(string type)
        {
            Shape shape = null;
            if (type.ToLower().Equals("circle"))
            {
                shape = new Circle();
            }
            else if (type.ToLower().Equals("rectangle"))
            {
                shape = new Rectangle();
            }
            else if (type.ToLower().Equals("square"))
            {
                shape = new Square();
            }
            else if (type.ToLower().Equals("triangle"))
            {
                shape = new Triangle();
            }
            return shape;
        }
    }
}