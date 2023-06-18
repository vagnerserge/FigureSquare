using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private readonly double length;
        private readonly double width;

        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Значение сторон прямоугольника должны быть больше нуля.");
            }
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public bool IsSquare()
        {
            return length == width;
        }
    }
}
