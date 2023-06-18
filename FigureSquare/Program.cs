using Shapes;

Console.WriteLine("------------Создание фигур и вычисление площади фигуры в try-catch-----------------------");

Console.WriteLine("Введите радиус круга:");
string? radiusInput = Console.ReadLine();

if (double.TryParse(radiusInput, out double radius))
{
    try
    {
        Circle circle = new(radius);
        Console.WriteLine($"Площадь круга: {circle.CalculateArea():0.###}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Ошибка при создании треугольника: " + ex.Message);
    }
}
else
{
    Console.WriteLine("Некорректный ввод радиуса круга.");
}


    Console.WriteLine("Введите сторону A треугольника:");
    string? sideAInput = Console.ReadLine();
    Console.WriteLine("Введите сторону B треугольника:");
    string? sideBInput = Console.ReadLine();
    Console.WriteLine("Введите сторону C треугольника:");
    string? sideCInput = Console.ReadLine();

if (double.TryParse(sideAInput, out double sideA) &&
    double.TryParse(sideBInput, out double sideB) &&
    double.TryParse(sideCInput, out double sideC))
{
    try
    {
        Triangle triangle = new(sideA, sideB, sideC);
        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea():0.###}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Ошибка при создании треугольника: " + ex.Message);
    }
}
else
{
    Console.WriteLine("Некорректный ввод сторон треугольника.");
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
        Console.WriteLine($"Площадь круга: {c.CalculateArea():0.###}\n");
    }
    else if (figure is Triangle t)
    {
        Console.WriteLine($"Площадь треугольника: {t.CalculateArea():0.###}");
        Console.WriteLine($"Треугольник {(t.IsRightTriangle() ? "" : "не")}прямоугольный\n");
    }
    else if (figure is Rectangle r)
    {
        Console.WriteLine($"Площадь прямоугольника: {r.CalculateArea():0.###}");
        Console.WriteLine($"Прямугольник - {(r.IsSquare() ? "" : "не ")}квадрат");
    }
}
Console.WriteLine("------------------------------------------------------------------------------------------\n");
