/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();

Console.WriteLine("Координаты точки A:");
Console.Write("Введите X0: ");
int x0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y0: ");
int y0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z0: ");
int z0 = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Координаты точки B:");
Console.Write("Введите X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z1: ");
int z1 = int.Parse(Console.ReadLine()!);

double x0x1 = Math.Pow(x0 - x1, 2);
double y0y1 = Math.Pow(y0 - y1, 2);
double z0z1 = Math.Pow(z0 - z1, 2);

double result = Math.Sqrt(x0x1 + y0y1 + z0z1);

Console.WriteLine($"Расстояние между точками A и B: {Math.Round(result, 2)}");
