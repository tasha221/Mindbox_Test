using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    internal class Triangle : IFigure
    {
        private double[] _sides;
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            _sides = new double[] { a, b, c };
            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            CheckTriangle();
            if (IsRightTriangle())
            {
                return _sides[0] * _sides[1] / 2;
            }

            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        private bool IsRightTriangle()
        {
            Array.Sort(_sides);
            if (Math.Pow(_sides[0], 2) * Math.Pow(_sides[1], 2) == Math.Pow(_sides[2], 2))
                return true;
            return false;
        }

        private void CheckTriangle()
        {
            if (_a <= 0 || _b <= 0 || _c <= 0)
                throw new ArgumentException("Sides of the triangle cannot be less than 0");
            if (_a + _b <= _c || _b + _c <= _a || _a + _c <= _b)
                throw new ArgumentException("Triangle with these sides does not exist");
        }
    }
}
