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
        Console.WriteLine($"Треугольник {(triangle.IsRightTriangle() ? "" : "не")}прямоугольный\n");
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

Console.WriteLine("Введите ширину прямоугольника:");
string? lengthInput = Console.ReadLine();
Console.WriteLine("Введите высоту прямоугольника:");
string? widthInput = Console.ReadLine();

if (double.TryParse(lengthInput, out double length) &&
    double.TryParse(widthInput, out double width))
{
    try
    {
        Rectangle rectangle = new(length, width);
        Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea():0.###}");
        Console.WriteLine($"Прямугольник - {(rectangle.IsSquare() ? "" : "не ")}квадрат");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Ошибка при создании прямоугольника: " + ex.Message);
    }
}
else
{
    Console.WriteLine("Некорректный ввод сторон прямоугольника.");
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
    Console.WriteLine($"Фигура: {figure.Name}");
    Console.WriteLine($"Площадь фигуры: {figure.CalculateArea():0.###}\n");
}
Console.WriteLine("------------------------------------------------------------------------------------------\n");
