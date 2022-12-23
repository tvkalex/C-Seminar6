// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1) / (-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

Console.Clear();
metka:
double k1 = inputNumber("Введите значение К1: ");
double k2 = inputNumber("Введите значение К2: ");
if (k1 == k2)
{
    System.Console.WriteLine("Введены одинаковы значения \n попробуйте еще раз:");
    goto metka;
}
double b1 = inputNumber("Введите значение В1: ");
double b2 = inputNumber("Введите значение В2: ");

PointXY(out double x, out double y);
Console.WriteLine($"Координаты пересечения прямых X: {x} Y: {y}");

void PointXY(out double x, out double y)
{
    x = Math.Round((-b2 + b1) / (-k1 + k2), 2);
    y = Math.Round(k2 * x + b2, 2);
}

int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
