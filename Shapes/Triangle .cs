using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

        public Triangle(double side1, double side2, double side3)
        {
            // Проверка на положительность и неравенство сторон треугольника
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Каждая из сторон треугольника должна быть больше нуля.");
            }

            if ((side1 + side2 <= side3) || (side2 + side3 <= side1) || (side3 + side1 <= side2))
            {
                throw new ArgumentException("Каждая из сторон треугольника должна быть меньше суммы двух других.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double CalculateArea()
        {
            // Используем формулу Герона для вычисления площади треугольника
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public bool IsRightTriangle()
        {
            // Проверяем, является ли треугольник прямоугольным по теореме Пифагора
            return Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
                   Math.Pow(side1, 2) + Math.Pow(side3, 2) == Math.Pow(side2, 2) ||
                   Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2);
        }
    }
}
