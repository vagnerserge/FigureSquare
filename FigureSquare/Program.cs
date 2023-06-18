using Shapes;

Console.WriteLine("------------Создание фигур и вычисление площади фигуры в try-catch-----------------------");
try
{
    Circle circle = new (5);
    Console.WriteLine($"Площадь круга: {circle.CalculateArea():F3}");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ошибка при создании треугольника" + ex.Message);
}

try
{
    Triangle triangle = new (3, 4, 5);
    Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea():F3}");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Ошибка при создании треугольника" + ex.Message);
}
Console.WriteLine("------------------------------------------------------------------------------------------\n");

Console.WriteLine("------------Вычисление площади фигуры без знания типа фигуры в compile-time----------------");

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
        ;
        Console.WriteLine($"Площадь круга: {c.CalculateArea()}\n");
    }
    else if (figure is Triangle t)
    {
        Console.WriteLine($"Площадь треугольника: {t.CalculateArea()}");
        Console.WriteLine($"Треугольник {(t.IsRightTriangle() ? "" : "не")}прямоугольный\n");
    }
    else if (figure is Rectangle r)
    {
        Console.WriteLine($"Площадь прямоугольника: {r.CalculateArea()}");
        Console.WriteLine($"Прямугольник - {(r.IsSquare() ? "" : "не ")}квадрат");
    }
}
Console.WriteLine("------------------------------------------------------------------------------------------\n");
