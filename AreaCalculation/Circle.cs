namespace AreaCalculation
{
    internal class Circle : IFigure
    {
        private double _radius;
        public Circle(double r)
        {
            _radius = r;
        }

        public double GetArea()
        {
            if (_radius <= 0)
                throw new ArgumentException("Radius of the circle cannot be less than 0");
            return Math.PI * _radius * _radius;
        }
    }
}
