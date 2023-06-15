using Shapes;

try
{
    Circle circle = new (5);
    double circleArea = circle.CalculateArea();
    Console.WriteLine($"Площадь круга: {circleArea}");
}
catch (AggregateException ex)
{
    Console.WriteLine("Ошибка при создании треугольника" + ex.Message);
}

try
{
    Triangle triangle = new (3, 4, 5);
    double triangleArea = triangle.CalculateArea();
    Console.WriteLine($"Площадь треугольника: {triangleArea}");
}
catch (AggregateException ex)
{
    Console.WriteLine("Ошибка при создании треугольника" + ex.Message);
}


List<Shape> Figures = new()
{
    new Circle(1),
    new Triangle(3, 3, 4),
    new Rectangle(3, 3)
};

foreach (Shape figure in Figures)
{
    if (figure is Circle c)
    {
        Console.WriteLine($"Площадь круга: {c.CalculateArea()}\n");
    }
    else if (figure is Triangle t)
    {
        Console.WriteLine($"Площадь треугольника: {t.CalculateArea}\n");
        Console.WriteLine($"Треугольник {(t.IsRightTriangle() ? "" : "не")}прямоугольный");
    }
    else if (figure is Rectangle r)
    {
        Console.WriteLine($"Площадь прямоугольника: {r.CalculateArea}\n");
        Console.WriteLine($"Прямугольник - {(r.IsSquare() ? "" : "не ")}квадрат");
    }
}
