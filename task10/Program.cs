/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();

Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 100 || n > 999) {
Console.WriteLine("Не верное число");
} else {
n = n / 10;
n = n % 10;
Console.WriteLine(n);
};


