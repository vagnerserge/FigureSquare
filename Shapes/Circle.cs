using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private readonly double radius;  // сделать проверку на отрицательность числа и выдавать сообщение в setter

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Значение радиуса круга должно быть больше нуля.");
            }

            this.radius = radius; // здесь сделать проверку на положительность
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
