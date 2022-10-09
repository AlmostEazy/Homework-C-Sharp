/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

(double, double) calcCoordinates(double numberOne, double multiplierOneX, double numberTwo, double multiplierTwoX) {
    double x = ((numberTwo - numberOne) / (multiplierOneX - multiplierTwoX));
    double y = multiplierOneX * x + numberOne;
    var result = (x, y);  
    return result;
}

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);

var res = calcCoordinates(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения двух прямых: ({Math.Round(res.Item1, 2)}; {Math.Round(res.Item2, 2)})");

