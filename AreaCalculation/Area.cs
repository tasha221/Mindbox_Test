namespace AreaCalculation
{
    static public class Area
    {
        static public double Any(double r)
        {
            return Circle(r);
        }

        static public double Any(double a, double b, double c)
        {
            return Triangle(a, b, c);
        }

        static public double Circle(double r)
        {
            var circle = new Circle(r);

            return circle.GetArea();
        }

        static public double Triangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            return triangle.GetArea();
        }
    }
}